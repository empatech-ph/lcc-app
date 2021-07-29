﻿
namespace LCC.Components
{
    partial class OptiplusComponent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt_optimize = new System.Windows.Forms.DataGridView();
            this.optiplus_materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optiplus_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optiplus_solutions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optiplus_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optiplus_gross_yield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optiplus_storage_part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optiplus_no_of_layouts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_use_soln = new MaterialSkin.Controls.MaterialCheckbox();
            this.btn_right = new MaterialSkin.Controls.MaterialButton();
            this.btn_left = new MaterialSkin.Controls.MaterialButton();
            this.table_parameters = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_optimize
            // 
            this.dt_optimize.AllowUserToAddRows = false;
            this.dt_optimize.AllowUserToDeleteRows = false;
            this.dt_optimize.AllowUserToResizeColumns = false;
            this.dt_optimize.AllowUserToResizeRows = false;
            this.dt_optimize.BackgroundColor = System.Drawing.Color.White;
            this.dt_optimize.CausesValidation = false;
            this.dt_optimize.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_optimize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_optimize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_optimize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optiplus_materials});
            this.dt_optimize.Location = new System.Drawing.Point(3, 125);
            this.dt_optimize.MultiSelect = false;
            this.dt_optimize.Name = "dt_optimize";
            this.dt_optimize.ReadOnly = true;
            this.dt_optimize.RowHeadersVisible = false;
            this.dt_optimize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_optimize.ShowEditingIcon = false;
            this.dt_optimize.Size = new System.Drawing.Size(180, 314);
            this.dt_optimize.TabIndex = 14;
            // 
            // optiplus_materials
            // 
            this.optiplus_materials.HeaderText = "Materials";
            this.optiplus_materials.Name = "optiplus_materials";
            this.optiplus_materials.ReadOnly = true;
            this.optiplus_materials.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optiplus_no,
            this.optiplus_solutions,
            this.optiplus_cost,
            this.optiplus_gross_yield,
            this.optiplus_storage_part,
            this.optiplus_no_of_layouts});
            this.dataGridView1.Location = new System.Drawing.Point(189, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(882, 314);
            this.dataGridView1.TabIndex = 15;
            // 
            // optiplus_no
            // 
            this.optiplus_no.HeaderText = "#";
            this.optiplus_no.Name = "optiplus_no";
            this.optiplus_no.ReadOnly = true;
            this.optiplus_no.Width = 25;
            // 
            // optiplus_solutions
            // 
            this.optiplus_solutions.HeaderText = "Solutions";
            this.optiplus_solutions.Name = "optiplus_solutions";
            this.optiplus_solutions.ReadOnly = true;
            this.optiplus_solutions.Width = 200;
            // 
            // optiplus_cost
            // 
            this.optiplus_cost.HeaderText = "Cost";
            this.optiplus_cost.Name = "optiplus_cost";
            this.optiplus_cost.ReadOnly = true;
            // 
            // optiplus_gross_yield
            // 
            this.optiplus_gross_yield.HeaderText = "Gross Yield %";
            this.optiplus_gross_yield.Name = "optiplus_gross_yield";
            this.optiplus_gross_yield.ReadOnly = true;
            this.optiplus_gross_yield.Width = 175;
            // 
            // optiplus_storage_part
            // 
            this.optiplus_storage_part.HeaderText = "Storage Parts Used";
            this.optiplus_storage_part.Name = "optiplus_storage_part";
            this.optiplus_storage_part.ReadOnly = true;
            this.optiplus_storage_part.Width = 175;
            // 
            // optiplus_no_of_layouts
            // 
            this.optiplus_no_of_layouts.HeaderText = "No. of Layouts";
            this.optiplus_no_of_layouts.Name = "optiplus_no_of_layouts";
            this.optiplus_no_of_layouts.ReadOnly = true;
            this.optiplus_no_of_layouts.Width = 175;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(15, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(82, 24);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Opti Plus";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(346, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 17);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Parameters";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.chk_use_soln);
            this.panel1.Controls.Add(this.btn_right);
            this.panel1.Controls.Add(this.btn_left);
            this.panel1.Controls.Add(this.table_parameters);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 115);
            this.panel1.TabIndex = 19;
            // 
            // chk_use_soln
            // 
            this.chk_use_soln.AutoSize = true;
            this.chk_use_soln.Checked = true;
            this.chk_use_soln.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_use_soln.Depth = 0;
            this.chk_use_soln.Location = new System.Drawing.Point(201, 52);
            this.chk_use_soln.Margin = new System.Windows.Forms.Padding(0);
            this.chk_use_soln.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_use_soln.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_use_soln.Name = "chk_use_soln";
            this.chk_use_soln.Ripple = true;
            this.chk_use_soln.Size = new System.Drawing.Size(124, 37);
            this.chk_use_soln.TabIndex = 20;
            this.chk_use_soln.Text = "Use Solution";
            this.chk_use_soln.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.AutoSize = false;
            this.btn_right.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_right.Depth = 0;
            this.btn_right.DrawShadows = true;
            this.btn_right.HighEmphasis = true;
            this.btn_right.Icon = null;
            this.btn_right.Location = new System.Drawing.Point(984, 63);
            this.btn_right.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_right.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(68, 20);
            this.btn_right.TabIndex = 20;
            this.btn_right.Text = "right";
            this.btn_right.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_right.UseAccentColor = false;
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.AutoSize = false;
            this.btn_left.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_left.Depth = 0;
            this.btn_left.DrawShadows = true;
            this.btn_left.HighEmphasis = true;
            this.btn_left.Icon = null;
            this.btn_left.Location = new System.Drawing.Point(908, 63);
            this.btn_left.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_left.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(68, 20);
            this.btn_left.TabIndex = 20;
            this.btn_left.Text = "left";
            this.btn_left.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_left.UseAccentColor = false;
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // table_parameters
            // 
            this.table_parameters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table_parameters.ColumnCount = 4;
            this.table_parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_parameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table_parameters.Location = new System.Drawing.Point(346, 55);
            this.table_parameters.Name = "table_parameters";
            this.table_parameters.RowCount = 1;
            this.table_parameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_parameters.Size = new System.Drawing.Size(555, 34);
            this.table_parameters.TabIndex = 19;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel6.Location = new System.Drawing.Point(819, 39);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(16, 13);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "4th";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel5.Location = new System.Drawing.Point(680, 39);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(16, 13);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "3rd";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel4.Location = new System.Drawing.Point(543, 39);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(19, 13);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "2nd";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel3.Location = new System.Drawing.Point(404, 39);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(15, 13);
            this.materialLabel3.TabIndex = 18;
            this.materialLabel3.Text = "1st";
            // 
            // OptiplusComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dt_optimize);
            this.Controls.Add(this.panel1);
            this.Name = "OptiplusComponent";
            this.Size = new System.Drawing.Size(1074, 442);
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dt_optimize;
        public System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel table_parameters;
        private MaterialSkin.Controls.MaterialButton btn_right;
        private MaterialSkin.Controls.MaterialButton btn_left;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_solutions;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_gross_yield;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_storage_part;
        private System.Windows.Forms.DataGridViewTextBoxColumn optiplus_no_of_layouts;
        private MaterialSkin.Controls.MaterialCheckbox chk_use_soln;
    }
}
