
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.optimizeBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_stockLength = new System.Windows.Forms.DataGridView();
            this.stockLength_stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_total_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLengthTable_total_cut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_repeated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_optimize = new System.Windows.Forms.DataGridView();
            this.optimize_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_no_of_parts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_uncut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_part_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_stock_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_gross_yield = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optimize_no_layout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.layout_sequence_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_part_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.material_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stockLength)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.AutoScroll = true;
            this.optimizeBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 448);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.Size = new System.Drawing.Size(1262, 101);
            this.optimizeBarPanel.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.materialLabel4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1262, 448);
            this.panel8.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 400);
            this.panel1.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 232);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Summary of Stocks";
            // 
            // dt_stockLength
            // 
            this.dt_stockLength.AllowUserToAddRows = false;
            this.dt_stockLength.AllowUserToDeleteRows = false;
            this.dt_stockLength.AllowUserToResizeColumns = false;
            this.dt_stockLength.AllowUserToResizeRows = false;
            this.dt_stockLength.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_stockLength.BackgroundColor = System.Drawing.Color.White;
            this.dt_stockLength.CausesValidation = false;
            this.dt_stockLength.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.NullValue = "-";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stockLength.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dt_stockLength.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_stockLength.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockLength_stock_code,
            this.stockLength_length,
            this.stockLength_stock_type,
            this.stockLength_rest,
            this.stockLength_total_cost,
            this.stockLengthTable_total_cut,
            this.stockLength_repeated,
            this.stockLength_note});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.NullValue = "-";
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_stockLength.DefaultCellStyle = dataGridViewCellStyle9;
            this.dt_stockLength.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_stockLength.Location = new System.Drawing.Point(0, 32);
            this.dt_stockLength.MultiSelect = false;
            this.dt_stockLength.Name = "dt_stockLength";
            this.dt_stockLength.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stockLength.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dt_stockLength.RowHeadersVisible = false;
            this.dt_stockLength.RowTemplate.Height = 25;
            this.dt_stockLength.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_stockLength.ShowEditingIcon = false;
            this.dt_stockLength.Size = new System.Drawing.Size(625, 130);
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
            this.stockLength_stock_code.Width = 92;
            // 
            // stockLength_length
            // 
            this.stockLength_length.DataPropertyName = "length";
            this.stockLength_length.HeaderText = "Length (mm)";
            this.stockLength_length.Name = "stockLength_length";
            this.stockLength_length.ReadOnly = true;
            this.stockLength_length.Width = 102;
            // 
            // stockLength_stock_type
            // 
            this.stockLength_stock_type.DataPropertyName = "stock_type";
            this.stockLength_stock_type.HeaderText = "Stock Type";
            this.stockLength_stock_type.Name = "stockLength_stock_type";
            this.stockLength_stock_type.ReadOnly = true;
            this.stockLength_stock_type.Width = 90;
            // 
            // stockLength_rest
            // 
            this.stockLength_rest.DataPropertyName = "rest";
            this.stockLength_rest.HeaderText = "Remnant";
            this.stockLength_rest.Name = "stockLength_rest";
            this.stockLength_rest.ReadOnly = true;
            this.stockLength_rest.Width = 80;
            // 
            // stockLength_total_cost
            // 
            this.stockLength_total_cost.DataPropertyName = "cost";
            dataGridViewCellStyle8.NullValue = "0";
            this.stockLength_total_cost.DefaultCellStyle = dataGridViewCellStyle8;
            this.stockLength_total_cost.HeaderText = "Total Cost";
            this.stockLength_total_cost.Name = "stockLength_total_cost";
            this.stockLength_total_cost.ReadOnly = true;
            this.stockLength_total_cost.Width = 84;
            // 
            // stockLengthTable_total_cut
            // 
            this.stockLengthTable_total_cut.DataPropertyName = "total_cut";
            this.stockLengthTable_total_cut.HeaderText = "Total Cut";
            this.stockLengthTable_total_cut.Name = "stockLengthTable_total_cut";
            this.stockLengthTable_total_cut.ReadOnly = true;
            this.stockLengthTable_total_cut.Width = 79;
            // 
            // stockLength_repeated
            // 
            this.stockLength_repeated.DataPropertyName = "repeated";
            this.stockLength_repeated.HeaderText = "Repeated";
            this.stockLength_repeated.Name = "stockLength_repeated";
            this.stockLength_repeated.ReadOnly = true;
            this.stockLength_repeated.Width = 81;
            // 
            // stockLength_note
            // 
            this.stockLength_note.DataPropertyName = "note";
            this.stockLength_note.HeaderText = "Note";
            this.stockLength_note.Name = "stockLength_note";
            this.stockLength_note.ReadOnly = true;
            this.stockLength_note.Width = 58;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.dt_optimize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1256, 226);
            this.panel6.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Summary of Cutlengths";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_optimize
            // 
            this.dt_optimize.AllowUserToAddRows = false;
            this.dt_optimize.AllowUserToDeleteRows = false;
            this.dt_optimize.AllowUserToResizeColumns = false;
            this.dt_optimize.AllowUserToResizeRows = false;
            this.dt_optimize.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_optimize.BackgroundColor = System.Drawing.Color.White;
            this.dt_optimize.CausesValidation = false;
            this.dt_optimize.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_optimize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_optimize.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_optimize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_optimize.Location = new System.Drawing.Point(0, 29);
            this.dt_optimize.MultiSelect = false;
            this.dt_optimize.Name = "dt_optimize";
            this.dt_optimize.ReadOnly = true;
            this.dt_optimize.RowHeadersVisible = false;
            this.dt_optimize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_optimize.ShowEditingIcon = false;
            this.dt_optimize.Size = new System.Drawing.Size(1256, 197);
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
            this.optimize_description.Width = 124;
            // 
            // optimize_no_of_parts
            // 
            this.optimize_no_of_parts.DataPropertyName = "quantity";
            this.optimize_no_of_parts.HeaderText = "No. of Parts";
            this.optimize_no_of_parts.Name = "optimize_no_of_parts";
            this.optimize_no_of_parts.ReadOnly = true;
            this.optimize_no_of_parts.Width = 87;
            // 
            // optimize_uncut
            // 
            this.optimize_uncut.DataPropertyName = "uncut_quantity";
            this.optimize_uncut.HeaderText = "Uncut Parts";
            this.optimize_uncut.Name = "optimize_uncut";
            this.optimize_uncut.ReadOnly = true;
            this.optimize_uncut.Width = 86;
            // 
            // optimize_part_length
            // 
            this.optimize_part_length.DataPropertyName = "total_parts_length";
            this.optimize_part_length.HeaderText = "Total Parts Length";
            this.optimize_part_length.Name = "optimize_part_length";
            this.optimize_part_length.ReadOnly = true;
            this.optimize_part_length.Width = 116;
            // 
            // optimize_stock_length
            // 
            this.optimize_stock_length.DataPropertyName = "total_stock_length";
            this.optimize_stock_length.HeaderText = "Total Stock Length";
            this.optimize_stock_length.Name = "optimize_stock_length";
            this.optimize_stock_length.ReadOnly = true;
            this.optimize_stock_length.Width = 120;
            // 
            // optimize_gross_yield
            // 
            this.optimize_gross_yield.DataPropertyName = "gross_yield";
            this.optimize_gross_yield.HeaderText = "Gross Yield %";
            this.optimize_gross_yield.Name = "optimize_gross_yield";
            this.optimize_gross_yield.ReadOnly = true;
            this.optimize_gross_yield.Width = 86;
            // 
            // optimize_cost
            // 
            this.optimize_cost.DataPropertyName = "cost";
            this.optimize_cost.HeaderText = "Cost";
            this.optimize_cost.Name = "optimize_cost";
            this.optimize_cost.ReadOnly = true;
            this.optimize_cost.Width = 55;
            // 
            // optimize_no_layout
            // 
            this.optimize_no_layout.DataPropertyName = "total_layout";
            this.optimize_no_layout.HeaderText = "No. of Layout";
            this.optimize_no_layout.Name = "optimize_no_layout";
            this.optimize_no_layout.ReadOnly = true;
            this.optimize_no_layout.Width = 96;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 168);
            this.panel2.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.panel9, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 168);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dataGridView2);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(949, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 162);
            this.panel9.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CausesValidation = false;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.material_stock_code,
            this.material_length,
            this.material_stock_type});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 32);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(310, 130);
            this.dataGridView2.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // material_stock_code
            // 
            this.material_stock_code.HeaderText = "Stock Code";
            this.material_stock_code.Name = "material_stock_code";
            this.material_stock_code.ReadOnly = true;
            this.material_stock_code.Width = 92;
            // 
            // material_length
            // 
            this.material_length.HeaderText = "Length";
            this.material_length.Name = "material_length";
            this.material_length.ReadOnly = true;
            this.material_length.Width = 69;
            // 
            // material_stock_type
            // 
            this.material_stock_type.HeaderText = "Stock Type";
            this.material_stock_type.Name = "material_stock_type";
            this.material_stock_type.ReadOnly = true;
            this.material_stock_type.Width = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Summary of Materials";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(634, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 162);
            this.panel7.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cutlength - Layout 1 (L1)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.NullValue = "-";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layout_sequence_no,
            this.layout_part_code,
            this.layout_length,
            this.layout_qty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = "-";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(309, 130);
            this.dataGridView1.TabIndex = 15;
            // 
            // layout_sequence_no
            // 
            this.layout_sequence_no.HeaderText = "Seq. #";
            this.layout_sequence_no.Name = "layout_sequence_no";
            this.layout_sequence_no.ReadOnly = true;
            this.layout_sequence_no.Width = 65;
            // 
            // layout_part_code
            // 
            this.layout_part_code.HeaderText = "Part Code";
            this.layout_part_code.Name = "layout_part_code";
            this.layout_part_code.ReadOnly = true;
            this.layout_part_code.Width = 83;
            // 
            // layout_length
            // 
            this.layout_length.HeaderText = "Length";
            this.layout_length.Name = "layout_length";
            this.layout_length.ReadOnly = true;
            this.layout_length.Width = 69;
            // 
            // layout_qty
            // 
            this.layout_qty.HeaderText = "Quantity";
            this.layout_qty.Name = "layout_qty";
            this.layout_qty.ReadOnly = true;
            this.layout_qty.Width = 78;
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
            // material_qty
            // 
            this.material_qty.HeaderText = "Quantity";
            this.material_qty.Name = "material_qty";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dt_stockLength);
            this.panel10.Controls.Add(this.label1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(625, 162);
            this.panel10.TabIndex = 2;
            // 
            // OptimizeComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.optimizeBarPanel);
            this.Controls.Add(this.panel8);
            this.Name = "OptimizeComponent";
            this.Size = new System.Drawing.Size(1262, 549);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_stockLength)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_stock_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_sequence_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_part_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_qty;
        private System.Windows.Forms.Panel panel10;
    }
}
