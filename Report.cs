using Microsoft.Reporting.WinForms;
using System.IO;

namespace LCC
{
    class Report
    {
        public static void Load(LocalReport report)
        {
            var items = new[] { new ReportValue { RPT_Title = "Cutting layouts", NestingRPT_Cost = "104.99m", NestingRPT_Yield = "93.20%", NestingRPT_GrossYield = "93.20%",
                NestingRPT_Date ="6/29/2021", NestingRPT_Stocks = "31", NestingRPT_Parts = "327", NestingRPT_Layouts = "5", NestingRPT_Project ="Project GAIA" } };
            var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };
            using var fs = new FileStream("NestingReport.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("Items", items));
            report.SetParameters(parameters);
        }
    }
}
