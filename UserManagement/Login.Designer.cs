
namespace LCC.UserManagement
{
    partial class Login
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
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_email = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_enterlicense = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Depth = 0;
            this.btn_login.DrawShadows = true;
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(249, 323);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(64, 36);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Login";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(91, 247);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(383, 50);
            this.tb_password.TabIndex = 13;
            this.tb_password.Text = "";
            this.tb_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_email_KeyDown);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Depth = 0;
            this.tb_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(91, 158);
            this.tb_email.MaxLength = 50;
            this.tb_email.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_email.Multiline = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(383, 50);
            this.tb_email.TabIndex = 12;
            this.tb_email.Text = "";
            this.tb_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_email_KeyDown);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(91, 225);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Password";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(91, 136);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "*Email";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(43, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(488, 45);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Please login the associated email address/ users  with the provided\r\nlicense key." +
    "";
            this.materialLabel1.UseAccent = true;
            // 
            // btn_enterlicense
            // 
            this.btn_enterlicense.AutoSize = false;
            this.btn_enterlicense.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_enterlicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enterlicense.Depth = 0;
            this.btn_enterlicense.DrawShadows = true;
            this.btn_enterlicense.HighEmphasis = true;
            this.btn_enterlicense.Icon = null;
            this.btn_enterlicense.Location = new System.Drawing.Point(391, 367);
            this.btn_enterlicense.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_enterlicense.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_enterlicense.Name = "btn_enterlicense";
            this.btn_enterlicense.Size = new System.Drawing.Size(155, 21);
            this.btn_enterlicense.TabIndex = 14;
            this.btn_enterlicense.Text = "Enter new license";
            this.btn_enterlicense.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_enterlicense.UseAccentColor = false;
            this.btn_enterlicense.UseVisualStyleBackColor = true;
            this.btn_enterlicense.Click += new System.EventHandler(this.btn_enterlicense_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 397);
            this.Controls.Add(this.btn_enterlicense);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(553, 397);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_login;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private MaterialSkin.Controls.MaterialTextBox tb_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_enterlicense;
    }
}