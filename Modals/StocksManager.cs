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
            Library.ThemeLibrary.initMaterialDesign(this);
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
            if (this.bST == false && this.bBO == true)
            {
                oList = oList.Where(e => e.stock_type == "BO");
                stock_type.Items.Add("BO");
            }
            else if (this.bST == true && this.bBO == false)
            {
                oList = oList.Where(e => e.stock_type == "ST");
                stock_type.Items.Add("ST");
            }
            else
            {
                oList = oList.Where(e => e.stock_type == "BO" || e.stock_type == "ST");
                stock_type.Items.Add("ST");
                stock_type.Items.Add("BO");
            }
            BindingList<StockModel> oListModel = new BindingList<StockModel>(oList.ToList());
            this.dt_stock.DataSource = oListModel;
            this.dt_stock.Columns["id"].Visible = false;
            this.dt_stock.Columns["cut_stock_type"].Visible = false;
            this.dt_stock.Columns["material_id"].Visible = false;
            this.dt_stock.Columns["visibility"].Visible = false;
            this.dt_stock.Columns["editable"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var oAddStockModal = new AddStocksModal();
            oAddStockModal.oStockManager = this;
            oAddStockModal.ShowDialog();
        }

        private void dt_stock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dt_stock_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.setRowEditableColor(e);
        }

        private void setRowEditableColor(dynamic e)
        {
            try
            {
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
            catch
            { }
        }

        private void dataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.setRowEditableColor(e);
        }

        private void dt_stock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var oRow = this.dt_stock.Rows[e.RowIndex];
                if (bool.Parse(oRow.Cells["editable"].Value.ToString()) == true && this.dt_stock.Columns[e.ColumnIndex].Name == "qty")
                {
                    var oModifyQtyModal = new ModifyQtyModal();
                    oModifyQtyModal.oCurrentRow = oRow;
                    oModifyQtyModal.oStockManager = this;
                    oModifyQtyModal.ShowDialog();
                }
                if (e.RowIndex != -1 && this.dt_stock.Columns[e.ColumnIndex].Name == "visibility_image" || this.dt_stock.Columns[e.ColumnIndex].Name == "editable_image" || this.dt_stock.Columns[e.ColumnIndex].Name == "remove_image")
                {
                    if (this.dt_stock.Columns[e.ColumnIndex].Name == "visibility_image")
                    {
                        oRow.Cells["visibility"].Value = !bool.Parse(oRow.Cells["visibility"].Value.ToString());
                        oRow.Cells["visibility_image"].Value = ((bool.Parse(oRow.Cells["visibility"].Value.ToString())) ? Properties.Resources.light_on : Properties.Resources.light_off);
                        (oRow.Cells["visibility_image"] as DataGridViewImageCell).ToolTipText = ((bool.Parse(oRow.Cells["visibility"].Value.ToString())) ? "Visible" : "Not Visible");

                        this.updateStock();
                    }
                    else if (this.dt_stock.Columns[e.ColumnIndex].Name == "editable_image")
                    {
                        oRow.Cells["editable"].Value = !bool.Parse(oRow.Cells["editable"].Value.ToString());
                        oRow.Cells["editable_image"].Value = ((bool.Parse(oRow.Cells["editable"].Value.ToString())) ? Properties.Resources.unlocked : Properties.Resources.locked);
                        (oRow.Cells["editable_image"] as DataGridViewImageCell).ToolTipText = ((bool.Parse(oRow.Cells["editable"].Value.ToString())) ? "Editable" : "Not Editable");

                        this.updateStock();
                    }
                    else if (this.dt_stock.Columns[e.ColumnIndex].Name == "remove_image")
                    {
                        DialogResult oDialog = MessageBox.Show("Do you want to continue to remove this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if(oDialog == DialogResult.Yes)
                        {
                            Library.UtilsLibrary.getUserFile().GetCollection<StockModel>().DeleteOne(oRow.Cells["id"].Value);
                            this.dt_stock.Rows.RemoveAt(oRow.Index);
                        }
                    }
                }
            }
            catch { }
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

                collection.UpdateOne(oRow => oRow.id == int.Parse(row.Cells["id"].Value.ToString()), new StockModel
                {
                    id = int.Parse(row.Cells["id"].Value.ToString()),
                    material_id = GLOBAL.iSelectedMaterialId,
                    qty = (row.Cells["qty"].Value == null) ? "0" : ((row.Cells["qty"].Value.ToString() == "∞") ? "-1" : row.Cells["qty"].Value.ToString()),
                    stock_type = row.Cells["stock_type"].Value.ToString(),
                    cost = (row.Cells["cost"].Value == null) ? 0.00 : double.Parse(row.Cells["cost"].Value.ToString()),
                    length = (row.Cells["length"].Value == null) ? 0 : double.Parse(row.Cells["length"].Value.ToString()),
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

        private void dt_stock_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow oRow in this.dt_stock.Rows)
            {
                oRow.Cells["visibility_image"].Value = (bool.Parse(oRow.Cells["visibility"].Value.ToString()) ? Properties.Resources.light_on : Properties.Resources.light_off);
                oRow.Cells["editable_image"].Value = (bool.Parse(oRow.Cells["editable"].Value.ToString()) ? Properties.Resources.unlocked : Properties.Resources.locked);

                (oRow.Cells["visibility_image"] as DataGridViewImageCell).ToolTipText = ((bool.Parse(oRow.Cells["visibility"].Value.ToString())) ? "Visible" : "Not Visible");
                (oRow.Cells["editable_image"] as DataGridViewImageCell).ToolTipText = ((bool.Parse(oRow.Cells["editable"].Value.ToString())) ? "Editable" : "Not Editable");

                if (oRow.Cells["qty"].Value.ToString() == "-1")
                {
                    oRow.Cells["qty"].Value = "∞";
                }
            }
        }
    }
}
