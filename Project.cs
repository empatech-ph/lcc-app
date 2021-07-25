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
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using ChoETL;
using System.Globalization;
using CsvHelper;
using LCC.Components;
using LCC.Library;
using System.Threading;
using LCC.Modals;

namespace LCC
{
    public partial class Project : MaterialForm
    {
        //public static string importOrExport = "";
        public static int selectedProject = 0;
        int LastNewRowIndex = -1;

        private DataStore oFile;
        public Project()
        {
            InitializeComponent();
            ThemeLibrary.initMaterialDesign(this);

            this.oFile = UtilsLibrary.getUserFile();
            this.initProject();
            this.initCutLength();
        }

        public void Project_Load(object sender, EventArgs e)
        {
            //tool tips
            projectToolTip.SetToolTip(projectBtn, "Projects");
            projectToolTip.SetToolTip(addProject, "Create New Project");
            projectToolTip.SetToolTip(materialBtn, "Materials");
            projectToolTip.SetToolTip(assemblyBtn, "Assemblies");
            projectToolTip.SetToolTip(storageBtn, "Audit Logs");
            projectToolTip.SetToolTip(printerBtn, "Print Reports");
            projectToolTip.SetToolTip(filterBtn, "Search and Filter");
            projectToolTip.SetToolTip(importBtn, "Import File");
            projectToolTip.SetToolTip(exportBtn, "Export File");
            projectToolTip.SetToolTip(optimizeBtn, "Optimize");

            //var rowIndex = cutLengthsTable.CurrentCell.IsNull() ? 0 : cutLengthsTable.CurrentCell.RowIndex;
            //DataGridViewRow row = cutLengthsTable.Rows[rowIndex];

        }
        private void projectTblView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = projectTable.Rows[e.RowIndex];
                GLOBAL.iSelectedProjectId = int.Parse(row.Cells["id"].Value.ToString());
                this.l_currentProject.Text = "Current Project :" + row.Cells["project_name"].Value.ToString();
                if (e.ColumnIndex == projectTable.Columns["view_column"].Index)
                {
                    MessageBox.Show("Test");
                }
                else if (e.ColumnIndex == projectTable.Columns["edit_column"].Index)
                {
                    NewOrEditProject editProject = new NewOrEditProject();
                    editProject.oProject = this;
                    editProject.projNameTxt.Text = row.Cells["project_name"].Value.ToString();
                    editProject.projNameReferenceTxt.Text = row.Cells["project_reference"].Value.ToString();
                    editProject.scopeOfWorksTxt.Text = row.Cells["scope"].Value.ToString();
                    editProject.revNumberTxt.Text = row.Cells["rev_no"].Value.ToString();
                    NewOrEditProject.editProjectId = int.Parse(row.Cells["id"].Value.ToString());
                    NewOrEditProject.isAdd = false;
                    editProject.ShowDialog();

                }
                this.materialComponent1.initDatagrid();
                this.initCutLength();
            }
        }

        private void projectBtn_Click(object sender, EventArgs e)
        {
            tabOptiPlus.Visible = true;
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            NewOrEditProject newProject = new NewOrEditProject(); ;
            newProject.oProject = this;
            NewOrEditProject.isAdd = true;
            newProject.ShowDialog();
        }

        public void initProject()
        {
            this.oFile.Reload();
            var oProjectList = this.oFile.GetCollection<ProjectModel>().AsQueryable();
            this.projectTable.DataSource = oProjectList.ToList();
            this.projectTable.Columns["id"].Visible = false;
            GLOBAL.iSelectedProjectId = (oProjectList.ToList().Count <= 0) ? 0 : oProjectList.FirstOrDefault().id;
            this.l_currentProject.Text = "Current Project : " + ((oProjectList.ToList().Count <= 0) ? "No selected project" : oProjectList.FirstOrDefault().project_name.ToString());
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            //importOrExport = "Import";
            ImportExportForm importExportForm = new ImportExportForm();
            importExportForm.oProject = this;
            importExportForm.ShowDialog();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            //importOrExport = "Export";
            //ImportExportForm importExportForm = new ImportExportForm();
            //importExportForm.ShowDialog();

            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save File";
            saveFileDialog.ShowDialog();
        }

        private void projectTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = projectTable.Rows[e.RowIndex];
            var collection = this.oFile.GetCollection<ProjectModel>();
            collection.UpdateOne(x => x.id == (int)row.Cells["id"].Value, new ProjectModel
            {
                id = int.Parse(row.Cells["id"].Value.ToString()),
                project_name = row.Cells["project_name"].Value.ToString(),
                project_reference = row.Cells["project_reference"].Value.ToString(),
                rev_no = row.Cells["rev_no"].Value.ToString(),
                scope = row.Cells["scope"].Value.ToString()
            });
        }

        private void printerBtn_Click(object sender, EventArgs e)
        {

        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var records = this.oFile.GetCollection<ProjectModel>().AsQueryable().Select(x => new { x.project_reference, x.project_name, x.scope, x.rev_no }).ToList();
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                }
                MessageBox.Show("File has been downloaded. Data has been exported succesfully.");
            }
            catch
            {
                MessageBox.Show("You may have uploaded a file with invalid entries. Please check your file and try again.");
            }

        }

        public void initCutLength()
        {
            var collection = this.oFile.GetCollection<CutLengthModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
            cutLengthsTable.DataSource = null;
            cutLengthsTable.DataSource = new BindingList<CutLengthModel>(collection);
            cutLengthsTable.Columns["id"].Visible = false;
            cutLengthsTable.Columns["project_id"].Visible = false;
            cutLengthsTable.Columns["part_code"].HeaderText = "Part Code";
            cutLengthsTable.Columns["description"].HeaderText = "Description";
            cutLengthsTable.Columns["grade"].HeaderText = "Grade";
            cutLengthsTable.Columns["quantity"].HeaderText = "Quantity";
            cutLengthsTable.Columns["uncut_quantity"].HeaderText = "Uncut Quantity";
            cutLengthsTable.Columns["length"].HeaderText = "Length";
            cutLengthsTable.Columns["order_number"].HeaderText = "Order Number";
            cutLengthsTable.Columns["note"].HeaderText = "Note";
        }

        private void cutLengthsTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            LastNewRowIndex = e.Row.Index - 1;
        }

        private void cutLengthsTable_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (LastNewRowIndex > -1)
            {
                try
                {
                    var row = cutLengthsTable.Rows[e.RowIndex];
                    if (tabOptiPlus.SelectedTab.Name == "cutLengthTab")
                    {
                        if (row.Cells["description"].Value != null && row.Cells["grade"].Value != null)
                        {
                            this.oFile.GetCollection<CutLengthModel>().InsertOne(new CutLengthModel
                            {
                                id = 1,
                                project_id = GLOBAL.iSelectedProjectId,
                                part_code = row.Cells["part_code"].Value != null ? row.Cells["part_code"].Value.ToString() : string.Empty,
                                description = row.Cells["description"].Value != null ? row.Cells["description"].Value.ToString() : string.Empty,
                                grade = row.Cells["grade"].Value != null ? row.Cells["grade"].Value.ToString() : string.Empty,
                                quantity = row.Cells["quantity"].Value != null ? int.Parse(row.Cells["quantity"].Value.ToString()) : 0,
                                uncut_quantity = row.Cells["uncut_quantity"].Value != null ? int.Parse(row.Cells["uncut_quantity"].Value.ToString()) : 0,
                                length = row.Cells["length"].Value != null ? double.Parse(row.Cells["length"].Value.ToString()) : 0.00,
                                order_number = row.Cells["order_number"].Value != null ? row.Cells["order_number"].Value.ToString() : string.Empty,
                                note = row.Cells["note"].Value != null ? row.Cells["note"].Value.ToString() : string.Empty,
                            });
                        }
                        else
                        {
                            MessageBox.Show("Description and Grade fields can't be null.");
                        }
                    }
                    else
                    {
                        this.oFile.GetCollection<ProjectModel>().InsertOne(new ProjectModel
                        {
                            id = 1,
                            project_name = row.Cells["project_name"].Value != null ? row.Cells["project_name"].Value.ToString() : string.Empty,
                            project_reference = row.Cells["project_reference"].Value != null ? row.Cells["project_reference"].Value.ToString() : string.Empty,
                            rev_no = row.Cells["rev_no"].Value != null ? row.Cells["rev_no"].Value.ToString() : string.Empty,
                            scope = row.Cells["scope"].Value != null ? row.Cells["scope"].Value.ToString() : string.Empty,
                        });
                    }

                }
                catch
                {
                    MessageBox.Show("Error.");
                }
                LastNewRowIndex = -1;
            }
        }

        private void cutLengthsTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = cutLengthsTable.Rows[e.RowIndex];
            if (row.Cells["id"].Value != null)
                this.oFile.GetCollection<CutLengthModel>().UpdateOne(x => x.id == (int)row.Cells["id"].Value, new CutLengthModel
                {
                    id = int.Parse(row.Cells["id"].Value.ToString()),
                    project_id = GLOBAL.iSelectedProjectId,
                    part_code = row.Cells["part_code"].Value != null ? row.Cells["part_code"].Value.ToString() : string.Empty,
                    description = row.Cells["description"].Value != null ? row.Cells["description"].Value.ToString() : string.Empty,
                    grade = row.Cells["grade"].Value != null ? row.Cells["grade"].Value.ToString() : string.Empty,
                    quantity = row.Cells["quantity"].Value != null ? int.Parse(row.Cells["quantity"].Value.ToString()) : 0,
                    uncut_quantity = row.Cells["uncut_quantity"].Value != null ? int.Parse(row.Cells["uncut_quantity"].Value.ToString()) : 0,
                    length = row.Cells["length"].Value != null ? double.Parse(row.Cells["length"].Value.ToString()) : 0.00F,
                    order_number = row.Cells["order_number"].Value != null ? row.Cells["order_number"].Value.ToString() : string.Empty,
                    note = row.Cells["note"].Value != null ? row.Cells["note"].Value.ToString() : string.Empty,
                });
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult oDialogResult = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (oDialogResult == DialogResult.Yes)
            {
                new Library.RegistryLibrary().deleteRegistry("login");
                this.Hide();
                new UserManagement.Login().Show();
            }

        }
 
        private void projectTable_SelectionChanged(object sender, EventArgs e)
        {

            GLOBAL.iSelectedProjectId = (this.projectTable.Rows.Count <= 0) ? 0 : int.Parse(this.projectTable.CurrentRow.Cells["id"].Value.ToString());
            this.l_currentProject.Text = "Current Project : " + ((this.projectTable.Rows.Count <= 0) ? "No selected project" : this.projectTable.CurrentRow.Cells["project_name"].Value.ToString());
            this.materialComponent1.initDatagrid();
            this.initCutLength();
        }

        private void optimizeBtn_Click(object sender, EventArgs e)
        {
            this.tabOptiPlus.SelectedIndex = 3;
            optimizeComponent1.triggerOptimize();
        } 

        private void projectTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.optimizeBtn.Visible = false;
            if (this.tabOptiPlus.SelectedTab.Name == "materialTab")
            {
                this.optimizeBtn.Visible = true;
            }
            if (this.tabOptiPlus.SelectedTab.Name == "cutLengthTab")
            {
                this.initCutLength();
            }
            searchString.Text = "";
        }

        private void cutLengthsTable_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context.ToString() == "Parsing, Commit")
                MessageBox.Show("Please check the format when editing the field.");
        }
        private void searchString_TextChanged(object sender, EventArgs e)
        {
            //var tableType = projectTab.SelectedTab.Name == "projTab" ? typeof(ProjectModel):  projectTab.SelectedTab.Name == "cutLengthTab" ? typeof(CutLengthModel) : typeof(MaterialModel);
            if (tabOptiPlus.SelectedTab.Name == "projTab")
            {
                var oProjectList = this.oFile.GetCollection<ProjectModel>();
                var matches = oProjectList.Find(searchString.Text);
                projectTable.DataSource = matches.AsQueryable().ToList();
                projectTable.Refresh();
            }
            else if (tabOptiPlus.SelectedTab.Name == "cutLengthTab")
            {
                var oProjectList = this.oFile.GetCollection<CutLengthModel>();
                var matches = oProjectList.Find(searchString.Text);
                cutLengthsTable.DataSource = matches.AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
                cutLengthsTable.Refresh();
            }
            else
            {
                dynamic oList = Library.UtilsLibrary.getUserFile().GetCollection<MaterialModel>().Find(searchString.Text).AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
                BindingList<MaterialModel> oListModel = new BindingList<MaterialModel>(oList);
                this.materialComponent1.dt_material.DataSource = oListModel;
                this.materialComponent1.dt_material.Refresh();
            }
        }

        private void fileBtn_MouseEnter(object sender, EventArgs e)
        {
            //fileBtnContextMenuStrip.Show(fileBtn, new Point(0, fileBtn.Height));
        }
    }
}