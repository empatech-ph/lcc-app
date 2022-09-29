using JsonFlatFileDataStore;
using LCC.Library;
using LCC.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Windows.Forms;

namespace LCC.Components
{
    public partial class OptiplusComponent : UserControl
    {
        readonly DataStore oFile;
        const int GROSS_YIELD = 0;
        const int COST = 1;
        const int STORAGE_PART = 2;
        const int LAYOUT = 3;
        private Dictionary<int, string> MAP_PARAMETER = new Dictionary<int, string>(){
                { GROSS_YIELD, "total_cost" },
                { COST, "gross_yield" },
                { STORAGE_PART, "total_storage_part" },
            };
        private string sCurrentSelected = "btn_gross_yield";
        private Dictionary<string, string> oParameters = new Dictionary<string, string>(){
                { "btn_gross_yield", "Gross Yield" },
                { "btn_total_cost", "Cost" },
                { "btn_total_storage_part", "Storage Parts Used" },
            };
        private List<TempOptiplusData> oTempOptiplusData = new List<TempOptiplusData>();
        public OptiplusComponent()
        {
            InitializeComponent();

            this.oFile = UtilsLibrary.getUserFile();
            this.setParameters();
            Button _btn_gross_yield = this.table_parameters.Controls[sCurrentSelected] as Button;
            _btn_gross_yield.BackColor = Color.SkyBlue;
        }

        private void initOptiplusData(string sDescription, string sGrade)
        {
            this.dt_optiplus.DataSource = new List<TempOptiplusData>();
            int iCounter = 1;
            this.oTempOptiplusData = GLOBAL.oTempCutlength.Where(e => e.grade == sGrade && e.description == sDescription).GroupBy(e => new
            {
                e.cutlength_desc_grade,
                e.part_code,
                e.gross_yield,
                e.quantity,
                e.cost,
                e.total_parts_length,
                e.total_stock_length
            })
            .Select(e => new TempOptiplusData()
            {
                auto_no = 0,
                solution_no = e.Last().solution_no,
                gross_yield = e.Last().gross_yield,
                total_cost = e.Last().cost,
                total_storage_part = e.Last().total_parts_length
            })
            .GroupBy(e => new { e.gross_yield, e.total_cost, e.total_storage_part })
            .Select(e => new TempOptiplusData()
             {
                 auto_no = iCounter++,
                 solution_no = e.Last().solution_no,
                 gross_yield = e.Last().gross_yield,
                 total_cost = e.Last().total_cost,
                 total_storage_part = e.Last().total_storage_part
            })
            .ToList();
            this.dt_optiplus.DataSource = this.oTempOptiplusData;
        }

        private void setParameters()
        {
            int i = 0;
            foreach (KeyValuePair<string, string> oParameter in oParameters)
            {
                this.table_parameters.Controls.Add(this.getNewGeneratedButton(oParameter.Key, oParameter.Value, i), i, 0);
                i++;
            }
            this.sortOptiplus();
        }

        private Button getNewGeneratedButton(string sKey, string sText, int iTag = 1)
        {
            Button oButton = new Button();
            oButton.Text = sText;
            oButton.FlatStyle = FlatStyle.Flat;
            oButton.Name = sKey;
            oButton.Font = new Font(FontFamily.GenericSansSerif, 9F, FontStyle.Bold);
            oButton.TextAlign = ContentAlignment.MiddleCenter;
            oButton.Dock = DockStyle.Fill;
            oButton.Cursor = Cursors.Hand;
            oButton.Click += new EventHandler(btn_parameter_Click);
            oButton.Tag = iTag;
            return oButton;
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            Control _current = this.table_parameters.Controls[sCurrentSelected];
            int _current_index = this.table_parameters.GetCellPosition(_current).Column;
            if (_current_index > 0)
            {
                this.table_parameters.SetColumn(_current, _current_index - 1);
                foreach (KeyValuePair<string, string> oParameter in oParameters)
                {
                    if (oParameter.Key != this.sCurrentSelected)
                    {
                        Control __current = this.table_parameters.Controls[oParameter.Key];
                        int __current_index = this.table_parameters.GetCellPosition(__current).Column;
                        if (_current_index - 1 == __current_index)
                        {
                            this.table_parameters.SetColumn(__current, _current_index);
                        }
                    }
                }
            }
            this.sortOptiplus();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {

            Control _current = this.table_parameters.Controls[sCurrentSelected];
            int _current_index = this.table_parameters.GetCellPosition(_current).Column;
            if (_current_index < 3)
            {
                this.table_parameters.SetColumn(_current, _current_index + 1);
                foreach (KeyValuePair<string, string> oParameter in oParameters)
                {
                    if (oParameter.Key != this.sCurrentSelected)
                    {
                        Control __current = this.table_parameters.Controls[oParameter.Key];
                        int __current_index = this.table_parameters.GetCellPosition(__current).Column;
                        if (_current_index + 1 == __current_index)
                        {
                            this.table_parameters.SetColumn(__current, _current_index);
                        }
                    }
                }
            }
            this.sortOptiplus();
        }

        private void btn_parameter_Click(object sender, EventArgs e)
        {
            Button _btn_current = sender as Button;

            Button _btn_gross_yield = this.table_parameters.Controls["btn_gross_yield"] as Button;
            Button _btn_cost = this.table_parameters.Controls["btn_total_cost"] as Button;
            Button _btn_storage_part = this.table_parameters.Controls["btn_total_storage_part"] as Button;

            _btn_gross_yield.BackColor = Color.White;
            _btn_cost.BackColor = Color.White;
            _btn_storage_part.BackColor = Color.White;

            _btn_current.BackColor = Color.SkyBlue;
            this.sCurrentSelected = _btn_current.Name;
        }

        private void dt_materials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRowIndex = e.RowIndex;
            if (iRowIndex != -1)
            {
                string sDescription = (this.dt_materials.Rows[iRowIndex].Cells["description"].Value.ToString());
                string sGrade = (this.dt_materials.Rows[iRowIndex].Cells["grade"].Value.ToString());
                this.initOptiplusData(sDescription, sGrade);
            }
            this.sortOptiplus();
        }

        private void dt_materials_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (this.dt_materials.RowCount > 0)
            {
                string sDescription = (this.dt_materials.Rows[0].Cells["description"].Value.ToString());
                string sGrade = (this.dt_materials.Rows[0].Cells["grade"].Value.ToString());
                this.initOptiplusData(sDescription, sGrade);
            }
        }

        private void sortOptiplus()
        {
            string sSortString = "";
            List<Control> oParameters = this.table_parameters.Controls.Cast<Control>().OrderBy(c => this.table_parameters.GetCellPosition(c).Column).ToList();
            foreach (Control oControl in oParameters)
            {
                sSortString += MAP_PARAMETER.FirstOrDefault(e => "btn_" + e.Value == oControl.Name).Value + " DESC,";
            }

            this.dt_optiplus.DataSource = this.oTempOptiplusData.AsQueryable().OrderBy(sSortString.TrimEnd(',')).ToList();
        }
    }

}
