
namespace LCC
{
    partial class ImportExportForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.importComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.importExportBtn = new MaterialSkin.Controls.MaterialButton();
            this.importLbl = new MaterialSkin.Controls.MaterialLabel();
            this.cancelImportBtn = new MaterialSkin.Controls.MaterialButton();
            this.importTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.browseBtn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // importComboBox
            // 
            this.importComboBox.AutoResize = false;
            this.importComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.importComboBox.Depth = 0;
            this.importComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.importComboBox.DropDownHeight = 174;
            this.importComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.importComboBox.DropDownWidth = 121;
            this.importComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.importComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importComboBox.FormattingEnabled = true;
            this.importComboBox.IntegralHeight = false;
            this.importComboBox.ItemHeight = 43;
            this.importComboBox.Items.AddRange(new object[] {
            "Project",
            "Cut Lengths",
            "Materials"});
            this.importComboBox.Location = new System.Drawing.Point(174, 79);
            this.importComboBox.MaxDropDownItems = 4;
            this.importComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.importComboBox.Name = "importComboBox";
            this.importComboBox.Size = new System.Drawing.Size(277, 49);
            this.importComboBox.StartIndex = 0;
            this.importComboBox.TabIndex = 0;
            this.importComboBox.TabStop = false;
            this.importComboBox.SelectedValueChanged += new System.EventHandler(this.importComboBox_SelectedValueChanged);
            // 
            // importExportBtn
            // 
            this.importExportBtn.AutoSize = false;
            this.importExportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importExportBtn.Depth = 0;
            this.importExportBtn.DrawShadows = true;
            this.importExportBtn.HighEmphasis = true;
            this.importExportBtn.Icon = null;
            this.importExportBtn.Location = new System.Drawing.Point(174, 220);
            this.importExportBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importExportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importExportBtn.Name = "importExportBtn";
            this.importExportBtn.Size = new System.Drawing.Size(132, 36);
            this.importExportBtn.TabIndex = 1;
            this.importExportBtn.Text = "Import";
            this.importExportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importExportBtn.UseAccentColor = false;
            this.importExportBtn.UseVisualStyleBackColor = true;
            this.importExportBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // importLbl
            // 
            this.importLbl.AutoSize = true;
            this.importLbl.Depth = 0;
            this.importLbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.importLbl.Location = new System.Drawing.Point(45, 93);
            this.importLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.importLbl.Name = "importLbl";
            this.importLbl.Size = new System.Drawing.Size(113, 19);
            this.importLbl.TabIndex = 3;
            this.importLbl.Text = "Entity to import:";
            // 
            // cancelImportBtn
            // 
            this.cancelImportBtn.AutoSize = false;
            this.cancelImportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelImportBtn.Depth = 0;
            this.cancelImportBtn.DrawShadows = true;
            this.cancelImportBtn.HighEmphasis = true;
            this.cancelImportBtn.Icon = null;
            this.cancelImportBtn.Location = new System.Drawing.Point(314, 220);
            this.cancelImportBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelImportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelImportBtn.Name = "cancelImportBtn";
            this.cancelImportBtn.Size = new System.Drawing.Size(137, 36);
            this.cancelImportBtn.TabIndex = 5;
            this.cancelImportBtn.Text = "Cancel";
            this.cancelImportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.cancelImportBtn.UseAccentColor = false;
            this.cancelImportBtn.UseVisualStyleBackColor = true;
            this.cancelImportBtn.Click += new System.EventHandler(this.cancelImportBtn_Click);
            // 
            // importTxt
            // 
            this.importTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.importTxt.Depth = 0;
            this.importTxt.Enabled = false;
            this.importTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importTxt.Location = new System.Drawing.Point(174, 140);
            this.importTxt.MaxLength = 50;
            this.importTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.importTxt.Multiline = false;
            this.importTxt.Name = "importTxt";
            this.importTxt.Size = new System.Drawing.Size(277, 50);
            this.importTxt.TabIndex = 8;
            this.importTxt.Text = "No file selected.";
            // 
            // browseBtn
            // 
            this.browseBtn.AutoSize = false;
            this.browseBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseBtn.Depth = 0;
            this.browseBtn.DrawShadows = true;
            this.browseBtn.HighEmphasis = true;
            this.browseBtn.Icon = null;
            this.browseBtn.Location = new System.Drawing.Point(45, 141);
            this.browseBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.browseBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(122, 49);
            this.browseBtn.TabIndex = 7;
            this.browseBtn.Text = "Browse";
            this.browseBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.browseBtn.UseAccentColor = false;
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // ImportExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 276);
            this.Controls.Add(this.importTxt);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.cancelImportBtn);
            this.Controls.Add(this.importLbl);
            this.Controls.Add(this.importExportBtn);
            this.Controls.Add(this.importComboBox);
            this.Name = "ImportExportForm";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialComboBox importComboBox;
        private MaterialSkin.Controls.MaterialButton importExportBtn;
        private MaterialSkin.Controls.MaterialLabel importLbl;
        private MaterialSkin.Controls.MaterialButton cancelImportBtn;
        private MaterialSkin.Controls.MaterialTextBox importTxt;
        private MaterialSkin.Controls.MaterialButton browseBtn;
    }
}