
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
            this.forNoOfUsersCanAccess = new System.Windows.Forms.Label();
            this.forLicenseKey = new System.Windows.Forms.Label();
            this.cb_noOfUserCanAccess = new System.Windows.Forms.ComboBox();
            this.tb_ownerName = new System.Windows.Forms.TextBox();
            this.tb_licenseKey = new System.Windows.Forms.TextBox();
            this.b_generate = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.tb_prodCode = new System.Windows.Forms.TextBox();
            this.forLicenseKeyLife = new System.Windows.Forms.Label();
            this.cb_licenseKeyLife = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // forOwnerName
            // 
            this.forOwnerName.AutoSize = true;
            this.forOwnerName.Location = new System.Drawing.Point(31, 75);
            this.forOwnerName.Name = "forOwnerName";
            this.forOwnerName.Size = new System.Drawing.Size(96, 15);
            this.forOwnerName.TabIndex = 0;
            this.forOwnerName.Text = "*Owner\'s Name: ";
            // 
            // forProductCode
            // 
            this.forProductCode.AutoSize = true;
            this.forProductCode.Location = new System.Drawing.Point(31, 162);
            this.forProductCode.Name = "forProductCode";
            this.forProductCode.Size = new System.Drawing.Size(96, 15);
            this.forProductCode.TabIndex = 0;
            this.forProductCode.Text = "*Product Codes: ";
            // 
            // forNoOfUsersCanAccess
            // 
            this.forNoOfUsersCanAccess.AutoSize = true;
            this.forNoOfUsersCanAccess.Location = new System.Drawing.Point(46, 104);
            this.forNoOfUsersCanAccess.Name = "forNoOfUsersCanAccess";
            this.forNoOfUsersCanAccess.Size = new System.Drawing.Size(74, 15);
            this.forNoOfUsersCanAccess.TabIndex = 0;
            this.forNoOfUsersCanAccess.Text = "Total Access:";
            // 
            // forLicenseKey
            // 
            this.forLicenseKey.AutoSize = true;
            this.forLicenseKey.Location = new System.Drawing.Point(49, 191);
            this.forLicenseKey.Name = "forLicenseKey";
            this.forLicenseKey.Size = new System.Drawing.Size(76, 15);
            this.forLicenseKey.TabIndex = 0;
            this.forLicenseKey.Text = "*License Key:";
            // 
            // cb_noOfUserCanAccess
            // 
            this.cb_noOfUserCanAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_noOfUserCanAccess.FormattingEnabled = true;
            this.cb_noOfUserCanAccess.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_noOfUserCanAccess.Location = new System.Drawing.Point(145, 101);
            this.cb_noOfUserCanAccess.Name = "cb_noOfUserCanAccess";
            this.cb_noOfUserCanAccess.Size = new System.Drawing.Size(197, 23);
            this.cb_noOfUserCanAccess.TabIndex = 2;
            // 
            // tb_ownerName
            // 
            this.tb_ownerName.Location = new System.Drawing.Point(146, 72);
            this.tb_ownerName.Name = "tb_ownerName";
            this.tb_ownerName.Size = new System.Drawing.Size(245, 23);
            this.tb_ownerName.TabIndex = 1;
            // 
            // tb_licenseKey
            // 
            this.tb_licenseKey.Location = new System.Drawing.Point(146, 188);
            this.tb_licenseKey.Name = "tb_licenseKey";
            this.tb_licenseKey.ReadOnly = true;
            this.tb_licenseKey.Size = new System.Drawing.Size(245, 23);
            this.tb_licenseKey.TabIndex = 5;
            // 
            // b_generate
            // 
            this.b_generate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.b_generate.Location = new System.Drawing.Point(145, 228);
            this.b_generate.Name = "b_generate";
            this.b_generate.Size = new System.Drawing.Size(108, 57);
            this.b_generate.TabIndex = 6;
            this.b_generate.Text = "Generate";
            this.b_generate.UseVisualStyleBackColor = false;
            this.b_generate.Click += new System.EventHandler(this.b_generate_Click);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.b_save.Location = new System.Drawing.Point(146, 291);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(245, 46);
            this.b_save.TabIndex = 10;
            this.b_save.Text = "Save";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(275, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(140, 25);
            this.title.TabIndex = 7;
            this.title.Text = "Key Generator";
            // 
            // tb_prodCode
            // 
            this.tb_prodCode.Location = new System.Drawing.Point(146, 159);
            this.tb_prodCode.Name = "tb_prodCode";
            this.tb_prodCode.ReadOnly = true;
            this.tb_prodCode.Size = new System.Drawing.Size(245, 23);
            this.tb_prodCode.TabIndex = 4;
            // 
            // forLicenseKeyLife
            // 
            this.forLicenseKeyLife.AutoSize = true;
            this.forLicenseKeyLife.Location = new System.Drawing.Point(27, 133);
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
            this.cb_licenseKeyLife.Location = new System.Drawing.Point(145, 130);
            this.cb_licenseKeyLife.Name = "cb_licenseKeyLife";
            this.cb_licenseKeyLife.Size = new System.Drawing.Size(192, 23);
            this.cb_licenseKeyLife.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Months";
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_verify.Location = new System.Drawing.Point(348, 354);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(70, 24);
            this.btn_verify.TabIndex = 10;
            this.btn_verify.Text = "Verifier";
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.b_save_Click);
            // 
            // KeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_generate);
            this.Controls.Add(this.tb_prodCode);
            this.Controls.Add(this.tb_licenseKey);
            this.Controls.Add(this.tb_ownerName);
            this.Controls.Add(this.cb_licenseKeyLife);
            this.Controls.Add(this.cb_noOfUserCanAccess);
            this.Controls.Add(this.forLicenseKey);
            this.Controls.Add(this.forLicenseKeyLife);
            this.Controls.Add(this.forProductCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forNoOfUsersCanAccess);
            this.Controls.Add(this.forOwnerName);
            this.Name = "KeyGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forOwnerName;
        private System.Windows.Forms.Label forProductCode;
        private System.Windows.Forms.Label forNoOfUsersCanAccess;
        private System.Windows.Forms.Label forLicenseKey;
        private System.Windows.Forms.ComboBox cb_noOfUserCanAccess;
        private System.Windows.Forms.TextBox tb_ownerName;
        private System.Windows.Forms.TextBox tb_licenseKey;
        private System.Windows.Forms.Button b_generate;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox tb_prodCode;
        private System.Windows.Forms.Label forLicenseKeyLife;
        private System.Windows.Forms.ComboBox cb_licenseKeyLife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_verify;
    }
}