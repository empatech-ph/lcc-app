using JsonFlatFileDataStore;
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
    public partial class AddStocksModal : MaterialForm
    {
        public StocksManager oStockManager;
        public AddStocksModal()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        public void btn_save_Click(object sender, EventArgs e)
        {
            var store = Library.UtilsLibrary.getUserFile();
            var oStockModel = store.GetCollection<StockModel>();
                oStockModel.InsertOne(new StockModel
                {
                    id = 1,
                    material_id = GLOBAL.iSelectedMaterialId,
                    qty = (this.c_qty.Text == "∞") ? "-1" : this.c_qty.Text,
                    stock_type = this.c_stockType.SelectedItem.ToString(),
                    cost = (this.tb_cost.TextLength <= 0) ? 0.00 : double.Parse(this.tb_cost.Text),
                    stock_code = this.tb_stock_code.Text,
                    note = this.rb_note.Text,
                    visibility = this.ck_visible.Checked,
                    editable = this.ck_editable.Checked
                });

                DialogResult oDialogResult = MessageBox.Show("Successfully inserted.\nDo you want to insert another?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(oDialogResult == DialogResult.Yes) {
                    this.rb_note.Clear();
                    this.tb_stock_code.Clear();
                    this.tb_cost.Text = "0.00";
                    this.c_qty.ResetText();
                    this.c_stockType.ResetText();
                    this.ck_visible.Checked = true;
                    this.ck_editable.Checked = true;
                } else {
                    this.Close();
                }

                oStockManager.initStockData();

        }

        private void tb_kerf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void AddStocksModal_Load(object sender, EventArgs e)
        {

            this.l_materialName.Text = this.oStockManager.l_material.Text;
            if (this.oStockManager.bST == false && this.oStockManager.bBO == true)
            {
                this.c_stockType.Items.Add("BO");
            }
            else if (this.oStockManager.bST == true && this.oStockManager.bBO == false)
            {
                this.c_stockType.Items.Add("ST");
            } 
            else
            {
                this.c_stockType.Items.Add("ST");
                this.c_stockType.Items.Add("BO");
            }
            this.c_qty.SelectedIndex = 0;
            this.c_stockType.SelectedIndex = 0;
        }

        private void c_qty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.c_qty.DropDownStyle = ComboBoxStyle.DropDown;
        }
    }
}
