
namespace LCC.Modals
{
    partial class AddStocksModal
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
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.tb_stock_code = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_cost = new MaterialSkin.Controls.MaterialTextBox();
            this.c_qty = new System.Windows.Forms.ComboBox();
            this.c_stockType = new System.Windows.Forms.ComboBox();
            this.rb_note = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.ck_editable = new MaterialSkin.Controls.MaterialCheckbox();
            this.ck_visible = new MaterialSkin.Controls.MaterialCheckbox();
            this.l_materialName = new MaterialSkin.Controls.MaterialLabel();
            this.tb_length = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.description = new MaterialSkin.Controls.MaterialTextBox();
            this.grade = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.DrawShadows = true;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(218, 448);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 36);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_stock_code
            // 
            this.tb_stock_code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_stock_code.Depth = 0;
            this.tb_stock_code.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_stock_code.Hint = "Stock Code";
            this.tb_stock_code.Location = new System.Drawing.Point(256, 87);
            this.tb_stock_code.MaxLength = 50;
            this.tb_stock_code.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_stock_code.Multiline = false;
            this.tb_stock_code.Name = "tb_stock_code";
            this.tb_stock_code.Size = new System.Drawing.Size(253, 50);
            this.tb_stock_code.TabIndex = 1;
            this.tb_stock_code.Text = "";
            // 
            // tb_cost
            // 
            this.tb_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_cost.Depth = 0;
            this.tb_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_cost.Hint = "Cost (AUD) / EA";
            this.tb_cost.Location = new System.Drawing.Point(382, 224);
            this.tb_cost.MaxLength = 50;
            this.tb_cost.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_cost.Multiline = false;
            this.tb_cost.Name = "tb_cost";
            this.tb_cost.Size = new System.Drawing.Size(119, 50);
            this.tb_cost.TabIndex = 5;
            this.tb_cost.Text = "0.00";
            this.tb_cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kerf_KeyPress);
            // 
            // c_qty
            // 
            this.c_qty.BackColor = System.Drawing.Color.LightGray;
            this.c_qty.DropDownHeight = 170;
            this.c_qty.DropDownWidth = 121;
            this.c_qty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c_qty.FormattingEnabled = true;
            this.c_qty.IntegralHeight = false;
            this.c_qty.ItemHeight = 15;
            this.c_qty.Items.AddRange(new object[] {
            "∞"});
            this.c_qty.Location = new System.Drawing.Point(24, 249);
            this.c_qty.MaxDropDownItems = 4;
            this.c_qty.Name = "c_qty";
            this.c_qty.Size = new System.Drawing.Size(92, 23);
            this.c_qty.TabIndex = 2;
            this.c_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kerf_KeyPress);
            // 
            // c_stockType
            // 
            this.c_stockType.BackColor = System.Drawing.Color.LightGray;
            this.c_stockType.DropDownHeight = 170;
            this.c_stockType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_stockType.DropDownWidth = 121;
            this.c_stockType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.c_stockType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c_stockType.FormattingEnabled = true;
            this.c_stockType.IntegralHeight = false;
            this.c_stockType.ItemHeight = 15;
            this.c_stockType.Location = new System.Drawing.Point(131, 249);
            this.c_stockType.MaxDropDownItems = 4;
            this.c_stockType.Name = "c_stockType";
            this.c_stockType.Size = new System.Drawing.Size(100, 23);
            this.c_stockType.TabIndex = 3;
            this.c_stockType.SelectedIndexChanged += new System.EventHandler(this.c_stockType_SelectedIndexChanged);
            // 
            // rb_note
            // 
            this.rb_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rb_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rb_note.Depth = 0;
            this.rb_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rb_note.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rb_note.Hint = "Note";
            this.rb_note.Location = new System.Drawing.Point(24, 319);
            this.rb_note.Margin = new System.Windows.Forms.Padding(5);
            this.rb_note.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_note.Name = "rb_note";
            this.rb_note.Size = new System.Drawing.Size(477, 87);
            this.rb_note.TabIndex = 6;
            this.rb_note.Text = "";
            // 
            // ck_editable
            // 
            this.ck_editable.AutoSize = true;
            this.ck_editable.Checked = true;
            this.ck_editable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_editable.Depth = 0;
            this.ck_editable.Location = new System.Drawing.Point(24, 409);
            this.ck_editable.Margin = new System.Windows.Forms.Padding(0);
            this.ck_editable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ck_editable.MouseState = MaterialSkin.MouseState.HOVER;
            this.ck_editable.Name = "ck_editable";
            this.ck_editable.Ripple = true;
            this.ck_editable.Size = new System.Drawing.Size(92, 37);
            this.ck_editable.TabIndex = 7;
            this.ck_editable.Text = "Editable";
            this.ck_editable.UseVisualStyleBackColor = true;
            // 
            // ck_visible
            // 
            this.ck_visible.AutoSize = true;
            this.ck_visible.Checked = true;
            this.ck_visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ck_visible.Depth = 0;
            this.ck_visible.Location = new System.Drawing.Point(24, 449);
            this.ck_visible.Margin = new System.Windows.Forms.Padding(0);
            this.ck_visible.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ck_visible.MouseState = MaterialSkin.MouseState.HOVER;
            this.ck_visible.Name = "ck_visible";
            this.ck_visible.Ripple = true;
            this.ck_visible.Size = new System.Drawing.Size(82, 37);
            this.ck_visible.TabIndex = 8;
            this.ck_visible.Text = "Visible";
            this.ck_visible.UseVisualStyleBackColor = true;
            // 
            // l_materialName
            // 
            this.l_materialName.Depth = 0;
            this.l_materialName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_materialName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.l_materialName.Location = new System.Drawing.Point(32, 74);
            this.l_materialName.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_materialName.Name = "l_materialName";
            this.l_materialName.Size = new System.Drawing.Size(207, 63);
            this.l_materialName.TabIndex = 6;
            this.l_materialName.Text = "material name";
            this.l_materialName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_length
            // 
            this.tb_length.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_length.Depth = 0;
            this.tb_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_length.Hint = "Length (mm)";
            this.tb_length.Location = new System.Drawing.Point(248, 224);
            this.tb_length.MaxLength = 50;
            this.tb_length.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_length.Multiline = false;
            this.tb_length.Name = "tb_length";
            this.tb_length.Size = new System.Drawing.Size(119, 50);
            this.tb_length.TabIndex = 4;
            this.tb_length.Text = "0.00";
            this.tb_length.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kerf_KeyPress);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel1.Location = new System.Drawing.Point(24, 293);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(32, 17);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Note";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(24, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 17);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Quantity";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel3.Location = new System.Drawing.Point(131, 224);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 17);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Stock Type";
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Depth = 0;
            this.description.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Hint = "Description";
            this.description.Location = new System.Drawing.Point(16, 160);
            this.description.MaxLength = 50;
            this.description.MouseState = MaterialSkin.MouseState.OUT;
            this.description.Multiline = false;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(256, 50);
            this.description.TabIndex = 10;
            this.description.Text = "";
            // 
            // grade
            // 
            this.grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grade.Depth = 0;
            this.grade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grade.Hint = "Grade";
            this.grade.Location = new System.Drawing.Point(280, 160);
            this.grade.MaxLength = 50;
            this.grade.MouseState = MaterialSkin.MouseState.OUT;
            this.grade.Multiline = false;
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(232, 50);
            this.grade.TabIndex = 11;
            this.grade.Text = "";
            // 
            // AddStocksModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 508);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.description);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.l_materialName);
            this.Controls.Add(this.ck_visible);
            this.Controls.Add(this.ck_editable);
            this.Controls.Add(this.rb_note);
            this.Controls.Add(this.c_stockType);
            this.Controls.Add(this.c_qty);
            this.Controls.Add(this.tb_length);
            this.Controls.Add(this.tb_cost);
            this.Controls.Add(this.tb_stock_code);
            this.Controls.Add(this.btn_save);
            this.MaximizeBox = false;
            this.Name = "AddStocksModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Stocks";
            this.Load += new System.EventHandler(this.AddStocksModal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AddStocksModal_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_save;
        private MaterialSkin.Controls.MaterialTextBox tb_stock_code;
        private MaterialSkin.Controls.MaterialTextBox tb_cost;
        private System.Windows.Forms.ComboBox c_qty;
        private System.Windows.Forms.ComboBox c_stockType;
        private MaterialSkin.Controls.MaterialMultiLineTextBox rb_note;
        private MaterialSkin.Controls.MaterialCheckbox ck_editable;
        private MaterialSkin.Controls.MaterialCheckbox ck_visible;
        private MaterialSkin.Controls.MaterialLabel l_materialName;
        private MaterialSkin.Controls.MaterialTextBox tb_length;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox description;
        private MaterialSkin.Controls.MaterialTextBox grade;
    }
}