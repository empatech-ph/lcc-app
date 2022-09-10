
namespace LCC.Modals
{
    partial class StocksManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt_stock = new System.Windows.Forms.DataGridView();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibility_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.editable_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.stockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_material = new System.Windows.Forms.Label();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.btnImport = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_stock
            // 
            this.dt_stock.AllowUserToAddRows = false;
            this.dt_stock.AllowUserToDeleteRows = false;
            this.dt_stock.AllowUserToResizeColumns = false;
            this.dt_stock.AllowUserToResizeRows = false;
            this.dt_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dt_stock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.description,
            this.grade,
            this.qty,
            this.length,
            this.stock_type,
            this.cost,
            this.stock_code,
            this.note,
            this.visibility_image,
            this.editable_image});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_stock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_stock.Location = new System.Drawing.Point(3, 156);
            this.dt_stock.Name = "dt_stock";
            this.dt_stock.RowHeadersVisible = false;
            this.dt_stock.RowTemplate.Height = 25;
            this.dt_stock.Size = new System.Drawing.Size(1406, 390);
            this.dt_stock.TabIndex = 4;
            this.dt_stock.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dt_stock_CellBeginEdit);
            this.dt_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCellClick);
            this.dt_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCellClick);
            this.dt_stock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_stock_CellDoubleClick);
            this.dt_stock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_stock_CellEndEdit);
            this.dt_stock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_stock_CellFormatting);
            this.dt_stock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dt_stock_DataBindingComplete);
            this.dt_stock.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dt_stock_DataError);
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Width = 119;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Width = 79;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qty.Width = 97;
            // 
            // length
            // 
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "Length (mm)";
            this.length.Name = "length";
            this.length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.length.Width = 128;
            // 
            // stock_type
            // 
            this.stock_type.DataPropertyName = "stock_type";
            this.stock_type.HeaderText = "Stock Type";
            this.stock_type.Name = "stock_type";
            this.stock_type.ReadOnly = true;
            this.stock_type.Width = 115;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost (AUD) / EA";
            this.cost.Name = "cost";
            this.cost.Width = 149;
            // 
            // stock_code
            // 
            this.stock_code.DataPropertyName = "stock_code";
            this.stock_code.HeaderText = "Stock Code";
            this.stock_code.Name = "stock_code";
            this.stock_code.Width = 119;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.Width = 72;
            // 
            // visibility_image
            // 
            this.visibility_image.HeaderText = "Visibility";
            this.visibility_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.visibility_image.Name = "visibility_image";
            this.visibility_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.visibility_image.Width = 77;
            // 
            // editable_image
            // 
            this.editable_image.HeaderText = "Editable";
            this.editable_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editable_image.Name = "editable_image";
            this.editable_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editable_image.Width = 75;
            // 
            // stockType
            // 
            this.stockType.HeaderText = "Stock Type";
            this.stockType.Name = "stockType";
            // 
            // stockCode
            // 
            this.stockCode.HeaderText = "Stock Code";
            this.stockCode.Name = "stockCode";
            // 
            // l_material
            // 
            this.l_material.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_material.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_material.Location = new System.Drawing.Point(416, 72);
            this.l_material.Name = "l_material";
            this.l_material.Size = new System.Drawing.Size(604, 78);
            this.l_material.TabIndex = 2;
            this.l_material.Text = "Material";
            this.l_material.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Depth = 0;
            this.btn_add.DrawShadows = true;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = global::LCC.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(7, 92);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(78, 36);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnImport
            // 
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImport.Depth = 0;
            this.btnImport.DrawShadows = true;
            this.btnImport.HighEmphasis = true;
            this.btnImport.Icon = global::LCC.Properties.Resources.import;
            this.btnImport.Location = new System.Drawing.Point(1304, 24);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnImport.Size = new System.Drawing.Size(104, 36);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnImport.UseAccentColor = false;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // StocksManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 549);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.l_material);
            this.Controls.Add(this.dt_stock);
            this.MaximizeBox = false;
            this.Name = "StocksManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.StocksManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCode;
        public System.Windows.Forms.Label l_material;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewImageColumn visibility_image;
        private System.Windows.Forms.DataGridViewImageColumn editable_image;
        private MaterialSkin.Controls.MaterialButton btnImport;
    }
}