
namespace LCC.UserManagement
{
    partial class ChangePassword
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
            this.btn_change = new MaterialSkin.Controls.MaterialButton();
            this.tb_confirmPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.l_email = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_change
            // 
            this.btn_change.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_change.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_change.Depth = 0;
            this.btn_change.DrawShadows = true;
            this.btn_change.HighEmphasis = true;
            this.btn_change.Icon = null;
            this.btn_change.Location = new System.Drawing.Point(247, 332);
            this.btn_change.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_change.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(80, 36);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "Change";
            this.btn_change.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_change.UseAccentColor = false;
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.BackColor = System.Drawing.Color.White;
            this.tb_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirmPassword.Depth = 0;
            this.tb_confirmPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_confirmPassword.Location = new System.Drawing.Point(105, 262);
            this.tb_confirmPassword.MaxLength = 50;
            this.tb_confirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_confirmPassword.Multiline = false;
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Password = true;
            this.tb_confirmPassword.Size = new System.Drawing.Size(383, 50);
            this.tb_confirmPassword.TabIndex = 2;
            this.tb_confirmPassword.Text = "";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(105, 156);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(383, 50);
            this.tb_password.TabIndex = 1;
            this.tb_password.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(105, 240);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(178, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "*Confirm New Password:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(105, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "*New Password:";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Depth = 0;
            this.l_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.l_email.Location = new System.Drawing.Point(51, 87);
            this.l_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(41, 19);
            this.l_email.TabIndex = 5;
            this.l_email.Text = "Email";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 383);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.tb_confirmPassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.materialLabel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 383);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_change;
        private MaterialSkin.Controls.MaterialTextBox tb_confirmPassword;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel l_email;
    }
}