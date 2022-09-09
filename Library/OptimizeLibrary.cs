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

        private static List<TempOptimizedModel> oTempOptimized = new List<TempOptimizedModel>();

        public OptimizeLibrary()
        {
        }

        private static List<StockModel> getStockPerProjectDescriptionAndGrade(string sDescription, string sGrade, double dLength, string sType)
        {
            List<StockModel> oStockModel = new List<StockModel>();
            foreach (MaterialModel oMaterialItem in OptimizeLibrary.getMaterialsPerProject())
            {
                if ((oMaterialItem.description ?? "").Trim() == sDescription.Trim() && (oMaterialItem.grade.Trim() ?? "") == sGrade.Trim())
                {
                    foreach (StockModel oStockItem in OptimizeLibrary.getStockPerMaterial((sDescription ?? "").Trim(), (sGrade ?? "").Trim()))
                    {
                        oStockModel.Add(oStockItem);
                    }
                }
            }

            List<StockModel> oStockList = new List<StockModel>();
            switch (sType)
            {
                case "length-asc":
                    oStockList = oStockModel.OrderBy(e => e.length % dLength).ToList();
                    break;
                case "length-desc":
                    oStockList = oStockModel.OrderByDescending(e => e.length % dLength).ToList();
                    break;
                case "stock-length-asc":
                    oStockList = oStockModel.OrderBy(e => e.length).ToList();
                    break;
                case "stock-length-desc":
                    oStockList = oStockModel.OrderByDescending(e => e.length).ToList();
                    break;
                case "length-with-rest-desc":
                    oStockList = oStockModel.OrderByDescending(e => e.length % dLength)
                        .ThenBy(e => Convert.ToDouble(Math.Floor(double.Parse((e.length / (dLength == 0 ? 1 : dLength)).ToString()))))
                        .ToList();
                    break;
                case "length-with-rest-asc":
                    oStockList = oStockModel.OrderBy(e => e.length % dLength)
                        .ThenBy(e => Convert.ToInt32(Math.Floor(double.Parse((e.length / (dLength == 0 ? 1 : dLength)).ToString()))))
                        .ToList();
                    break;
                case "cost-asc":
                    oStockList = oStockModel.OrderBy(e => e.cost).ToList();
                    break;
                case "cost-desc":
                    oStockList = oStockModel.OrderByDescending(e => e.cost).ToList();
                    break;
                case "qty-asc":
                    oStockList = oStockModel.OrderBy(e => e.qty).ToList();
                    break;
                case "qty-desc":
                    oStockList = oStockModel.OrderByDescending(e => e.qty).ToList();
                    break;
                case "stock-asc":
                    oStockList = oStockModel.OrderBy(e => e.stock_type).ToList();
                    break;
                case "stock-desc":
                    oStockList = oStockModel.OrderByDescending(e => e.stock_type).ToList();
                    break;
            }
            return oStockList;

        }

        private static List<StockModel> getStockPerMaterial(string sDescription, string sGrade)
        {
            return OptimizeLibrary.oFile
                .GetCollection<StockModel>()
                .AsQueryable()
                .Where(e => (e.description ?? "").Trim() == sDescription && (e.grade ?? "").Trim() == sGrade && e.visibility == true)
                .ToList();
        }

        private static MaterialModel getMaterialByDescriptionAndGrade(string sDescription, string sGrade)
        {
            return OptimizeLibrary.oFile.GetCollection<MaterialModel>()
                .AsQueryable()
                .Where(e => (e.description ?? "").Trim() == sDescription && (e.grade ?? "").Trim() == sGrade)
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
                .Where(e => e.project_id == GLOBAL.iSelectedProjectId && OptimizeLibrary.getMaterialsPerProject().Select(e => new { desc_grade = (e.description ?? "").Trim() + (e.grade ?? "").Trim() }).Select(e => e.desc_grade).ToList().Contains(((e.description ?? "").Trim() + (e.grade ?? "").Trim())))
                .OrderByDescending(e => e.length)
                .ToList();
        }

        public static void optimize(BackgroundWorker oBackgroundWorker)
        {
            GLOBAL.oTempOptimized.Clear();
            GLOBAL.oTempCutlength.Clear();
            GLOBAL.oTempCurrentUseOptimizeType.Clear();
            OptimizeLibrary.oTempOptimized.Clear();

            OptimizeLibrary.generateTempOptimize("stock-length-desc");
            OptimizeLibrary.generateTempOptimize("stock-length-asc");
            OptimizeLibrary.generateTempOptimize("length-asc");
            OptimizeLibrary.generateTempOptimize("length-desc");
            OptimizeLibrary.generateTempOptimize("length-with-rest-asc");
            OptimizeLibrary.generateTempOptimize("length-with-rest-desc");
            OptimizeLibrary.generateTempOptimize("cost-asc");
            OptimizeLibrary.generateTempOptimize("cost-desc");
            OptimizeLibrary.generateTempOptimize("qty-asc");
            OptimizeLibrary.generateTempOptimize("qty-desc");
            OptimizeLibrary.generateTempOptimize("stock-asc");
            OptimizeLibrary.generateTempOptimize("stock-desc");

            oBackgroundWorker.ReportProgress(20);

            List<TempFilteredOptimized> oFilteredOptimized = OptimizeLibrary.oTempOptimized.GroupBy(e => new { e.cutlength_id, e.optimize_type }).Select(e => new TempFilteredOptimized
            {
                cutlength_id = e.First().cutlength_id,
                optimize_type = e.First().optimize_type,
                sum = e.Sum(e => e.total_rest),
                data = e.ToList()
            }).ToList();

            oBackgroundWorker.ReportProgress(25);

            List<TempFilteredOptimizedGrouped> oFilteredOptimizedGrouped = oFilteredOptimized.GroupBy(e  => e.cutlength_id).Select(e => new TempFilteredOptimizedGrouped
            {
                cutlength_id = e.First().cutlength_id,
                sum = e.First().sum,
                data = e.ToList()
        }).ToList();

            List<TempDepthFilteredOptimized> oDepthFilteredOptimized = new List<TempDepthFilteredOptimized>();

            oBackgroundWorker.ReportProgress(30);

            foreach (TempFilteredOptimizedGrouped oFiltered in oFilteredOptimizedGrouped)
            {
                oDepthFilteredOptimized.Add(new TempDepthFilteredOptimized() { 
                    cutlength_id = oFiltered.cutlength_id,
                    sum = oFiltered.sum,
                    data = oFiltered.data.First().data.ToList()
                    
                });
            }

            oBackgroundWorker.ReportProgress(35);

            for (int i = 0; i < oDepthFilteredOptimized.Count; i++)
            {
                int iCutLengthNo = oDepthFilteredOptimized[i].cutlength_id;
                TempDepthFilteredOptimized oFiltered = oDepthFilteredOptimized.First(e => e.cutlength_id == iCutLengthNo);
                GLOBAL.oTempCurrentUseOptimizeType.Add(new TempCurrentUseOptimizeType() { 
                    cutlength_id = iCutLengthNo,
                    optimize_type = oFiltered.data.First().optimize_type
                });
                GLOBAL.oTempOptimized.AddRange(oFiltered.data);
            }

            oBackgroundWorker.ReportProgress(45);
        }

        private static void generateTempOptimize(string sType)
        {
            GLOBAL.oTempCutlength.AddRange(OptimizeLibrary.getCutLength().Select(e => new TempCutlengthModel
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
                optimize_type = sType,
                solution_no = (new Random()).Next(100000000, 900000000)
            }).ToList());
            int iIdTempOptimized = 1;
            List<TempCutlengthModel> oTempCutlengthModel = new List<TempCutlengthModel>();
            foreach (TempCutlengthModel oCutLengthItem in GLOBAL.oTempCutlength)
            {
                MaterialModel oMaterialModel = OptimizeLibrary.getMaterialByDescriptionAndGrade((oCutLengthItem.description ?? "").Trim(), (oCutLengthItem.grade ?? "").Trim());
                double dTotalMargins = oMaterialModel.trim_left + oMaterialModel.trim_right;
                double dPartAllowance = oMaterialModel.part_allowance * 2;
                double dComputedCutlengthLength = dPartAllowance + oCutLengthItem.length;
                List<StockModel> oStockModel = OptimizeLibrary.getStockPerProjectDescriptionAndGrade(oCutLengthItem.description, oCutLengthItem.grade, dComputedCutlengthLength, sType);
                List<TempOptimizedModel> oTempOptimizedList = new List<TempOptimizedModel>();
                for (int i = 0; i < oStockModel.Count; i++)
                {
                    StockModel oStockItem = oStockModel[i];
                    TempOptimizedModel oTempOptimizeModel = new TempOptimizedModel();
                    int iStockQty = int.Parse(oStockItem.qty);
                    int iUsedStockQty = 0;
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
                            if (dAdvRemStockLength < dRemStockLength && oStockModel.Count - 1 != i && iAdvQtyCut > iQtyCut)
                            {
                                oCutLengthItem.uncut_quantity += iQtyCut;
                                break;
                            };
                            double dScrapOrRemnant = double.Parse(dRemStockLength.ToString("0.00"));
                            oCutLengthItem.cost += oStockItem.cost;
                            oCutLengthItem.total_stock_length += oStockItem.length;
                            oTempOptimizeModel = new TempOptimizedModel()
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
                                cost = oStockItem.cost,
                                note = oStockItem.note,
                                optimize_type = sType
                            };
                            oTempOptimizedList.Add(oTempOptimizeModel);
                            double dPartLength = Math.Round((dComputedCutlengthLength * (oCutLengthItem.quantity - oCutLengthItem.uncut_quantity)), 2);
                            oCutLengthItem.total_parts_length = (Double.IsNaN(dPartLength) == true) ? 0.00 : dPartLength;

                            double dGrossYield = Math.Round(((oCutLengthItem.total_parts_length / oCutLengthItem.total_stock_length) * 100), 2);
                            oCutLengthItem.gross_yield = (Double.IsNaN(dGrossYield) == true) ? 0.00 : dGrossYield;

                            if (oCutLengthItem.uncut_quantity <= 0 || (iQtyCut == iStockQty && iStockQty != -1)) break;
                            if (iUsedStockQty >= iStockQty && iStockQty != -1) break;
                        }

                        if (oTempOptimizeModel.id == 0)
                        {

                            int iQtyCut1 = Convert.ToInt32(Math.Ceiling(double.Parse(((dComputedStockLength) / (dComputedCutlengthLength + oMaterialModel.kerf)).ToString())));
                            iQtyCut1 = (iQtyCut1 > oCutLengthItem.uncut_quantity) ? oCutLengthItem.uncut_quantity : iQtyCut1;
                            iUsedStockQty += 1;
                            if (iQtyCut1 <= 0) break;
                            oTempOptimizeModel = new TempOptimizedModel()
                            {
                                id = iIdTempOptimized++,
                                stock_id = oStockItem.id,
                                stock_code = oStockItem.stock_code,
                                stock_desc_grade = oCutLengthItem.description + ", " + oCutLengthItem.grade,
                                material_id = oStockItem.material_id,
                                cutlength_id = oCutLengthItem.id,
                                stock_length = oStockItem.length,
                                cutlength_desc = oCutLengthItem.description,
                                total_cut = iQtyCut1,
                                total_uncut = oCutLengthItem.uncut_quantity,
                                remaining_stock_length = oMaterialModel.min_remnant_length,
                                scrap_stock_length = oMaterialModel.min_remnant_length,
                                total_rest = oMaterialModel.min_remnant_length,
                                cutlength_length = oCutLengthItem.length,
                                computed_cutlength_length = dComputedCutlengthLength,
                                trim_right = oMaterialModel.trim_right,
                                trim_left = oMaterialModel.trim_left,
                                kerf = oMaterialModel.kerf,
                                stock_type = oStockItem.stock_type,
                                cost = oStockItem.cost,
                                note = oStockItem.note,
                                optimize_type = sType,
                            };
                            oTempOptimizedList.Add(oTempOptimizeModel);
                        }
                    }

                }
                int iIncr = 1;
                List<TempOptimizedModel> oFilteredOptimizedModel = oTempOptimizedList.Where(o => Convert.ToDouble(o.total_uncut) != o.stock_length).ToList();
                List<TempStocklengthModel> oGroupedOptimized = oFilteredOptimizedModel.GroupBy(o => new
                {
                    o.stock_id,
                    o.cutlength_id,
                    o.total_cut,
                    o.total_rest,
                    o.optimize_type
                }).Select(o => new TempStocklengthModel
                {
                    id = iIncr++,
                    optimize_type = o.First().optimize_type,
                    cutlength_id = o.First().cutlength_id,
                    material_id = o.First().material_id,
                    stock_code = o.First().stock_code,
                    stock_desc_grade = o.First().stock_desc_grade,
                    length = o.First().stock_length,
                    rest = o.First().remaining_stock_length,
                    scrap = o.First().scrap_stock_length,
                    repeated = o.Count(),
                    total_cut = o.First().total_cut,
                    cutlength_length = o.First().computed_cutlength_length,
                    kerf = o.First().kerf,
                    trim_left = o.First().trim_left,
                    trim_right = o.First().trim_right,
                    stock_type = o.First().stock_type,
                    cost = o.First().cost * o.Count(),
                    note = o.First().note
                }).ToList();

                foreach (TempStocklengthModel oTempOptimized in oGroupedOptimized)
                {
                    dynamic mTempCutlength = GLOBAL.oTempCutlength.Find(o => o.id == oTempOptimized.cutlength_id && o.optimize_type == oTempOptimized.optimize_type);
                    if (mTempCutlength != null ) {
                        mTempCutlength.total_layout++;
                    }
                }
                OptimizeLibrary.oTempOptimized.AddRange(oTempOptimizedList);
            }

        }

    }
}
