using LCC.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace LCC
{
    public partial class ReportViewerForm : Form
    {
        private readonly ReportViewer reportViewer;
        public List<TempCutlengthModel> oTempCutlength = new List<TempCutlengthModel>();
        public List<TempStocklengthModel> oTempStockLengthModel = new List<TempStocklengthModel>();
        public FlowLayoutPanel optimizeBarPnl = new FlowLayoutPanel();
        public string reportType;
        public ReportViewerForm()
        {
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
        }

        protected override void OnLoad(EventArgs e)
        {
            if (reportType == "Label - Parts / Cut Lengths")
            {
                Report.LoadCutLengthReport(reportViewer.LocalReport);
            }
            else if (reportType == "Inventory List")
            {
                Report.LoadInventoryCommListReport(reportViewer.LocalReport, true);
            }
            else if (reportType == "Commercial Lengths List")
            {
                Report.LoadInventoryCommListReport(reportViewer.LocalReport, false);
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
    }
}
