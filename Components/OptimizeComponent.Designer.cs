
namespace LCC.Components
{
    partial class OptimizeComponent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt_stockLength = new System.Windows.Forms.DataGridView();
            this.stockLength_stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLengthTable_total_cut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_repeated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimizeBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dt_optimize = new System.Windows.Forms.DataGridView();
            this.optimize_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_no_of_parts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_uncut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_part_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_stock_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_gross_yield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_no_layout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stockLength)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_stockLength
            // 
            this.dt_stockLength.AllowUserToAddRows = false;
            this.dt_stockLength.AllowUserToDeleteRows = false;
            this.dt_stockLength.AllowUserToResizeColumns = false;
            this.dt_stockLength.AllowUserToResizeRows = false;
            this.dt_stockLength.BackgroundColor = System.Drawing.Color.White;
            this.dt_stockLength.CausesValidation = false;
            this.dt_stockLength.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stockLength.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_stockLength.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_stockLength.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockLength_stock_code,
            this.stockLength_length,
            this.stockLength_stock_type,
            this.stockLength_scrap,
            this.stockLength_rest,
            this.stockLength_total_cost,
            this.stockLengthTable_total_cut,
            this.stockLength_repeated,
            this.stockLength_note});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_stockLength.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt_stockLength.Location = new System.Drawing.Point(9, 236);
            this.dt_stockLength.MultiSelect = false;
            this.dt_stockLength.Name = "dt_stockLength";
            this.dt_stockLength.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stockLength.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_stockLength.RowHeadersVisible = false;
            this.dt_stockLength.RowTemplate.Height = 25;
            this.dt_stockLength.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_stockLength.ShowEditingIcon = false;
            this.dt_stockLength.Size = new System.Drawing.Size(1058, 132);
            this.dt_stockLength.TabIndex = 2;
            this.dt_stockLength.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockLengthTable_CellClick);
            this.dt_stockLength.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dt_optimize_DataError);
            // 
            // stockLength_stock_code
            // 
            this.stockLength_stock_code.DataPropertyName = "stock_code";
            this.stockLength_stock_code.HeaderText = "Stock Code";
            this.stockLength_stock_code.Name = "stockLength_stock_code";
            this.stockLength_stock_code.ReadOnly = true;
            this.stockLength_stock_code.Width = 150;
            // 
            // stockLength_length
            // 
            this.stockLength_length.DataPropertyName = "length";
            this.stockLength_length.HeaderText = "Length (mm)";
            this.stockLength_length.Name = "stockLength_length";
            this.stockLength_length.ReadOnly = true;
            this.stockLength_length.Width = 110;
            // 
            // stockLength_stock_type
            // 
            this.stockLength_stock_type.DataPropertyName = "stock_type";
            this.stockLength_stock_type.HeaderText = "Stock Type";
            this.stockLength_stock_type.Name = "stockLength_stock_type";
            this.stockLength_stock_type.ReadOnly = true;
            // 
            // stockLength_scrap
            // 
            this.stockLength_scrap.DataPropertyName = "scrap";
            this.stockLength_scrap.HeaderText = "Scrap";
            this.stockLength_scrap.Name = "stockLength_scrap";
            this.stockLength_scrap.ReadOnly = true;
            // 
            // stockLength_rest
            // 
            this.stockLength_rest.DataPropertyName = "rest";
            this.stockLength_rest.HeaderText = "Remnant";
            this.stockLength_rest.Name = "stockLength_rest";
            this.stockLength_rest.ReadOnly = true;
            this.stockLength_rest.Width = 90;
            // 
            // stockLength_total_cost
            // 
            this.stockLength_total_cost.DataPropertyName = "cost";
            dataGridViewCellStyle2.NullValue = "0";
            this.stockLength_total_cost.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockLength_total_cost.HeaderText = "Total Cost";
            this.stockLength_total_cost.Name = "stockLength_total_cost";
            this.stockLength_total_cost.ReadOnly = true;
            // 
            // stockLengthTable_total_cut
            // 
            this.stockLengthTable_total_cut.DataPropertyName = "total_cut";
            this.stockLengthTable_total_cut.HeaderText = "Total Cut";
            this.stockLengthTable_total_cut.Name = "stockLengthTable_total_cut";
            this.stockLengthTable_total_cut.ReadOnly = true;
            this.stockLengthTable_total_cut.Width = 85;
            // 
            // stockLength_repeated
            // 
            this.stockLength_repeated.DataPropertyName = "repeated";
            this.stockLength_repeated.HeaderText = "Repeated";
            this.stockLength_repeated.Name = "stockLength_repeated";
            this.stockLength_repeated.ReadOnly = true;
            this.stockLength_repeated.Width = 70;
            // 
            // stockLength_note
            // 
            this.stockLength_note.DataPropertyName = "note";
            this.stockLength_note.HeaderText = "Note";
            this.stockLength_note.Name = "stockLength_note";
            this.stockLength_note.ReadOnly = true;
            this.stockLength_note.Width = 225;
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.AutoScroll = true;
            this.optimizeBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 374);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.Size = new System.Drawing.Size(1078, 72);
            this.optimizeBarPanel.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.dt_stockLength);
            this.panel8.Controls.Add(this.dt_optimize);
            this.panel8.Controls.Add(this.materialLabel6);
            this.panel8.Controls.Add(this.materialLabel4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1078, 374);
            this.panel8.TabIndex = 16;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_optimize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dt_optimize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_optimize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.optimize_description,
            this.optimize_no_of_parts,
            this.optimize_uncut,
            this.optimize_part_length,
            this.optimize_stock_length,
            this.optimize_gross_yield,
            this.optimize_cost,
            this.optimize_no_layout});
            this.dt_optimize.Location = new System.Drawing.Point(10, 50);
            this.dt_optimize.MultiSelect = false;
            this.dt_optimize.Name = "dt_optimize";
            this.dt_optimize.ReadOnly = true;
            this.dt_optimize.RowHeadersVisible = false;
            this.dt_optimize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_optimize.ShowEditingIcon = false;
            this.dt_optimize.Size = new System.Drawing.Size(1058, 143);
            this.dt_optimize.TabIndex = 13;
            this.dt_optimize.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthTable_CellClick);
            this.dt_optimize.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dt_optimize_DataError);
            // 
            // optimize_description
            // 
            this.optimize_description.DataPropertyName = "cutlength_desc_grade";
            this.optimize_description.HeaderText = "Description (Grade)";
            this.optimize_description.Name = "optimize_description";
            this.optimize_description.ReadOnly = true;
            this.optimize_description.Width = 265;
            // 
            // optimize_no_of_parts
            // 
            this.optimize_no_of_parts.DataPropertyName = "quantity";
            this.optimize_no_of_parts.HeaderText = "No. of Parts";
            this.optimize_no_of_parts.Name = "optimize_no_of_parts";
            this.optimize_no_of_parts.ReadOnly = true;
            // 
            // optimize_uncut
            // 
            this.optimize_uncut.DataPropertyName = "uncut_quantity";
            this.optimize_uncut.HeaderText = "Uncut Parts";
            this.optimize_uncut.Name = "optimize_uncut";
            this.optimize_uncut.ReadOnly = true;
            // 
            // optimize_part_length
            // 
            this.optimize_part_length.DataPropertyName = "total_parts_length";
            this.optimize_part_length.HeaderText = "Total Parts Length";
            this.optimize_part_length.Name = "optimize_part_length";
            this.optimize_part_length.ReadOnly = true;
            this.optimize_part_length.Width = 135;
            // 
            // optimize_stock_length
            // 
            this.optimize_stock_length.DataPropertyName = "total_stock_length";
            this.optimize_stock_length.HeaderText = "Total Stock Length";
            this.optimize_stock_length.Name = "optimize_stock_length";
            this.optimize_stock_length.ReadOnly = true;
            this.optimize_stock_length.Width = 135;
            // 
            // optimize_gross_yield
            // 
            this.optimize_gross_yield.DataPropertyName = "gross_yield";
            this.optimize_gross_yield.HeaderText = "Gross Yield %";
            this.optimize_gross_yield.Name = "optimize_gross_yield";
            this.optimize_gross_yield.ReadOnly = true;
            this.optimize_gross_yield.Width = 110;
            // 
            // optimize_cost
            // 
            this.optimize_cost.DataPropertyName = "cost";
            this.optimize_cost.HeaderText = "Cost";
            this.optimize_cost.Name = "optimize_cost";
            this.optimize_cost.ReadOnly = true;
            this.optimize_cost.Width = 75;
            // 
            // optimize_no_layout
            // 
            this.optimize_no_layout.DataPropertyName = "total_layout";
            this.optimize_no_layout.HeaderText = "No. of Layout";
            this.optimize_no_layout.Name = "optimize_no_layout";
            this.optimize_no_layout.ReadOnly = true;
            this.optimize_no_layout.Width = 108;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.materialLabel6.Location = new System.Drawing.Point(10, 216);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(122, 17);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Summary of Stocks";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(8, 14);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(147, 24);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Result Summary";
            // 
            // OptimizeComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.optimizeBarPanel);
            this.Controls.Add(this.panel8);
            this.Name = "OptimizeComponent";
            this.Size = new System.Drawing.Size(1078, 446);
            ((System.ComponentModel.ISupportInitialize)(this.dt_stockLength)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dt_stockLength;
        public System.Windows.Forms.FlowLayoutPanel optimizeBarPanel;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public System.Windows.Forms.DataGridView dt_optimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_stock_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_total_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLengthTable_total_cut;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_repeated;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_no_of_parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_uncut;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_part_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_stock_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_gross_yield;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn optimize_no_layout;
    }
}
