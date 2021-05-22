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
using ExcelDataReader;

namespace LCC
{
    public partial class ImportExportForm : MaterialForm
    {
        public ImportExportForm()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            //importExportBtn.Text = Project.importOrExport;
            //this.Text = Project.importOrExport;
            //importLbl.Text = Project.importOrExport + " entity:";
            //browseBtn.Enabled = Project.importOrExport == "Import";
            //browsePanel.Enabled = Project.importOrExport == "Import";
            //importExportBtn.Enabled = Project.importOrExport == "Export";
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
            openFileDialog.Filter = "CSV and Text Files (*.csv;*.txt;*.xlsx)|*.csv;*.txt;*.xlsx";
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
            try
            {
                if (importTxt.Text.IsNullOrEmpty())
                    MessageBox.Show("Please select file to import.");
                else
                {
                    string filePath = string.Empty;
                    filePath = openFileDialog.FileName; //get the path of the file
                    var extension = Path.GetExtension(openFileDialog.FileName);
                    var reader = new ChoCSVReader(filePath).IgnoreHeader();
                    dynamic rec;
                    if (extension == ".csv" || extension == ".txt")
                    {
                        while ((rec = reader.Read()) != null)
                        {
                            if (importComboBox.SelectedItem.ToString() == "Project")
                            {
                                var collection = Library.UtilsLibrary.getUserFile().GetCollection<ProjectModel>();
                                collection.InsertOne(new ProjectModel { id = 1, project_name = rec[1], project_reference = rec[0], rev_no = rec[3], scope = rec[2] });
                            }
                            else
                            {
                                if (extension != ".xlsx")
                                {
                                    var collection = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                                    collection.InsertOne(
                                        new CutLengthModel
                                        {
                                            id = 1,
                                            project_id = Project.selectedProject,
                                            part_code = rec[0],
                                            description = rec[1],
                                            grade = rec[2],
                                            quantity = int.Parse(rec[3]),
                                            uncut_quantity = int.Parse(rec[4]),
                                            length = int.Parse(rec[5]),
                                            order_number = rec[6],
                                            note = rec[7]
                                        });
                                }
                            }
                        }
                    }

                    else
                    {
                        using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader2 = ExcelReaderFactory.CreateReader(stream))
                            {
                                var result = reader2.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                                    {
                                        UseHeaderRow = true
                                    }
                                });
                                DataRowCollection row = result.Tables[0].Rows;

                                List<object> rowDataList = null;
                                List<object> allRowsList = new List<object>();
                                foreach (DataRow item in row)
                                {
                                    rowDataList = item.ItemArray.ToList();
                                    allRowsList.Add(rowDataList); 
                                    var collection2 = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                                    collection2.InsertOne(
                                        new CutLengthModel
                                        {
                                            id = 1,
                                            project_id = Project.selectedProject,
                                            part_code = item.ItemArray[0].ToString(),
                                            description = item.ItemArray[1].ToString(),
                                            grade = item.ItemArray[2].ToString(),
                                            quantity = int.Parse(item.ItemArray[3].ToString()),
                                            uncut_quantity = int.Parse(item.ItemArray[4].ToString()),
                                            length = int.Parse(item.ItemArray[5].ToString()),
                                            order_number = item.ItemArray[6].ToString(),
                                            note = item.ItemArray[7].ToString()
                                        });
                                }
                            }
                        }
                    }
                    MessageBox.Show("File has been uploaded. Data has been imported succesfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You may have uploaded a file with invalid entries. Please check your file and try again.");
            }
            this.Close();
        }
        private void cancelImportBtn_Click(object sender, EventArgs e)
        {
            ImportExportForm importExportForm = new ImportExportForm();
            importExportForm.Close();
        }
    }
}
