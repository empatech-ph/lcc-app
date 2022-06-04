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
        public OptimizeComponent()
        {
            InitializeComponent();
            this.oFile = UtilsLibrary.getUserFile();
        }

        public void triggerOptimize(BackgroundWorker oBackgroundWorker)
        {
            oBackgroundWorker.ReportProgress(0);

            OptimizeLibrary.optimize(oBackgroundWorker);

            oBackgroundWorker.ReportProgress(50);
            GLOBAL.oTempStockLengthOptimized = new List<TempStocklengthModel>();
            GLOBAL.oTempStockLengthOptimized = GLOBAL.oTempOptimized.GroupBy(o => new
            {
                o.stock_id,
                o.cutlength_id,
                o.total_cut,
                o.total_rest
            }).Select(o => new TempStocklengthModel
            {
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

            foreach (TempStocklengthModel oTempStockLength in GLOBAL.oTempStockLengthOptimized)
            {
                GLOBAL.oTempCutlength.Find(o => o.id == oTempStockLength.cutlength_id).total_layout++;
                if (oTempStockLength.rest != 0)
                {
                    this.saveRemnantScrapStock(oTempStockLength);
                    continue;

                }
                else if (oTempStockLength.scrap != 0)
                {
                    this.saveRemnantScrapStock(oTempStockLength);
                    continue;
                }
            }
            oBackgroundWorker.ReportProgress(90);
        }

        private void saveRemnantScrapStock(TempStocklengthModel oTempStockLength)
        {
            var oStockCollection = this.oFile.GetCollection<RemnantStockModel>();
            string sCutStockType = ((oTempStockLength.rest != 0) ? "remnant" : "scrap");
            double dLength = ((oTempStockLength.rest != 0) ? oTempStockLength.rest : oTempStockLength.scrap);
            oStockCollection.InsertOne(new RemnantStockModel
            {
                cost = 0.00,
                cut_stock_type = sCutStockType,
                length = dLength,
                stock_code = oTempStockLength.stock_code,
                stock_type = oTempStockLength.stock_type,
                material_id = oTempStockLength.material_id,
                note = oTempStockLength.note,
                qty = oTempStockLength.repeated.ToString(),
                editable = false,
                visibility = true,

            });
        }
       
        public void initOptimizedStockLengthDataTable(int iCutLength)
        {

            this.dt_stockLength.DataSource = new List<TempStocklengthModel>();
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.cutlength_id == iCutLength);
            this.dt_stockLength.DataSource = oTempStockLengthModel.ToArray();

            this.optimizeBarPanel.Controls.Clear();

            foreach (TempStocklengthModel oTempStockLength in oTempStockLengthModel)
            {
                var oStockCollection = this.oFile.GetCollection<StockModel>();
                OptimizeBarComponent oOptimizeBar = new OptimizeBarComponent();
                oOptimizeBar.initializeBar(oTempStockLength);
                this.optimizeBarPanel.Controls.Add(oOptimizeBar);
            }
        }
        public void assignReportParameters()
        {
            ReportViewerForm reportViewerForm = new ReportViewerForm();
            reportViewerForm.oTempCutlength = GLOBAL.oTempCutlength;
            reportViewerForm.oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized;
            reportViewerForm.optimizeBarPnl = this.optimizeBarPanel;
            reportViewerForm.Show();
        }

        private void cutLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow oCurrentRow = this.dt_optimize.Rows[e.RowIndex];
                var iCutLength = int.Parse(oCurrentRow.Cells["id"].Value.ToString());
                this.initOptimizedStockLengthDataTable(iCutLength);
            }
        }

        private void stockLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.optimizeBarPanel.AutoScrollPosition = new Point(3, e.RowIndex * 90);
            }
        }

        private void dt_optimize_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
