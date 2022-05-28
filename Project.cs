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
using Microsoft.Reporting.WinForms;
using GuiLabs.Undo;
using System.Threading;
using LCC.Modals;

namespace LCC
{
    public partial class Project : MaterialForm
    {
        //public static string importOrExport = "";
        ActionManager actionManager = new ActionManager();
        //Project project = new Project();
        public static int selectedProject = 0;
        int LastNewRowIndex = -1;

        private DataStore oFile;
        ProjectModel proj = new ProjectModel();
        
        public Project()
        {
            //this.Icon = Properties.Resources.;
            InitializeComponent();
            ThemeLibrary.initMaterialDesign(this);

            if(((new Library.RegistryLibrary()).getLogin()).user_type != 2)
            {
                this.importInventoryList.Visible = false;
                this.importCommercialLengths.Visible = false;
            }

            this.oFile = UtilsLibrary.getUserFile();
            this.initProject();
            this.initCutLength();

            //for redo/undo commands
            proj.ProjectNameChanged += proj_ProjectNameChanged;
            UpdateUndoRedoButtons();
        }
        void UpdateUndoRedoButtons()
        {
            undoBtn.Enabled = actionManager.CanUndo;
            redoBtn.Enabled = actionManager.CanRedo;
        }
        void proj_ProjectNameChanged()
        {
            reentrancyGuard = true;
            projectTable.CurrentCell.Value = proj.project_name;
            reentrancyGuard = false;
        }

        bool reentrancyGuard = false;
        //void SetProperty(string propertyName, object propertyValue)
        //{
        //    if (reentrancyGuard)
        //    {
        //        return;
        //    }
        //    SetPropertyAction action = new SetPropertyAction(proj, propertyName, propertyValue);
        //    actionManager.RecordAction(action);
        //    UpdateUndoRedoButtons();
        //    this.initProject();
        //}

