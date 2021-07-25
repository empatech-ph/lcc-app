using JsonFlatFileDataStore;
using LCC.Library;
using LCC.Model;
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
        public OptimizeComponent()
        {
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

            var dtCutLengthTable = this.dt_optimize.DataSource as DataTable;
            if (dtCutLengthTable != null) dtCutLengthTable.Rows.Clear();
            this.dt_optimize.DataSource = GLOBAL.oTempCutlength;

            this.dt_optimize.Columns["grade"].Visible = false;
            this.dt_optimize.Columns["project_id"].Visible = false;
            this.dt_optimize.Columns["order_number"].Visible = false;
            this.dt_optimize.Columns["length"].Visible = false;
            this.dt_optimize.Columns["part_code"].Visible = false;
            this.dt_optimize.Columns["note"].Visible = false;
            this.dt_optimize.Columns["description"].Visible = false;
            this.dt_optimize.Columns["id"].Visible = false;


            foreach (TempCutlengthModel oCutLength in GLOBAL.oTempCutlength)
            {
                var oCutLengthCollection = UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                oCutLengthCollection.UpdateOne(e => e.id == oCutLength.id, oCutLength);

            }

            if (this.dt_optimize.RowCount > 0)
            {
                this.initOptimizedStockLengthDataTable(int.Parse(this.dt_optimize.Rows[0].Cells["id"].Value.ToString()));
            }

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
        }

        private void saveRemnantScrapStock(TempStocklengthModel oTempStockLength)
        {
            var oStockCollection = UtilsLibrary.getUserFile().GetCollection<StockModel>();
            string sCutStockType = ((oTempStockLength.rest != 0) ? "remnant" : "scrap");
            double dLength = ((oTempStockLength.rest != 0) ? oTempStockLength.rest : oTempStockLength.scrap);
            var oExistingStockLength = oStockCollection.AsQueryable().Where(e => e.cut_stock_type == sCutStockType && e.length == dLength &&
                        e.stock_code == oTempStockLength.stock_code && e.material_id == oTempStockLength.material_id).FirstOrDefault();
            if (oExistingStockLength != null)
            {

                oStockCollection.UpdateOne(e => e.id == oExistingStockLength.id, new StockModel
                {
                    qty = (oTempStockLength.repeated + int.Parse(oExistingStockLength.qty)).ToString()
                });
            }
            else
            {
                oStockCollection.InsertOne(new StockModel
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
        }

        private void initOptimizedStockLengthDataTable(int iCutLength)
        {
            var dtStockLengthTable = this.stockLengthTable.DataSource as DataTable;
            if (dtStockLengthTable != null) dtStockLengthTable.Rows.Clear();
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.cutlength_id == iCutLength);
            this.stockLengthTable.DataSource = oTempStockLengthModel;
            this.stockLengthTable.Columns["cutlength_id"].Visible = false;
            this.stockLengthTable.Columns["material_id"].Visible = false;
            this.stockLengthTable.Columns["data"].Visible = false;
            this.stockLengthTable.Columns["stock_desc_grade"].Visible = false;
            this.stockLengthTable.Columns["cutlength_length"].Visible = false;
            this.stockLengthTable.Columns["trim_left"].Visible = false;
            this.stockLengthTable.Columns["trim_right"].Visible = false;
            this.stockLengthTable.Columns["kerf"].Visible = false;

            this.optimizeBarPanel.Controls.Clear();

            foreach (TempStocklengthModel oTempStockLength in oTempStockLengthModel)
            {
                var oStockCollection = UtilsLibrary.getUserFile().GetCollection<StockModel>();
                OptimizeBarComponent oOptimizeBar = new OptimizeBarComponent();
                oOptimizeBar.initializeBar(oTempStockLength);
                this.optimizeBarPanel.Controls.Add(oOptimizeBar);
            }
        }

        private void cutLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow oCurrentRow = this.dt_optimize.Rows[e.RowIndex];
                this.initOptimizedStockLengthDataTable(int.Parse(oCurrentRow.Cells["id"].Value.ToString()));
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
