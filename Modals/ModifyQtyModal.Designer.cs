
namespace LCC.Modals
{
    partial class ModifyQtyModal
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
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.c_qty = new System.Windows.Forms.ComboBox();
            this.btn_save = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            this.materialLabel2.Location = new System.Drawing.Point(76, 94);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(56, 17);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Quantity";
            // 
            // c_qty
            // 
            this.c_qty.BackColor = System.Drawing.Color.LightGray;
            this.c_qty.DropDownHeight = 170;
            this.c_qty.DropDownWidth = 121;
            this.c_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.c_qty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c_qty.FormattingEnabled = true;
            this.c_qty.IntegralHeight = false;
            this.c_qty.ItemHeight = 17;
            this.c_qty.Items.AddRange(new object[] {
            "∞"});
            this.c_qty.Location = new System.Drawing.Point(76, 119);
            this.c_qty.MaxDropDownItems = 4;
            this.c_qty.Name = "c_qty";
            this.c_qty.Size = new System.Drawing.Size(92, 25);
            this.c_qty.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.DrawShadows = true;
            this.btn_save.HighEmphasis = true;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(93, 200);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(58, 36);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_save.UseAccentColor = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ModifyQtyModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 263);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.c_qty);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(262, 263);
            this.Name = "ModifyQtyModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Quantity";
            this.Load += new System.EventHandler(this.ModifyQtyModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox c_qty;
        private MaterialSkin.Controls.MaterialButton btn_save;
    }
}