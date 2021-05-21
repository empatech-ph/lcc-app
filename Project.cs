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
using CsvHelper.Configuration;
namespace LCC
{
    public partial class Project : MaterialForm
    {
        //public static string importOrExport = "";

        private DataStore oFile;

        public Project()
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

            this.oFile = Library.UtilsLibrary.getUserFile();
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

            //project table
            var oProjectList = this.oFile.GetCollection<ProjectModel>().AsQueryable();
            projectTable.DataSource = oProjectList.ToList();
            GLOBAL.iSelectedProjectId = (oProjectList.ToList().Count <= 0) ? 0 : oProjectList.Select(x => x.id).First();
            materialComponent1.initDatagrid();
            projectTable.Columns["id"].Visible = false;
            projectTable.Columns["project_name"].HeaderText = "Project Name";
            projectTable.Columns["project_reference"].HeaderText = "Project Reference #";
            projectTable.Columns["scope"].HeaderText = "Scope of Works";
            projectTable.Columns["rev_no"].HeaderText = "Revision #";
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "view_column";
            viewButtonColumn.HeaderText = "View";
            //viewButtonColumn.FlatStyle = FlatStyle.Flat;
            viewButtonColumn.UseColumnTextForButtonValue = true;
            viewButtonColumn.Text = "View";
            int columnIndex = 5;
            if (projectTable.Columns["view_column"] == null)
            {
                projectTable.Columns.Insert(columnIndex, viewButtonColumn);
            }
            projectTable.Columns[columnIndex].HeaderText = "";
            projectTable.CellClick += projectTblView_CellClick;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "edit_column";
            editButtonColumn.HeaderText = "Edit";
            //viewButtonColumn.FlatStyle = FlatStyle.Flat;
            editButtonColumn.UseColumnTextForButtonValue = true;
            editButtonColumn.Text = "Edit";
            int columnIndexEdit = 5;
            if (projectTable.Columns["edit_column"] == null)
            {
                projectTable.Columns.Insert(columnIndexEdit, editButtonColumn);
            }
            projectTable.Columns[columnIndexEdit].HeaderText = "";
            projectTable.CellClick += projectTblEdit_CellClick;
            //var rowIndex = cutLengthsTable.CurrentCell.IsNull() ? 0 : cutLengthsTable.CurrentCell.RowIndex;
            //DataGridViewRow row = cutLengthsTable.Rows[rowIndex];
        }
        private void projectTblView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == projectTable.Columns["view_column"].Index)
            {
                MessageBox.Show("Test");
            }
        }

        private void projectTblEdit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == projectTable.Columns["edit_column"].Index)
            {
                MessageBox.Show("Test");
            }
        }

        private void projectBtn_Click(object sender, EventArgs e)
        {
            projectTab.Visible = true;
        }

        private void addProject_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject();
            newProject.ShowDialog();
        }

        private void Project_Activated(object sender, EventArgs e)
        {
            projectTable.DataSource = this.oFile.GetCollection<ProjectModel>().AsQueryable().ToList();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            //importOrExport = "Import";
            ImportExportForm importExportForm = new ImportExportForm();
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
            var rowIndex = projectTable.CurrentCell.RowIndex;
            var row = projectTable.Rows[rowIndex];
            var collection = this.oFile.GetCollection<ProjectModel>();
            collection.UpdateOne(x => x.id == (int)row.Cells["id"].Value, new ProjectModel { id = int.Parse(row.Cells["id"].Value.ToString()), project_name = row.Cells["project_name"].Value.ToString(), project_reference = row.Cells["project_reference"].Value.ToString(), rev_no = row.Cells["rev_no"].Value.ToString(), scope = row.Cells["scope"].Value.ToString() });
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
                    //csv.Flush();
                }
                MessageBox.Show("File has been downloaded. Data has been exported succesfully.");
            }
            catch
            {
                MessageBox.Show("You may have uploaded a file with invalid entries. Please check your file and try again.");
            }

        }

        private void cutLengthsTable_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var rowIndex = cutLengthsTable.CurrentCell.RowIndex;
                var row = cutLengthsTable.Rows[rowIndex];
                var collection = this.oFile.GetCollection<CutLengthModel>();
                collection.InsertOne(new CutLengthModel
                {
                    id = 1,
                    project_id = GLOBAL.iSelectedProjectId,
                    part_code = row.Cells[2].Value.ToString(),
                    description = row.Cells[3].Value.ToString(),
                    grade = row.Cells[4].Value.ToString(),
                    quantity = int.Parse(row.Cells[5].Value.ToString()),
                    uncut_quantity = int.Parse(row.Cells[6].Value.ToString()),
                    length = int.Parse(row.Cells[7].Value.ToString()),
                    order_number = row.Cells[8].Value.ToString(),
                    note = row.Cells[9].Value.ToString()
                });
            }
            catch {
                MessageBox.Show("Error.");
            }
        }

        private void projectTab_TabIndexChanged(object sender, EventArgs e)
        {
            if (projectTab.SelectedTab == projectTab.TabPages["cutLengthTab"])
            {
                //cut lengths table
                var collection = this.oFile.GetCollection<CutLengthModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
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
        }

        private void projectTab_Selected(object sender, TabControlEventArgs e)
        {
            if (projectTab.SelectedTab == projectTab.TabPages["cutLengthTab"])
            {
                //cut lengths table
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
        }

        private void projectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = projectTable.CurrentCell.RowIndex;
            var row = projectTable.Rows[rowIndex];
            GLOBAL.iSelectedProjectId = int.Parse(row.Cells["id"].Value.ToString());
            this.materialComponent1.initDatagrid();
        }
    }
}
