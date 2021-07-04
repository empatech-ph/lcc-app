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
    public partial class AddMaterialModal : MaterialForm
    {
        public MaterialComponent oMaterialComponent;
        public AddMaterialModal()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        public void btn_save_Click(object sender, EventArgs e)
        {
            var store = Library.UtilsLibrary.getUserFile();
            var oMaterialModel = store.GetCollection<MaterialModel>();
            try
            {
                if(this.tb_description.TextLength <= 0 || this.tb_grade.TextLength <= 0)
                {
                    throw new Exception();
                }

                oMaterialModel.InsertOne(new MaterialModel
                {
                    id = 1,
                    project_id = GLOBAL.iSelectedProjectId,
                    description = this.tb_description.Text,
                    grade = this.tb_grade.Text,
                    kerf = this.tb_kerf.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_kerf.Text),
                    trim_left = this.tb_trim_left.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_trim_left.Text),
                    trim_right = this.tb_trim_right.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_trim_right.Text),
                    part_allowance = this.tb_partial_allowance.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_partial_allowance.Text),
                    min_remnant_length = this.tb_min_remnant.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_min_remnant.Text),
                });

                DialogResult oDialogResult = MessageBox.Show("Successfully inserted.\nDo you want to insert another?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(oDialogResult == DialogResult.Yes) {
                    this.tb_description.Clear();
                    this.tb_grade.Clear();
                    this.tb_kerf.Text = "0.00";
                    this.tb_trim_left.Text = "0.00";
                    this.tb_trim_right.Text = "0.00";
                    this.tb_partial_allowance.Text = "0.00";
                    this.tb_min_remnant.Text = "0.00";
                } else {
                    this.Close();
                }

                oMaterialComponent.initDatagrid();
            }
            catch(Exception)
            {
                MessageBox.Show("You may have entered invalid inputs, Please check.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_kerf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