        public void Project_Load(object sender, EventArgs e)
        {
            //tool tips
            this.Icon = Properties.Resources.taskbar_icon;
            projectToolTip.SetToolTip(addProject, "Create New Project");
            projectToolTip.SetToolTip(storageBtn, "Audit Logs");
            projectToolTip.SetToolTip(printerBtn, "Print Reports");
            projectToolTip.SetToolTip(importBtn, "Import File");
            projectToolTip.SetToolTip(exportBtn, "Export File");
            projectToolTip.SetToolTip(optimizeBtn, "Optimize");

            //var rowIndex = cutLengthsTable.CurrentCell.IsNull() ? 0 : cutLengthsTable.CurrentCell.RowIndex;
            //DataGridViewRow row = cutLengthsTable.Rows[rowIndex];


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
            this.projectTable.Columns["project_reference"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.projectTable.Columns["rev_no"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            GLOBAL.iSelectedProjectId = (oProjectList.ToList().Count <= 0) ? 0 : oProjectList.FirstOrDefault().id;
            this.l_currentProject.Text = "Current Project : " + ((oProjectList.ToList().Count <= 0) ? "No selected project" : oProjectList.FirstOrDefault().project_reference.ToString() + " - " + oProjectList.FirstOrDefault().project_name.ToString());
        }

        private void projectTblView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = projectTable.Rows[e.RowIndex];
                GLOBAL.iSelectedProjectId = int.Parse(row.Cells["id"].Value.ToString());
                this.l_currentProject.Text = "Current Project : " + row.Cells["project_reference"].Value.ToString() + " - " + row.Cells["project_name"].Value.ToString();

                if (e.ColumnIndex == projectTable.Columns["edit_column"].Index)
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

        private void importBtn_Click(object sender, EventArgs e)
        {
            ImportFieldMapping importFieldMapping = new ImportFieldMapping();
            importFieldMapping.oProject = this;
            importFieldMapping.openFileDialog.Filter = "CSV and Text Files (*.csv;*.txt;*.xlsx)|*.csv;*.txt;*.xlsx";
            importFieldMapping.openFileDialog.Title = "Browse File";
            System.Windows.Forms.DialogResult dialogResult = importFieldMapping.openFileDialog.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.Cancel) return;

            if (tabOptiPlus.SelectedTab.Text != null)
            { 
                importFieldMapping.openFileDialog.Tag = tabOptiPlus.SelectedTab.Text;
                importFieldMapping.importFieldMappingDisplay(sender, e);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var getType = sender.GetType().Name.ToString();
            if (getType != "MaterialButton")
            {
                ToolStripMenuItem btn = (ToolStripMenuItem)sender;
                var menuItem = btn.Text;
                saveFileDialog.Tag = menuItem;
            }

            saveFileDialog.Tag = "";
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

            //SetProperty("project_name", row.Cells["project_name"].Value.ToString());
        }

        private void printerBtn_Click(object sender, EventArgs e)
        {
            GeneralReport generateReport = new GeneralReport();

            generateReport.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                if (saveFileDialog.Tag.ToString() == "Projects")
                {
                    var records = from p in this.oFile.GetCollection<ProjectModel>().AsQueryable()
                                  join cl in this.oFile.GetCollection<CutLengthModel>().AsQueryable()
                                  on p.id equals cl.project_id
                                  join m in this.oFile.GetCollection<MaterialModel>().AsQueryable()
                                  on p.id equals m.project_id
                                  join sl in this.oFile.GetCollection<StockModel>().AsQueryable()
                                  on m.id equals sl.material_id
                                  select new
                                  {
                                      p,
                                      cl,
                                      sl,
                                      m
                                  };
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(records);
                    }
                }
                else
                {
                    var records = this.oFile.GetCollection<ProjectModel>().AsQueryable().Select(x => new { x.project_reference, x.project_name, x.scope, x.rev_no }).ToList();
                    using (var writer = new StreamWriter(saveFileDialog.FileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteRecords(records);
                    }
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
            cutLengthsTable.DataSource = new List<CutLengthModel>();
            cutLengthsTable.DataSource = new BindingList<CutLengthModel>(collection);
            cutLengthsTable.Columns["id"].Visible = false;
            cutLengthsTable.Columns["project_id"].Visible = false;
            cutLengthsTable.Columns["part_code"].HeaderText = "Part Code";
            cutLengthsTable.Columns["description"].HeaderText = "Description";
            cutLengthsTable.Columns["grade"].HeaderText = "Grade";
            cutLengthsTable.Columns["quantity"].HeaderText = "Quantity";
            cutLengthsTable.Columns["uncut_quantity"].HeaderText = "Uncut Quantity";
            cutLengthsTable.Columns["uncut_quantity"].ReadOnly = true;
            cutLengthsTable.Columns["length"].HeaderText = "Length";
            cutLengthsTable.Columns["order_number"].HeaderText = "Order Number";
            cutLengthsTable.Columns["note"].HeaderText = "Note";
            cutLengthsTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cutLengthsTable.Columns["description"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cutLengthsTable.Columns["note"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
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
            this.l_currentProject.Text = "Current Project : " + ((this.projectTable.Rows.Count <= 0) ? "No selected project" : this.projectTable.CurrentRow.Cells["project_reference"].Value.ToString() + " - " + this.projectTable.CurrentRow.Cells["project_name"].Value.ToString());
            this.materialComponent1.initDatagrid();
            this.initCutLength();
        }

        private void optimizeBtn_Click(object sender, EventArgs e)
        {
            this.optimizeBtn.Enabled = false;
            this.tabOptiPlus.SelectedIndex = 3;
            this.optimizeComponent1.dt_optimize.DataSource = new List<TempCutlengthModel>();
            this.optimizeComponent1.dt_stockLength.DataSource = new List<TempStocklengthModel>();
            this.optiplusComponent1.dt_materials.DataSource = new List<TempCutlengthModel>();

            this.optiplusComponent1.dt_materials.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            this.optiplusComponent1.dt_materials.Columns["optiplus_desc_grade"].Visible = true;

            
            this.optimizeComponent1.dt_optimize.Columns["grade"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["project_id"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["order_number"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["length"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["part_code"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["note"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["description"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["id"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["optimize_type"].Visible = false;
            this.optimizeComponent1.dt_optimize.Columns["solution_no"].Visible = false;

            this.optimizeComponent1.dt_stockLength.Columns["cutlength_id"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["material_id"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["data"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["stock_desc_grade"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["cutlength_length"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["trim_left"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["trim_right"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["kerf"].Visible = false;
            this.optimizeComponent1.dt_stockLength.Columns["optimize_type"].Visible = false;

            this.optimizeComponent1.optimizeBarPanel.Controls.Clear();
            this.oBackgroundWorker.RunWorkerAsync();
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
                dynamic oList = this.oFile.GetCollection<MaterialModel>().Find(searchString.Text).AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
                BindingList<MaterialModel> oListModel = new BindingList<MaterialModel>(oList);
                this.materialComponent1.dt_material.DataSource = oListModel;
                this.materialComponent1.dt_material.Refresh();  
            }
        }

        private void projectTab_Selected(object sender, TabControlEventArgs e)
        {
            searchString.Text = "";
        }

        private void fileMenuStrip_Click(object sender, EventArgs e)
        {
            fileMenuStrip.Show(fileBtn, new Point(0, fileBtn.Height));
        }

        private void fileMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Import")
            {
                importBtn_Click(sender, e);
            }
            else if (e.ClickedItem.Text == "Export")
            {
                //
            }
        }

        private void exportProjects_Click(object sender, EventArgs e)
        {
            exportBtn_Click(sender, e);
        }

        private void exportReports_Click(object sender, EventArgs e)
        {

        }

        private void importCutLength_Click(object sender, EventArgs e)
        {
            ImportExportForm import = new ImportExportForm();
            import.oProject = this;
            import.browseBtn_Click(sender, e);
        }

        private void importInventoryList_Click(object sender, EventArgs e)
        {
            ImportExportForm import = new ImportExportForm();
            import.oProject = this;
            import.browseBtn_Click(sender, e);
        }

        private void importCommercialLengths_Click(object sender, EventArgs e)
        {
            ImportExportForm import = new ImportExportForm();
            import.oProject = this;
            import.browseBtn_Click(sender, e);
        }

        private void Project_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Y)
            {
                undoBtn_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.Z)
            {
                redoBtn_Click(sender, e);
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            actionManager.Undo();
            UpdateUndoRedoButtons();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            actionManager.Redo();
            UpdateUndoRedoButtons();
        }

        private void fileBtn_MouseHover(object sender, EventArgs e)
        {
            fileMenuStrip.Show(fileBtn, new Point(0, fileBtn.Height));
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            fileMenuStrip.Show(fileBtn, new Point(0, fileBtn.Height));
        }

        private void optionsBtn_Click(object sender, EventArgs e)
        {

        }

        private void projectTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.projectTable.EndEdit();
            if (e.RowIndex != -1)
            {
                var row = projectTable.Rows[e.RowIndex];
                var changedValue = (row.Cells[e.ColumnIndex].Value ?? "").ToString();
                //SetProperty("project_name", changedValue);
            }
        }

        private void fileBtn_MouseEnter(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
        }
        private void helpBtn_Click(object sender, EventArgs e)
        {
            //fileBtnContextMenuStrip.Show(fileBtn, new Point(0, fileBtn.Height));
            Help help = new Help();
            help.ShowDialog();
        }

        private void oBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.optimizeComponent1.triggerOptimize(this.oBackgroundWorker);
            this.oBackgroundWorker.ReportProgress(100);
        }

        private void oBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressOptimize.Value = e.ProgressPercentage;
        }

        private void oBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.optimizeBtn.Enabled = true;
            this.progressOptimize.Value = 0;

            this.optimizeComponent1.dt_optimize.DataSource = GLOBAL.oTempCutlength.Where(e => GLOBAL.oTempCurrentUseOptimizeType.Select(e => e.optimize_type  + e.cutlength_id).ToArray().Contains(e.optimize_type + e.id)).ToList();
            this.optiplusComponent1.dt_materials.DataSource = GLOBAL.oTempCutlength.Where(e => GLOBAL.oTempCurrentUseOptimizeType.Select(e => e.optimize_type + e.cutlength_id).ToArray().Contains(e.optimize_type + e.id)).ToList();

            if (this.optimizeComponent1.dt_optimize.RowCount > 0)
            {
                this.optimizeComponent1.initOptimizedStockLengthDataTable(int.Parse(this.optimizeComponent1.dt_optimize.Rows[0].Cells["id"].Value.ToString()));
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult oDialogResult = MessageBox.Show("Do you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (oDialogResult == DialogResult.Yes)
            {
                new Library.RegistryLibrary().deleteRegistry("login");
                this.Hide();
                new UserManagement.Login().Show();
            }
        }

        private void Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cutLengthsTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = cutLengthsTable.Rows[e.RowIndex];
                this.statusBarLbl.Text = this.l_currentProject.Text.Remove(0, 18) + " - " + row.Cells["part_code"].Value.ToString() + " - " + row.Cells["description"].Value.ToString();

                this.materialComponent1.initDatagrid();
                this.initCutLength();
            }
        }
    }
}