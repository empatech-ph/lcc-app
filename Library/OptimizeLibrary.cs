using JsonFlatFileDataStore;
using LCC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LCC.Library
{
    class OptimizeLibrary
    {
        private static DataStore oFile = UtilsLibrary.getUserFile();

        private static List<TempOptimizedModel> oRestOptimized1 = new List<TempOptimizedModel>();
        private static List<TempOptimizedModel> oRestOptimized2 = new List<TempOptimizedModel>();

        public OptimizeLibrary()
        {
        }

        private static List<StockModel> getStockPerProjectDescriptionAndGrade(string sDescription, string sGrade, double dLength, string sType)
        {
            List<StockModel> oStockModel = new List<StockModel>();
            foreach (MaterialModel oMaterialItem in OptimizeLibrary.getMaterialsPerProject())
            {
                if (oMaterialItem.description == sDescription && oMaterialItem.grade == sGrade)
                {
                    foreach (StockModel oStockItem in OptimizeLibrary.getStockPerMaterial(int.Parse(oMaterialItem.id.ToString())))
                    {
                        oStockModel.Add(oStockItem);
                    }
                }
            }

            List<StockModel> oStockList = new List<StockModel>();
            switch (sType)
            {
                case "rest1":
                    oStockList = oStockModel.OrderBy(e => e.length % dLength).ToList();
                    break;
                case "rest2":
                    oStockList = oStockModel.OrderByDescending(e => e.length % dLength)
                        .ThenBy(e => Convert.ToInt32(Math.Floor(double.Parse((e.length / dLength).ToString()))))
                        .ToList();
                    break;
                case "cost":
                    oStockList = oStockModel.OrderBy(e => e.cost).ToList();
                    break;
            }


            return oStockList;

        }

        private static List<StockModel> getStockPerMaterial(int iMaterialId)
        {
            return OptimizeLibrary.oFile
                .GetCollection<StockModel>()
                .AsQueryable()
                .Where(e => e.material_id == iMaterialId && e.visibility == true)
                .ToList();
        }

        private static MaterialModel getMaterialByDescriptionAndGrade(string sDescription, string sGrade)
        {
            return OptimizeLibrary.oFile.GetCollection<MaterialModel>()
                .AsQueryable()
                .Where(e => e.description == sDescription && e.grade == sGrade)
                .First();
        }

        private static List<MaterialModel> getMaterialsPerProject()
        {
            return OptimizeLibrary.oFile
                .GetCollection<MaterialModel>()
                .AsQueryable()
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId && GLOBAL.aCheckedMaterials.Contains(e.id))
                .ToList();
        }

        private static List<CutLengthModel> getCutLength()
        {
            return OptimizeLibrary.oFile
                .GetCollection<CutLengthModel>()
                .AsQueryable()
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId && OptimizeLibrary.getMaterialsPerProject().Select(e => new { desc_grade = e.description + e.grade }).Select(e => e.desc_grade).ToList().Contains((e.description + e.grade)))
                .OrderByDescending(e => e.length)
                .ToList();
        }

        public static void optimize(BackgroundWorker oBackgroundWorker)
        {
            GLOBAL.oTempOptimized.Clear();
            GLOBAL.oTempCutlength.Clear();
            OptimizeLibrary.oRestOptimized1.Clear();
            OptimizeLibrary.oRestOptimized2.Clear();

            OptimizeLibrary.generateTempOptimize(ref OptimizeLibrary.oRestOptimized1, "rest1");
            OptimizeLibrary.generateTempOptimize(ref OptimizeLibrary.oRestOptimized2, "rest2");

            oBackgroundWorker.ReportProgress(25);

            List<TempFilteredOptimized> oFilteredOptimized1 = OptimizeLibrary.oRestOptimized1.GroupBy(e => e.cutlength_id).Select(e => new TempFilteredOptimized
            {
                cutlength_id = e.First().cutlength_id,
                sum = e.Sum(e => e.total_rest),
                data = e.ToList()
            }).ToList();

            List<TempFilteredOptimized> oFilteredOptimized2 = OptimizeLibrary.oRestOptimized2.GroupBy(e => e.cutlength_id).Select(e => new TempFilteredOptimized
            {
                cutlength_id = e.First().cutlength_id,
                sum = e.Sum(e => e.total_rest),
                data = e.ToList()
            }).ToList();

            oBackgroundWorker.ReportProgress(35);

            for (int i = 0; i < oFilteredOptimized1.Count; i++)
            {
                int iCutLengthNo = oFilteredOptimized1[i].cutlength_id;
                TempFilteredOptimized oFiltered1 = oFilteredOptimized1.Find(e => e.cutlength_id == iCutLengthNo);
                TempFilteredOptimized oFiltered2 = oFilteredOptimized2.Find(e => e.cutlength_id == iCutLengthNo);
                GLOBAL.oTempOptimized.AddRange((oFiltered1.sum >= oFiltered2.sum) ? oFiltered2.data : oFiltered1.data);
            }

            oBackgroundWorker.ReportProgress(45);
        }

        private static void generateTempOptimize(ref List<TempOptimizedModel> oTempOptimize, string sType)
        {
            GLOBAL.oTempCutlength.Clear();
            GLOBAL.oTempCutlength = OptimizeLibrary.getCutLength().Select(e => new TempCutlengthModel
            {
                id = e.id,
                part_code = e.part_code,
                cutlength_desc_grade = e.description + " (" + e.grade + ")",
                description = e.description,
                grade = e.grade,
                length = e.length,
                quantity = e.quantity,
                note = e.note,
                order_number = e.order_number,
                project_id = e.project_id,
                uncut_quantity = e.quantity,
                total_stock_length = 0,
                total_parts_length = 0,
                cost = 0,
                gross_yield = 0,
                total_layout = 0,
            }).ToList();

            int iIdTempOptimized = 1;
            foreach (TempCutlengthModel oCutLengthItem in GLOBAL.oTempCutlength)
            {
                MaterialModel oMaterialModel = OptimizeLibrary.getMaterialByDescriptionAndGrade(oCutLengthItem.description, oCutLengthItem.grade);
                double dTotalMargins = oMaterialModel.trim_left + oMaterialModel.trim_right;
                double dPartAllowance = oMaterialModel.part_allowance * 2;
                double dComputedCutlengthLength = dPartAllowance + oCutLengthItem.length;
                List<StockModel> oStockModel = OptimizeLibrary.getStockPerProjectDescriptionAndGrade(oCutLengthItem.description, oCutLengthItem.grade, dComputedCutlengthLength, sType);
                for (int i = 0; i < oStockModel.Count; i++)
                {
                    StockModel oStockItem = oStockModel[i];
                    int iStockQty = int.Parse(oStockItem.qty);
                    int iUsedStockQty = 0;
                    double dCost = 0;
                    double dComputedStockLength = oStockItem.length - dTotalMargins;
                    if (dComputedStockLength > 0 && dComputedCutlengthLength > 0 && dComputedStockLength >= dComputedCutlengthLength && ((int.Parse(oStockItem.qty) > 0) || int.Parse(oStockItem.qty) == -1))
                    {
                        while ((iStockQty > 0 || iStockQty == -1) && oCutLengthItem.uncut_quantity > 0)
                        {
                            double dAdvRemStockLength = 0.00;
                            int iAdvQtyCut = 0;
                            int iQtyCut = Convert.ToInt32(Math.Ceiling(double.Parse((dComputedStockLength / (dComputedCutlengthLength + oMaterialModel.kerf)).ToString())));
                            iQtyCut = (iQtyCut > oCutLengthItem.uncut_quantity) ? oCutLengthItem.uncut_quantity : iQtyCut;
                            iUsedStockQty += 1;
                            iQtyCut = (oCutLengthItem.uncut_quantity < 0) ? iQtyCut + oCutLengthItem.uncut_quantity : iQtyCut;
                            double dRemStockLength = dComputedStockLength - ((dComputedCutlengthLength + oMaterialModel.kerf) * iQtyCut) + oMaterialModel.kerf;
                            if (dRemStockLength < 0)
                            {
                                iQtyCut--;
                                dRemStockLength = dComputedStockLength - ((dComputedCutlengthLength + oMaterialModel.kerf) * iQtyCut) + oMaterialModel.kerf;
                            }
                            oCutLengthItem.uncut_quantity -= iQtyCut;
                            if (oStockModel.Count - 1 != i)
                            {
                                iAdvQtyCut = Convert.ToInt32(Math.Ceiling(double.Parse(((oStockModel[i + 1].length - dTotalMargins) / (dComputedCutlengthLength + oMaterialModel.kerf)).ToString())));
                                dAdvRemStockLength = (oStockModel[i + 1].length + dTotalMargins) - ((dComputedCutlengthLength + oMaterialModel.kerf) * iAdvQtyCut) + oMaterialModel.kerf;
                                if (dAdvRemStockLength < 0)
                                {
                                    iAdvQtyCut--;
                                    dAdvRemStockLength = oStockModel[i + 1].length - ((dComputedCutlengthLength + oMaterialModel.kerf) * iAdvQtyCut) + oMaterialModel.kerf;
                                }
                            }
                            if (dAdvRemStockLength < dRemStockLength && oStockModel.Count - 1 != i && iAdvQtyCut > oCutLengthItem.uncut_quantity)
                            {
                                oCutLengthItem.uncut_quantity += iQtyCut;
                                break;
                            };
                            double dScrapOrRemnant = double.Parse(dRemStockLength.ToString("0.00"));
                            dCost += oStockItem.cost;
                            oCutLengthItem.cost += dCost;
                            oCutLengthItem.total_stock_length += oStockItem.length;
                            oTempOptimize.Add(new TempOptimizedModel()
                            {
                                id = iIdTempOptimized++,
                                stock_id = oStockItem.id,
                                stock_code = oStockItem.stock_code,
                                stock_desc_grade = oCutLengthItem.description + ", " + oCutLengthItem.grade,
                                material_id = oStockItem.material_id,
                                cutlength_id = oCutLengthItem.id,
                                stock_length = oStockItem.length,
                                cutlength_desc = oCutLengthItem.description,
                                total_cut = iQtyCut,
                                total_uncut = oCutLengthItem.uncut_quantity,
                                remaining_stock_length = (dScrapOrRemnant > oMaterialModel.min_remnant_length) ? dScrapOrRemnant : 0.00,
                                scrap_stock_length = (dScrapOrRemnant < oMaterialModel.min_remnant_length) ? dScrapOrRemnant : 0.00,
                                total_rest = dScrapOrRemnant,
                                cutlength_length = oCutLengthItem.length,
                                computed_cutlength_length = dComputedCutlengthLength,
                                trim_right = oMaterialModel.trim_right,
                                trim_left = oMaterialModel.trim_left,
                                kerf = oMaterialModel.kerf,
                                stock_type = oStockItem.stock_type,
                                cost = dCost,
                                note = oStockItem.note
                            });
                            if (oCutLengthItem.uncut_quantity <= 0 || (iQtyCut == iStockQty && iStockQty != -1)) break;
                            if (iUsedStockQty >= iStockQty && iStockQty != -1) break;
                        }
                    }
                }
                double dPartLength = Math.Round((dComputedCutlengthLength * (oCutLengthItem.quantity - oCutLengthItem.uncut_quantity)), 2);
                oCutLengthItem.total_parts_length = (Double.IsNaN(dPartLength) == true) ? 0.00 : dPartLength;

                double dGrossYield = Math.Round(((oCutLengthItem.total_parts_length / oCutLengthItem.total_stock_length) * 100), 2);
                oCutLengthItem.gross_yield = (Double.IsNaN(dGrossYield) == true) ? 0.00 : dGrossYield;
            }
        }

    }
}
