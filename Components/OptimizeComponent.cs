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
using System.Threading;
using System.Windows.Forms;

namespace LCC.Components
{
    public partial class OptimizeComponent : UserControl
    {
        DataStore oFile;
        public int iSelectedCutlegthId = 0;
        public string sSelectedLayout = "";
        public int iSelectedStockId = 0;
        public OptimizeComponent()
        {
            InitializeComponent();
            this.oFile = UtilsLibrary.getUserFile();

            string unit = GLOBAL.getOptions().unit ?? "mm";
            foreach (DataGridViewColumn oHeader in this.dt_optimize.Columns)
            {
                oHeader.HeaderText = oHeader.HeaderText.Replace("(mm)", "(" + unit + ")");
            }
            foreach (DataGridViewColumn oHeader in this.dt_stockLength.Columns)
            {
                oHeader.HeaderText = oHeader.HeaderText.Replace("(mm)", "(" + unit + ")");
            }
            foreach (DataGridViewColumn oHeader in this.dt_summary_cutlengths.Columns)
            {
                oHeader.HeaderText = oHeader.HeaderText.Replace("(mm)", "(" + unit + ")");
            }
            foreach (DataGridViewColumn oHeader in this.dt_summary_materials.Columns)
            {
                oHeader.HeaderText = oHeader.HeaderText.Replace("(mm)", "(" + unit + ")");
            }
        }

        public void triggerOptimize(BackgroundWorker oBackgroundWorker)
        {
            oBackgroundWorker.ReportProgress(0);

            OptimizeLibrary.optimize(oBackgroundWorker);

            int iIncr = 1;
            oBackgroundWorker.ReportProgress(50);
            GLOBAL.oTempStockLengthOptimized = new List<TempStocklengthModel>();
            GLOBAL.oTempStockLengthOptimized = GLOBAL.oTempOptimized.GroupBy(o => new
            {
                o.stock_id,
                o.cutlength_id,
                o.total_cut,
                o.total_rest,
                o.optimize_type
            }).Select(o => new TempStocklengthModel
            {
                id = iIncr++,
                optimize_type = o.Last().optimize_type,
                cutlength_id = o.Last().cutlength_id,
                material_id = o.Last().material_id,
                stock_code = o.Last().stock_code,
                stock_desc_grade = o.Last().stock_desc_grade,
                length = o.Last().stock_length,
                rest = o.Last().remaining_stock_length,
                scrap = o.Last().scrap_stock_length,
                repeated = o.Count(),
                total_cut = o.Last().total_cut,
                cutlength_length = o.Last().computed_cutlength_length,
                kerf = o.Last().kerf,
                trim_left = o.Last().trim_left,
                trim_right = o.Last().trim_right,
                stock_type = o.Last().stock_type,
                cost = o.Last().cost,
                note = o.Last().note,
                data = o.Last()
            }).ToList();

            oBackgroundWorker.ReportProgress(55);

            foreach (TempCutlengthModel oCutLength in GLOBAL.oTempCutlength)
            {
                var oCutLengthCollection = this.oFile.GetCollection<CutLengthModel>();
                oCutLengthCollection.UpdateOne(e => e.id == oCutLength.id, oCutLength);
            }

            oBackgroundWorker.ReportProgress(80);

        }

        public void initOptimizedStockLengthDataTable()
        {

            this.dt_stockLength.DataSource = new List<TempStocklengthModel>();
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => (e.cutlength_id == this.iSelectedCutlegthId && Convert.ToDouble(e.data.total_uncut) != e.data.stock_length));
            this.dt_stockLength.DataSource = oTempStockLengthModel.ToArray();
            this.dt_stockLength.Columns["total_cut"].Visible = false;
            this.dt_stockLength.Columns["cost"].Visible = false;
            this.dt_stockLength.Columns["id"].Visible = false;

            int iIncr = 1;
            foreach (DataGridViewRow oRow in this.dt_stockLength.Rows)
            {
                oRow.Cells["layout_no"].Value = "L" + iIncr;
                iIncr++;
            }

            this.optimizeBarPanel.Controls.Clear();

