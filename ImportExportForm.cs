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
    public partial class ImportExportForm : MaterialForm
    {
        public ImportExportForm()
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

        private void ImportForm_Load(object sender, EventArgs e)
        {
            importExportBtn.Text = Project.importOrExport;
            this.Text = Project.importOrExport;
            importLbl.Text = Project.importOrExport + " entity:";
            browseBtn.Enabled = Project.importOrExport == "Import";
            browsePanel.Enabled = Project.importOrExport == "Import";
            importExportBtn.Enabled = Project.importOrExport == "Export";
            importComboBox.SelectedItem = "Project";
        }

        private void importComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (importComboBox.SelectedItem.ToString() == "Project")
            {
                browseBtn.Enabled = true;
            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog.Title = "Browse File";
            openFileDialog.ShowDialog();
            importTxt.Text = openFileDialog.FileName;
        }

        private void importTxt_TextChanged(object sender, EventArgs e)
        {
            if (openFileDialog.FileName != "")
            {
                importExportBtn.Enabled = true;
            }
        }
        private void importBtn_Click(object sender, EventArgs e)
        {
            if (Project.importOrExport == "Import")
            {
                try
                {
                    string filePath = string.Empty;

                    filePath = openFileDialog.FileName; //get the path of the file
                    var reader = new ChoCSVReader(filePath).IgnoreHeader();
                    dynamic rec;

                    while ((rec = reader.Read()) != null)
                    {
                        var store = new DataStore("data.json");
                        var collection = store.GetCollection<ProjectModel>();
                        collection.InsertOne(new ProjectModel { id = 1, project_name = rec[0], project_reference = rec[1], rev_no = rec[2], scope = rec[3] });
                    }
                    MessageBox.Show("File has been uploaded. Data has been imported succesfully.");
                }
                catch
                {
                    MessageBox.Show("You may have uploaded a file with invalid entries. Please check your file and try again.");
                }

            }
            else
            {
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
                saveFileDialog.Title = "Save File";
                saveFileDialog.ShowDialog();
            }
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                var store = new DataStore("data.json");
                var records = store.GetCollection<ProjectModel>().AsQueryable().ToList();
                using (var writer = new StreamWriter(saveFileDialog.FileName))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(records);
                    //csv.Flush();
                }
                MessageBox.Show("File has been uploaded. Data has been exported succesfully.");
            }
            catch
            {
                MessageBox.Show("You may have uploaded a file with invalid entries. Please check your file and try again.");
            }

        }
    }
}
