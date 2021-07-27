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
		public static List<TempCutlengthModel> oTempCutlength;
		public static List<TempStocklengthModel> oTempStockLengthModel;
		public static FlowLayoutPanel optimizeBarPnl;
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
			SaveControlAsImage(optimizeBarPnl, Path.Combine(Path.GetFullPath(@"..\..\"), "optBar.png"));
			Report.Load(reportViewer.LocalReport, oTempCutlength, oTempStockLengthModel);
			reportViewer.RefreshReport();
			base.OnLoad(e);
		}

		private void SaveControlAsImage(Control control, string path)
		{
			Bitmap bitmap = new Bitmap(control.Width, control.Height);
			control.DrawToBitmap(bitmap, control.Bounds);
			using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
			{
				/* using ImageFormat.Png or ImageFormat.Bmp saves the image with better quality */
				bitmap.Save(fs, ImageFormat.Png);
			}
		}
	}
}
