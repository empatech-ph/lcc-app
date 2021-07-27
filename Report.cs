using LCC.Library;
using LCC.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

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
    }
}
