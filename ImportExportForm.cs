﻿using System;
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
using CsvHelper;
using ExcelDataReader;
using System.Globalization;

namespace LCC
{
    public partial class ImportExportForm : MaterialForm
    {

        public Project oProject;
        public ImportExportForm()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            importComboBox.SelectedItem = "Project";
        }

        private void importComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (importComboBox.SelectedItem.ToString() == "Project")
            {
                browseBtn.Enabled = true;
            }
        }

        public void browseBtn_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem btn = (ToolStripMenuItem)sender;
            var menuItem = btn.Text;
            openFileDialog.Filter = "CSV and Text Files (*.csv;*.txt;*.xlsx)|*.csv;*.txt;*.xlsx";
            openFileDialog.Title = "Browse File";
            openFileDialog.ShowDialog();

            if (menuItem == null)
            {

                importTxt.Text = openFileDialog.FileName;
            }
            else
            {
                openFileDialog.Tag = menuItem;
                importBtn_Click(sender, e);
            }


        }

        private void importTxt_TextChanged(object sender, EventArgs e)
        {
            if (openFileDialog.FileName != "")
            {
                importExportBtn.Enabled = true;
            }
        }
        public void importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (importTxt.Text.IsNullOrEmpty())
                    MessageBox.Show("Please select file to import.");
                else
                {
                    string filePath = string.Empty;
                    filePath = openFileDialog.FileName;
                    var extension = Path.GetExtension(openFileDialog.FileName);
                    var reader = new ChoCSVReader(filePath).WithFirstLineHeader();
                    dynamic rec;
                    if (extension == ".csv" || extension == ".txt")
                    {
                        while ((rec = reader.Read()) != null)
                        {
                            if (openFileDialog.Tag.ToString() == "" && importComboBox.SelectedItem.ToString() == "Project")
                            {
                                var collection = Library.UtilsLibrary.getUserFile().GetCollection<ProjectModel>();
                                collection.InsertOne(new ProjectModel { id = 1, project_name = rec.project_name, project_reference = rec.project_reference, rev_no = rec.rev_no, scope = rec.scope });
                            }
                            else
                            {
                                if ((openFileDialog.Tag.ToString() != "" || importComboBox.SelectedItem.ToString() != "Project") && GLOBAL.iSelectedProjectId != 0)
                                {
                                    if (extension != ".xlsx")
                                    {
                                        if (importComboBox.SelectedItem.ToString() == "Cut Lengths" || openFileDialog.Tag.ToString() == "Cut Lengths")
                                        {
                                            var collection = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                                            collection.InsertOne(
                                                new CutLengthModel
                                                {
                                                    id = 1,
                                                    project_id = GLOBAL.iSelectedProjectId,
                                                    part_code = rec.part_code,
                                                    description = rec.description,
                                                    grade = rec.grade,
                                                    quantity = int.Parse(rec.quantity),
                                                    uncut_quantity = int.Parse(rec.uncut_quantity),
                                                    length = int.Parse(rec.length),
                                                    order_number = rec.order_number,
                                                    note = rec.note
                                                });
                                        }
                                        else
                                        {
                                            var collection = Library.UtilsLibrary.getUserFile().GetCollection<StockModel>();
                                            collection.InsertOne(
                                                new StockModel
                                                {
                                                    id = 1,
                                                    material_id = GLOBAL.iSelectedMaterialId,
                                                    qty = rec.qty,
                                                    length = int.Parse(rec.length),
                                                    stock_type = openFileDialog.Tag.ToString() == "Inventory List" ? rec.stock_type = "ST" : rec.stock_type = "BO",
                                                    cost = double.Parse(rec.cost),
                                                    stock_code = rec.stock_code,
                                                    note = rec.note,
                                                    visibility = rec.visibility == "TRUE",
                                                    editable = rec.editable == "TRUE"
                                                });
                                        }

                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        if (GLOBAL.iSelectedProjectId != 0)
                        {
                            var siteMapHeaderList = new List<string>() { "part_code", "description", "grade", "quantity", "uncut_quantity", "length", "order_number", "note", "qty", "length", "stock_type", "cost", "stock_code", "note", "visibility", "editable" };
                            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                            {
                                using (var reader2 = ExcelReaderFactory.CreateReader(stream))
                                {
                                    var result = reader2.AsDataSet(new ExcelDataSetConfiguration()
                                    {
                                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                                        {
                                            UseHeaderRow = true,
                                            FilterColumn = (rowReader, columnIndex) =>
                                            {
                                                return (siteMapHeaderList.Contains(rowReader.GetString(columnIndex)));
                                            }
                                        }
                                    });

                                    DataRowCollection row = result.Tables[0].Rows;
                                    foreach (DataRow item in row)
                                    {
                                        if (importComboBox.SelectedItem.ToString() == "Cut Lengths")
                                        {
                                            List<CutLengthModel> allRowsList = new List<CutLengthModel>();
                                            allRowsList.Add(new CutLengthModel
                                            {
                                                id = 1,
                                                project_id = GLOBAL.iSelectedProjectId,
                                                part_code = item.ItemArray[0].ToString(),
                                                description = item.ItemArray[1].ToString(),
                                                grade = item.ItemArray[2].ToString(),
                                                quantity = int.Parse(item.ItemArray[3].ToString()),
                                                uncut_quantity = int.Parse(item.ItemArray[4].ToString()),
                                                length = int.Parse(item.ItemArray[5].ToString()),
                                                order_number = item.ItemArray[6].ToString(),
                                                note = item.ItemArray[7].ToString()
                                            });

                                            var collection2 = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                                            collection2.InsertMany(allRowsList);
                                        }
                                        else
                                        {
                                            List<StockModel> allRowsList = new List<StockModel>();
                                            allRowsList.Add(new StockModel
                                            {
                                                id = 1,
                                                material_id = GLOBAL.iSelectedMaterialId,
                                                qty = item.ItemArray[0].ToString(),
                                                length = int.Parse(item.ItemArray[1].ToString()),
                                                stock_type = item.ItemArray[2].ToString(),
                                                cost = double.Parse(item.ItemArray[3].ToString()),
                                                stock_code = item.ItemArray[4].ToString(),
                                                note = item.ItemArray[5].ToString(),
                                                visibility = item.ItemArray[6].Equals(true),
                                                editable = item.ItemArray[7].Equals(true)
                                            });

                                            var collection2 = Library.UtilsLibrary.getUserFile().GetCollection<StockModel>();
                                            collection2.InsertMany(allRowsList);
                                        }
                                    }

                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select project.");
                            return;
                        }
                    }
                    MessageBox.Show("File has been uploaded. Data has been imported succesfully.");
                    this.oProject.initProject();
                    this.oProject.initCutLength();
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
            this.Hide();
        }

        private void sampleTemplateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saveFileDialog.Tag = "";
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Save File";
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            List<string> fileHeaders = new List<string>();
            string[] projectHeaders = new string[4] { "project_reference", "project_name", "rev", "scope" };
            string[] clHeaders = new string[8] { "part_code", "description", "grade", "quantity", "uncut_quantity",
                "length", "order_number", "note" };
            string[] mtrlHeaders = new string[8] { "qty", "length", "stocky_type", "cost", "stock_code",
                "note", "visibility", "editable" };

            var importTemplate = importComboBox.SelectedItem.ToString();
            if (importTemplate == "Project")
            {
                fileHeaders.AddRange(projectHeaders);
            }
            else if (importTemplate == "Cut Lengths")
            {
                fileHeaders.AddRange(clHeaders);
            }
            else
            {
                fileHeaders.AddRange(mtrlHeaders);
            }
            using (var writer = new StreamWriter(saveFileDialog.FileName))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Write out header
                fileHeaders.ForEach(delegate (String name)
                {
                    csv.WriteField(name);
                });
            }
        }
    }
}