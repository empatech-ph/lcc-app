
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
            this.list = new System.Windows.Forms.DataGridViewButtonColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kerf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trim_left = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trim_right = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_remnant_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_material)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_material
            // 
            this.dt_material.AllowUserToAddRows = false;
            this.dt_material.AllowUserToResizeColumns = false;
            this.dt_material.AllowUserToResizeRows = false;
            this.dt_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_material.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.list,
            this.description,
            this.grade,
            this.kerf,
            this.trim_left,
            this.trim_right,
            this.part_allowance,
            this.min_remnant_length});
            this.dt_material.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_material.Location = new System.Drawing.Point(0, 100);
            this.dt_material.Name = "dt_material";
            this.dt_material.RowHeadersVisible = false;
            this.dt_material.RowTemplate.Height = 25;
            this.dt_material.Size = new System.Drawing.Size(898, 367);
            this.dt_material.TabIndex = 0;
            this.dt_material.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_material_CellEndEdit);
            this.dt_material.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dt_material_EditingControlShowing);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            dataGridViewCellStyle1.NullValue = null;
            this.no.DefaultCellStyle = dataGridViewCellStyle1;
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 45;
            // 
            // list
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Stock";
            this.list.DefaultCellStyle = dataGridViewCellStyle2;
            this.list.HeaderText = "List";
            this.list.MinimumWidth = 10;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.Width = 50;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.description.Width = 200;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grade.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kerf
            // 
            this.kerf.DataPropertyName = "kerf";
            dataGridViewCellStyle3.NullValue = null;
            this.kerf.DefaultCellStyle = dataGridViewCellStyle3;
            this.kerf.HeaderText = "Kerf (mm)";
            this.kerf.Name = "kerf";
            this.kerf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kerf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // 
            // min_remnant_length
            // 
            this.min_remnant_length.DataPropertyName = "min_remnant_length";
            this.min_remnant_length.HeaderText = "Min. Remnant Length (mm)";
            this.min_remnant_length.Name = "min_remnant_length";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Depth = 0;
            this.btn_add.DrawShadows = true;
            this.btn_add.HighEmphasis = true;
            this.btn_add.Icon = global::LCC.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(10, 55);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(153, 36);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add Material";
            this.btn_add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_add.UseAccentColor = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // MaterialComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dt_material);
            this.Name = "MaterialComponent";
            this.Size = new System.Drawing.Size(898, 467);
            ((System.ComponentModel.ISupportInitialize)(this.dt_material)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_material;
        private MaterialSkin.Controls.MaterialButton btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewButtonColumn list;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn kerf;
        private System.Windows.Forms.DataGridViewTextBoxColumn trim_left;
        private System.Windows.Forms.DataGridViewTextBoxColumn trim_right;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_remnant_length;
    }
}
