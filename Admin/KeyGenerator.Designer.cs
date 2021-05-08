
namespace LCC.Admin
{
    partial class KeyGenerator
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
            this.forOwnerName = new System.Windows.Forms.Label();
            this.forProductCode = new System.Windows.Forms.Label();
            this.forLicenseKey = new System.Windows.Forms.Label();
            this.tb_ownerName = new System.Windows.Forms.TextBox();
            this.tb_licenseKey = new System.Windows.Forms.TextBox();
            this.b_generate = new MaterialSkin.Controls.MaterialButton();
            this.b_save = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.tb_prodCode = new System.Windows.Forms.TextBox();
            this.forLicenseKeyLife = new System.Windows.Forms.Label();
            this.cb_licenseKeyLife = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_verify = new MaterialSkin.Controls.MaterialButton();
            this.forAllowedEmails = new System.Windows.Forms.Label();
            this.rt_allowedEmails = new System.Windows.Forms.RichTextBox();
            this.forOwnerEmail = new System.Windows.Forms.Label();
            this.tb_ownerEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // forOwnerName
            // 
            this.forOwnerName.AutoSize = true;
            this.forOwnerName.Location = new System.Drawing.Point(36, 79);
            this.forOwnerName.Name = "forOwnerName";
            this.forOwnerName.Size = new System.Drawing.Size(96, 15);
            this.forOwnerName.TabIndex = 0;
            this.forOwnerName.Text = "*Owner\'s Name: ";
            // 
            // forProductCode
            // 
            this.forProductCode.AutoSize = true;
            this.forProductCode.Location = new System.Drawing.Point(42, 269);
            this.forProductCode.Name = "forProductCode";
            this.forProductCode.Size = new System.Drawing.Size(91, 15);
            this.forProductCode.TabIndex = 0;
            this.forProductCode.Text = "*Product Code: ";
            // 
            // forLicenseKey
            // 
            this.forLicenseKey.AutoSize = true;
            this.forLicenseKey.Location = new System.Drawing.Point(55, 298);
            this.forLicenseKey.Name = "forLicenseKey";
            this.forLicenseKey.Size = new System.Drawing.Size(76, 15);
            this.forLicenseKey.TabIndex = 0;
            this.forLicenseKey.Text = "*License Key:";
            // 
            // tb_ownerName
            // 
            this.tb_ownerName.Location = new System.Drawing.Point(151, 76);
            this.tb_ownerName.Name = "tb_ownerName";
            this.tb_ownerName.Size = new System.Drawing.Size(289, 23);
            this.tb_ownerName.TabIndex = 1;
            // 
            // tb_licenseKey
            // 
            this.tb_licenseKey.Location = new System.Drawing.Point(152, 295);
            this.tb_licenseKey.Name = "tb_licenseKey";
            this.tb_licenseKey.ReadOnly = true;
            this.tb_licenseKey.Size = new System.Drawing.Size(288, 23);
            this.tb_licenseKey.TabIndex = 6;
            // 
            // b_generate
            // 
            this.b_generate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_generate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.b_generate.Depth = 0;
            this.b_generate.DrawShadows = true;
            this.b_generate.HighEmphasis = true;
            this.b_generate.Icon = null;
            this.b_generate.Location = new System.Drawing.Point(271, 337);
            this.b_generate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_generate.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(95, 36);
            this.b_generate.TabIndex = 8;
            this.b_generate.Text = "Generate";
            this.b_generate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.b_generate.UseAccentColor = false;
            this.b_generate.UseVisualStyleBackColor = false;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // b_save
            // 
            this.b_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_save.Depth = 0;
            this.b_save.DrawShadows = true;
            this.b_save.HighEmphasis = true;
            this.b_save.Icon = null;
            this.b_save.Location = new System.Drawing.Point(205, 337);
            this.b_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.b_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(58, 36);
            this.b_save.TabIndex = 7;
            this.b_save.Text = "Save";
            this.b_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.b_save.UseAccentColor = false;
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Depth = 0;
            this.button1.DrawShadows = true;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(374, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_prodCode
            // 
            this.tb_prodCode.Location = new System.Drawing.Point(152, 266);
            this.tb_prodCode.Name = "tb_prodCode";
            this.tb_prodCode.ReadOnly = true;
            this.tb_prodCode.Size = new System.Drawing.Size(288, 23);
            this.tb_prodCode.TabIndex = 5;
            // 
            // forLicenseKeyLife
            // 
            this.forLicenseKeyLife.AutoSize = true;
            this.forLicenseKeyLife.Location = new System.Drawing.Point(33, 145);
            this.forLicenseKeyLife.Name = "forLicenseKeyLife";
            this.forLicenseKeyLife.Size = new System.Drawing.Size(93, 15);
            this.forLicenseKeyLife.TabIndex = 0;
            this.forLicenseKeyLife.Text = "License Key Life:";
            // 
            // cb_licenseKeyLife
            // 
            this.cb_licenseKeyLife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_licenseKeyLife.FormattingEnabled = true;
            this.cb_licenseKeyLife.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12",
            "24"});
            this.cb_licenseKeyLife.Location = new System.Drawing.Point(151, 142);
            this.cb_licenseKeyLife.Name = "cb_licenseKeyLife";
            this.cb_licenseKeyLife.Size = new System.Drawing.Size(235, 23);
            this.cb_licenseKeyLife.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Months";
            // 
            // btn_verify
            // 
            this.btn_verify.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_verify.Depth = 0;
            this.btn_verify.DrawShadows = true;
            this.btn_verify.HighEmphasis = true;
            this.btn_verify.Icon = null;
            this.btn_verify.Location = new System.Drawing.Point(360, 388);
            this.btn_verify.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_verify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(83, 36);
            this.btn_verify.TabIndex = 10;
            this.btn_verify.Text = "Verifier";
            this.btn_verify.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_verify.UseAccentColor = false;
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // forAllowedEmails
            // 
            this.forAllowedEmails.AutoSize = true;
            this.forAllowedEmails.Location = new System.Drawing.Point(31, 177);
            this.forAllowedEmails.Name = "forAllowedEmails";
            this.forAllowedEmails.Size = new System.Drawing.Size(102, 30);
            this.forAllowedEmails.TabIndex = 11;
            this.forAllowedEmails.Text = "*Allowed Emails: \r\n(Separated with , )";
            // 
            // rt_allowedEmails
            // 
            this.rt_allowedEmails.Location = new System.Drawing.Point(151, 177);
            this.rt_allowedEmails.Name = "rt_allowedEmails";
            this.rt_allowedEmails.Size = new System.Drawing.Size(289, 83);
            this.rt_allowedEmails.TabIndex = 4;
            this.rt_allowedEmails.Text = "";
            // 
            // forOwnerEmail
            // 
            this.forOwnerEmail.AutoSize = true;
            this.forOwnerEmail.Location = new System.Drawing.Point(36, 108);
            this.forOwnerEmail.Name = "forOwnerEmail";
            this.forOwnerEmail.Size = new System.Drawing.Size(96, 15);
            this.forOwnerEmail.TabIndex = 0;
            this.forOwnerEmail.Text = "*Owner\'s Email:  ";
            // 
            // tb_ownerEmail
            // 
            this.tb_ownerEmail.Location = new System.Drawing.Point(151, 105);
            this.tb_ownerEmail.Name = "tb_ownerEmail";
            this.tb_ownerEmail.Size = new System.Drawing.Size(289, 23);
            this.tb_ownerEmail.TabIndex = 2;
            // 
            // KeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 438);
            this.Controls.Add(this.rt_allowedEmails);
            this.Controls.Add(this.forAllowedEmails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_generate);
            this.Controls.Add(this.tb_prodCode);
            this.Controls.Add(this.tb_licenseKey);
            this.Controls.Add(this.tb_ownerEmail);
            this.Controls.Add(this.tb_ownerName);
            this.Controls.Add(this.cb_licenseKeyLife);
            this.Controls.Add(this.forLicenseKey);
            this.Controls.Add(this.forLicenseKeyLife);
            this.Controls.Add(this.forOwnerEmail);
            this.Controls.Add(this.forProductCode);
            this.Controls.Add(this.forOwnerName);
            this.MaximizeBox = false;
            this.Name = "KeyGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forOwnerName;
        private System.Windows.Forms.Label forProductCode;
        private System.Windows.Forms.Label forLicenseKey;
        private System.Windows.Forms.TextBox tb_ownerName;
        private System.Windows.Forms.TextBox tb_licenseKey;
        private MaterialSkin.Controls.MaterialButton b_generate;
        private MaterialSkin.Controls.MaterialButton b_save;
        private MaterialSkin.Controls.MaterialButton button1;
        private System.Windows.Forms.TextBox tb_prodCode;
        private System.Windows.Forms.Label forLicenseKeyLife;
        private System.Windows.Forms.ComboBox cb_licenseKeyLife;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btn_verify;
        private System.Windows.Forms.Label forAllowedEmails;
        private System.Windows.Forms.RichTextBox rt_allowedEmails;
        private System.Windows.Forms.Label forOwnerEmail;
        private System.Windows.Forms.TextBox tb_ownerEmail;
    }
}