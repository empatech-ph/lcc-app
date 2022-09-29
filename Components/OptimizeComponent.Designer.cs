
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.optimizeBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.dt_summary_materials = new System.Windows.Forms.DataGridView();
            this.layout_material_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_material_stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_material_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_material_stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumarry_materials_label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sub_layout_label = new System.Windows.Forms.Label();
            this.dt_summary_cutlengths = new System.Windows.Forms.DataGridView();
            this.layout_sequence_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_part_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dt_stockLength = new System.Windows.Forms.DataGridView();
            this.layout_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_rest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_repeated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockLength_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_label = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.material_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_summary_materials)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_summary_cutlengths)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stockLength)).BeginInit();
            this.SuspendLayout();
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.AutoScroll = true;
            this.optimizeBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 366);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.optimizeBarPanel.Size = new System.Drawing.Size(1262, 183);
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
            this.panel8.Size = new System.Drawing.Size(1262, 366);
            this.panel8.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 325);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 164);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dt_optimize);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1256, 158);
            this.panel6.TabIndex = 15;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.NullValue = "-";
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_optimize.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.NullValue = "-";
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_optimize.DefaultCellStyle = dataGridViewCellStyle18;
            this.dt_optimize.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_optimize.Location = new System.Drawing.Point(0, 3);
            this.dt_optimize.MultiSelect = false;
            this.dt_optimize.Name = "dt_optimize";
            this.dt_optimize.ReadOnly = true;
            this.dt_optimize.RowHeadersVisible = false;
            this.dt_optimize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_optimize.ShowEditingIcon = false;
            this.dt_optimize.Size = new System.Drawing.Size(1256, 155);
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
            this.optimize_part_length.HeaderText = "Total Parts Length (mm)";
            this.optimize_part_length.Name = "optimize_part_length";
            this.optimize_part_length.ReadOnly = true;
            this.optimize_part_length.Width = 119;
            // 
            // optimize_stock_length
            // 
            this.optimize_stock_length.DataPropertyName = "total_stock_length";
            this.optimize_stock_length.HeaderText = "Total Stock Length (mm)";
            this.optimize_stock_length.Name = "optimize_stock_length";
            this.optimize_stock_length.ReadOnly = true;
            this.optimize_stock_length.Width = 123;
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
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 161);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1262, 161);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dt_summary_materials);
            this.panel9.Controls.Add(this.sumarry_materials_label);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(949, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 155);
            this.panel9.TabIndex = 1;
            // 
            // dt_summary_materials
            // 
            this.dt_summary_materials.AllowUserToAddRows = false;
            this.dt_summary_materials.AllowUserToDeleteRows = false;
            this.dt_summary_materials.AllowUserToResizeColumns = false;
            this.dt_summary_materials.AllowUserToResizeRows = false;
            this.dt_summary_materials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_summary_materials.BackgroundColor = System.Drawing.Color.White;
            this.dt_summary_materials.CausesValidation = false;
            this.dt_summary_materials.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.NullValue = "-";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_summary_materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dt_summary_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_summary_materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layout_material_qty,
            this.layout_material_stock_code,
            this.layout_material_length,
            this.layout_material_stock_type});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.NullValue = "-";
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_summary_materials.DefaultCellStyle = dataGridViewCellStyle11;
            this.dt_summary_materials.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_summary_materials.Location = new System.Drawing.Point(0, 28);
            this.dt_summary_materials.MultiSelect = false;
            this.dt_summary_materials.Name = "dt_summary_materials";
            this.dt_summary_materials.ReadOnly = true;
            this.dt_summary_materials.RowHeadersVisible = false;
            this.dt_summary_materials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_summary_materials.ShowEditingIcon = false;
            this.dt_summary_materials.Size = new System.Drawing.Size(310, 127);
            this.dt_summary_materials.TabIndex = 16;
            // 
            // layout_material_qty
            // 
            this.layout_material_qty.DataPropertyName = "layout_material_qty";
            this.layout_material_qty.HeaderText = "Qty";
            this.layout_material_qty.Name = "layout_material_qty";
            this.layout_material_qty.ReadOnly = true;
            this.layout_material_qty.Width = 51;
            // 
            // layout_material_stock_code
            // 
            this.layout_material_stock_code.DataPropertyName = "layout_material_stock_code";
            this.layout_material_stock_code.HeaderText = "Stock Code";
            this.layout_material_stock_code.Name = "layout_material_stock_code";
            this.layout_material_stock_code.ReadOnly = true;
            this.layout_material_stock_code.Width = 92;
            // 
            // layout_material_length
            // 
            this.layout_material_length.DataPropertyName = "layout_material_length";
            this.layout_material_length.HeaderText = "Length (mm)";
            this.layout_material_length.Name = "layout_material_length";
            this.layout_material_length.ReadOnly = true;
            this.layout_material_length.Width = 102;
            // 
            // layout_material_stock_type
            // 
            this.layout_material_stock_type.DataPropertyName = "layout_material_stock_type";
            this.layout_material_stock_type.HeaderText = "Stock Type";
            this.layout_material_stock_type.Name = "layout_material_stock_type";
            this.layout_material_stock_type.ReadOnly = true;
            this.layout_material_stock_type.Width = 90;
            // 
            // sumarry_materials_label
            // 
            this.sumarry_materials_label.AutoSize = true;
            this.sumarry_materials_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sumarry_materials_label.Location = new System.Drawing.Point(8, 7);
            this.sumarry_materials_label.Name = "sumarry_materials_label";
            this.sumarry_materials_label.Size = new System.Drawing.Size(142, 17);
            this.sumarry_materials_label.TabIndex = 15;
            this.sumarry_materials_label.Text = "Summary of Materials";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.sub_layout_label);
            this.panel7.Controls.Add(this.dt_summary_cutlengths);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(634, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(309, 155);
            this.panel7.TabIndex = 0;
            // 
            // sub_layout_label
            // 
            this.sub_layout_label.AutoSize = true;
            this.sub_layout_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sub_layout_label.Location = new System.Drawing.Point(8, 7);
            this.sub_layout_label.Name = "sub_layout_label";
            this.sub_layout_label.Size = new System.Drawing.Size(154, 17);
            this.sub_layout_label.TabIndex = 14;
            this.sub_layout_label.Text = "Cutlength - Layout 1 (L1)";
            // 
            // dt_summary_cutlengths
            // 
            this.dt_summary_cutlengths.AllowUserToAddRows = false;
            this.dt_summary_cutlengths.AllowUserToDeleteRows = false;
            this.dt_summary_cutlengths.AllowUserToResizeColumns = false;
            this.dt_summary_cutlengths.AllowUserToResizeRows = false;
            this.dt_summary_cutlengths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_summary_cutlengths.BackgroundColor = System.Drawing.Color.White;
            this.dt_summary_cutlengths.CausesValidation = false;
            this.dt_summary_cutlengths.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.NullValue = "-";
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_summary_cutlengths.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dt_summary_cutlengths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_summary_cutlengths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layout_sequence_no,
            this.layout_part_code,
            this.layout_length,
            this.layout_qty});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.NullValue = "-";
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_summary_cutlengths.DefaultCellStyle = dataGridViewCellStyle13;
            this.dt_summary_cutlengths.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_summary_cutlengths.Location = new System.Drawing.Point(0, 28);
            this.dt_summary_cutlengths.MultiSelect = false;
            this.dt_summary_cutlengths.Name = "dt_summary_cutlengths";
            this.dt_summary_cutlengths.ReadOnly = true;
            this.dt_summary_cutlengths.RowHeadersVisible = false;
            this.dt_summary_cutlengths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_summary_cutlengths.ShowEditingIcon = false;
            this.dt_summary_cutlengths.Size = new System.Drawing.Size(309, 127);
            this.dt_summary_cutlengths.TabIndex = 15;
            // 
            // layout_sequence_no
            // 
            this.layout_sequence_no.DataPropertyName = "layout_sequence_no";
            this.layout_sequence_no.HeaderText = "Seq. #";
            this.layout_sequence_no.Name = "layout_sequence_no";
            this.layout_sequence_no.ReadOnly = true;
            this.layout_sequence_no.Width = 65;
            // 
            // layout_part_code
            // 
            this.layout_part_code.DataPropertyName = "layout_part_code";
            this.layout_part_code.HeaderText = "Part Code";
            this.layout_part_code.Name = "layout_part_code";
            this.layout_part_code.ReadOnly = true;
            this.layout_part_code.Width = 83;
            // 
            // layout_length
            // 
            this.layout_length.DataPropertyName = "layout_length";
            this.layout_length.HeaderText = "Length (mm)";
            this.layout_length.Name = "layout_length";
            this.layout_length.ReadOnly = true;
            this.layout_length.Width = 102;
            // 
            // layout_qty
            // 
            this.layout_qty.DataPropertyName = "layout_qty";
            this.layout_qty.HeaderText = "Quantity";
            this.layout_qty.Name = "layout_qty";
            this.layout_qty.ReadOnly = true;
            this.layout_qty.Width = 78;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dt_stockLength);
            this.panel10.Controls.Add(this.layout_label);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(625, 155);
            this.panel10.TabIndex = 2;
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
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.NullValue = "-";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stockLength.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dt_stockLength.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_stockLength.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layout_no,
            this.stockLength_length,
            this.stockLength_stock_code,
            this.stockLength_stock_type,
            this.stockLength_rest,
            this.stockLength_repeated,
            this.stockLength_note});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.NullValue = "-";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_stockLength.DefaultCellStyle = dataGridViewCellStyle15;
            this.dt_stockLength.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_stockLength.Location = new System.Drawing.Point(0, 28);
            this.dt_stockLength.MultiSelect = false;
            this.dt_stockLength.Name = "dt_stockLength";
            this.dt_stockLength.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stockLength.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dt_stockLength.RowHeadersVisible = false;
            this.dt_stockLength.RowTemplate.Height = 25;
            this.dt_stockLength.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_stockLength.ShowEditingIcon = false;
            this.dt_stockLength.Size = new System.Drawing.Size(625, 127);
            this.dt_stockLength.TabIndex = 2;
            this.dt_stockLength.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockLengthTable_CellClick);
            this.dt_stockLength.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dt_optimize_DataError);
            // 
            // layout_no
            // 
            this.layout_no.HeaderText = "Layout #";
            this.layout_no.Name = "layout_no";
            this.layout_no.ReadOnly = true;
            this.layout_no.Width = 78;
            // 
            // stockLength_length
            // 
            this.stockLength_length.DataPropertyName = "length";
            this.stockLength_length.HeaderText = "Length (mm)";
            this.stockLength_length.Name = "stockLength_length";
            this.stockLength_length.ReadOnly = true;
            this.stockLength_length.Width = 102;
            // 
            // stockLength_stock_code
            // 
            this.stockLength_stock_code.DataPropertyName = "stock_code";
            this.stockLength_stock_code.HeaderText = "Stock Code";
            this.stockLength_stock_code.Name = "stockLength_stock_code";
            this.stockLength_stock_code.ReadOnly = true;
            this.stockLength_stock_code.Width = 92;
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
            // stockLength_repeated
            // 
            this.stockLength_repeated.DataPropertyName = "repeated";
            this.stockLength_repeated.HeaderText = "Instances";
            this.stockLength_repeated.Name = "stockLength_repeated";
            this.stockLength_repeated.ReadOnly = true;
            this.stockLength_repeated.Width = 82;
            // 
            // stockLength_note
            // 
            this.stockLength_note.DataPropertyName = "note";
            this.stockLength_note.HeaderText = "Note";
            this.stockLength_note.Name = "stockLength_note";
            this.stockLength_note.ReadOnly = true;
            this.stockLength_note.Width = 58;
            // 
            // layout_label
            // 
            this.layout_label.AutoSize = true;
            this.layout_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.layout_label.Location = new System.Drawing.Point(8, 7);
            this.layout_label.Name = "layout_label";
            this.layout_label.Size = new System.Drawing.Size(126, 17);
            this.layout_label.TabIndex = 3;
            this.layout_label.Text = "Summary of Stocks";
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
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_optimize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_summary_materials)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_summary_cutlengths)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stockLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dt_stockLength;
        public System.Windows.Forms.FlowLayoutPanel optimizeBarPanel;
        private System.Windows.Forms.Panel panel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        public MaterialSkin.Controls.MaterialLabel materialLabel4;
        public System.Windows.Forms.DataGridView dt_optimize;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_scrap;
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
        private System.Windows.Forms.Label layout_label;
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
        private System.Windows.Forms.Label sub_layout_label;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_qty;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_stock_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_rest;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_repeated;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_note;
        public System.Windows.Forms.DataGridView dt_summary_materials;
        private System.Windows.Forms.Label sumarry_materials_label;
        public System.Windows.Forms.DataGridView dt_summary_cutlengths;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_sequence_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_part_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_material_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_material_stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_material_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_material_stock_type;
    }
}
