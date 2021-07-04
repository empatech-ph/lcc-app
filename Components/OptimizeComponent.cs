using LCC.Model;
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
            var oOptimize = new Library.OptimizeLibrary();
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
                cutlength_length = o.Last().cutlength_length,
                data = o.Last()
            }).ToList();

            var dtStockLengthTable = this.stockLengthTable.DataSource as DataTable;
            var dtCutLengthTable = this.cutLengthTable.DataSource as DataTable;
            if (dtStockLengthTable != null) dtStockLengthTable.Rows.Clear();
            if (dtCutLengthTable != null) dtCutLengthTable.Rows.Clear();

            this.cutLengthTable.DataSource = GLOBAL.oTempCutlength;
            this.cutLengthTable.Columns["grade"].Visible = false;
            this.cutLengthTable.Columns["description"].Visible = false;
            this.cutLengthTable.Columns["cutlength_id"].Visible = false;
            if (this.cutLengthTable.RowCount > 0) 
            {
                this.initOptimizedStockLengthDataTable(int.Parse(this.cutLengthTable.CurrentRow.Cells["cutlength_id"].Value.ToString())); 
            }
        }

        private void initOptimizedStockLengthDataTable(int iCutLength)
        {
            var dtStockLengthTable = this.stockLengthTable.DataSource as DataTable;
            if (dtStockLengthTable != null) dtStockLengthTable.Rows.Clear();
            List<TempStocklengthModel> oTempStockLengthModel = GLOBAL.oTempStockLengthOptimized.FindAll(e => e.cutlength_id == iCutLength);
            this.stockLengthTable.DataSource = oTempStockLengthModel;
            this.stockLengthTable.Columns["cutlength_id"].Visible = false;
            this.stockLengthTable.Columns["data"].Visible = false;
            this.stockLengthTable.Columns["stock_desc_grade"].Visible = false;
            this.stockLengthTable.Columns["cutlength_length"].Visible = false;

            this.optimizeBarPanel.Controls.Clear();
            
            foreach(TempStocklengthModel oTempStockLength in oTempStockLengthModel)
            {
                OptimizeBarComponent oOptimizeBar = new OptimizeBarComponent();
                oOptimizeBar.initializeBar(oTempStockLength);
                this.optimizeBarPanel.Controls.Add(oOptimizeBar);
            }
        }

        private void cutLengthTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow oCurrentRow = this.cutLengthTable.Rows[e.RowIndex];
                this.initOptimizedStockLengthDataTable(int.Parse(oCurrentRow.Cells["cutlength_id"].Value.ToString()));
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
