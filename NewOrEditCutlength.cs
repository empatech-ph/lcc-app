using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using JsonFlatFileDataStore;
using LCC.Model;
using Newtonsoft.Json;
using System.Linq;

namespace LCC
{
    public partial class NewOrEditCutlength : MaterialForm
    {
        public static int newProjectId = 0;
        public static int editProjectId = 0;
        public static bool isAdd = true;
        public Project oProject;
        public NewOrEditCutlength()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            NewOrEditProject form = new NewOrEditProject();
            form.Text = isAdd ? "Add New Cut Lengths" : "Edit Cut Lengths";
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            try {
                double dLength = 0.00;
                int iQty = 0;
                if(double.TryParse(this.length.Text, out dLength) == false || int.TryParse(this.qty.Text, out iQty) == false)
                {
                    MessageBox.Show("Please check length (must be int or double) and qty (must be int).");
                }
                else if (!string.IsNullOrWhiteSpace(this.description.Text) && !string.IsNullOrWhiteSpace(this.grade.Text) && !string.IsNullOrWhiteSpace(this.qty.Text) && !string.IsNullOrWhiteSpace(this.length.Text))
                {
                    Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>().InsertOne(new CutLengthModel
                    {
                        id = 1,
                        project_id = GLOBAL.iSelectedProjectId,
                        part_code = !string.IsNullOrWhiteSpace(this.partcode.Text) ? this.partcode.Text : string.Empty,
                        description = !string.IsNullOrWhiteSpace(this.description.Text) ? this.description.Text : string.Empty,
                        grade = !string.IsNullOrWhiteSpace(this.grade.Text) ? this.grade.Text : string.Empty,
                        quantity = !string.IsNullOrWhiteSpace(this.qty.Text) ? int.Parse(this.qty.Text) : 0,
                        uncut_quantity = 0,
                        length = !string.IsNullOrWhiteSpace(this.length.Text) ? double.Parse(this.length.Text) : 0.00,
                        order_number = !string.IsNullOrWhiteSpace(this.orderno.Text) ? this.orderno.Text : string.Empty,
                        note = !string.IsNullOrWhiteSpace(this.note.Text) ? this.note.Text : string.Empty,
                    });
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fields are required and can't be null.");
                }
                this.oProject.initCutLength();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error!, " + ee.Message);
            }
            
        }

        private void projNameReferenceTxt_Validating(object sender, CancelEventArgs e)
        {

        }

        private void projNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void projNameReferenceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void qty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
