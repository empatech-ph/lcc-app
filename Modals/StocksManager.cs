using LCC.Components;
using LCC.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Modals
{
    public partial class StocksManager : MaterialForm
    {
        public bool bST;
        public bool bBO;
        public StocksManager()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            this.initMaterialTitle();
        }

        public void initMaterialTitle()
        {
            dynamic oMaterial = Library.UtilsLibrary.getUserFile().GetCollection<MaterialModel>().AsQueryable()
                .Where(o => o.id == GLOBAL.iSelectedMaterialId)
                .Select(o => new { o.description, o.grade })
                .First();
            this.l_material.Text = oMaterial.description + " " + oMaterial.grade;
        }

        public void initStockData()
        {
            IEnumerable<StockModel> oList = Library.UtilsLibrary.getUserFile().GetCollection<StockModel>()
                .AsQueryable()
                .Where(e => e.material_id == GLOBAL.iSelectedMaterialId);

            if (this.bST == true && this.bBO == true)
            {
                oList = oList.Where(e => e.stock_type == "BO" || e.stock_type == "ST");
            }
            else if (this.bST == false && this.bBO == true)
            {
                oList = oList.Where(e => e.stock_type == "BO");
            }
            else if (this.bST == true && this.bBO == false)
            {
                oList = oList.Where(e => e.stock_type == "ST");
            }
            BindingList<StockModel> oListModel = new BindingList<StockModel>(oList.ToList());
            this.dt_stock.DataSource = oListModel;
            this.dt_stock.Columns["id"].Visible = false;
            this.dt_stock.Columns["material_id"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var oAddStockModal = new AddStocksModal();
            oAddStockModal.oStockManager = this;
            oAddStockModal.ShowDialog();
        }

        private void dt_stock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var oRow = this.dt_stock.Rows[e.RowIndex];
            if (oRow.Cells["qty"].Value.ToString() == "-1")
            {
                oRow.Cells["qty"].Value = "∞";
            }
            this.setRowEditableColor(e);
        }

        private void dt_stock_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.setRowEditableColor(e);
        }

        private void setRowEditableColor(dynamic e)
        {
            //var oRow = this.dt_stock.Rows[e.RowIndex];
            //if (bool.Parse(oRow.Cells["editable"].Value.ToString()) == true)
            //{
            //    oRow.DefaultCellStyle.BackColor = Color.Salmon;
            //}
            //else
            //{
            //    oRow.DefaultCellStyle.BackColor = Color.Empty;
            //}
            var oRow = this.dt_stock.Rows[e.RowIndex];
            if (this.dt_stock.Columns[e.ColumnIndex].Name != "editable")
            {
                if (bool.Parse(oRow.Cells["editable"].Value.ToString()) == false)
                {
                    oRow.Cells[e.ColumnIndex].ReadOnly = true;
                }
                else if (this.dt_stock.Columns[e.ColumnIndex].Name != "qty")
                {
                    oRow.Cells[e.ColumnIndex].ReadOnly = false;
                }
            }
        }

        private void dataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.setRowEditableColor(e);
        }

        private void dt_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var oRow = this.dt_stock.Rows[e.RowIndex];
            if (bool.Parse(oRow.Cells["editable"].Value.ToString()) == true && this.dt_stock.Columns[e.ColumnIndex].Name == "qty")
            {
                var oModifyQtyModal = new ModifyQtyModal();
                oModifyQtyModal.oCurrentRow = oRow;
                oModifyQtyModal.oStockManager = this;
                oModifyQtyModal.ShowDialog();
            }
        }

        private void dt_stock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.updateStock();
        }

        public void updateStock()
        {
            try
            {
                var row = this.dt_stock.Rows[this.dt_stock.CurrentCell.RowIndex];
                var oStore = Library.UtilsLibrary.getUserFile();
                var collection = oStore.GetCollection<StockModel>();

                collection.UpdateOne(oRow => oRow.id == (int)row.Cells["id"].Value, new StockModel
                {
                    id = 1,
                    material_id = GLOBAL.iSelectedMaterialId,
                    qty = (row.Cells["qty"].Value == null) ? "0" : ((row.Cells["qty"].Value.ToString() == "∞") ? "-1" : row.Cells["qty"].Value.ToString()),
                    stock_type = row.Cells["stock_type"].Value.ToString(),
                    cost = (row.Cells["cost"].Value == null) ? 0.00 : double.Parse(row.Cells["cost"].Value.ToString()),
                    stock_code = (row.Cells["stock_code"].Value == null) ? "" : row.Cells["stock_code"].Value.ToString(),
                    note = (row.Cells["note"].Value == null) ? "" : row.Cells["note"].Value.ToString(),
                    visibility = bool.Parse(row.Cells["visibility"].Value.ToString()),
                    editable = bool.Parse(row.Cells["editable"].Value.ToString())
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the format when editing the field.");
            }
        }

        private void StocksManager_Load(object sender, EventArgs e)
        {
            this.initStockData();
        }
    }
}
