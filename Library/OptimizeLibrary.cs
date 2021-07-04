using JsonFlatFileDataStore;
using LCC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LCC.Library
{
    class OptimizeLibrary
    {
        private DataStore oFile;

        private List<TempOptimizedModel> oTempOptimized1 = new List<TempOptimizedModel>();
        private List<TempOptimizedModel> oTempOptimized2 = new List<TempOptimizedModel>();

        private List<TempCutlengthModel> oTempCutlength1 = new List<TempCutlengthModel>();
        private List<TempCutlengthModel> oTempCutlength2 = new List<TempCutlengthModel>();

        public OptimizeLibrary()
        {
            this.oFile = UtilsLibrary.getUserFile();
        }

        private List<StockModel> getStockPerProjectDescriptionAndGrade(string sDescription, string sGrade, double dLength, bool bSecond = false)
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
            return (bSecond == true) ? 
                oStockModel.OrderBy(e => e.length % dLength).ToList() :
                oStockModel.OrderByDescending(e => e.length % dLength)
                .ThenBy(e => Convert.ToInt32(Math.Floor(double.Parse((e.length / dLength).ToString()))))
                .ToList();
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
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId && this.getMaterialsPerProject().Select(e => new { desc_grade = e.description + e.grade }).Select(e => e.desc_grade).ToList().Contains((e.description + e.grade)))
                .OrderByDescending(e => e.length)
                .ToList();
        }

        public void optimize()
        {
            GLOBAL.oTempOptimized.Clear();
            GLOBAL.oTempCutlength.Clear();

            this.generateTempOptimize(ref this.oTempOptimized1);
            this.generateTempOptimize(ref this.oTempOptimized2, true);

            List<TempFilteredOptimized> oFilteredOptimized1 = this.oTempOptimized1.GroupBy(e => e.cutlength_id).Select(e => new TempFilteredOptimized
            {
                cutlength_id = e.First().cutlength_id,
                sum = e.Sum(e => e.remaining_stock_length),
                data = e.ToList()
            }).ToList();

            List<TempFilteredOptimized> oFilteredOptimized2 = this.oTempOptimized2.GroupBy(e => e.cutlength_id).Select(e => new TempFilteredOptimized
            {
                cutlength_id = e.First().cutlength_id,
                sum = e.Sum(e => e.remaining_stock_length),
                data = e.ToList()
            }).ToList();

            for (int i = 0; i < oFilteredOptimized1.Count; i++)
            {
                int iCutLengthNo = oFilteredOptimized1[i].cutlength_id;
                TempFilteredOptimized oFiltered1 = oFilteredOptimized1.Find(e => e.cutlength_id == iCutLengthNo);
                TempFilteredOptimized oFiltered2 = oFilteredOptimized2.Find(e => e.cutlength_id == iCutLengthNo);
                GLOBAL.oTempOptimized.AddRange((oFiltered1.sum >= oFiltered2.sum) ? oFiltered2.data : oFiltered1.data);
            }
        }

        private void generateTempOptimize(ref List<TempOptimizedModel> oTempOptimize, bool bIsSecond = false)
        {
            GLOBAL.oTempCutlength.Clear();
            GLOBAL.oTempCutlength = this.getCutLength().Select(e => new TempCutlengthModel
            {
                cutlength_id = e.id,
                part_code = e.part_code,
                cutlength_desc_grade = e.description + " (" + e.grade + ")",
                description = e.description,
                grade = e.grade,
                length = e.length,
                quantity = e.quantity,
                uncut = e.quantity
            }).ToList();
            int iIdTempOptimized = 1;
            foreach (TempCutlengthModel oCutLengthItem in GLOBAL.oTempCutlength)
            {
                List<StockModel> oStockModel = this.getStockPerProjectDescriptionAndGrade(oCutLengthItem.description, oCutLengthItem.grade, oCutLengthItem.length, bIsSecond);
                for (int i = 0; i < oStockModel.Count; i++)
                {
                    StockModel oStockItem = oStockModel[i];
                    int iStockQty = int.Parse(oStockItem.qty);
                    int iUsedStockQty = 0;
                    if (oStockItem.length != 0 && oCutLengthItem.length != 0 && oStockItem.length >= oCutLengthItem.length && ((int.Parse(oStockItem.qty) > 0) || int.Parse(oStockItem.qty) == -1))
                    {
                        while ((iStockQty > 0 || iStockQty == -1) && oCutLengthItem.uncut > 0)
                        {
                            double dAdvRemStockLength = 0.00;
                            int iAdvQtyCut = 0;
                            int iQtyCut = Convert.ToInt32(Math.Floor(double.Parse((oStockItem.length / oCutLengthItem.length).ToString())));
                            iQtyCut = (iQtyCut > oCutLengthItem.uncut) ? oCutLengthItem.uncut : iQtyCut;
                            iUsedStockQty += 1;
                            oCutLengthItem.uncut -= iQtyCut;
                            iQtyCut = (oCutLengthItem.uncut < 0) ? iQtyCut + oCutLengthItem.uncut : iQtyCut;
                            double dRemStockLength = oStockItem.length - (oCutLengthItem.length * iQtyCut);
                            if (oStockModel.Count - 1 != i)
                            {
                                iAdvQtyCut = Convert.ToInt32(Math.Floor(double.Parse((oStockModel[i + 1].length / oCutLengthItem.length).ToString())));
                                dAdvRemStockLength = oStockModel[i + 1].length - (oCutLengthItem.length * iAdvQtyCut);
                            }
                            if (dAdvRemStockLength < dRemStockLength && oStockModel.Count - 1 != i && iAdvQtyCut > oCutLengthItem.uncut)
                            {
                                oCutLengthItem.uncut += iQtyCut;
                                break;
                            };
                            oTempOptimize.Add(new TempOptimizedModel()
                            {
                                id = iIdTempOptimized++,
                                stock_id = oStockItem.id,
                                stock_code = oStockItem.stock_code,
                                stock_desc_grade = oCutLengthItem.description + ", " + oCutLengthItem.grade,
                                material_id = oStockItem.material_id,
                                cutlength_id = oCutLengthItem.cutlength_id,
                                stock_length = oStockItem.length,
                                cutlength_desc = oCutLengthItem.description,
                                total_cut = iQtyCut,
                                total_uncut = oCutLengthItem.uncut,
                                remaining_stock_length = double.Parse(dRemStockLength.ToString("0.00")),
                                cutlength_length = oCutLengthItem.length
                            });
                            if (oCutLengthItem.uncut <= 0 || (iQtyCut == iStockQty && iStockQty != -1)) break;
                            if (iUsedStockQty >= iStockQty && iStockQty != -1) break;
                        }
                    }
                }
            }
        }

    }
}
