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
        public ImportFieldMapping()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void ImportFieldMapping_Load(object sender, EventArgs e)
        {
            checkBoxContainsFirstRow.Checked = true;
        }

        private void btnImportFieldMap_Click(object sender, EventArgs e)
        {
            var dataGridViewFieldMapping = dataGridViewFieldMap.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
            string filePath = string.Empty;
            filePath = openFileDialog.FileName;
            var extension = Path.GetExtension(filename);
            var reader = new ChoCSVReader(filePath).WithFirstLineHeader();
            dynamic rec;
            if (this.sType == "Materials")
            {
                var descGradeDistinct = dataGridViewImportData.Rows.Cast<DataGridViewRow>().Select(x => new { V = x.Cells[0].Value.ToString(), Y = x.Cells[1].Value.ToString() }).Distinct().ToList();
                var collection = Library.UtilsLibrary.getUserFile().GetCollection<StockModel>();
                var materialItem = new MaterialModel();
                while ((rec = reader.Read()) != null)
                {
                    collection.InsertOne(
                    new StockModel
                    {
                        id = 1,
                        material_id = materialItem.id,
                        qty = rec[dataGridViewFieldMapping[4][1]] ?? "0",
                        stock_type = this.sInvetoryType,
                        description = rec[dataGridViewFieldMapping[0][1]],
                        grade = rec[dataGridViewFieldMapping[1][1]],
                        length = double.Parse(rec[dataGridViewFieldMapping[2][1]]) ?? 0.00,
                        cost = double.Parse(rec[dataGridViewFieldMapping[3][1]]) ?? 0.00,
                        stock_code = "",
                        note = "",
                        visibility = false,
                        editable = false
                    });
                }
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
                        collection.InsertOne(new ProjectModel { id = 1, project_reference = rec[dataGridViewFieldMapping[0][1]], project_name = rec[dataGridViewFieldMapping[1][1]], rev_no = rec[dataGridViewFieldMapping[2][1]], scope = rec[dataGridViewFieldMapping[3][1]] });
                    }
                    else if (this.sType == "Cut Lengths")
                    {
                        var collection = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>();
                        collection.InsertOne(
                            new CutLengthModel
                            {
                                id = 1,
                                project_id = GLOBAL.iSelectedProjectId,
                                part_code = rec[dataGridViewFieldMapping[0][1]],
                                description = rec[dataGridViewFieldMapping[1][1]],
                                grade = rec[dataGridViewFieldMapping[2][1]],
                                length = double.Parse(rec[dataGridViewFieldMapping[3][1]]),
                                quantity = int.Parse(rec[dataGridViewFieldMapping[4][1]]),
                                uncut_quantity = int.Parse(rec[dataGridViewFieldMapping[5][1]]),
                                order_number = rec[dataGridViewFieldMapping[6][1]],
                                note = rec[dataGridViewFieldMapping[7][1]]
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
            else
            {
                List<string> oList = new List<string>() { "Description", "Grade", "Length", "Cost", "Qty" };
                if (this.sGrade != "" && this.sDescription != "")
                {
                    oList = new List<string>() { "Length", "Cost", "Qty" };
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
            dataGridViewFieldMap.Columns["defaultValue"].ReadOnly = true;
            ShowDialog();
            //}
            if (this.oProject != null) {
                this.oProject.initProject();
                this.oProject.initCutLength();
            }
        }

        private void btnImportFieldMapClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}