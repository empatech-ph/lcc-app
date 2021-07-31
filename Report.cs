using LCC.Library;
using LCC.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using JsonFlatFileDataStore;
using System.Linq;

namespace LCC
{
    class Report
    {
        public static void Load(LocalReport report, List<TempCutlengthModel> oTempCutlength, List<TempStocklengthModel> oTempStockLengthModel)
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

            foreach (TempCutlengthModel oCutLength in oTempCutlength)
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
            using var fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\"), "RPT_ResultSummary.rdlc"), FileMode.Open);
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
            using var fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\"), "RPT_CutLengthReport.rdlc"), FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("Items", items));
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
            using var fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\"), "RPT_InventoryList.rdlc"), FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("inventoryListReport", items));
            report.SetParameters(parameters);
        }
    }
}
