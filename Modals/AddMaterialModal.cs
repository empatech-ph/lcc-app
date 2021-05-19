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
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        public void btn_save_Click(object sender, EventArgs e)
        {
            var store = Library.UtilsLibrary.getUserFile();
            var collection = store.GetCollection<MaterialModel>();
            try
            {
                if(this.tb_description.TextLength <= 0)
                {
                    throw new Exception();
                }
                collection.InsertOne(new MaterialModel
                {
                    description = this.tb_description.Text,
                    grade = this.tb_grade.Text,
                    kerf = this.tb_kerf.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_kerf.Text),
                    trim_left = this.tb_trim_left.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_trim_left.Text),
                    trim_right = this.tb_trim_right.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_trim_right.Text),
                    part_allowance = this.tb_partial_allowance.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_partial_allowance.Text),
                    min_remnant_length = this.tb_min_remnant.TextLength <= 0 ? 0.00 : Convert.ToDouble(this.tb_min_remnant.Text),
                });

                DialogResult oDialogResult = MessageBox.Show("Successfully inserted.\nYou want to insert another?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
    }
}