            foreach (TempStocklengthModel oTempStockLength in oTempStockLengthModel)
            {
                var oStockCollection = this.oFile.GetCollection<StockModel>();
                OptimizeBarComponent oOptimizeBar = new OptimizeBarComponent();
                oOptimizeBar.initializeBar(oTempStockLength);
                this.optimizeBarPanel.Controls.Add(oOptimizeBar);
            }
            int iRowIndexOptimize = this.dt_optimize.CurrentRow.Index;
            int iRowIndexStockLength = this.dt_stockLength.CurrentRow.Index;
            if (this.dt_optimize.CurrentRow.Index != -1)
            {
                this.iSelectedStockId = Int32.Parse(this.dt_stockLength.Rows[iRowIndexStockLength].Cells["id"].Value.ToString());
                this.layout_label.Text = this.dt_optimize.Rows[iRowIndexOptimize].Cells["optimize_description"].Value.ToString() + " Layouts";
                this.sSelectedLayout = this.dt_stockLength.Rows[iRowIndexStockLength].Cells["layout_no"].Value.ToString();
                this.sub_layout_label.Text = "Cutlengths - " + this.sSelectedLayout;
                this.initSummaryOfCutlengths();
            }
        }

        private void initSummaryOfCutlengths()
        {
            List<TempSubLayoutOptimize> oSummaryCutlengths = new List<TempSubLayoutOptimize>();
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.id == this.iSelectedStockId && e.cutlength_id == this.iSelectedCutlegthId);
            var oCutLengthCollection = this.oFile.GetCollection<CutLengthModel>();
            var oFilteredCutlength = oCutLengthCollection.Find(e => e.id == this.iSelectedCutlegthId).First();
            int iIncr = 1;
            foreach (dynamic oSummary in oTempStockLengthModel.Select(e => new { layout_sequence_no = 0, layout_part_code = "", layout_length = e.cutlength_length, layout_qty = e.total_cut }).ToList())
            {
                oSummaryCutlengths.Add(new TempSubLayoutOptimize() { layout_sequence_no = this.sSelectedLayout + "." + iIncr, layout_part_code = oFilteredCutlength.part_code, layout_length = oSummary.layout_length, layout_qty = oSummary.layout_qty });
                iIncr++;
            }
            this.dt_summary_cutlengths.DataSource = oSummaryCutlengths;
            this.initSummaryOfMaterials();
        }
        private void initSummaryOfMaterials()
        {
            List<TempSubLayoutMaterialOptimize> oSummaryMaterials = new List<TempSubLayoutMaterialOptimize>();
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.id == this.iSelectedStockId && e.cutlength_id == this.iSelectedCutlegthId);
            this.dt_summary_materials.DataSource = oTempStockLengthModel.Select(e => new TempSubLayoutMaterialOptimize { layout_material_length = e.length, layout_material_qty = e.repeated, layout_material_stock_code = e.stock_code, layout_material_stock_type = e.stock_type }).ToArray();
        }

        public void assignReportParameters()
        {
            ReportViewerForm reportViewerForm = new ReportViewerForm();
            reportViewerForm.optimizeBarPnl = this.optimizeBarPanel;
            reportViewerForm.Show();
        }

        private void cutLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow oCurrentRow = this.dt_optimize.Rows[e.RowIndex];
                var iCutLength = int.Parse(oCurrentRow.Cells["id"].Value.ToString());
                this.initOptimizedStockLengthDataTable();
                this.initSummaryOfCutlengths();
                this.layout_label.Text = oCurrentRow.Cells["optimize_description"].Value.ToString() + " Layouts";
            }
        }

        private void stockLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.optimizeBarPanel.AutoScrollPosition = new Point(3, e.RowIndex * 90);

                this.sSelectedLayout = this.dt_stockLength.Rows[e.RowIndex].Cells["layout_no"].Value.ToString();
                this.sub_layout_label.Text = "Cutlengths - " + this.sSelectedLayout;
                this.iSelectedStockId = Int32.Parse(this.dt_stockLength.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.initSummaryOfCutlengths();
            }
        }

        private void dt_optimize_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
