
namespace LCC.Admin
{
    partial class KeyVerifier
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
            this.forProdCode = new MaterialSkin.Controls.MaterialLabel();
            this.forLicenseKey = new MaterialSkin.Controls.MaterialLabel();
            this.tb_prodCode = new System.Windows.Forms.TextBox();
            this.tb_LicenseKey = new System.Windows.Forms.TextBox();
            this.btn_verify = new MaterialSkin.Controls.MaterialButton();
            this.forAllowedEmail = new MaterialSkin.Controls.MaterialLabel();
            this.tb_allowedEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // forProdCode
            // 
            this.forProdCode.AutoSize = true;
            this.forProdCode.Depth = 0;
            this.forProdCode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forProdCode.Location = new System.Drawing.Point(38, 90);
            this.forProdCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.forProdCode.Name = "forProdCode";
            this.forProdCode.Size = new System.Drawing.Size(107, 19);
            this.forProdCode.TabIndex = 9;
            this.forProdCode.Text = "*Product Code:";
            // 
            // forLicenseKey
            // 
            this.forLicenseKey.AutoSize = true;
            this.forLicenseKey.Depth = 0;
            this.forLicenseKey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forLicenseKey.Location = new System.Drawing.Point(50, 153);
            this.forLicenseKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.forLicenseKey.Name = "forLicenseKey";
            this.forLicenseKey.Size = new System.Drawing.Size(96, 19);
            this.forLicenseKey.TabIndex = 9;
            this.forLicenseKey.Text = "*License Key:";
            // 
            // tb_prodCode
            // 
            this.tb_prodCode.Location = new System.Drawing.Point(164, 88);
            this.tb_prodCode.Name = "tb_prodCode";
            this.tb_prodCode.Size = new System.Drawing.Size(299, 23);
            this.tb_prodCode.TabIndex = 1;
            // 
            // tb_LicenseKey
            // 
            this.tb_LicenseKey.Location = new System.Drawing.Point(164, 151);
            this.tb_LicenseKey.Name = "tb_LicenseKey";
            this.tb_LicenseKey.Size = new System.Drawing.Size(299, 23);
            this.tb_LicenseKey.TabIndex = 2;
            // 
            // btn_verify
            // 
            this.btn_verify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_verify.Depth = 0;
            this.btn_verify.DrawShadows = true;
            this.btn_verify.HighEmphasis = true;
            this.btn_verify.Icon = null;
            this.btn_verify.Location = new System.Drawing.Point(276, 194);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_verify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(70, 36);
            this.btn_verify.TabIndex = 3;
            this.btn_verify.Text = "Verify";
            this.btn_verify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_verify.UseAccentColor = false;
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // forAllowedEmail
            // 
            this.forAllowedEmail.AutoSize = true;
            this.forAllowedEmail.Depth = 0;
            this.forAllowedEmail.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.forAllowedEmail.Location = new System.Drawing.Point(36, 124);
            this.forAllowedEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.forAllowedEmail.Name = "forAllowedEmail";
            this.forAllowedEmail.Size = new System.Drawing.Size(112, 19);
            this.forAllowedEmail.TabIndex = 9;
            this.forAllowedEmail.Text = "*Allowed Email:";
            // 
            // tb_allowedEmail
            // 
            this.tb_allowedEmail.Location = new System.Drawing.Point(164, 122);
            this.tb_allowedEmail.Name = "tb_allowedEmail";
            this.tb_allowedEmail.Size = new System.Drawing.Size(299, 23);
            this.tb_allowedEmail.TabIndex = 2;
            // 
            // KeyVerifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 251);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.tb_allowedEmail);
            this.Controls.Add(this.tb_LicenseKey);
            this.Controls.Add(this.forAllowedEmail);
            this.Controls.Add(this.tb_prodCode);
            this.Controls.Add(this.forLicenseKey);
            this.Controls.Add(this.forProdCode);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(494, 264);
            this.Name = "KeyVerifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Verifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_prodCode;
        private System.Windows.Forms.TextBox tb_LicenseKey;
        private MaterialSkin.Controls.MaterialButton btn_verify;
        private System.Windows.Forms.TextBox tb_allowedEmail;
        private MaterialSkin.Controls.MaterialLabel forProdCode;
        private MaterialSkin.Controls.MaterialLabel forLicenseKey;
        private MaterialSkin.Controls.MaterialLabel forAllowedEmail;
    }
}