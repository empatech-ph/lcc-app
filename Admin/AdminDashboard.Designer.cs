
namespace LCC.Admin
{
    partial class AdminDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logoutBtn = new MaterialSkin.Controls.MaterialButton();
            this.dt_license = new System.Windows.Forms.DataGridView();
            this.license_product_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_license_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_owner_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_owner_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.license_is_active = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt_user = new System.Windows.Forms.DataGridView();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_is_active = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_keyGenerator = new MaterialSkin.Controls.MaterialButton();
            this.btn_verifier = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_reload = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dt_license)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_user)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = false;
            this.logoutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutBtn.Depth = 0;
            this.logoutBtn.DrawShadows = true;
            this.logoutBtn.HighEmphasis = true;
            this.logoutBtn.Icon = null;
            this.logoutBtn.Location = new System.Drawing.Point(975, 24);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logoutBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoutBtn.Size = new System.Drawing.Size(80, 36);
            this.logoutBtn.TabIndex = 18;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logoutBtn.UseAccentColor = false;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dt_license
            // 
            this.dt_license.AllowUserToAddRows = false;
            this.dt_license.AllowUserToDeleteRows = false;
            this.dt_license.AllowUserToResizeColumns = false;
            this.dt_license.AllowUserToResizeRows = false;
            this.dt_license.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_license.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_license.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_license.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.license_product_code,
            this.license_license_key,
            this.license_owner_name,
            this.license_owner_email,
            this.license_is_active});
            this.dt_license.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_license.Location = new System.Drawing.Point(0, 0);
            this.dt_license.Name = "dt_license";
            this.dt_license.ReadOnly = true;
            this.dt_license.RowHeadersVisible = false;
            this.dt_license.RowTemplate.Height = 25;
            this.dt_license.Size = new System.Drawing.Size(675, 369);
            this.dt_license.TabIndex = 19;
            this.dt_license.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_license_CellClick);
            this.dt_license.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dt_material_DataBindingComplete);
            // 
            // license_product_code
            // 
            this.license_product_code.DataPropertyName = "product_code";
            dataGridViewCellStyle2.NullValue = null;
            this.license_product_code.DefaultCellStyle = dataGridViewCellStyle2;
            this.license_product_code.HeaderText = "Prooduct Code";
            this.license_product_code.Name = "license_product_code";
            this.license_product_code.ReadOnly = true;
            this.license_product_code.Width = 150;
            // 
            // license_license_key
            // 
            this.license_license_key.DataPropertyName = "license_key";
            this.license_license_key.HeaderText = "License Key";
            this.license_license_key.Name = "license_license_key";
            this.license_license_key.ReadOnly = true;
            this.license_license_key.Width = 150;
            // 
            // license_owner_name
            // 
            this.license_owner_name.DataPropertyName = "owner_name";
            this.license_owner_name.HeaderText = "Owner Name";
            this.license_owner_name.Name = "license_owner_name";
            this.license_owner_name.ReadOnly = true;
            this.license_owner_name.Width = 150;
            // 
            // license_owner_email
            // 
            this.license_owner_email.DataPropertyName = "owner_email";
            this.license_owner_email.HeaderText = "Owner Email";
            this.license_owner_email.Name = "license_owner_email";
            this.license_owner_email.ReadOnly = true;
            this.license_owner_email.Width = 150;
            // 
            // license_is_active
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.license_is_active.DefaultCellStyle = dataGridViewCellStyle3;
            this.license_is_active.HeaderText = "Status";
            this.license_is_active.Image = global::LCC.Properties.Resources.checked_user_male_480px;
            this.license_is_active.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.license_is_active.Name = "license_is_active";
            this.license_is_active.ReadOnly = true;
            this.license_is_active.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 369);
            this.panel1.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dt_user);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(686, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 369);
            this.panel3.TabIndex = 1;
            // 
            // dt_user
            // 
            this.dt_user.AllowUserToAddRows = false;
            this.dt_user.AllowUserToDeleteRows = false;
            this.dt_user.AllowUserToResizeColumns = false;
            this.dt_user.AllowUserToResizeRows = false;
            this.dt_user.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_user.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_name,
            this.user_email,
            this.user_is_active});
            this.dt_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_user.Location = new System.Drawing.Point(0, 0);
            this.dt_user.Name = "dt_user";
            this.dt_user.ReadOnly = true;
            this.dt_user.RowHeadersVisible = false;
            this.dt_user.RowTemplate.Height = 25;
            this.dt_user.Size = new System.Drawing.Size(370, 369);
            this.dt_user.TabIndex = 20;
            this.dt_user.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dt_user_DataBindingComplete);
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "name";
            this.user_name.HeaderText = "Owner Name";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            this.user_name.Width = 150;
            // 
            // user_email
            // 
            this.user_email.DataPropertyName = "email";
            this.user_email.HeaderText = "Owner Email";
            this.user_email.Name = "user_email";
            this.user_email.ReadOnly = true;
            this.user_email.Width = 150;
            // 
            // user_is_active
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.user_is_active.DefaultCellStyle = dataGridViewCellStyle5;
            this.user_is_active.HeaderText = "Status";
            this.user_is_active.Image = global::LCC.Properties.Resources.checked_user_male_480px;
            this.user_is_active.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.user_is_active.Name = "user_is_active";
            this.user_is_active.ReadOnly = true;
            this.user_is_active.Width = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dt_license);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 369);
            this.panel2.TabIndex = 0;
            // 
            // btn_keyGenerator
            // 
            this.btn_keyGenerator.AutoSize = false;
            this.btn_keyGenerator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_keyGenerator.Depth = 0;
            this.btn_keyGenerator.DrawShadows = true;
            this.btn_keyGenerator.HighEmphasis = true;
            this.btn_keyGenerator.Icon = null;
            this.btn_keyGenerator.Location = new System.Drawing.Point(209, 24);
            this.btn_keyGenerator.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_keyGenerator.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_keyGenerator.Name = "btn_keyGenerator";
            this.btn_keyGenerator.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_keyGenerator.Size = new System.Drawing.Size(186, 36);
            this.btn_keyGenerator.TabIndex = 21;
            this.btn_keyGenerator.Text = "License Key generator";
            this.btn_keyGenerator.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_keyGenerator.UseAccentColor = false;
            this.btn_keyGenerator.UseVisualStyleBackColor = true;
            this.btn_keyGenerator.Click += new System.EventHandler(this.btn_keyGenerator_Click);
            // 
            // btn_verifier
            // 
            this.btn_verifier.AutoSize = false;
            this.btn_verifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_verifier.Depth = 0;
            this.btn_verifier.DrawShadows = true;
            this.btn_verifier.HighEmphasis = true;
            this.btn_verifier.Icon = null;
            this.btn_verifier.Location = new System.Drawing.Point(403, 24);
            this.btn_verifier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_verifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_verifier.Name = "btn_verifier";
            this.btn_verifier.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_verifier.Size = new System.Drawing.Size(141, 36);
            this.btn_verifier.TabIndex = 21;
            this.btn_verifier.Text = "License verifier";
            this.btn_verifier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_verifier.UseAccentColor = false;
            this.btn_verifier.UseVisualStyleBackColor = true;
            this.btn_verifier.Click += new System.EventHandler(this.btn_verifier_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(6, 82);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 24);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "License Keys";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(689, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(52, 24);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Users";
            // 
            // btn_reload
            // 
            this.btn_reload.AutoSize = false;
            this.btn_reload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reload.BackgroundImage = global::LCC.Properties.Resources.reset_480px;
            this.btn_reload.Depth = 0;
            this.btn_reload.DrawShadows = true;
            this.btn_reload.HighEmphasis = true;
            this.btn_reload.Icon = global::LCC.Properties.Resources.reset_480px;
            this.btn_reload.Location = new System.Drawing.Point(910, 70);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_reload.Size = new System.Drawing.Size(149, 36);
            this.btn_reload.TabIndex = 23;
            this.btn_reload.Text = "Reload data";
            this.btn_reload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reload.UseAccentColor = false;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 487);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btn_verifier);
            this.Controls.Add(this.btn_keyGenerator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logoutBtn);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeanearCut 1D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminDashboard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dt_license)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_user)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton logoutBtn;
        public System.Windows.Forms.DataGridView dt_license;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dt_user;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btn_keyGenerator;
        private MaterialSkin.Controls.MaterialButton btn_verifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_product_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_license_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_owner_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn license_owner_email;
        private System.Windows.Forms.DataGridViewImageColumn license_is_active;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_email;
        private System.Windows.Forms.DataGridViewImageColumn user_is_active;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btn_reload;
    }
}