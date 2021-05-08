
namespace LCC
{
    partial class NewProject
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.projNameReferenceTxt = new System.Windows.Forms.TextBox();
            this.projNameTxt = new System.Windows.Forms.TextBox();
            this.scopeOfWorksTxt = new System.Windows.Forms.TextBox();
            this.revNumberTxt = new System.Windows.Forms.TextBox();
            this.addProjectBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 88);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(188, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Project Name Reference #:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 116);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(100, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Project Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(24, 144);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(116, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Scope of Works:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(24, 173);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Revision #:";
            // 
            // projNameReferenceTxt
            // 
            this.projNameReferenceTxt.Location = new System.Drawing.Point(236, 84);
            this.projNameReferenceTxt.Name = "projNameReferenceTxt";
            this.projNameReferenceTxt.Size = new System.Drawing.Size(249, 23);
            this.projNameReferenceTxt.TabIndex = 4;
            // 
            // projNameTxt
            // 
            this.projNameTxt.Location = new System.Drawing.Point(236, 116);
            this.projNameTxt.Name = "projNameTxt";
            this.projNameTxt.Size = new System.Drawing.Size(249, 23);
            this.projNameTxt.TabIndex = 5;
            // 
            // scopeOfWorksTxt
            // 
            this.scopeOfWorksTxt.Location = new System.Drawing.Point(236, 144);
            this.scopeOfWorksTxt.Name = "scopeOfWorksTxt";
            this.scopeOfWorksTxt.Size = new System.Drawing.Size(249, 23);
            this.scopeOfWorksTxt.TabIndex = 6;
            // 
            // revNumberTxt
            // 
            this.revNumberTxt.Location = new System.Drawing.Point(236, 173);
            this.revNumberTxt.Name = "revNumberTxt";
            this.revNumberTxt.Size = new System.Drawing.Size(249, 23);
            this.revNumberTxt.TabIndex = 7;
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.AutoSize = false;
            this.addProjectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProjectBtn.Depth = 0;
            this.addProjectBtn.DrawShadows = true;
            this.addProjectBtn.HighEmphasis = true;
            this.addProjectBtn.Icon = null;
            this.addProjectBtn.Location = new System.Drawing.Point(285, 205);
            this.addProjectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addProjectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(159, 24);
            this.addProjectBtn.TabIndex = 8;
            this.addProjectBtn.Text = "OK";
            this.addProjectBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addProjectBtn.UseAccentColor = false;
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 253);
            this.Controls.Add(this.addProjectBtn);
            this.Controls.Add(this.revNumberTxt);
            this.Controls.Add(this.scopeOfWorksTxt);
            this.Controls.Add(this.projNameTxt);
            this.Controls.Add(this.projNameReferenceTxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "NewProject";
            this.Sizable = false;
            this.Text = "Add New Project";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox projNameReferenceTxt;
        private System.Windows.Forms.TextBox projNameTxt;
        private System.Windows.Forms.TextBox scopeOfWorksTxt;
        private System.Windows.Forms.TextBox revNumberTxt;
        private MaterialSkin.Controls.MaterialButton addProjectBtn;
    }
}