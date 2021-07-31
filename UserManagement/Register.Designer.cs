
namespace LCC.UserManagement
{
    partial class Register
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
            this.btn_register = new MaterialSkin.Controls.MaterialButton();
            this.tb_name = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_email = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tb_confirmPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.Depth = 0;
            this.btn_register.DrawShadows = true;
            this.btn_register.HighEmphasis = true;
            this.btn_register.Icon = null;
            this.btn_register.Location = new System.Drawing.Point(229, 472);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(89, 36);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_register.UseAccentColor = false;
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_name.Depth = 0;
            this.tb_name.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_name.Location = new System.Drawing.Point(101, 198);
            this.tb_name.MaxLength = 50;
            this.tb_name.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_name.Multiline = false;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(383, 50);
            this.tb_name.TabIndex = 2;
            this.tb_name.Text = "";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Depth = 0;
            this.tb_email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_email.Location = new System.Drawing.Point(101, 110);
            this.tb_email.MaxLength = 50;
            this.tb_email.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_email.Multiline = false;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(383, 50);
            this.tb_email.TabIndex = 1;
            this.tb_email.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(101, 176);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(50, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "*Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(101, 88);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "*Email";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(101, 272);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(78, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "*Password";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.White;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_password.Location = new System.Drawing.Point(101, 294);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(383, 50);
            this.tb_password.TabIndex = 4;
            this.tb_password.Text = "";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(101, 364);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(139, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "*Confirm Password";
            // 
            // tb_confirmPassword
            // 
            this.tb_confirmPassword.BackColor = System.Drawing.Color.White;
            this.tb_confirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_confirmPassword.Depth = 0;
            this.tb_confirmPassword.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_confirmPassword.Location = new System.Drawing.Point(101, 386);
            this.tb_confirmPassword.MaxLength = 50;
            this.tb_confirmPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_confirmPassword.Multiline = false;
            this.tb_confirmPassword.Name = "tb_confirmPassword";
            this.tb_confirmPassword.Password = true;
            this.tb_confirmPassword.Size = new System.Drawing.Size(383, 50);
            this.tb_confirmPassword.TabIndex = 5;
            this.tb_confirmPassword.Text = "";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 530);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_confirmPassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(563, 530);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_register;
        private MaterialSkin.Controls.MaterialTextBox tb_name;
        private MaterialSkin.Controls.MaterialTextBox tb_email;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox tb_confirmPassword;
    }
}