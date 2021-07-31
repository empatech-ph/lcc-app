
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
            this.dt_stock = new System.Windows.Forms.DataGridView();
            this.stockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_material = new MaterialSkin.Controls.MaterialLabel();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibility_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.editable_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.remove_image = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_stock
            // 
            this.dt_stock.AllowUserToAddRows = false;
            this.dt_stock.AllowUserToDeleteRows = false;
            this.dt_stock.AllowUserToResizeColumns = false;
            this.dt_stock.AllowUserToResizeRows = false;
            this.dt_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qty,
            this.length,
            this.stock_type,
            this.cost,
            this.stock_code,
            this.note,
            this.visibility_image,
            this.editable_image,
            this.remove_image});
            this.dt_stock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_stock.Location = new System.Drawing.Point(3, 156);
            this.dt_stock.Name = "dt_stock";
            this.dt_stock.RowHeadersVisible = false;
            this.dt_stock.RowTemplate.Height = 25;
            this.dt_stock.Size = new System.Drawing.Size(975, 390);
            this.dt_stock.TabIndex = 4;
            this.dt_stock.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dt_stock_CellBeginEdit);
            this.dt_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCellClick);
            this.dt_stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCellClick);
            this.dt_stock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_stock_CellDoubleClick);
            this.dt_stock.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_stock_CellEndEdit);
            this.dt_stock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_stock_CellFormatting);
            this.dt_stock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dt_stock_DataBindingComplete);
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
            this.l_material.Depth = 0;
            this.l_material.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_material.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.l_material.Location = new System.Drawing.Point(195, 74);
            this.l_material.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_material.Name = "l_material";
            this.l_material.Size = new System.Drawing.Size(604, 58);
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
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.qty.Width = 60;
            // 
            // length
            // 
            this.length.DataPropertyName = "length";
            this.length.HeaderText = "Length (mm)";
            this.length.Name = "length";
            this.length.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.length.Width = 120;
            // 
            // stock_type
            // 
            this.stock_type.DataPropertyName = "stock_type";
            this.stock_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_type.HeaderText = "Stock Type";
            this.stock_type.Name = "stock_type";
            this.stock_type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stock_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.stock_type.Width = 90;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost (AUD) / EA";
            this.cost.Name = "cost";
            this.cost.Width = 135;
            // 
            // stock_code
            // 
            this.stock_code.DataPropertyName = "stock_code";
            this.stock_code.HeaderText = "Stock Code";
            this.stock_code.Name = "stock_code";
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "Note";
            this.note.Name = "note";
            this.note.Width = 240;
            // 
            // visibility_image
            // 
            this.visibility_image.HeaderText = "Visibility";
            this.visibility_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.visibility_image.Name = "visibility_image";
            this.visibility_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.visibility_image.Width = 65;
            // 
            // editable_image
            // 
            this.editable_image.HeaderText = "Editable";
            this.editable_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editable_image.Name = "editable_image";
            this.editable_image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editable_image.Width = 65;
            // 
            // remove_image
            // 
            this.remove_image.HeaderText = "Delete";
            this.remove_image.Image = global::LCC.Properties.Resources.delete_bin_480px;
            this.remove_image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.remove_image.Name = "remove_image";
            this.remove_image.Width = 65;
            // 
            // StocksManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 549);
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
        public MaterialSkin.Controls.MaterialLabel l_material;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn length;
        private System.Windows.Forms.DataGridViewComboBoxColumn stock_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewImageColumn visibility_image;
        private System.Windows.Forms.DataGridViewImageColumn editable_image;
        private System.Windows.Forms.DataGridViewImageColumn remove_image;
    }
}