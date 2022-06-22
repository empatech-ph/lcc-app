
namespace LCC
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.symbolDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.decimalLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sampleTxt = new System.Windows.Forms.Label();
            this.sampleLbl = new System.Windows.Forms.Label();
            this.optionTab = new MaterialSkin.Controls.MaterialTabControl();
            this.measureTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trailingChkBtn = new System.Windows.Forms.CheckBox();
            this.leadingChkBtn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.unitDropdown = new System.Windows.Forms.ComboBox();
            this.unitLbl = new System.Windows.Forms.Label();
            this.precisionDropdown = new System.Windows.Forms.ComboBox();
            this.precisionLbl = new System.Windows.Forms.Label();
            this.typeDropdown = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.formatText = new System.Windows.Forms.Label();
            this.formatMaxLengthLbl = new System.Windows.Forms.Label();
            this.costTab = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.optOkBtn = new MaterialSkin.Controls.MaterialButton();
            this.cancelOptBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel3.SuspendLayout();
            this.optionTab.SuspendLayout();
            this.measureTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.costTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // symbolDropdown
            // 
            this.symbolDropdown.FormattingEnabled = true;
            this.symbolDropdown.Location = new System.Drawing.Point(70, 111);
            this.symbolDropdown.Name = "symbolDropdown";
            this.symbolDropdown.Size = new System.Drawing.Size(310, 23);
            this.symbolDropdown.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Symbol:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 85);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(59, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // decimalLbl
            // 
            this.decimalLbl.AutoSize = true;
            this.decimalLbl.Location = new System.Drawing.Point(14, 87);
            this.decimalLbl.Name = "decimalLbl";
            this.decimalLbl.Size = new System.Drawing.Size(89, 15);
            this.decimalLbl.TabIndex = 4;
            this.decimalLbl.Text = "Decimal Places:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sampleTxt);
            this.panel3.Controls.Add(this.sampleLbl);
            this.panel3.Location = new System.Drawing.Point(14, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 57);
            this.panel3.TabIndex = 2;
            // 
            // sampleTxt
            // 
            this.sampleTxt.AutoSize = true;
            this.sampleTxt.Location = new System.Drawing.Point(24, 28);
            this.sampleTxt.Name = "sampleTxt";
            this.sampleTxt.Size = new System.Drawing.Size(25, 15);
            this.sampleTxt.TabIndex = 3;
            this.sampleTxt.Text = "n/a";
            // 
            // sampleLbl
            // 
            this.sampleLbl.AutoSize = true;
            this.sampleLbl.Location = new System.Drawing.Point(13, 9);
            this.sampleLbl.Name = "sampleLbl";
            this.sampleLbl.Size = new System.Drawing.Size(49, 15);
            this.sampleLbl.TabIndex = 2;
            this.sampleLbl.Text = "Sample:";
            // 
            // optionTab
            // 
            this.optionTab.Controls.Add(this.measureTab);
            this.optionTab.Controls.Add(this.costTab);
            this.optionTab.Depth = 0;
            this.optionTab.Location = new System.Drawing.Point(10, 92);
            this.optionTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionTab.Multiline = true;
            this.optionTab.Name = "optionTab";
            this.optionTab.SelectedIndex = 0;
            this.optionTab.Size = new System.Drawing.Size(482, 379);
            this.optionTab.TabIndex = 1;
            // 
            // measureTab
            // 
            this.measureTab.Controls.Add(this.label3);
            this.measureTab.Controls.Add(this.panel1);
            this.measureTab.Location = new System.Drawing.Point(4, 24);
            this.measureTab.Name = "measureTab";
            this.measureTab.Padding = new System.Windows.Forms.Padding(3);
            this.measureTab.Size = new System.Drawing.Size(474, 351);
            this.measureTab.TabIndex = 0;
            this.measureTab.Text = "Measurement Unit";
            this.measureTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Length Format";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.unitDropdown);
            this.panel1.Controls.Add(this.unitLbl);
            this.panel1.Controls.Add(this.precisionDropdown);
            this.panel1.Controls.Add(this.precisionLbl);
            this.panel1.Controls.Add(this.typeDropdown);
            this.panel1.Controls.Add(this.typeLbl);
            this.panel1.Controls.Add(this.formatText);
            this.panel1.Controls.Add(this.formatMaxLengthLbl);
            this.panel1.Location = new System.Drawing.Point(19, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 287);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.trailingChkBtn);
            this.panel2.Controls.Add(this.leadingChkBtn);
            this.panel2.Location = new System.Drawing.Point(46, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 71);
            this.panel2.TabIndex = 10;
            // 
            // trailingChkBtn
            // 
            this.trailingChkBtn.AutoSize = true;
            this.trailingChkBtn.Enabled = false;
            this.trailingChkBtn.Location = new System.Drawing.Point(14, 34);
            this.trailingChkBtn.Name = "trailingChkBtn";
            this.trailingChkBtn.Size = new System.Drawing.Size(64, 19);
            this.trailingChkBtn.TabIndex = 12;
            this.trailingChkBtn.Text = "Trailing";
            this.trailingChkBtn.UseVisualStyleBackColor = true;
            // 
            // leadingChkBtn
            // 
            this.leadingChkBtn.AutoSize = true;
            this.leadingChkBtn.Enabled = false;
            this.leadingChkBtn.Location = new System.Drawing.Point(14, 9);
            this.leadingChkBtn.Name = "leadingChkBtn";
            this.leadingChkBtn.Size = new System.Drawing.Size(68, 19);
            this.leadingChkBtn.TabIndex = 11;
            this.leadingChkBtn.Text = "Leading";
            this.leadingChkBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zero Suppression";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unitDropdown
            // 
            this.unitDropdown.FormattingEnabled = true;
            this.unitDropdown.Items.AddRange(new object[] {
            "",
            "mm",
            "cm",
            "dm",
            "m"});
            this.unitDropdown.Location = new System.Drawing.Point(268, 133);
            this.unitDropdown.Name = "unitDropdown";
            this.unitDropdown.Size = new System.Drawing.Size(87, 23);
            this.unitDropdown.TabIndex = 8;
            // 
            // unitLbl
            // 
            this.unitLbl.AutoSize = true;
            this.unitLbl.Location = new System.Drawing.Point(230, 138);
            this.unitLbl.Name = "unitLbl";
            this.unitLbl.Size = new System.Drawing.Size(32, 15);
            this.unitLbl.TabIndex = 7;
            this.unitLbl.Text = "Unit:";
            this.unitLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precisionDropdown
            // 
            this.precisionDropdown.FormattingEnabled = true;
            this.precisionDropdown.Items.AddRange(new object[] {
            "1",
            "0.1",
            "0.01",
            "0.001",
            "0.0001",
            "0.00001",
            "0.000001"});
            this.precisionDropdown.Location = new System.Drawing.Point(202, 104);
            this.precisionDropdown.Name = "precisionDropdown";
            this.precisionDropdown.Size = new System.Drawing.Size(153, 23);
            this.precisionDropdown.TabIndex = 6;
            // 
            // precisionLbl
            // 
            this.precisionLbl.AutoSize = true;
            this.precisionLbl.Location = new System.Drawing.Point(143, 107);
            this.precisionLbl.Name = "precisionLbl";
            this.precisionLbl.Size = new System.Drawing.Size(58, 15);
            this.precisionLbl.TabIndex = 5;
            this.precisionLbl.Text = "Precision:";
            this.precisionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeDropdown
            // 
            this.typeDropdown.FormattingEnabled = true;
            this.typeDropdown.Items.AddRange(new object[] {
            "Decimal",
            "Feet and Decimal Inches",
            "Fractional",
            "Feet and Fractional Inches"});
            this.typeDropdown.Location = new System.Drawing.Point(100, 70);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.Size = new System.Drawing.Size(251, 23);
            this.typeDropdown.TabIndex = 4;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(60, 73);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(34, 15);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Type:";
            this.typeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatText
            // 
            this.formatText.AutoSize = true;
            this.formatText.Location = new System.Drawing.Point(232, 43);
            this.formatText.Name = "formatText";
            this.formatText.Size = new System.Drawing.Size(25, 15);
            this.formatText.TabIndex = 2;
            this.formatText.Text = "n/a";
            this.formatText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formatMaxLengthLbl
            // 
            this.formatMaxLengthLbl.AutoSize = true;
            this.formatMaxLengthLbl.Location = new System.Drawing.Point(191, 18);
            this.formatMaxLengthLbl.Name = "formatMaxLengthLbl";
            this.formatMaxLengthLbl.Size = new System.Drawing.Size(113, 15);
            this.formatMaxLengthLbl.TabIndex = 1;
            this.formatMaxLengthLbl.Text = "Format/Max Length";
            // 
            // costTab
            // 
            this.costTab.Controls.Add(this.symbolDropdown);
            this.costTab.Controls.Add(this.panel3);
            this.costTab.Controls.Add(this.label2);
            this.costTab.Controls.Add(this.decimalLbl);
            this.costTab.Controls.Add(this.numericUpDown1);
            this.costTab.Location = new System.Drawing.Point(4, 24);
            this.costTab.Name = "costTab";
            this.costTab.Padding = new System.Windows.Forms.Padding(3);
            this.costTab.Size = new System.Drawing.Size(474, 351);
            this.costTab.TabIndex = 1;
            this.costTab.Text = "Cost Unit";
            this.costTab.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.optionTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(-6, 63);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(519, 23);
            this.materialTabSelector1.TabIndex = 2;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // optOkBtn
            // 
            this.optOkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optOkBtn.Depth = 0;
            this.optOkBtn.DrawShadows = true;
            this.optOkBtn.HighEmphasis = true;
            this.optOkBtn.Icon = null;
            this.optOkBtn.Location = new System.Drawing.Point(333, 477);
            this.optOkBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optOkBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.optOkBtn.Name = "optOkBtn";
            this.optOkBtn.Size = new System.Drawing.Size(41, 36);
            this.optOkBtn.TabIndex = 3;
            this.optOkBtn.Text = "Ok";
            this.optOkBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.optOkBtn.UseAccentColor = false;
            this.optOkBtn.UseVisualStyleBackColor = true;
            this.optOkBtn.Click += new System.EventHandler(this.optOkBtn_Click);
            // 
            // cancelOptBtn
            // 
            this.cancelOptBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelOptBtn.Depth = 0;
            this.cancelOptBtn.DrawShadows = true;
            this.cancelOptBtn.HighEmphasis = true;
            this.cancelOptBtn.Icon = null;
            this.cancelOptBtn.Location = new System.Drawing.Point(387, 477);
            this.cancelOptBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelOptBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelOptBtn.Name = "cancelOptBtn";
            this.cancelOptBtn.Size = new System.Drawing.Size(77, 36);
            this.cancelOptBtn.TabIndex = 4;
            this.cancelOptBtn.Text = "Cancel";
            this.cancelOptBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelOptBtn.UseAccentColor = false;
            this.cancelOptBtn.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 522);
            this.Controls.Add(this.cancelOptBtn);
            this.Controls.Add(this.optOkBtn);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.optionTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.optionTab.ResumeLayout(false);
            this.measureTab.ResumeLayout(false);
            this.measureTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.costTab.ResumeLayout(false);
            this.costTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label sampleTxt;
        private System.Windows.Forms.Label sampleLbl;
        private System.Windows.Forms.Label decimalLbl;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox symbolDropdown;
        private MaterialSkin.Controls.MaterialTabControl optionTab;
        private System.Windows.Forms.TabPage measureTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox trailingChkBtn;
        private System.Windows.Forms.CheckBox leadingChkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox unitDropdown;
        private System.Windows.Forms.Label unitLbl;
        private System.Windows.Forms.ComboBox precisionDropdown;
        private System.Windows.Forms.Label precisionLbl;
        private System.Windows.Forms.ComboBox typeDropdown;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label formatText;
        private System.Windows.Forms.Label formatMaxLengthLbl;
        private System.Windows.Forms.TabPage costTab;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialButton optOkBtn;
        private MaterialSkin.Controls.MaterialButton cancelOptBtn;
    }
}