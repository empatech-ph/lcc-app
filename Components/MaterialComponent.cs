using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LCC.Model;
using System.Linq;

namespace LCC.Components
{
    public partial class MaterialComponent : UserControl
    {
        public MaterialComponent()
        {
            InitializeComponent();
            this.initDatagrid();
        }

        public void initDatagrid()
        {
            var oStore = Library.UtilsLibrary.getUserFile();
            BindingList<MaterialModel> oListModel = new BindingList<MaterialModel>(oStore.GetCollection<MaterialModel>().AsQueryable().ToList());
            this.dt_material.DataSource = oListModel;
            this.dt_material.Columns["id"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var oAddMaterialModal = new Modals.AddMaterialModal();
            oAddMaterialModal.oMaterialComponent = this;
            oAddMaterialModal.ShowDialog();
        }

        private void dt_material_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = this.dt_material.Rows[this.dt_material.CurrentCell.RowIndex];
                var oStore = Library.UtilsLibrary.getUserFile();
                var collection = oStore.GetCollection<MaterialModel>();

                collection.UpdateOne(oRow => oRow.id == (int)row.Cells["id"].Value, new MaterialModel
                {
                    no = row.Cells["no"].Value != null ? (int)row.Cells["no"].Value : 0,
                    description = row.Cells["description"].Value != null ? row.Cells["description"].Value.ToString() : "",
                    grade = row.Cells["grade"].Value != null ? row.Cells["grade"].Value.ToString() : "",
                    kerf = row.Cells["kerf"].Value != null ? Convert.ToDouble(row.Cells["kerf"].Value) : 0.00,
                    trim_left = row.Cells["trim_left"].Value != null ? Convert.ToDouble(row.Cells["trim_left"].Value) : 0.00,
                    trim_right = row.Cells["trim_right"].Value != null ? Convert.ToDouble(row.Cells["trim_right"].Value) : 0.00,
                    part_allowance = row.Cells["part_allowance"].Value != null ? Convert.ToDouble(row.Cells["part_allowance"].Value) : 0.00,
                    min_remnant_length = row.Cells["min_remnant_length"].Value != null ? Convert.ToDouble(row.Cells["min_remnant_length"].Value) : 0.00
                });
            }
            catch(Exception)
            {
                MessageBox.Show("Please check the format when editing the field.");
            }
        }

        private void dt_material_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string sCellName = this.dt_material.Columns[this.dt_material.CurrentCell.ColumnIndex].Name;
            if(sCellName == "kerf" || sCellName == "trim_left" || sCellName == "trim_right" || sCellName == "part_allowance" || sCellName == "min_remnant_length") {

                //e.Control.KeyPress += new KeyPressEventHandler(CheckKey);
            }
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
