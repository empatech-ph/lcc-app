
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
            this.btn_confirm = new MaterialSkin.Controls.MaterialButton();
            this.tb_licenseKey = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_productCode = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_confirm
            // 
            this.btn_confirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirm.Depth = 0;
            this.btn_confirm.DrawShadows = true;
            this.btn_confirm.HighEmphasis = true;
            this.btn_confirm.Icon = null;
            this.btn_confirm.Location = new System.Drawing.Point(247, 326);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(86, 36);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_confirm.UseAccentColor = false;
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tb_licenseKey
            // 
            this.tb_licenseKey.BackColor = System.Drawing.Color.White;
            this.tb_licenseKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_licenseKey.Depth = 0;
            this.tb_licenseKey.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_licenseKey.Location = new System.Drawing.Point(107, 241);
            this.tb_licenseKey.MaxLength = 50;
            this.tb_licenseKey.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_licenseKey.Multiline = false;
            this.tb_licenseKey.Name = "tb_licenseKey";
            this.tb_licenseKey.Size = new System.Drawing.Size(383, 50);
            this.tb_licenseKey.TabIndex = 2;
            this.tb_licenseKey.Text = "";
            // 
            // tb_productCode
            // 
            this.tb_productCode.BackColor = System.Drawing.Color.White;
            this.tb_productCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_productCode.Depth = 0;
            this.tb_productCode.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_productCode.Location = new System.Drawing.Point(107, 135);
            this.tb_productCode.MaxLength = 50;
            this.tb_productCode.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_productCode.Multiline = false;
            this.tb_productCode.Name = "tb_productCode";
            this.tb_productCode.Size = new System.Drawing.Size(383, 50);
            this.tb_productCode.TabIndex = 1;
            this.tb_productCode.Text = "";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(107, 219);
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
            this.materialLabel2.Location = new System.Drawing.Point(107, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "*New Password:";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 383);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_licenseKey);
            this.Controls.Add(this.tb_productCode);
            this.Controls.Add(this.materialLabel3);
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

        private MaterialSkin.Controls.MaterialButton btn_confirm;
        private MaterialSkin.Controls.MaterialTextBox tb_licenseKey;
        private MaterialSkin.Controls.MaterialTextBox tb_productCode;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}