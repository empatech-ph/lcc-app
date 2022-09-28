using JsonFlatFileDataStore;
using LCC.Components;
using LCC.Library;
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
        private dynamic oLogin;
        public bool bIsGeneral = false;
        public AddStocksModal()
        {
            InitializeComponent();
            this.oLogin = new RegistryLibrary().getLogin();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        

        public void btn_save_Click(object sender, EventArgs e)
        {
            var store = Library.UtilsLibrary.getUserFile();
            if (this.description.Text != "" || this.grade.Text != "")
            {
                var oStockModel = store.GetCollection<StockModel>();
                oStockModel.InsertOne(new StockModel
                {
                    id = 1,
                    project_id = GLOBAL.iSelectedProjectId,
                    material_id = GLOBAL.iSelectedMaterialId,
                    grade = this.grade.Text,
                    description = this.description.Text,
                    qty = (this.c_qty.Text == "∞") ? "-1" : this.c_qty.Text,
                    stock_type = (oStockManager.sStockType == "") ? this.c_stockType.SelectedItem.ToString() : oStockManager.sStockType,
                    length = double.Parse(this.tb_length.Text.ToString()),
                    cost = (this.tb_cost.TextLength <= 0) ? 0.00 : double.Parse(this.tb_cost.Text),
                    stock_code = this.tb_stock_code.Text,
                    note = this.rb_note.Text,
                    visibility = this.ck_visible.Checked,
                    editable = this.ck_editable.Checked,
                    is_general = this.bIsGeneral
                });
                MessageBox.Show("Successfully inserted.", "Success");
                this.Close();
                oStockManager.initStockData();
            } else
            {
                MessageBox.Show("Please don`t leave description and grade blank.", "Error");
            }
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
            if (this.oStockManager.sDescription != "" || this.oStockManager.sGrade != "")
            {
                this.description.Enabled = false;
                this.grade.Enabled = false;

                this.description.Text = GLOBAL.sSelectedDescription;
                this.grade.Text = GLOBAL.sSelectedGrade;
            }

            this.l_materialName.Text = this.oStockManager.l_material.Text;
            if (this.oStockManager.sStockType != "")
            {
                this.c_stockType.Items.Add(this.oStockManager.sStockType);

            } else
            {
                if (this.oStockManager.bST == false && this.oStockManager.bBO == true)
                {
                    this.c_stockType.Items.Add("BO");
                    this.c_qty.Enabled = false;
                }
                else if (this.oStockManager.bST == true && this.oStockManager.bBO == false)
                {
                    this.c_stockType.Items.Add("ST");
                }
                else
                {

                    if (oLogin.user_type != 1)
                    {
                        this.c_stockType.Items.Add("BO");
                        this.c_qty.Enabled = false;
                    }
                    else
                    { 
                        this.c_stockType.Items.Add("ST");
                        this.c_stockType.Items.Add("BO");
                    }
                }
            }
            this.c_qty.SelectedIndex = 0;
            this.c_stockType.SelectedIndex = 0;
        }

        private void c_qty_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.c_qty.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void c_stockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.c_stockType.SelectedItem.ToString() == "BO")
            {
                this.c_qty.SelectedIndex = 0;
                this.c_qty.Enabled = false;
            }
            else {
                this.c_qty.Enabled = true;
            }
        }
    }
}
