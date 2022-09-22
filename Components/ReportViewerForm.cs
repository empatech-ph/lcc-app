using LCC.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using MaterialSkin.Controls;
using System.Drawing.Printing;

namespace LCC
{
    public partial class ReportViewerForm : Form
    {
        private readonly ReportViewer reportViewer;
        public FlowLayoutPanel optimizeBarPnl = new FlowLayoutPanel();
        public string reportType;
        public GeneralReport oGeneralReportForm;
        public ReportViewerForm()
        {
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);

            WindowState = FormWindowState.Maximized;

           PageSettings pg = new PageSettings();
            pg.Margins.Top = 1/2;
            pg.Margins.Bottom = 1/2;
            pg.Margins.Left = 0;
            pg.Margins.Right = 0;
            pg.Landscape = true;
            reportViewer.SetPageSettings(pg);
            reportViewer.RefreshReport();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (reportType == "Label - Parts / Cut Lengths")
            {
                Report.LoadCutLengthReport(reportViewer);
            }
            else if (reportType == "Inventory List")
            {
                Report.LoadInventoryCommListReport(reportViewer.LocalReport, true);
            }
            else if (reportType == "Commercial Lengths List")
            {
                Report.LoadInventoryCommListReport(reportViewer.LocalReport, false);
            }
            else if (reportType == "Material Quantity - Storage and Buyout")
            {
                Report.loadMaterialXStocksReport(reportViewer, false);
            }
            else if (reportType == "Material Quantity - Remnants & Scraps")
            {
                Report.loadMaterialXStocksReport(reportViewer, true);
            }
            else if (reportType == "Nesting Layout")
            {
                GLOBAL.isPrintNestedCompact = false;
                Report.loadNestingLayoutReport(reportViewer.LocalReport);
            } 
            else if (reportType == "Nesting Layout (Compressed)")
            {
                GLOBAL.isPrintNestedCompact = true;
                Report.loadNestingLayoutReport(reportViewer.LocalReport);

            }
            else
            {
                MessageBox.Show("Report not availabe");
                //SaveControlAsImage(optimizeBarPnl, Path.Combine(Path.GetFullPath(@"..\..\"), "optBar.png"));
                //Report.Load(reportViewer.LocalReport, oTempCutlength, oTempStockLengthModel);
            }
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }

        private void SaveControlAsImage(Control control, string path)
        {
            try
            {
                Bitmap bitmap = new Bitmap(control.Width, control.Height);
                control.DrawToBitmap(bitmap, control.Bounds);
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    /* using ImageFormat.Png or ImageFormat.Bmp saves the image with better quality */
                    bitmap.Save(fs, ImageFormat.Png);
                }
            } catch (Exception) { }
        }

        private void ReportViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.oGeneralReportForm.Hide();
        }
    }
}
