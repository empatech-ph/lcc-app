
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.stockLengthTable = new System.Windows.Forms.DataGridView();
            this.stockLength_stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLengthTable_total_cut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_repeated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cutLengthTable = new System.Windows.Forms.DataGridView();
            this.cutlengthTable_part_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutLengthTable_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlengthTable_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutLengthTable_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutLengthTable_uncut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimizeBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockLengthTable)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutLengthTable)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.stockLengthTable);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(568, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(510, 261);
            this.panel6.TabIndex = 15;
            // 
            // stockLengthTable
            // 
            this.stockLengthTable.AllowUserToAddRows = false;
            this.stockLengthTable.AllowUserToDeleteRows = false;
            this.stockLengthTable.AllowUserToOrderColumns = true;
            this.stockLengthTable.AllowUserToResizeColumns = false;
            this.stockLengthTable.AllowUserToResizeRows = false;
            this.stockLengthTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.stockLengthTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockLengthTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockLengthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockLengthTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockLength_stock_code,
            this.stockLength_length,
            this.stockLength_rest,
            this.stockLengthTable_total_cut,
            this.stockLength_repeated});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockLengthTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockLengthTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stockLengthTable.Location = new System.Drawing.Point(0, 0);
            this.stockLengthTable.MultiSelect = false;
            this.stockLengthTable.Name = "stockLengthTable";
            this.stockLengthTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockLengthTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.stockLengthTable.RowHeadersVisible = false;
            this.stockLengthTable.RowTemplate.Height = 25;
            this.stockLengthTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockLengthTable.ShowEditingIcon = false;
            this.stockLengthTable.Size = new System.Drawing.Size(508, 259);
            this.stockLengthTable.TabIndex = 2;
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
            // stockLength_rest
            // 
            this.stockLength_rest.DataPropertyName = "rest";
            this.stockLength_rest.HeaderText = "Rest (mm)";
            this.stockLength_rest.Name = "stockLength_rest";
            this.stockLength_rest.ReadOnly = true;
            this.stockLength_rest.Width = 90;
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
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cutLengthTable);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(558, 261);
            this.panel5.TabIndex = 18;
            // 
            // cutLengthTable
            // 
            this.cutLengthTable.AllowUserToAddRows = false;
            this.cutLengthTable.AllowUserToDeleteRows = false;
            this.cutLengthTable.AllowUserToOrderColumns = true;
            this.cutLengthTable.AllowUserToResizeColumns = false;
            this.cutLengthTable.AllowUserToResizeRows = false;
            this.cutLengthTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.cutLengthTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cutLengthTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cutLengthTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cutLengthTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cutlengthTable_part_code,
            this.cutLengthTable_description,
            this.cutlengthTable_length,
            this.cutLengthTable_quantity,
            this.cutLengthTable_uncut});
            this.cutLengthTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cutLengthTable.Location = new System.Drawing.Point(0, 0);
            this.cutLengthTable.MultiSelect = false;
            this.cutLengthTable.Name = "cutLengthTable";
            this.cutLengthTable.ReadOnly = true;
            this.cutLengthTable.RowHeadersVisible = false;
            this.cutLengthTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cutLengthTable.ShowEditingIcon = false;
            this.cutLengthTable.Size = new System.Drawing.Size(556, 259);
            this.cutLengthTable.TabIndex = 3;
            this.cutLengthTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthTable_CellClick);
            // 
            // cutlengthTable_part_code
            // 
            this.cutlengthTable_part_code.DataPropertyName = "part_code";
            this.cutlengthTable_part_code.HeaderText = "Part Code";
            this.cutlengthTable_part_code.Name = "cutlengthTable_part_code";
            this.cutlengthTable_part_code.ReadOnly = true;
            this.cutlengthTable_part_code.Width = 135;
            // 
            // cutLengthTable_description
            // 
            this.cutLengthTable_description.DataPropertyName = "cutlength_desc_grade";
            this.cutLengthTable_description.HeaderText = "Description";
            this.cutLengthTable_description.Name = "cutLengthTable_description";
            this.cutLengthTable_description.ReadOnly = true;
            this.cutLengthTable_description.Width = 190;
            // 
            // cutlengthTable_length
            // 
            this.cutlengthTable_length.DataPropertyName = "length";
            this.cutlengthTable_length.HeaderText = "Length (mm)";
            this.cutlengthTable_length.Name = "cutlengthTable_length";
            this.cutlengthTable_length.ReadOnly = true;
            this.cutlengthTable_length.Width = 110;
            // 
            // cutLengthTable_quantity
            // 
            this.cutLengthTable_quantity.DataPropertyName = "quantity";
            this.cutLengthTable_quantity.HeaderText = "Quantity";
            this.cutLengthTable_quantity.Name = "cutLengthTable_quantity";
            this.cutLengthTable_quantity.ReadOnly = true;
            this.cutLengthTable_quantity.Width = 65;
            // 
            // cutLengthTable_uncut
            // 
            this.cutLengthTable_uncut.DataPropertyName = "uncut";
            this.cutLengthTable_uncut.HeaderText = "Uncut";
            this.cutLengthTable_uncut.Name = "cutLengthTable_uncut";
            this.cutLengthTable_uncut.ReadOnly = true;
            this.cutLengthTable_uncut.Width = 50;
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.AutoScroll = true;
            this.optimizeBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 348);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.Size = new System.Drawing.Size(1078, 98);
            this.optimizeBarPanel.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.materialLabel6);
            this.panel8.Controls.Add(this.materialLabel5);
            this.panel8.Controls.Add(this.materialLabel4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1078, 87);
            this.panel8.TabIndex = 16;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.materialLabel6.Location = new System.Drawing.Point(578, 67);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(78, 17);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Used Stocks";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.materialLabel5.Location = new System.Drawing.Point(8, 67);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(113, 17);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Used Cut Lengths";
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
            this.materialLabel4.Size = new System.Drawing.Size(205, 24);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Optimized Cut Lengths";
            // 
            // OptimizeComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.optimizeBarPanel);
            this.Controls.Add(this.panel8);
            this.Name = "OptimizeComponent";
            this.Size = new System.Drawing.Size(1078, 446);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockLengthTable)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cutLengthTable)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView stockLengthTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLengthTable_total_cut;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_repeated;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView cutLengthTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutlengthTable_part_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutLengthTable_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutlengthTable_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutLengthTable_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cutLengthTable_uncut;
        private System.Windows.Forms.FlowLayoutPanel optimizeBarPanel;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}
