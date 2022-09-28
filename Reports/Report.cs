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
using System.Drawing.Printing;
using QRCoder;

namespace LCC
{
    class Report
    {

        public static void loadNestingLayoutReport(LocalReport oReport)
        {

            int iIncrOptiBar = 1;
            List< TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => (e.description == GLOBAL.sSelectedPrintDescriptionOptimized && e.grade == GLOBAL.sSelectedPrintGradeOptimized && Convert.ToDouble(e.data.total_uncut) != e.data.stock_length));
            if (GLOBAL.isPrintNestedCompact == true)
            {
                foreach (TempStocklengthModel oTempStockLength in oTempStockLengthModel)
                {
                    oTempStockLength.path = new Uri(UtilsLibrary.getPublicPath() + @"\L" + iIncrOptiBar.ToString() + "-COMPRESSED.jpg").AbsoluteUri;
                    iIncrOptiBar++;
                }
            } else
            {
                foreach (TempStocklengthModel oTempStockLength in oTempStockLengthModel)
                {
                    oTempStockLength.path = new Uri(UtilsLibrary.getPublicPath() + @"\L" + iIncrOptiBar.ToString() + ".jpg").AbsoluteUri;
                    iIncrOptiBar++;
                }

            }
            oReport.EnableExternalImages = true;
            using var fs = new FileStream(UtilsLibrary.getPublicPath() + "/Reports/" + ((GLOBAL.isPrintNestedCompact == true) ? "RPT_NestedLayoutCompact.rdlc" : "RPT_NestedLayout.rdlc"), FileMode.Open);
            oReport.DataSources.Add(new ReportDataSource("Optimized", GLOBAL.oTempOptimized));
            oReport.DataSources.Add(new ReportDataSource("OptimizedCutLengths", GLOBAL.oTempCutlength.Where(e => e.id == GLOBAL.iSelectedPrintCutLengthOptimized)));
            oReport.DataSources.Add(new ReportDataSource("OptimizedStockLengths", oTempStockLengthModel));
            oReport.DataSources.Add(new ReportDataSource("OptimizedParts", GLOBAL.oTempPartOptimized.Distinct()));
            oReport.LoadReportDefinition(fs);

        }

        public static void loadMaterialXStocksReport (ReportViewer oReport, bool isRemnant)
        {

            PageSettings pg = new PageSettings();
            pg.Landscape = false;
            pg.Margins.Top = 1 / 2;
            pg.Margins.Bottom = 1 / 2;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            oReport.SetPageSettings(pg);
            oReport.RefreshReport();
            
            if (isRemnant == false)
            {
                using FileStream fs = new FileStream(UtilsLibrary.getPublicPath() + "/Reports/RPT_MaterialReport_STBO.rdlc", FileMode.Open);
                oReport.LocalReport.DataSources.Add(new ReportDataSource("Project", UtilsLibrary.getUserFile().GetCollection<ProjectModel>().AsQueryable().Where(e => e.id == GLOBAL.iSelectedProjectId).ToList()));
                oReport.LocalReport.DataSources.Add(new ReportDataSource("Stocks_BO", UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId && e.stock_type == "BO").ToList()));
                oReport.LocalReport.DataSources.Add(new ReportDataSource("Stocks_ST", UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId && e.stock_type == "ST").ToList()));

                oReport.LocalReport.LoadReportDefinition(fs);

            }
            else
            {
                using FileStream fs = new FileStream(UtilsLibrary.getPublicPath() + "/Reports/RPT_MaterialReport_RS.rdlc", FileMode.Open);
                oReport.LocalReport.DataSources.Add(new ReportDataSource("Project", UtilsLibrary.getUserFile().GetCollection<ProjectModel>().AsQueryable().Where(e => e.id == GLOBAL.iSelectedProjectId).ToList()));
                oReport.LocalReport.DataSources.Add(new ReportDataSource("Scrap", UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId && e.cut_stock_type == "scrap").ToList()));
                oReport.LocalReport.DataSources.Add(new ReportDataSource("Remnant", UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId && e.cut_stock_type == "remnant").ToList()));

                oReport.LocalReport.LoadReportDefinition(fs);
            }
        }



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
            var parameters = new[] { new ReportParameter("optBarPanelImage", Path.Combine(UtilsLibrary.getPublicPath() + @"\L1.png"), true) };
            report.EnableExternalImages = true;
            using var fs = new FileStream(UtilsLibrary.getPublicPath() + "/Reports/RPT_ResultSummary.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("optimizeComponent", clItems));
            report.DataSources.Add(new ReportDataSource("optimizeComponent", slItems));
            report.SetParameters(parameters);
        }

        public static void LoadCutLengthReport(ReportViewer oReport)
        {

            PageSettings pg = new PageSettings();
            pg.Landscape = false;
            pg.Margins.Top = 1 / 2;
            pg.Margins.Bottom = 1 / 2;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            oReport.SetPageSettings(pg);
            oReport.RefreshReport();

            var collection = UtilsLibrary.getUserFile().GetCollection<CutLengthModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
            var items = new ReportValue[collection.Count];
            int count = 0;
            foreach (var oCutLength in collection)
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(collection[count].part_code + " - " + collection[count].length.ToString(), QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap bmp = qrCode.GetGraphic(7);
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Bmp);
                    items[count] = new ReportValue
                    {
                        CutLengthRPT_PartLength = collection[count].length.ToString(),
                        CutLengthRPT_MaterialDesc = collection[count].description.ToString(),
                        CutLengthRPT_PartCode = collection[count].part_code.ToString(),
                        CutLengthRPT_QR = ms.ToArray()
    
                    };
                }
                count++;
            }
            using var fs = new FileStream(UtilsLibrary.getPublicPath() + "/Reports/RPT_CutLengthReport.rdlc", FileMode.Open);
            oReport.LocalReport.LoadReportDefinition(fs);
            oReport.LocalReport.DataSources.Add(new ReportDataSource("Items", items));
            oReport.LocalReport.DataSources.Add(new ReportDataSource("ReportData", items));
        }
        public static void LoadInventoryCommListReport(LocalReport report, bool isInventoryList)
        {
            var stockType = isInventoryList ? "ST" : "BO";
            var collection = UtilsLibrary.getUserFile().GetCollection<StockModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId && e.stock_type == stockType).ToList();
            var items = new ReportValue[collection.Count];
            int count = 0;
            foreach (var oInventory in collection)
            {
                items[count] = new ReportValue
                {
                    CutLengthRPT_MaterialDesc = oInventory.description.ToString(),
                    MaterialRPT_Qty = oInventory.qty.ToString(),
                    MaterialRPT_Length = oInventory.length.ToString(),
                    MaterialRPT_UnitCost = oInventory.cost.ToString(),
                    MaterialRPT_StockCode = oInventory.stock_code.ToString(),
                    MaterialRPT_Note = oInventory.note.ToString(),
                };
                count++;
            }
            var title = isInventoryList ? "Inventory List Report" : "Commercial Lengths Report";
            var parameters = new[] { new ReportParameter("rptTitle", title) };
            using var fs = new FileStream(UtilsLibrary.getPublicPath() + "/Reports/RPT_InventoryList.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("inventoryListReport", items));
            report.DataSources.Add(new ReportDataSource("Project", UtilsLibrary.getUserFile().GetCollection<ProjectModel>().AsQueryable().Where(e => e.id == GLOBAL.iSelectedProjectId).ToList()));
            report.SetParameters(parameters);
        }

    }
}
