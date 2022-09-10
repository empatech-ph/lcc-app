using LCC.Library;
using LCC.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using JsonFlatFileDataStore;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace LCC
{
    class Report
    {
        public static void loadNestedReport(LocalReport report, List<TempCutlengthModel> oTempCutlength, List<TempStocklengthModel> oTempStockLengthModel)
        {
            //var items = new[] {
            //    new ReportValue { RPT_Title = "Cutting layouts", NestingRPT_Cost = "104.99m", NestingRPT_Yield = "93.20%", NestingRPT_GrossYield = "93.20%",
            //    NestingRPT_Date ="6/29/2021", NestingRPT_Stocks = "31", NestingRPT_Parts = "327", NestingRPT_Layouts = "5", NestingRPT_Project ="Project GAIA" },
            //    new ReportValue { RPT_Title = "Cutting layouts", NestingRPT_Cost = "104.99m", NestingRPT_Yield = "93.20%", NestingRPT_GrossYield = "93.20%",
            //    NestingRPT_Date ="6/29/2021", NestingRPT_Stocks = "31", NestingRPT_Parts = "327", NestingRPT_Layouts = "5", NestingRPT_Project ="Project GAIA" }
            //};
            var clItems = new ReportValue[oTempCutlength.Count];
            var slItems = new ReportValue[oTempStockLengthModel.Count];
            int count = 0;

            foreach (TempCutlengthModel oCutLength in GLOBAL.oTempCutlength.Distinct().Where(e => GLOBAL.oTempCurrentUseOptimizeType.Select(e => e.optimize_type + e.cutlength_id).ToArray().Contains(e.optimize_type + e.id)).ToList())
            {
                clItems[count] = new ReportValue
                {
                    Result_clPartCode = oCutLength.part_code,
                    Result_clDesc = oCutLength.description,
                    Result_clLength = oCutLength.length.ToString(),
                    Result_clQty = oCutLength.quantity.ToString(),
                    Result_clUncut = oCutLength.uncut_quantity.ToString()
                };
                count++;
            }

            count = 0;

            foreach (TempStocklengthModel oStockLength in oTempStockLengthModel)
            {
                slItems[count] = new ReportValue
                {
                    Result_stockStockCode = oStockLength.stock_code,
                    Result_stockLength = oStockLength.length.ToString(),
                    Result_stockRest = oStockLength.rest.ToString(),
                    Result_stockTotalCut = oStockLength.total_cut.ToString(),
                    Result_stockRepeated = oStockLength.repeated.ToString()
                };
                count++;
            }
            //var image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\"), "optBar.jpeg"));
            var parameters = new[] { new ReportParameter("optBarPanelImage", Path.Combine(Path.GetFullPath(@"..\..\"), "optBar.png"), true) };
            report.EnableExternalImages = true;
            using var fs = new FileStream(Environment.CurrentDirectory + "/../../../RPT_ResultSummary.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("optimizeComponent", clItems));
            report.DataSources.Add(new ReportDataSource("optimizeComponent", slItems));
            report.SetParameters(parameters);
        }

        public static void LoadCutLengthReport(LocalReport report)
        {
            var collection = (from p in UtilsLibrary.getUserFile().GetCollection<ProjectModel>().AsQueryable()
                              join cl in UtilsLibrary.getUserFile().GetCollection<CutLengthModel>().AsQueryable()
                              on p.id equals cl.project_id
                              join m in UtilsLibrary.getUserFile().GetCollection<MaterialModel>().AsQueryable()
                              on p.id equals m.project_id
                              join sl in UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable()
                              on m.id equals sl.material_id
                              where p.id == GLOBAL.iSelectedProjectId
                              select new
                              {
                                  p,
                                  cl,
                                  sl,
                                  m
                              }).ToList();
            var items = new ReportValue[collection.Count];
            int count = 0;
            foreach (var oCutLength in collection)
            {
                items[count] = new ReportValue
                {
                    CutLengthRPT_PartLength = oCutLength.cl.length.ToString(),
                    CutLengthRPT_MaterialDesc = oCutLength.m.description.ToString(),
                    CutLengthRPT_PartCode = oCutLength.cl.part_code.ToString(),
                    MaterialRPT_ProjectNumber = oCutLength.p.project_reference.ToString(),
                    NestingRPT_Project = oCutLength.p.project_reference.ToString(),
                    MaterialRPT_Scope = oCutLength.p.scope.ToString(),
                    MaterialRPT_Rev = oCutLength.p.rev_no.ToString()
                };
                count++;
            }
            using var fs = new FileStream(Environment.CurrentDirectory + "/../../../RPT_CutLengthReport.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("Items", items));
            report.DataSources.Add(new ReportDataSource("ReportData", items));
        }
        public static void LoadInventoryCommListReport(LocalReport report, bool isInventoryList)
        {
            var stockType = isInventoryList ? "ST" : "BO";
            var collection = (from p in UtilsLibrary.getUserFile().GetCollection<ProjectModel>().AsQueryable()
                              join m in UtilsLibrary.getUserFile().GetCollection<MaterialModel>().AsQueryable()
                              on p.id equals m.project_id
                              join sl in UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable()
                              on m.id equals sl.material_id
                              where sl.stock_type == stockType && p.id == GLOBAL.iSelectedProjectId
                              select new
                              {
                                  p,
                                  sl,
                                  m
                              }).ToList();
            var items = new ReportValue[collection.Count];
            int count = 0;
            foreach (var oInventory in collection)
            {
                items[count] = new ReportValue
                {
                    CutLengthRPT_MaterialDesc = oInventory.m.description.ToString(),
                    NestingRPT_Project = oInventory.p.project_reference.ToString(),
                    MaterialRPT_Qty = oInventory.sl.qty.ToString(),
                    MaterialRPT_Length = oInventory.sl.length.ToString(),
                    MaterialRPT_UnitCost = oInventory.sl.cost.ToString(),
                    MaterialRPT_StockCode = oInventory.sl.stock_code.ToString(),
                    MaterialRPT_Note = oInventory.sl.note.ToString()
                };
                count++;
            }
            var title = isInventoryList ? "Inventory List Report" : "Commercial Lengths Report";
            var parameters = new[] { new ReportParameter("rptTitle", title) };
            using var fs = new FileStream(Environment.CurrentDirectory + "/../../../RPT_InventoryList.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("inventoryListReport", items));
            report.SetParameters(parameters);
        }
        public static void LoadMaterialReport(LocalReport report, bool isRemnantScrap)
        {
            var collection = (from p in UtilsLibrary.getUserFile().GetCollection<ProjectModel>().AsQueryable()
                              join m in UtilsLibrary.getUserFile().GetCollection<MaterialModel>().AsQueryable()
                              on p.id equals m.project_id
                              join sl in UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable()
                              on m.id equals sl.material_id
                              where p.id == GLOBAL.iSelectedProjectId
                              select new
                              {
                                  p,
                                  sl,
                                  m
                              });

            //List<string> container = new List<string>();
            if (isRemnantScrap)
            {
                var container = collection.Where(x => x.sl.cut_stock_type != "stock");
                filterMaterialData(container, isRemnantScrap, report);
            }
            else
            {
                var container = collection.Where(x => x.sl.cut_stock_type == "stock");
                filterMaterialData(container, isRemnantScrap, report);
            }
        }

        public static void filterMaterialData(IEnumerable<dynamic> materialData, bool isRemnantScrap, LocalReport report)
        {
            try
            {
                if (!isRemnantScrap)
                {
                    var items = new ReportValue[materialData.ToList().Count];
                    var items2 = new ReportValue[materialData.ToList().Count];
                    int count = 0;
                    foreach (var oInventory in materialData.Where(x => x.sl.stock_type == "ST").ToList())
                    {
                        items[count] = new ReportValue
                        {
                            CutLengthRPT_MaterialDesc = oInventory.m.description.ToString(),
                            MaterialRPT_Qty = oInventory.sl.qty.ToString(),
                            MaterialRPT_Length = oInventory.sl.length.ToString(),
                            MaterialRPT_UnitCost = oInventory.sl.cost.ToString(),
                            MaterialRPT_TotalCost = oInventory.sl.cost.ToString()
                        };
                        count++;
                    }
                    count = 0;

                    foreach (var oInventory in materialData.Where(x => x.sl.stock_type == "BO").ToList())
                    {
                        items2[count] = new ReportValue
                        {
                            CutLengthRPT_MaterialDesc = oInventory.m.description.ToString(),
                            MaterialRPT_QtyS = oInventory.sl.qty.ToString(),
                            MaterialRPT_LengthS = oInventory.sl.length.ToString(),
                            MaterialRPT_StockCodeS = oInventory.sl.stock_code.ToString(),
                            MaterialRPT_NoteS = oInventory.sl.note.ToString()
                        };
                        count++;
                    }

                    var parameters = new[] { new ReportParameter("projRef", materialData.Select(x => x.p.project_reference.ToString()).FirstOrDefault())
                    ,new ReportParameter("projName", materialData.Select(x => x.p.project_name.ToString()).FirstOrDefault())
                    ,new ReportParameter("scope", materialData.Select(x => x.p.scope.ToString()).FirstOrDefault())
                    ,new ReportParameter("rev_no", materialData.Select(x => x.p.rev_no.ToString()).FirstOrDefault())
                    ,new ReportParameter("CurDate", DateTime.Now.ToString())
                };
                    using var fs = new FileStream(Environment.CurrentDirectory + "/../../../RPT_MaterialReport_STBO.rdlc", FileMode.Open);
                    report.LoadReportDefinition(fs);
                    report.DataSources.Add(new ReportDataSource("Items", items));
                    report.DataSources.Add(new ReportDataSource("Items", items2));
                    report.SetParameters(parameters);
                }
                else
                {
                    var remnants = new ReportValue[materialData.ToList().Count];
                    var scraps = new ReportValue[materialData.ToList().Count];
                    int count = 0;

                    foreach (var rem in materialData.Where(x => x.sl.cut_stock_type == "remnant").ToList())
                    {
                        remnants[count] = new ReportValue
                        {

                            MaterialRPT_Material = rem.m.description.ToString(),
                            MaterialRPT_Grade = rem.m.grade.ToString(),
                            MaterialRPT_Qty = rem.sl.qty.ToString(),
                            MaterialRPT_Length = rem.sl.length.ToString()
                        };
                        count++;
                    }

                    count = 0;

                    foreach (var scrap in materialData.Where(x => x.sl.cut_stock_type == "scrap").ToList())
                    {
                        scraps[count] = new ReportValue
                        {
                            MaterialRPT_MaterialS = scrap.m.description.ToString(),
                            MaterialRPT_GradeS = scrap.m.grade.ToString(),
                            MaterialRPT_QtyS = scrap.sl.qty.ToString(),
                            MaterialRPT_LengthS = scrap.sl.length.ToString()
                        };
                        count++;
                    }
                    var parameters = new[] { new ReportParameter("projRef", materialData.Select(x => x.p.project_reference.ToString()).FirstOrDefault())
                    ,new ReportParameter("projName", materialData.Select(x => x.p.project_name.ToString()).FirstOrDefault())
                    ,new ReportParameter("scope", materialData.Select(x => x.p.scope.ToString()).FirstOrDefault())
                    ,new ReportParameter("rev_no", materialData.Select(x => x.p.rev_no.ToString()).FirstOrDefault())
                    ,new ReportParameter("curDate", DateTime.Now.ToString())
                };
                    using var fs = new FileStream(Environment.CurrentDirectory + "/../../../RPT_MaterialReport_RS.rdlc", FileMode.Open);
                    report.LoadReportDefinition(fs);
                    report.SetParameters(parameters);
                    report.DataSources.Add(new ReportDataSource("Items", remnants));
                    report.DataSources.Add(new ReportDataSource("Items", scraps));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Report not available.");
            }
        }

    }
}
