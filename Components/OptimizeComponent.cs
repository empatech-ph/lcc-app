using JsonFlatFileDataStore;
using LCC.Library;
using LCC.Model;
using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Components
{
    public partial class OptimizeComponent : UserControl
    {
        private readonly ReportViewer reportViewer;
        public OptimizeComponent()
        {
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            InitializeComponent();
        }

        public void triggerOptimize()
        {
            var oOptimize = new OptimizeLibrary();
            oOptimize.optimize();
            GLOBAL.oTempStockLengthOptimized = GLOBAL.oTempOptimized.GroupBy(o => new
            {
                o.stock_id,
                o.cutlength_id,
                o.total_cut,
                o.remaining_stock_length
            }).Select(o => new TempStocklengthModel
            {
                cutlength_id = o.Last().cutlength_id,
                stock_code = o.Last().stock_code,
                stock_desc_grade = o.Last().stock_desc_grade,
                length = o.Last().stock_length,
                rest = o.Last().remaining_stock_length,
                repeated = o.Count(),
                total_cut = o.Last().total_cut,
                cutlength_length = o.Last().computed_cutlength_length,
                kerf = o.Last().kerf,
                trim_left = o.Last().trim_left,
                trim_right = o.Last().trim_right,
                data = o.Last()
            }).ToList();

            var dtStockLengthTable = this.stockLengthTable.DataSource as DataTable;
            var dtCutLengthTable = this.cutLengthTable.DataSource as DataTable;
            if (dtStockLengthTable != null) dtStockLengthTable.Rows.Clear();
            if (dtCutLengthTable != null) dtCutLengthTable.Rows.Clear();

            this.cutLengthTable.DataSource = GLOBAL.oTempCutlength;
            this.cutLengthTable.Columns["grade"].Visible = false;
            this.cutLengthTable.Columns["project_id"].Visible = false;
            this.cutLengthTable.Columns["order_number"].Visible = false;
            this.cutLengthTable.Columns["note"].Visible = false;
            this.cutLengthTable.Columns["description"].Visible = false;
            this.cutLengthTable.Columns["id"].Visible = false;

            var iCutLength = int.Parse(this.cutLengthTable.CurrentRow.Cells["id"].Value.ToString());
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.cutlength_id == iCutLength);
            if (this.cutLengthTable.RowCount > 0)
            {
                this.initOptimizedStockLengthDataTable(iCutLength, GLOBAL.oTempCutlength, oTempStockLengthModel);
            }

            foreach (TempCutlengthModel oCutLength in GLOBAL.oTempCutlength)
            {
                var oCutLengthCollection = UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                oCutLengthCollection.UpdateOne(e => e.id == oCutLength.id, oCutLength);
            }
            assignReportParameters(oTempStockLengthModel);
        }

        private void initOptimizedStockLengthDataTable(int iCutLength, List<TempCutlengthModel> oTempCutlength, List<TempStocklengthModel> oTempStockLengthModel)
        {
            var dtStockLengthTable = this.stockLengthTable.DataSource as DataTable;
            if (dtStockLengthTable != null) dtStockLengthTable.Rows.Clear();
            this.stockLengthTable.DataSource = oTempStockLengthModel;
            this.stockLengthTable.Columns["cutlength_id"].Visible = false;
            this.stockLengthTable.Columns["data"].Visible = false;
            this.stockLengthTable.Columns["stock_desc_grade"].Visible = false;
            this.stockLengthTable.Columns["cutlength_length"].Visible = false;
            this.stockLengthTable.Columns["trim_left"].Visible = false;
            this.stockLengthTable.Columns["trim_right"].Visible = false;
            this.stockLengthTable.Columns["kerf"].Visible = false;

            this.optimizeBarPanel.Controls.Clear();

            foreach (TempStocklengthModel oTempStockLength in oTempStockLengthModel)
            {
                OptimizeBarComponent oOptimizeBar = new OptimizeBarComponent();
                oOptimizeBar.initializeBar(oTempStockLength);
                this.optimizeBarPanel.Controls.Add(oOptimizeBar);
            }
            assignReportParameters(oTempStockLengthModel);
            //Report.Load(reportViewer.LocalReport, GLOBAL.oTempCutlength, oTempStockLengthModel);
            //reportViewer.RefreshReport();
        }
        public void assignReportParameters(List<TempStocklengthModel> oTempStockLengthModel) {

            ReportViewerForm.oTempCutlength = GLOBAL.oTempCutlength;
            ReportViewerForm.oTempStockLengthModel = oTempStockLengthModel;
            ReportViewerForm.optimizeBarPnl = this.optimizeBarPanel;
            ReportViewerForm reportViewerForm = new ReportViewerForm();
            reportViewerForm.Show();
        }

        private void cutLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow oCurrentRow = this.cutLengthTable.Rows[e.RowIndex];
                var iCutLength = int.Parse(oCurrentRow.Cells["id"].Value.ToString());
                List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.cutlength_id == iCutLength);
                this.initOptimizedStockLengthDataTable(int.Parse(oCurrentRow.Cells["id"].Value.ToString()), new List<TempCutlengthModel>(), oTempStockLengthModel);
                assignReportParameters(oTempStockLengthModel);
            }
        }

        private void stockLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.optimizeBarPanel.AutoScrollPosition = new Point(3, e.RowIndex * 90);
            }
        }
    }
}
