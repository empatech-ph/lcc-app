
namespace LCC.Admin
{
    partial class AssignRoles
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
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.dgv_usersToBeAdded = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usersToBeAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.Depth = 0;
            this.btn_save.DrawShadows = true;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(210, 426);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 36);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_usersToBeAdded
            // 
            this.dgv_usersToBeAdded.AllowUserToResizeColumns = false;
            this.dgv_usersToBeAdded.AllowUserToResizeRows = false;
            this.dgv_usersToBeAdded.BackgroundColor = System.Drawing.Color.White;
            this.dgv_usersToBeAdded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_usersToBeAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_usersToBeAdded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.role});
            this.dgv_usersToBeAdded.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_usersToBeAdded.Location = new System.Drawing.Point(6, 71);
            this.dgv_usersToBeAdded.Name = "dgv_usersToBeAdded";
            this.dgv_usersToBeAdded.RowHeadersVisible = false;
            this.dgv_usersToBeAdded.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_usersToBeAdded.RowTemplate.Height = 25;
            this.dgv_usersToBeAdded.Size = new System.Drawing.Size(482, 346);
            this.dgv_usersToBeAdded.TabIndex = 4;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 300;
            // 
            // role
            // 
            dataGridViewCellStyle1.NullValue = "Please select";
            this.role.DefaultCellStyle = dataGridViewCellStyle1;
            this.role.HeaderText = "Roles";
            this.role.Items.AddRange(new object[] {
            "System Administrator",
            "Moderator",
            "Estimator"});
            this.role.Name = "role";
            this.role.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.role.Width = 175;
            // 
            // AssignRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 471);
            this.Controls.Add(this.dgv_usersToBeAdded);
            this.Controls.Add(this.btn_save);
            this.MaximizeBox = false;
            this.Name = "AssignRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usersToBeAdded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btn_save;
        private System.Windows.Forms.DataGridView dgv_usersToBeAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewComboBoxColumn role;
    }
}