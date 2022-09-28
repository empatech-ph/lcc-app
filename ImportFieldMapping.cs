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
using CsvHelper;
using ExcelDataReader;
using System.Globalization;
using LCC.Library;
using LCC.Modals;

namespace LCC
{
    public partial class ImportFieldMapping : MaterialForm
    {
        public string filename;
        public Project oProject;
        public string sType;
        public string sInvetoryType = "";
        public string sDescription = "";
        public string sGrade = "";
        public StocksManager oStockManager;
        public ImportFieldMapping()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void ImportFieldMapping_Load(object sender, EventArgs e)
        {
        }

        private dynamic getValidatedValue(dynamic oRecord, int iRowIndex, string sDefault = "")
        {
            try
            {
                var mRecordDescription = dataGridViewFieldMap.Rows[iRowIndex].Cells[1].Value;
                if (mRecordDescription == null)
                {
                    var mDefault = dataGridViewFieldMap.Rows[iRowIndex].Cells[2].Value;
                    if (mDefault == null)
                    {
                        return sDefault;
                    }
                    return mDefault.ToString();
                }

                return oRecord[mRecordDescription.ToString()];
            }
            catch (Exception)
            {
                return sDefault;
            }
        }

        private void btnImportFieldMap_Click(object sender, EventArgs e)
        {
            string filePath = openFileDialog.FileName;
            var reader = new ChoCSVReader(filePath).WithFirstLineHeader();
            dynamic rec;
            bool bIsWithExisting = (this.sDescription != "" && this.sGrade != "");
            if (this.sType == "Materials")
            {
                var collection = Library.UtilsLibrary.getUserFile().GetCollection<StockModel>();
                var materialItem = new MaterialModel();
                if (checkBoxClearData.Checked == true)
                {
                    if (bIsWithExisting)
                    {
                        collection.DeleteManyAsync(e => e.description == this.sDescription && e.grade == this.sGrade);
                    } else
                    {
                        collection.DeleteManyAsync(e => e.stock_type == this.sInvetoryType);
                    }

                }
                while ((rec = reader.Read()) != null)
                {
                    if (this.getValidatedValue(rec, 0, "") == "" && this.getValidatedValue(rec, 1, "") == "")
                    {
                        MessageBox.Show("Grade and Description can't be null");
                        return;
                    }
                    collection.InsertOne(
                        new StockModel
                        {
                            id = 1,
                            project_id = GLOBAL.iSelectedProjectId,
                            material_id = materialItem.id,
                            qty = this.getValidatedValue(rec, bIsWithExisting ? 2 : 4, (this.sInvetoryType == "ST") ? "0" : "-1"),
                            stock_type = bIsWithExisting ? "ST" : this.sInvetoryType,
                            description = bIsWithExisting ? this.sDescription : this.getValidatedValue(rec, 0, this.sDescription),
                            grade = bIsWithExisting ? this.sGrade : this.getValidatedValue(rec, 1, this.sGrade),
                            length = double.Parse(this.getValidatedValue(rec, bIsWithExisting ? 0 : 2, "0.00")),
                            cost = double.Parse(this.getValidatedValue(rec, bIsWithExisting ? 1 : 3, "0.00")),
                            stock_code = "",
                            note = "",
                            visibility = true,
                            editable = true
                        });
                }
                this.oStockManager.initStockData();
            }
            else
            {
                while ((rec = reader.Read()) != null)
                {
                    if (this.sType == "Project")
                    {
                        //if (default value walang laman) { 

                        //}
                        var collection = Library.UtilsLibrary.getUserFile().GetCollection<ProjectModel>();
                        collection.InsertOne(new ProjectModel {
                            id = 1, 
                            project_reference = this.getValidatedValue(rec, 0, ""),
                            project_name = this.getValidatedValue(rec, 1, ""),
                            rev_no = this.getValidatedValue(rec, 2, ""),
                            scope = this.getValidatedValue(rec, 3, "")
                        });
                    }
                    else if (this.sType == "Cut Lengths")
                    {
                        if (this.getValidatedValue(rec, 1, "") == "" && this.getValidatedValue(rec, 2, "") == "")
                        {
                            MessageBox.Show("Grade and Description can't be null");
                            return;
                        }
                        var collection = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                        collection.InsertOne(
                            new CutLengthModel
                            {
                                id = 1,
                                project_id = GLOBAL.iSelectedProjectId,
                                part_code = this.getValidatedValue(rec, 0, ""),
                                description = this.getValidatedValue(rec, 1, ""),
                                grade = this.getValidatedValue(rec, 2, ""),
                                length = double.Parse(this.getValidatedValue(rec, 3, "0.00")),
                                quantity = int.Parse(this.getValidatedValue(rec, 4, "0")),
                                uncut_quantity = int.Parse(this.getValidatedValue(rec, 5, "0")),
                                order_number = this.getValidatedValue(rec, 6, ""),
                                note = this.getValidatedValue(rec, 7, "")
                            });
                    }
                }
            }

            this.Close();
        }

