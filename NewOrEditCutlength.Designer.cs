
namespace LCC
{
    partial class NewOrEditCutlength
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrEditCutlength));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.partcode = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.save = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.length = new System.Windows.Forms.TextBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.orderno = new System.Windows.Forms.TextBox();
            this.note = new System.Windows.Forms.TextBox();
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
            this.materialLabel1.Size = new System.Drawing.Size(81, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Part Code*:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 116);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Description*:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(24, 144);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(54, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Grade*:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(24, 173);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Quantity*:";
            // 
            // partcode
            // 
            this.partcode.Location = new System.Drawing.Point(132, 82);
            this.partcode.Name = "partcode";
            this.partcode.Size = new System.Drawing.Size(249, 23);
            this.partcode.TabIndex = 4;
            this.partcode.TextChanged += new System.EventHandler(this.projNameReferenceTxt_TextChanged);
            this.partcode.Validating += new System.ComponentModel.CancelEventHandler(this.projNameReferenceTxt_Validating);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(132, 114);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(249, 23);
            this.description.TabIndex = 5;
            this.description.TextChanged += new System.EventHandler(this.projNameTxt_TextChanged);
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(132, 142);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(249, 23);
            this.grade.TabIndex = 6;
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(132, 171);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(249, 23);
            this.qty.TabIndex = 7;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // save
            // 
            this.save.AutoSize = false;
            this.save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save.Depth = 0;
            this.save.DrawShadows = true;
            this.save.HighEmphasis = true;
            this.save.Icon = null;
            this.save.Location = new System.Drawing.Point(177, 303);
            this.save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save.MouseState = MaterialSkin.MouseState.HOVER;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(159, 24);
            this.save.TabIndex = 8;
            this.save.Text = "OK";
            this.save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save.UseAccentColor = false;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(24, 202);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(61, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "Length*:";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(132, 200);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(249, 23);
            this.length.TabIndex = 7;
            this.length.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(24, 233);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(103, 19);
            this.materialLabel6.TabIndex = 3;
            this.materialLabel6.Text = "Order Number:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(24, 266);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(38, 19);
            this.materialLabel7.TabIndex = 3;
            this.materialLabel7.Text = "Note:";
            // 
            // orderno
            // 
            this.orderno.Location = new System.Drawing.Point(132, 231);
            this.orderno.Name = "orderno";
            this.orderno.Size = new System.Drawing.Size(249, 23);
            this.orderno.TabIndex = 7;
            // 
            // note
            // 
            this.note.Location = new System.Drawing.Point(132, 260);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(249, 23);
            this.note.TabIndex = 7;
            // 
            // NewOrEditCutlength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 337);
            this.Controls.Add(this.save);
            this.Controls.Add(this.note);
            this.Controls.Add(this.orderno);
            this.Controls.Add(this.length);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.description);
            this.Controls.Add(this.partcode);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewOrEditCutlength";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Cut Lengths";
            this.Load += new System.EventHandler(this.NewProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton addProjectBtn;
        public System.Windows.Forms.TextBox projNameReferenceTxt;
        public System.Windows.Forms.TextBox projNameTxt;
        public System.Windows.Forms.TextBox scopeOfWorksTxt;
        public System.Windows.Forms.TextBox revNumberTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        public System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox partcode;
        public System.Windows.Forms.TextBox description;
        public System.Windows.Forms.TextBox grade;
        public System.Windows.Forms.TextBox qty;
        private MaterialSkin.Controls.MaterialButton save;
        public System.Windows.Forms.TextBox length;
        public System.Windows.Forms.TextBox orderno;
        public System.Windows.Forms.TextBox note;
    }
}