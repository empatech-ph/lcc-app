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

        private List<StockModel> getStockPerProjectDescriptionAndGrade(string sDescription, string sGrade, double dLength)
        {
            List<StockModel> oStockModel = new List<StockModel>();
            foreach (MaterialModel oMaterialItem in this.getMaterialsPerProject())
            {
                if (oMaterialItem.description == sDescription && oMaterialItem.grade == sGrade)
                {
                    foreach (StockModel oStockItem in this.getStockPerMaterial(int.Parse(oMaterialItem.id.ToString())))
                    {
                        oStockModel.Add(oStockItem);
                    }
                }
            }
            return oStockModel.OrderByDescending(e => e.length % dLength)
                .ToList();
            //return oStockModel.OrderByDescending(e => Convert.ToInt32(Math.Floor(double.Parse((e.length / dLength).ToString()))))
                //.ThenBy(e => e.length % dLength)
                //.ToList();
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
                List<StockModel> oStockModel = this.getStockPerProjectDescriptionAndGrade(oCutLengthItem.description, oCutLengthItem.grade, oCutLengthItem.length);
                MessageBox.Show(JsonConvert.SerializeObject(oStockModel));
                for (int i = 0; i < oStockModel.Count; i++)
                {
                    StockModel oStockItem = oStockModel[i];
                    int iStockQty = int.Parse(oStockItem.qty);
                    int iUsedStockQty = 0;
                    if (oStockItem.length != 0 && oCutLengthItem.length != 0 && oStockItem.length >= oCutLengthItem.length && ((int.Parse(oStockItem.qty) > 0) || int.Parse(oStockItem.qty) == -1))
                    {
                        while ((iStockQty > 0 || iStockQty == -1) && iNeedCut > 0)
                        {
                            int iAdvRemCutLength = 0;
                            int iAdvQtyCut = 0;
                            int iQtyCut = Convert.ToInt32(Math.Floor(double.Parse((oStockItem.length / oCutLengthItem.length).ToString())));
                            iQtyCut = (iQtyCut > iNeedCut) ? iNeedCut : iQtyCut;
                            iUsedStockQty += 1;
                            iNeedCut -= iQtyCut;
                            iQtyCut = (iNeedCut < 0) ? iQtyCut + iNeedCut : iQtyCut;
                            iQtyCut = (iQtyCut > iStockQty && iStockQty != -1) ? iStockQty : iQtyCut;
                            int iRemCutLength = oStockItem.length - (oCutLengthItem.length * iQtyCut);
                            if (oStockModel.Count - 1 != i)
                            {
                                iAdvQtyCut = Convert.ToInt32(Math.Floor(double.Parse((oStockModel[i + 1].length / oCutLengthItem.length).ToString())));
                                iAdvRemCutLength = oStockModel[i + 1].length - (oCutLengthItem.length * iAdvQtyCut);
                            } 
                            if (iAdvRemCutLength < iRemCutLength && iRemCutLength != 0 && oStockModel.Count - 1 != i && iAdvQtyCut >= iQtyCut)
                            {
                                iNeedCut += iQtyCut;
                                break;
                            };
                            GLOBAL.oTempOptimized.Add(new TempOptimizedModel()
                            {
                                cutlength_description = oCutLengthItem.description,
                                cutlength_grade = oCutLengthItem.grade,
                                cutlength_length = oCutLengthItem.length,
                                cutlength_qty = oCutLengthItem.quantity,
                                cutlength_rem_qty = (iNeedCut < 0) ? 0 : iNeedCut,
                                stock_length = oStockItem.length,
                                stock_qty = (iStockQty < 0) ? "unlimited" : iStockQty.ToString(),
                                stock_used_qty = iUsedStockQty.ToString(),
                                total_cut = iQtyCut,
                                remaining_cut_length = iRemCutLength
                            });
                            if (iUsedStockQty >= iStockQty && iStockQty != -1) break;
                            if (iNeedCut <= 0 || (iQtyCut == iStockQty && iStockQty != -1)) break;
                        }
                    }
                }
                
            }

        }
    }
}
