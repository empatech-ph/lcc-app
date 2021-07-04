using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using JsonFlatFileDataStore;
using System.Linq;

namespace LCC
{
    public partial class Form1 : Form
    {
        private readonly ReportViewer reportViewer;
        public Form1()
        {
            Text = "Report viewer";
            WindowState = FormWindowState.Maximized;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Report.Load(reportViewer.LocalReport);
            reportViewer.RefreshReport();
            base.OnLoad(e);
        }
    }
}
