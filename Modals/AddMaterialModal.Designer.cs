
namespace LCC.Modals
{
    partial class AddMaterialModal
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
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.tb_description = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_grade = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_kerf = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_trim_left = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_trim_right = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_partial_allowance = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_min_remnant = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.DrawShadows = true;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(227, 325);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 36);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_description
            // 
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Depth = 0;
            this.tb_description.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_description.Hint = "Description*";
            this.tb_description.Location = new System.Drawing.Point(32, 90);
            this.tb_description.MaxLength = 50;
            this.tb_description.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_description.Multiline = false;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(230, 50);
            this.tb_description.TabIndex = 1;
            this.tb_description.Text = "";
            // 
            // tb_grade
            // 
            this.tb_grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_grade.Depth = 0;
            this.tb_grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_grade.Hint = "Grade";
            this.tb_grade.Location = new System.Drawing.Point(279, 90);
            this.tb_grade.MaxLength = 50;
            this.tb_grade.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_grade.Multiline = false;
            this.tb_grade.Name = "tb_grade";
            this.tb_grade.Size = new System.Drawing.Size(230, 50);
            this.tb_grade.TabIndex = 1;
            this.tb_grade.Text = "";
            // 
            // tb_kerf
            // 
            this.tb_kerf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_kerf.Depth = 0;
            this.tb_kerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_kerf.Hint = "Kerf (mm)";
            this.tb_kerf.Location = new System.Drawing.Point(32, 164);
            this.tb_kerf.MaxLength = 50;
            this.tb_kerf.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_kerf.Multiline = false;
            this.tb_kerf.Name = "tb_kerf";
            this.tb_kerf.Size = new System.Drawing.Size(143, 50);
            this.tb_kerf.TabIndex = 1;
            this.tb_kerf.Text = "0.00";
            // 
            // tb_trim_left
            // 
            this.tb_trim_left.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_trim_left.Depth = 0;
            this.tb_trim_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_trim_left.Hint = "Trim Left (mm)";
            this.tb_trim_left.Location = new System.Drawing.Point(192, 164);
            this.tb_trim_left.MaxLength = 50;
            this.tb_trim_left.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_trim_left.Multiline = false;
            this.tb_trim_left.Name = "tb_trim_left";
            this.tb_trim_left.Size = new System.Drawing.Size(145, 50);
            this.tb_trim_left.TabIndex = 1;
            this.tb_trim_left.Text = "0.00";
            // 
            // tb_trim_right
            // 
            this.tb_trim_right.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_trim_right.Depth = 0;
            this.tb_trim_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_trim_right.Hint = "Trim Right (mm)";
            this.tb_trim_right.Location = new System.Drawing.Point(358, 164);
            this.tb_trim_right.MaxLength = 50;
            this.tb_trim_right.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_trim_right.Multiline = false;
            this.tb_trim_right.Name = "tb_trim_right";
            this.tb_trim_right.Size = new System.Drawing.Size(151, 50);
            this.tb_trim_right.TabIndex = 1;
            this.tb_trim_right.Text = "0.00";
            // 
            // tb_partial_allowance
            // 
            this.tb_partial_allowance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_partial_allowance.Depth = 0;
            this.tb_partial_allowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_partial_allowance.Hint = "Partial Allowance (mm)";
            this.tb_partial_allowance.Location = new System.Drawing.Point(32, 245);
            this.tb_partial_allowance.MaxLength = 50;
            this.tb_partial_allowance.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_partial_allowance.Multiline = false;
            this.tb_partial_allowance.Name = "tb_partial_allowance";
            this.tb_partial_allowance.Size = new System.Drawing.Size(230, 50);
            this.tb_partial_allowance.TabIndex = 1;
            this.tb_partial_allowance.Text = "0.00";
            // 
            // tb_min_remnant
            // 
            this.tb_min_remnant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_min_remnant.Depth = 0;
            this.tb_min_remnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_min_remnant.Hint = "Min. Remnant Length (mm)";
            this.tb_min_remnant.Location = new System.Drawing.Point(279, 245);
            this.tb_min_remnant.MaxLength = 50;
            this.tb_min_remnant.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_min_remnant.Multiline = false;
            this.tb_min_remnant.Name = "tb_min_remnant";
            this.tb_min_remnant.Size = new System.Drawing.Size(230, 50);
            this.tb_min_remnant.TabIndex = 1;
            this.tb_min_remnant.Text = "0.00";
            // 
            // AddMaterialModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 392);
            this.Controls.Add(this.tb_min_remnant);
            this.Controls.Add(this.tb_partial_allowance);
            this.Controls.Add(this.tb_trim_right);
            this.Controls.Add(this.tb_trim_left);
            this.Controls.Add(this.tb_kerf);
            this.Controls.Add(this.tb_grade);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.btn_save);
            this.MaximizeBox = false;
            this.Name = "AddMaterialModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox tb_description;
        private MaterialSkin.Controls.MaterialTextBox tb_grade;
        private MaterialSkin.Controls.MaterialTextBox tb_kerf;
        private MaterialSkin.Controls.MaterialTextBox tb_trim_left;
        private MaterialSkin.Controls.MaterialTextBox tb_trim_right;
        private MaterialSkin.Controls.MaterialTextBox tb_partial_allowance;
        private MaterialSkin.Controls.MaterialTextBox tb_min_remnant;
    }
}