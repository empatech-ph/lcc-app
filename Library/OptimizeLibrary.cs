using JsonFlatFileDataStore;
using LCC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Library
{
    class OptimizeLibrary
    {
        private DataStore oFile;

        public OptimizeLibrary()
        {
            this.oFile = UtilsLibrary.getUserFile();
        }

        private List<StockModel> getStockPerProjectDescriptionAndGrade(string sDescription, string sGrade)
        {
            List<StockModel> oStock = new List<StockModel>();
            foreach (MaterialModel oMaterialItem in this.getMaterialsPerProject())
            {
                if (oMaterialItem.description == sDescription && oMaterialItem.grade == sGrade)
                {
                    foreach (StockModel oStockItem in this.getStockPerMaterial(int.Parse(oMaterialItem.id.ToString())))
                    {
                        oStock.Add(oStockItem);
                    }
                }
            }
            return oStock.OrderByDescending(e => e.qty).ToList();
        }

        private List<StockModel> getStockPerMaterial(int iMaterialId)
        {
            return this.oFile
                .GetCollection<StockModel>()
                .AsQueryable()
                .Where(e => e.material_id == iMaterialId && e.visibility == true)
                .ToList();
        }

        private List<MaterialModel> getMaterialsPerProject()
        {
            return this.oFile
                .GetCollection<MaterialModel>()
                .AsQueryable()
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId && GLOBAL.aCheckedMaterials.Contains(e.id))
                .ToList();
        }

        private List<CutLengthModel> getCutLength()
        {
            return this.oFile
                .GetCollection<CutLengthModel>()
                .AsQueryable()
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId)
                .OrderByDescending(e => e.length)
                .ToList();
        }

        public void optimize()
        {
            GLOBAL.oTempOptimized.Clear();
            foreach (CutLengthModel oCutLengthItem in this.getCutLength())
            {
                int iCutQty = oCutLengthItem.quantity;
                int iNeedCut = iCutQty;
                foreach (StockModel oStockItem in this.getStockPerProjectDescriptionAndGrade(oCutLengthItem.description, oCutLengthItem.grade))
                {
                    int iStockQty = int.Parse(oStockItem.qty);
                    int iUsedStockQty = (iStockQty == -1) ? 0 : iStockQty;
                    if (oStockItem.length != 0 && oCutLengthItem.length != 0 && oStockItem.length >= oCutLengthItem.length && ((int.Parse(oStockItem.qty) > 0) || int.Parse(oStockItem.qty) == -1))
                    {
                        while (iStockQty > 0 || iStockQty  == - 1)
                        {
                            if (iNeedCut > 0)
                            {
                                int iQtyCut = Convert.ToInt32(Math.Floor(double.Parse((oStockItem.length / oCutLengthItem.length).ToString())));
                                iQtyCut = (iQtyCut > iNeedCut) ? iNeedCut : iQtyCut;
                                iUsedStockQty += iQtyCut;
                                iUsedStockQty = (iUsedStockQty > iCutQty) ? iCutQty : iUsedStockQty;
                                iQtyCut = (iQtyCut > iStockQty && iStockQty != -1) ? iStockQty : iQtyCut;
                                iNeedCut -= iQtyCut;
                                iQtyCut = (iNeedCut < 0) ? iQtyCut + iNeedCut : iQtyCut;

                                GLOBAL.oTempOptimized.Add(new TempOptimizedModel()
                                {
                                    cutlength_description = oCutLengthItem.description,
                                    cutlength_grade = oCutLengthItem.grade,
                                    cutlength_length = oCutLengthItem.length,
                                    cutlength_qty = (iNeedCut < 0) ? 0 : iNeedCut,
                                    stock_length = oStockItem.length,
                                    stock_qty = (iStockQty < 0) ? "unlimited" : iStockQty.ToString(),

                                    total_cut = iQtyCut,
                                    remaining_cut_length = oStockItem.length - (oCutLengthItem.length * iQtyCut)
                                }); 
                                if (iNeedCut <= 0 || (iQtyCut == iStockQty && iStockQty != -1)) break;
                            }
                        }
                    }
                }
            }
        }
    }
}
