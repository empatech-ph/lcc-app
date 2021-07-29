using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.Components
{
    public partial class OptiplusComponent : UserControl
    {
        private string sCurrentSelected = "btn_gross_yield";
        private Dictionary<string, string> oParameters = new Dictionary<string, string>(){
                { "btn_gross_yield", "Gross Yield" },
                { "btn_cost", "Cost" },
                { "btn_storage_part", "Storage Parts Used" },
                { "btn_layout", "No. of Layouts" },
            };
        public OptiplusComponent()
        {
            InitializeComponent();
            this.setParameters();

            Button _btn_gross_yield = this.table_parameters.Controls[sCurrentSelected] as Button;
            _btn_gross_yield.BackColor = Color.SkyBlue;
        }

        private void setParameters()
        {
            int i = 0;
            foreach (KeyValuePair<string, string> oParameter in oParameters)
            {
                this.table_parameters.Controls.Add(this.getNewGeneratedButton(oParameter.Key, oParameter.Value), i, 0);
                i++;
            }
        }

        private Button getNewGeneratedButton(string sKey, string sText)
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
        }

        private void btn_parameter_Click(object sender, EventArgs e)
        {
            Button _btn_current = sender as Button;

            Button _btn_layout = this.table_parameters.Controls["btn_layout"] as Button;
            Button _btn_gross_yield = this.table_parameters.Controls["btn_gross_yield"] as Button;
            Button _btn_cost = this.table_parameters.Controls["btn_cost"] as Button;
            Button _btn_storage_part = this.table_parameters.Controls["btn_storage_part"] as Button;

            _btn_layout.BackColor = Color.White;
            _btn_gross_yield.BackColor = Color.White;
            _btn_cost.BackColor = Color.White;
            _btn_storage_part.BackColor = Color.White;

            _btn_current.BackColor = Color.SkyBlue;
            this.sCurrentSelected = _btn_current.Name;
        }
    }
}
