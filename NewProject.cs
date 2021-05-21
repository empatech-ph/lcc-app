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
    public partial class NewProject : MaterialForm
    {
        public static int newProjectId = 0;
        public NewProject()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void NewProject_Load(object sender, EventArgs e)
        {

        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(projNameTxt.Text) && !string.IsNullOrWhiteSpace(projNameReferenceTxt.Text) && !string.IsNullOrWhiteSpace(revNumberTxt.Text) && !string.IsNullOrWhiteSpace(scopeOfWorksTxt.Text))
                {
                    var collection = Library.UtilsLibrary.getUserFile().GetCollection<ProjectModel>();
                    newProjectId = collection.GetNextIdValue();
                    collection.InsertOne(new ProjectModel { id = 1, project_name = projNameTxt.Text, project_reference = projNameReferenceTxt.Text, rev_no = revNumberTxt.Text, scope = scopeOfWorksTxt.Text });
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You may have entered invalid inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void projNameReferenceTxt_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
