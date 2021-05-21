﻿using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LCC.Model;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace LCC.Components
{
    public partial class MaterialComponent : UserControl
    {
        public MaterialComponent()
        {
            InitializeComponent();
            this.initDatagrid();
        }

        public void initDatagrid()
        {
            dynamic oList = Library.UtilsLibrary.getUserFile().GetCollection<MaterialModel>().AsQueryable().Where(e => e.project_id == GLOBAL.iSelectedProjectId).ToList();
            BindingList<MaterialModel> oListModel = new BindingList<MaterialModel>(oList);
            this.dt_material.DataSource = oListModel;
            this.dt_material.Columns["id"].Visible = false;
            this.dt_material.Columns["project_id"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (GLOBAL.iSelectedProjectId != 0)
            {
                var oAddMaterialModal = new Modals.AddMaterialModal();
                oAddMaterialModal.oMaterialComponent = this;
                oAddMaterialModal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select project.");
            }
        }

        private void dt_material_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = this.dt_material.Rows[this.dt_material.CurrentCell.RowIndex];
                var oStore = Library.UtilsLibrary.getUserFile();
                var collection = oStore.GetCollection<MaterialModel>();

                collection.UpdateOne(oRow => oRow.id == int.Parse(row.Cells["id"].Value.ToString()), new MaterialModel
                {
                    id = int.Parse(row.Cells["id"].Value.ToString()),
                    project_id = GLOBAL.iSelectedProjectId,
                    description = row.Cells["description"].Value != null ? row.Cells["description"].Value.ToString() : "",
                    grade = row.Cells["grade"].Value != null ? row.Cells["grade"].Value.ToString() : "",
                    kerf = row.Cells["kerf"].Value != null ? Convert.ToDouble(row.Cells["kerf"].Value) : 0.00,
                    trim_left = row.Cells["trim_left"].Value != null ? Convert.ToDouble(row.Cells["trim_left"].Value) : 0.00,
                    trim_right = row.Cells["trim_right"].Value != null ? Convert.ToDouble(row.Cells["trim_right"].Value) : 0.00,
                    part_allowance = row.Cells["part_allowance"].Value != null ? Convert.ToDouble(row.Cells["part_allowance"].Value) : 0.00,
                    min_remnant_length = row.Cells["min_remnant_length"].Value != null ? Convert.ToDouble(row.Cells["min_remnant_length"].Value) : 0.00
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Please check the format when editing the field.");
            }
        }

        private void dt_material_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string sCellName = this.dt_material.Columns[this.dt_material.CurrentCell.ColumnIndex].Name;
            if (sCellName == "kerf" || sCellName == "trim_left" || sCellName == "trim_right" || sCellName == "part_allowance" || sCellName == "min_remnant_length")
            {

                //e.Control.KeyPress += new KeyPressEventHandler(CheckKey);
            }
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_analyze_Click(object sender, EventArgs e)
        {
            if (GLOBAL.iSelectedProjectId != 0)
            {
                dynamic oCutLength = Library.UtilsLibrary.getUserFile().GetCollection<CutLengthModel>().AsQueryable()
                        .Where(e => e.project_id == GLOBAL.iSelectedProjectId)
                        .Select(o => new { o.description, o.grade })
                        .Distinct()
                        .ToList();
                var oMaterialModel = Library.UtilsLibrary.getUserFile().GetCollection<MaterialModel>();
                foreach (dynamic oItem in oCutLength)
                {
                    int mExistingRowsCount = oMaterialModel.AsQueryable()
                        .Where(e => e.description == oItem.description.ToString() && e.grade == oItem.grade.ToString()).ToList().Count;

                    if (mExistingRowsCount <= 0)
                        oMaterialModel.InsertOne(new MaterialModel
                        {
                            id = 1,
                            description = oItem.description.ToString(),
                            grade = oItem.grade.ToString(),
                            kerf = 0.00,
                            trim_left = 0.00,
                            trim_right = 0.00,
                            part_allowance = 0.00,
                            min_remnant_length = 0.00,
                            project_id = GLOBAL.iSelectedProjectId,
                        });
                }
                this.initDatagrid();
            }
            else
            {
                MessageBox.Show("Please select project.");
            }
        }

        private void dt_material_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dt_material.Columns["stock"].Index)
            {
                if (this.ST.Checked == false && this.BO.Checked == false)
                {
                    MessageBox.Show("Please check atleast 1 in the filter.");
                }
                else
                {
                    var rowIndex = this.dt_material.CurrentCell.RowIndex;
                    var row = this.dt_material.Rows[rowIndex];
                    GLOBAL.iSelectedMaterialId = int.Parse(row.Cells["id"].Value.ToString());
                    var oStockManager = new Modals.StocksManager();
                    oStockManager.bBO = this.BO.Checked;
                    oStockManager.bST = this.ST.Checked;
                    oStockManager.ShowDialog();
                }
            }
        }

        private void dt_material_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = this.dt_material.Rows[e.RowIndex];
            row.Cells["no"].Value = String.Format("{0}", e.RowIndex + 1);
        }

        private void dt_material_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var row = this.dt_material.Rows[e.RowIndex];
            row.Cells["no"].Value = String.Format("{0}", e.RowIndex + 1);
        }

        private void dt_material_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if(e.Context.ToString() == "Parsing, Commit")
            MessageBox.Show("Please check the format when editing the field.");
        }
    }
}
