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
    public partial class NewOrEditProject : MaterialForm
    {
        public static int newProjectId = 0;
        public static int editProjectId = 0;
        public static bool isAdd = true;
        public Project oProject;
        public NewOrEditProject()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void NewProject_Load(object sender, EventArgs e)
        {
            NewOrEditProject form = new NewOrEditProject();
            form.Text = isAdd ? "Add New Project" : "Edit Project";
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(projNameTxt.Text) && !string.IsNullOrWhiteSpace(projNameReferenceTxt.Text) && !string.IsNullOrWhiteSpace(revNumberTxt.Text) && !string.IsNullOrWhiteSpace(scopeOfWorksTxt.Text))
                {
                    var collection = Library.UtilsLibrary.getUserFile().GetCollection<ProjectModel>();
                    Project.selectedProject = collection.GetNextIdValue();
                    if (isAdd)
                    {
                        collection.InsertOne(new ProjectModel { id = 1, project_name = projNameTxt.Text, project_reference = projNameReferenceTxt.Text, rev_no = revNumberTxt.Text, scope = scopeOfWorksTxt.Text, is_active = true });
                    }
                    else
                    {

                        collection.UpdateOne(x => x.id == editProjectId, new ProjectModel { id = editProjectId, project_name = projNameTxt.Text, project_reference = projNameReferenceTxt.Text, rev_no = revNumberTxt.Text, scope = scopeOfWorksTxt.Text, is_active = true });
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.oProject.initProject();
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
