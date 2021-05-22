using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.Modals
{
    public partial class ModifyQtyModal : MaterialForm
    {
        public DataGridViewRow oCurrentRow;
        public StocksManager oStockManager;
        public ModifyQtyModal()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            oCurrentRow.Cells["qty"].Value = this.c_qty.Text;
            oStockManager.updateStock();

        }

        private void ModifyQtyModal_Load(object sender, EventArgs e)
        {
            this.c_qty.Text = oCurrentRow.Cells["qty"].Value.ToString();
        }
    }
}
