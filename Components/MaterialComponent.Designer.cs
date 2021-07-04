
namespace LCC.Components
{
    partial class MaterialComponent
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
            this.dt_material = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewButtonColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trim_left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trim_right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_remnant_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            this.btn_analyze = new MaterialSkin.Controls.MaterialButton();
            this.ST = new MaterialSkin.Controls.MaterialCheckbox();
            this.BO = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dt_material)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_material
            // 
            this.dt_material.AllowUserToAddRows = false;
            this.dt_material.AllowUserToResizeColumns = false;
            this.dt_material.AllowUserToResizeRows = false;
            this.dt_material.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dt_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.stock,
            this.description,
            this.grade,
            this.kerf,
            this.trim_left,
            this.trim_right,
            this.part_allowance,
            this.min_remnant_length});
            this.dt_material.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_material.Location = new System.Drawing.Point(0, 89);
            this.dt_material.Name = "dt_material";
            this.dt_material.RowHeadersVisible = false;
            this.dt_material.RowTemplate.Height = 25;
            this.dt_material.Size = new System.Drawing.Size(1080, 359);
            this.dt_material.TabIndex = 0;
            this.dt_material.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_material_CellClick);
            this.dt_material.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_material_CellEndEdit);
            this.dt_material.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dt_material_CellFormatting);
            this.dt_material.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dt_material_DataError);
            this.dt_material.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dt_material_EditingControlShowing);
            this.dt_material.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dt_material_RowsAdded);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle1.NullValue = null;
            this.no.DefaultCellStyle = dataGridViewCellStyle1;
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.Width = 40;
            // 
            // stock
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Stock";
            this.stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.stock.HeaderText = "List";
            this.stock.MinimumWidth = 10;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stock.Width = 80;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.description.Width = 200;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grade.Width = 200;
            // 
            // kerf
            // 
            this.kerf.DataPropertyName = "kerf";
            dataGridViewCellStyle3.NullValue = null;
            this.kerf.DefaultCellStyle = dataGridViewCellStyle3;
            this.kerf.HeaderText = "Kerf (mm)";
            this.kerf.Name = "kerf";
            this.kerf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // trim_left
            // 
            this.trim_left.DataPropertyName = "trim_left";
            this.trim_left.HeaderText = "Trim Left (mm)";
            this.trim_left.Name = "trim_left";
            // 
            // trim_right
            // 
            this.trim_right.DataPropertyName = "trim_right";
            this.trim_right.HeaderText = "Trim Right (mm)";
            this.trim_right.Name = "trim_right";
            // 
            // part_allowance
            // 
            this.part_allowance.DataPropertyName = "part_allowance";
            this.part_allowance.HeaderText = "Part Allowance (mm)";
            this.part_allowance.Name = "part_allowance";
            this.part_allowance.Width = 120;
            // 
            // min_remnant_length
            // 
            this.min_remnant_length.DataPropertyName = "min_remnant_length";
            this.min_remnant_length.HeaderText = "Min. Remnant Length (mm)";
            this.min_remnant_length.Name = "min_remnant_length";
            this.min_remnant_length.Width = 120;
            // 
            // btn_add
            // 
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Depth = 0;
            this.btn_add.DrawShadows = true;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = global::LCC.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(368, 9);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_add.Size = new System.Drawing.Size(78, 36);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_analyze
            // 
            this.btn_analyze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_analyze.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_analyze.Depth = 0;
            this.btn_analyze.DrawShadows = true;
            this.btn_analyze.HighEmphasis = true;
            this.btn_analyze.Icon = global::LCC.Properties.Resources.play;
            this.btn_analyze.Location = new System.Drawing.Point(454, 9);
            this.btn_analyze.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_analyze.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_analyze.Name = "btn_analyze";
            this.btn_analyze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_analyze.Size = new System.Drawing.Size(114, 36);
            this.btn_analyze.TabIndex = 1;
            this.btn_analyze.Text = "Analyze";
            this.btn_analyze.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_analyze.UseAccentColor = false;
            this.btn_analyze.UseVisualStyleBackColor = false;
            this.btn_analyze.Click += new System.EventHandler(this.btn_analyze_Click);
            // 
            // ST
            // 
            this.ST.AutoSize = true;
            this.ST.Checked = true;
            this.ST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ST.Depth = 0;
            this.ST.Location = new System.Drawing.Point(576, 8);
            this.ST.Margin = new System.Windows.Forms.Padding(0);
            this.ST.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ST.MouseState = MaterialSkin.MouseState.HOVER;
            this.ST.Name = "ST";
            this.ST.Ripple = true;
            this.ST.Size = new System.Drawing.Size(130, 37);
            this.ST.TabIndex = 2;
            this.ST.Text = "Use Inventory";
            this.ST.UseVisualStyleBackColor = true;
            // 
            // BO
            // 
            this.BO.AutoSize = true;
            this.BO.Checked = true;
            this.BO.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BO.Depth = 0;
            this.BO.Location = new System.Drawing.Point(720, 8);
            this.BO.Margin = new System.Windows.Forms.Padding(0);
            this.BO.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BO.MouseState = MaterialSkin.MouseState.HOVER;
            this.BO.Name = "BO";
            this.BO.Ripple = true;
            this.BO.Size = new System.Drawing.Size(233, 37);
            this.BO.TabIndex = 2;
            this.BO.Text = "Use Commercial Length List";
            this.BO.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(6, 13);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(164, 24);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Manage Materials";
            // 
            // MaterialComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.BO);
            this.Controls.Add(this.ST);
            this.Controls.Add(this.btn_analyze);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dt_material);
            this.Name = "MaterialComponent";
            this.Size = new System.Drawing.Size(1080, 448);
            ((System.ComponentModel.ISupportInitialize)(this.dt_material)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_add;
        private MaterialSkin.Controls.MaterialButton btn_analyze;
        private MaterialSkin.Controls.MaterialCheckbox ST;
        private MaterialSkin.Controls.MaterialCheckbox BO;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewButtonColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerf;
        private System.Windows.Forms.DataGridViewTextBoxColumn trim_left;
        private System.Windows.Forms.DataGridViewTextBoxColumn trim_right;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_remnant_length;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        public System.Windows.Forms.DataGridView dt_material;
    }
}
