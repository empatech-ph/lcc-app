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
    public partial class StocksManager : MaterialForm
    {
        public bool bST;
        public bool bBO;
        public string sStockType = "";
        private dynamic oInfo;
        private dynamic oLogin;
        public string sDescription = "";
        public string sGrade= "";
       
        public StocksManager()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
            this.initMaterialTitle();
            string unit = GLOBAL.getOptions().unit ?? "mm";
            foreach (DataGridViewColumn oHeader in this.dt_stock.Columns)
            {
                oHeader.HeaderText = oHeader.HeaderText.Replace("(mm)", "(" + unit + ")");
            }
        }

        public StocksManager(string sStockType)
        {
            InitializeComponent();
            this.oLogin = new RegistryLibrary().getLogin(); 
            string unit = GLOBAL.getOptions().unit ?? "mm";
            foreach (DataGridViewColumn oHeader in this.dt_stock.Columns)
            {
                oHeader.HeaderText = oHeader.HeaderText.Replace("(mm)", "(" + unit + ")");
            }
            Library.ThemeLibrary.initMaterialDesign(this);
            this.sStockType = sStockType;

            this.l_material.Text = (sStockType == "BO") ? "Commercial Length List" : "Inventory List";

            if (oLogin.user_type == 2 && sStockType == "ST")
            {
                this.btn_add.Visible = false;
            }
        }

        public void initMaterialTitle()
        {
            dynamic oMaterial = Library.UtilsLibrary.getUserFile().GetCollection<MaterialModel>().AsQueryable()
                .Where(o => o.id == GLOBAL.iSelectedMaterialId)
                .Select(o => new { o.description, o.grade })
                .First();
            this.l_material.Text = oMaterial.description + " " + oMaterial.grade;
            this.sDescription = oMaterial.description;
            this.sGrade = oMaterial.grade;
        }

        public void initStockData()
        {
            IEnumerable<StockModel> oStockList = Library.UtilsLibrary.getUserFile().GetCollection<StockModel>()
                .AsQueryable();

            if (this.sStockType != "") {
                IEnumerable<MaterialModel> oMaterialList = Library.UtilsLibrary.getUserFile().GetCollection<MaterialModel>()
                .AsQueryable();
                oStockList = oStockList.Where(e => e.project_id == GLOBAL.iSelectedProjectId && e.stock_type == this.sStockType);
                
                this.dt_stock.Columns["stock_type"].Visible = false;
                this.dt_stock.Columns["grade"].ReadOnly = true;
                this.dt_stock.Columns["description"].ReadOnly = true;
            } else {
                oStockList = oStockList.Where(e => e.project_id == GLOBAL.iSelectedProjectId && ((e.grade ?? "").Trim() == GLOBAL.sSelectedGrade.Trim() && (e.description ?? "").Trim() == GLOBAL.sSelectedDescription.Trim()) && ((e.stock_type == "BO" || this.bST == true) && (e.stock_type == "ST" || this.bBO == true)));

                this.dt_stock.Columns["grade"].Visible = false;
                this.dt_stock.Columns["description"].Visible = false;
            }

            BindingList<StockModel> oListModel = new BindingList<StockModel>(oStockList.ToList());
            this.dt_stock.DataSource = oListModel;
            this.dt_stock.Columns["id"].Visible = false;
            this.dt_stock.Columns["project_id"].Visible = false;
            this.dt_stock.Columns["stock_type"].ReadOnly = true;
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
                this.dt_stock.Columns["stock_type"].ReadOnly = true;
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
                if (bool.Parse(oRow.Cells["editable"].Value.ToString()) == true && this.dt_stock.Columns[e.ColumnIndex].Name == "qty" && oRow.Cells["stock_type"].Value.ToString() != "BO")
                {
                    var oModifyQtyModal = new ModifyQtyModal();
                    oModifyQtyModal.oCurrentRow = oRow;
                    oModifyQtyModal.oStockManager = this;
                    oModifyQtyModal.ShowDialog();
                }
                if (e.RowIndex != -1 && this.dt_stock.Columns[e.ColumnIndex].Name == "visibility_image" || this.dt_stock.Columns[e.ColumnIndex].Name == "editable_image")
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
                    project_id = GLOBAL.iSelectedProjectId,
                    material_id = GLOBAL.iSelectedMaterialId,
                    qty = (row.Cells["qty"].Value == null) ? "0" : ((row.Cells["qty"].Value.ToString() == "∞") ? "-1" : row.Cells["qty"].Value.ToString()),
                    stock_type = row.Cells["stock_type"].Value.ToString(),
                    cost = (row.Cells["cost"].Value == null) ? 0.00 : double.Parse(row.Cells["cost"].Value.ToString()),
                    length = (row.Cells["length"].Value == null) ? 0 : double.Parse(row.Cells["length"].Value.ToString()),
                    stock_code = (row.Cells["stock_code"].Value == null) ? "" : row.Cells["stock_code"].Value.ToString(),
                    note = (row.Cells["note"].Value == null) ? "" : row.Cells["note"].Value.ToString(),
                    description = (row.Cells["description"].Value == null) ? "" : row.Cells["description"].Value.ToString(),
                    grade = (row.Cells["grade"].Value == null) ? "" : row.Cells["grade"].Value.ToString(),
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportFieldMapping importFieldMapping = new ImportFieldMapping();
            importFieldMapping.Text += " - " + "Materials";
            importFieldMapping.sInvetoryType = this.sStockType;
            importFieldMapping.sDescription = this.sDescription;
            importFieldMapping.sGrade = this.sGrade;
            importFieldMapping.openFileDialog.Filter = "CSV and Text Files (*.csv;*.txt;*.xlsx)|*.csv;*.txt;*.xlsx";
            importFieldMapping.openFileDialog.Title = "Browse File";
            System.Windows.Forms.DialogResult dialogResult = importFieldMapping.openFileDialog.ShowDialog();
            importFieldMapping.sType = "Materials";
            if (dialogResult == System.Windows.Forms.DialogResult.Cancel) return;
            importFieldMapping.openFileDialog.Tag = "Materials";
            importFieldMapping.importFieldMappingDisplay(sender, e);
        }

        private void dt_stock_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Please check if you have inputted the correct information");
        }
    }
}