        public void importFieldMappingDisplay(object sender, EventArgs e)
        {
            string filePath = string.Empty;
            filePath = openFileDialog.FileName;
            var extension = Path.GetExtension(openFileDialog.FileName);
            //if (extension == ".csv" || extension == ".txt")
            //{
            DataGridViewComboBoxColumn sourceField = new DataGridViewComboBoxColumn();
            sourceField.HeaderText = "Source Field";
            sourceField.Name = "sourceField";

            DataGridViewColumn destField = new DataGridViewColumn();
            destField.HeaderText = "Destination Field";
            destField.Name = "destinationField";

            dataGridViewFieldMap.Columns.Add("destinationField", "Destination Field");
            dataGridViewFieldMap.Columns.Add(sourceField);
            dataGridViewFieldMap.Columns.Add("defaultValue", "Default Value");

            var siteMapHeaderList = new List<string>() { };

            using (var reader = new ChoCSVReader(filePath).WithFirstLineHeader())
            {
                DataTable dt = reader.AsDataTable();
                dataGridViewImportData.DataSource = dt;
                sourceField.Items.AddRange(reader.Context.Headers);
            }
            if (this.sType == "Project")
            {
                siteMapHeaderList = new List<string>() { "Project Reference", "Project Name", "Revision Number", "Scope", };
            }
            else if (this.sType == "Cut Lengths")
            {
                siteMapHeaderList = new List<string>() { "Part Code", "Description", "Grade", "Length", "Quantity", "Uncut Quantity", "Order Number", "Note" };
            }
            else if (this.sType == "Materials")
            {
                List<string> oList = new List<string>() { "Description", "Grade", "Length", "Cost", "Qty" };
                if (this.sGrade != "" && this.sDescription != "")
                {
                    oList = new List<string>() { "Length", "Cost", "Qty" };
                }
                else
                {

                    if (this.sInvetoryType == "BO")
                    {
                        oList = new List<string>() { "Description", "Grade", "Length", "Cost" };
                    }
                    else if (this.sInvetoryType == "BO")
                    {
                        oList = new List<string>() { "Description", "Grade", "Length", "Cost", "Qty" };
                    }
                }

                siteMapHeaderList = dataGridViewImportData.ColumnCount > 4 ? new List<string>() { "Description", "Grade", "Stock Code", "Quantity", "Length", "Note" } : oList;
            }

            List<DataGridViewRow> rows = new List<DataGridViewRow>(siteMapHeaderList.Count);
            foreach (var dest in siteMapHeaderList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewFieldMap, dest);
                rows.Add(row);
            }

            dataGridViewFieldMap.Rows.AddRange(rows.ToArray());
            ShowDialog();
            //}
            if (this.oProject != null)
            {
                this.oProject.initProject();
                this.oProject.initCutLength();
            }
        }

        private void btnImportFieldMapClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBoxClearData_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxClearData.Checked == true)
                MessageBox.Show("This will delete the entire record");
        }
    }
}