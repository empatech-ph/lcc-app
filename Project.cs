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
    public partial class Project : MaterialForm
    {
        public static string importOrExport = "";

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
        }

        public void Project_Load(object sender, EventArgs e)
        {
            var store = new DataStore("data.json");
            projectTable.DataSource = store.GetCollection<ProjectModel>().AsQueryable().ToList();
            projectTable.Columns["id"].Visible = false;
            projectTable.Columns["project_name"].HeaderText = "Project Name";
            projectTable.Columns["project_reference"].HeaderText = "Project Reference #";
            projectTable.Columns["scope"].HeaderText = "Scope of Works";
            projectTable.Columns["rev_no"].HeaderText = "Revision #";
            DataGridViewButtonColumn viewButtonColumn = new DataGridViewButtonColumn();
            viewButtonColumn.Name = "view_column";
            //viewButtonColumn.FlatStyle = FlatStyle.Flat;
            viewButtonColumn.UseColumnTextForButtonValue = true;
            viewButtonColumn.Text = "View";
            int columnIndex = 5;
            if (projectTable.Columns["view_column"] == null)
            {
                projectTable.Columns.Insert(columnIndex, viewButtonColumn);
            }
            projectTable.Columns[columnIndex].HeaderText = "";
            projectTable.CellClick += dataGridViewSoftware_CellClick;
        }
        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == projectTable.Columns["view_column"].Index)
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
            newProject.Show();
        }

        private void Project_Activated(object sender, EventArgs e)
        {
            var store = new DataStore("data.json");
            projectTable.DataSource = store.GetCollection<ProjectModel>().AsQueryable().ToList();
        }

        private void projectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = projectTable.Rows[e.RowIndex];
                cellClickLabel.Text = row != null ? "Project " + row.Cells[3].Value.ToString() : "";
            }
            catch (Exception)
            { }

        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            importOrExport = "Import";
            ImportExportForm importExportForm = new ImportExportForm();
            importExportForm.Show();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            importOrExport = "Export";
            ImportExportForm importExportForm = new ImportExportForm();
            importExportForm.Show();
        }

        private void projectTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = projectTable.CurrentCell.RowIndex;
            var row = projectTable.Rows[rowIndex];
            var store = new DataStore("data.json");
            var collection = store.GetCollection<ProjectModel>();
            collection.UpdateOne(x => x.id == (int)row.Cells["id"].Value, new ProjectModel { project_name = row.Cells[3].Value.ToString(), project_reference = row.Cells[2].Value.ToString(), rev_no = row.Cells[5].Value.ToString(), scope = row.Cells[4].Value.ToString() });
        }

        private void printerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
