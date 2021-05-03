
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
            this.title = new System.Windows.Forms.Label();
            this.forProdCode = new System.Windows.Forms.Label();
            this.forLicenseKey = new System.Windows.Forms.Label();
            this.tb_prodCode = new System.Windows.Forms.TextBox();
            this.tb_LicenseKey = new System.Windows.Forms.TextBox();
            this.btn_verify = new System.Windows.Forms.Button();
            this.forAllowedEmail = new System.Windows.Forms.Label();
            this.tb_allowedEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 25);
            this.title.TabIndex = 8;
            this.title.Text = "Key Verifier";
            // 
            // forProdCode
            // 
            this.forProdCode.AutoSize = true;
            this.forProdCode.Location = new System.Drawing.Point(51, 79);
            this.forProdCode.Name = "forProdCode";
            this.forProdCode.Size = new System.Drawing.Size(88, 15);
            this.forProdCode.TabIndex = 9;
            this.forProdCode.Text = "*Product Code:";
            // 
            // forLicenseKey
            // 
            this.forLicenseKey.AutoSize = true;
            this.forLicenseKey.Location = new System.Drawing.Point(63, 142);
            this.forLicenseKey.Name = "forLicenseKey";
            this.forLicenseKey.Size = new System.Drawing.Size(76, 15);
            this.forLicenseKey.TabIndex = 9;
            this.forLicenseKey.Text = "*License Key:";
            // 
            // tb_prodCode
            // 
            this.tb_prodCode.Location = new System.Drawing.Point(145, 76);
            this.tb_prodCode.Name = "tb_prodCode";
            this.tb_prodCode.Size = new System.Drawing.Size(219, 23);
            this.tb_prodCode.TabIndex = 1;
            // 
            // tb_LicenseKey
            // 
            this.tb_LicenseKey.Location = new System.Drawing.Point(145, 139);
            this.tb_LicenseKey.Name = "tb_LicenseKey";
            this.tb_LicenseKey.Size = new System.Drawing.Size(219, 23);
            this.tb_LicenseKey.TabIndex = 2;
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_verify.Location = new System.Drawing.Point(202, 193);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(95, 44);
            this.btn_verify.TabIndex = 3;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // forAllowedEmail
            // 
            this.forAllowedEmail.AutoSize = true;
            this.forAllowedEmail.Location = new System.Drawing.Point(49, 113);
            this.forAllowedEmail.Name = "forAllowedEmail";
            this.forAllowedEmail.Size = new System.Drawing.Size(90, 15);
            this.forAllowedEmail.TabIndex = 9;
            this.forAllowedEmail.Text = "*Allowed Email:";
            // 
            // tb_allowedEmail
            // 
            this.tb_allowedEmail.Location = new System.Drawing.Point(145, 110);
            this.tb_allowedEmail.Name = "tb_allowedEmail";
            this.tb_allowedEmail.Size = new System.Drawing.Size(219, 23);
            this.tb_allowedEmail.TabIndex = 2;
            // 
            // KeyVerifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 264);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.tb_allowedEmail);
            this.Controls.Add(this.tb_LicenseKey);
            this.Controls.Add(this.forAllowedEmail);
            this.Controls.Add(this.tb_prodCode);
            this.Controls.Add(this.forLicenseKey);
            this.Controls.Add(this.forProdCode);
            this.Controls.Add(this.title);
            this.Name = "KeyVerifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyVerifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label forProdCode;
        private System.Windows.Forms.Label forLicenseKey;
        private System.Windows.Forms.TextBox tb_prodCode;
        private System.Windows.Forms.TextBox tb_LicenseKey;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Label forAllowedEmail;
        private System.Windows.Forms.TextBox tb_allowedEmail;
    }
}