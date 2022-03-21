
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
            this.generateReportDropdown = new MaterialSkin.Controls.MaterialComboBox();
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
            // generateReportDropdown
            // 
            this.generateReportDropdown.AutoResize = false;
            this.generateReportDropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.generateReportDropdown.Depth = 0;
            this.generateReportDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.generateReportDropdown.DropDownHeight = 174;
            this.generateReportDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generateReportDropdown.DropDownWidth = 121;
            this.generateReportDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.generateReportDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateReportDropdown.FormattingEnabled = true;
            this.generateReportDropdown.IntegralHeight = false;
            this.generateReportDropdown.ItemHeight = 43;
            this.generateReportDropdown.Items.AddRange(new object[] {
            "Nesting Layout ",
            "Nesting Layout (Compressed)",
            "Material Quantity - Storage and Buyout",
            "Material Quantity - Remnants & Scraps",
            "Label - Parts / Cut Lengths",
            "Inventory List",
            "Commercial Lengths List"});
            this.generateReportDropdown.Location = new System.Drawing.Point(28, 85);
            this.generateReportDropdown.MaxDropDownItems = 4;
            this.generateReportDropdown.MouseState = MaterialSkin.MouseState.OUT;
            this.generateReportDropdown.Name = "generateReportDropdown";
            this.generateReportDropdown.Size = new System.Drawing.Size(336, 49);
            this.generateReportDropdown.StartIndex = 0;
            this.generateReportDropdown.TabIndex = 1;
            // 
            // GeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 168);
            this.Controls.Add(this.generateReportDropdown);
            this.Controls.Add(this.generateReportBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 168);
            this.MinimumSize = new System.Drawing.Size(549, 168);
            this.Name = "GeneralReport";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Reports";
            this.Load += new System.EventHandler(this.GeneralReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton generateBtn;
        private MaterialSkin.Controls.MaterialButton generateReportBtn;
        private MaterialSkin.Controls.MaterialComboBox generateReportDropdown;
    }
}