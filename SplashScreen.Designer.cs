
namespace LCC
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_currentLoggedUser = new System.Windows.Forms.Label();
            this.l_licenseCode = new System.Windows.Forms.Label();
            this.l_currentLogged = new System.Windows.Forms.Label();
            this.l_appStatus = new System.Windows.Forms.Label();
            this.l_AppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressContainer = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.progressContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.l_currentLoggedUser);
            this.panel1.Controls.Add(this.l_licenseCode);
            this.panel1.Controls.Add(this.l_currentLogged);
            this.panel1.Controls.Add(this.l_appStatus);
            this.panel1.Controls.Add(this.l_AppName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 295);
            this.panel1.TabIndex = 0;
            // 
            // l_currentLoggedUser
            // 
            this.l_currentLoggedUser.Location = new System.Drawing.Point(344, 246);
            this.l_currentLoggedUser.Name = "l_currentLoggedUser";
            this.l_currentLoggedUser.Size = new System.Drawing.Size(137, 15);
            this.l_currentLoggedUser.TabIndex = 4;
            this.l_currentLoggedUser.Text = "None";
            this.l_currentLoggedUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_licenseCode
            // 
            this.l_licenseCode.AutoSize = true;
            this.l_licenseCode.Location = new System.Drawing.Point(14, 246);
            this.l_licenseCode.Name = "l_licenseCode";
            this.l_licenseCode.Size = new System.Drawing.Size(35, 15);
            this.l_licenseCode.TabIndex = 4;
            this.l_licenseCode.Text = "Code";
            // 
            // l_currentLogged
            // 
            this.l_currentLogged.AutoSize = true;
            this.l_currentLogged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_currentLogged.Location = new System.Drawing.Point(395, 228);
            this.l_currentLogged.Name = "l_currentLogged";
            this.l_currentLogged.Size = new System.Drawing.Size(86, 15);
            this.l_currentLogged.TabIndex = 3;
            this.l_currentLogged.Text = "Current Login:";
            // 
            // l_appStatus
            // 
            this.l_appStatus.AutoSize = true;
            this.l_appStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_appStatus.Location = new System.Drawing.Point(14, 228);
            this.l_appStatus.Name = "l_appStatus";
            this.l_appStatus.Size = new System.Drawing.Size(134, 15);
            this.l_appStatus.TabIndex = 3;
            this.l_appStatus.Text = "Licensed or Unlicensed";
            // 
            // l_AppName
            // 
            this.l_AppName.AutoSize = true;
            this.l_AppName.BackColor = System.Drawing.Color.White;
            this.l_AppName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l_AppName.Location = new System.Drawing.Point(172, 142);
            this.l_AppName.Name = "l_AppName";
            this.l_AppName.Size = new System.Drawing.Size(141, 29);
            this.l_AppName.TabIndex = 0;
            this.l_AppName.Text = "LinearCut 1D";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LCC.Properties.Resources._183331897_150351457100256_4252464618922505131_n;
            this.pictureBox1.Location = new System.Drawing.Point(154, -55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 286);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // progressContainer
            // 
            this.progressContainer.BackColor = System.Drawing.Color.White;
            this.progressContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressContainer.Controls.Add(this.progressBar);
            this.progressContainer.Location = new System.Drawing.Point(26, 195);
            this.progressContainer.Name = "progressContainer";
            this.progressContainer.Size = new System.Drawing.Size(467, 22);
            this.progressContainer.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(97)))), ((int)(((byte)(143)))));
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(10, 22);
            this.progressBar.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(518, 318);
            this.Controls.Add(this.progressContainer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(518, 318);
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.progressContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel progressContainer;
        private System.Windows.Forms.Label l_AppName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel progressBar;
        private System.Windows.Forms.Label l_licenseCode;
        private System.Windows.Forms.Label l_appStatus;
        private System.Windows.Forms.Label l_currentLoggedUser;
        private System.Windows.Forms.Label l_currentLogged;
        private System.Windows.Forms.Timer timer1;
    }
}