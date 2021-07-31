
namespace LCC
{
    partial class BootEnterLicenseKey
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_productCode = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_licenseKey = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_proceed = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(479, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Please enter the License Key provided from our subscription service.";
            // 
            // tb_productCode
            // 
            this.tb_productCode.BackColor = System.Drawing.Color.White;
            this.tb_productCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_productCode.Depth = 0;
            this.tb_productCode.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_productCode.Location = new System.Drawing.Point(99, 168);
            this.tb_productCode.MaxLength = 50;
            this.tb_productCode.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_productCode.Multiline = false;
            this.tb_productCode.Name = "tb_productCode";
            this.tb_productCode.Size = new System.Drawing.Size(383, 50);
            this.tb_productCode.TabIndex = 1;
            this.tb_productCode.Text = "";
            this.tb_productCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_productCode_KeyDown);
            // 
            // tb_licenseKey
            // 
            this.tb_licenseKey.BackColor = System.Drawing.Color.White;
            this.tb_licenseKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_licenseKey.Depth = 0;
            this.tb_licenseKey.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_licenseKey.Location = new System.Drawing.Point(99, 274);
            this.tb_licenseKey.MaxLength = 50;
            this.tb_licenseKey.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_licenseKey.Multiline = false;
            this.tb_licenseKey.Name = "tb_licenseKey";
            this.tb_licenseKey.Size = new System.Drawing.Size(383, 50);
            this.tb_licenseKey.TabIndex = 2;
            this.tb_licenseKey.Text = "";
            this.tb_licenseKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_productCode_KeyDown);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(99, 146);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(103, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "*Product Code";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(99, 252);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "*License Key";
            // 
            // btn_proceed
            // 
            this.btn_proceed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proceed.Depth = 0;
            this.btn_proceed.DrawShadows = true;
            this.btn_proceed.HighEmphasis = true;
            this.btn_proceed.Icon = null;
            this.btn_proceed.Location = new System.Drawing.Point(239, 359);
            this.btn_proceed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_proceed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(86, 36);
            this.btn_proceed.TabIndex = 3;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_proceed.UseAccentColor = false;
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // BootEnterLicenseKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 426);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.tb_licenseKey);
            this.Controls.Add(this.tb_productCode);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 450);
            this.Name = "BootEnterLicenseKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to LenearCut1D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox tb_productCode;
        private MaterialSkin.Controls.MaterialTextBox tb_licenseKey;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btn_proceed;
    }
}