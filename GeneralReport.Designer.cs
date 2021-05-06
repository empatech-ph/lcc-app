
namespace LCC
{
    partial class GeneralReport
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
            this.generateReportBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.AutoSize = false;
            this.generateReportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateReportBtn.Depth = 0;
            this.generateReportBtn.DrawShadows = true;
            this.generateReportBtn.HighEmphasis = true;
            this.generateReportBtn.Icon = null;
            this.generateReportBtn.Location = new System.Drawing.Point(371, 85);
            this.generateReportBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generateReportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(167, 49);
            this.generateReportBtn.TabIndex = 0;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generateReportBtn.UseAccentColor = false;
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(28, 85);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(336, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            // 
            // GeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 175);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.generateReportBtn);
            this.Name = "GeneralReport";
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.GeneralReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton generateBtn;
        private MaterialSkin.Controls.MaterialButton generateReportBtn;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}