namespace LCC
{
    partial class ImportFieldMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFieldMapping));
            this.importOptionsgrpbx = new System.Windows.Forms.GroupBox();
            this.checkBoxClearData = new System.Windows.Forms.CheckBox();
            this.grpBxData = new System.Windows.Forms.GroupBox();
            this.dataGridViewImportData = new System.Windows.Forms.DataGridView();
            this.dataTbl = new System.Windows.Forms.DataGridView();
            this.grpBxFieldMap = new System.Windows.Forms.GroupBox();
            this.dataGridViewFieldMap = new System.Windows.Forms.DataGridView();
            this.fieldMapTbl = new System.Windows.Forms.DataGridView();
            this.btnImportFieldMap = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnImportCancel = new MaterialSkin.Controls.MaterialButton();
            this.importOptionsgrpbx.SuspendLayout();
            this.grpBxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbl)).BeginInit();
            this.grpBxFieldMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFieldMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMapTbl)).BeginInit();
            this.SuspendLayout();
            // 
            // importOptionsgrpbx
            // 
            this.importOptionsgrpbx.Controls.Add(this.checkBoxClearData);
            this.importOptionsgrpbx.Location = new System.Drawing.Point(16, 80);
            this.importOptionsgrpbx.Name = "importOptionsgrpbx";
            this.importOptionsgrpbx.Size = new System.Drawing.Size(743, 95);
            this.importOptionsgrpbx.TabIndex = 0;
            this.importOptionsgrpbx.TabStop = false;
            this.importOptionsgrpbx.Text = "Options";
            // 
            // checkBoxClearData
            // 
            this.checkBoxClearData.AutoSize = true;
            this.checkBoxClearData.Location = new System.Drawing.Point(16, 48);
            this.checkBoxClearData.Name = "checkBoxClearData";
            this.checkBoxClearData.Size = new System.Drawing.Size(196, 19);
            this.checkBoxClearData.TabIndex = 1;
            this.checkBoxClearData.Text = "Clear current data before import";
            this.checkBoxClearData.UseVisualStyleBackColor = true;
            this.checkBoxClearData.CheckedChanged += new System.EventHandler(this.checkBoxClearData_CheckedChanged);
            // 
            // grpBxData
            // 
            this.grpBxData.Controls.Add(this.dataGridViewImportData);
            this.grpBxData.Controls.Add(this.dataTbl);
            this.grpBxData.Location = new System.Drawing.Point(16, 181);
            this.grpBxData.Name = "grpBxData";
            this.grpBxData.Size = new System.Drawing.Size(743, 167);
            this.grpBxData.TabIndex = 1;
            this.grpBxData.TabStop = false;
            this.grpBxData.Text = "Data";
            // 
            // dataGridViewImportData
            // 
            this.dataGridViewImportData.AllowUserToAddRows = false;
            this.dataGridViewImportData.AllowUserToDeleteRows = false;
            this.dataGridViewImportData.AllowUserToResizeColumns = false;
            this.dataGridViewImportData.AllowUserToResizeRows = false;
            this.dataGridViewImportData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewImportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImportData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewImportData.Location = new System.Drawing.Point(30, 36);
            this.dataGridViewImportData.Name = "dataGridViewImportData";
            this.dataGridViewImportData.RowHeadersVisible = false;
            this.dataGridViewImportData.Size = new System.Drawing.Size(672, 97);
            this.dataGridViewImportData.TabIndex = 0;
            // 
            // dataTbl
            // 
            this.dataTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTbl.Location = new System.Drawing.Point(19, 22);
            this.dataTbl.Name = "dataTbl";
            this.dataTbl.RowTemplate.Height = 25;
            this.dataTbl.Size = new System.Drawing.Size(705, 127);
            this.dataTbl.TabIndex = 1;
            // 
            // grpBxFieldMap
            // 
            this.grpBxFieldMap.Controls.Add(this.dataGridViewFieldMap);
            this.grpBxFieldMap.Controls.Add(this.fieldMapTbl);
            this.grpBxFieldMap.Location = new System.Drawing.Point(16, 354);
            this.grpBxFieldMap.Name = "grpBxFieldMap";
            this.grpBxFieldMap.Size = new System.Drawing.Size(743, 251);
            this.grpBxFieldMap.TabIndex = 2;
            this.grpBxFieldMap.TabStop = false;
            this.grpBxFieldMap.Text = "Field Mapping";
            // 
            // dataGridViewFieldMap
            // 
            this.dataGridViewFieldMap.AllowUserToAddRows = false;
            this.dataGridViewFieldMap.AllowUserToDeleteRows = false;
            this.dataGridViewFieldMap.AllowUserToResizeColumns = false;
            this.dataGridViewFieldMap.AllowUserToResizeRows = false;
            this.dataGridViewFieldMap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFieldMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFieldMap.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewFieldMap.Location = new System.Drawing.Point(30, 35);
            this.dataGridViewFieldMap.Name = "dataGridViewFieldMap";
            this.dataGridViewFieldMap.RowHeadersVisible = false;
            this.dataGridViewFieldMap.RowTemplate.Height = 25;
            this.dataGridViewFieldMap.Size = new System.Drawing.Size(672, 182);
            this.dataGridViewFieldMap.TabIndex = 2;
            // 
            // fieldMapTbl
            // 
            this.fieldMapTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldMapTbl.Location = new System.Drawing.Point(19, 22);
            this.fieldMapTbl.Name = "fieldMapTbl";
            this.fieldMapTbl.RowTemplate.Height = 25;
            this.fieldMapTbl.Size = new System.Drawing.Size(705, 213);
            this.fieldMapTbl.TabIndex = 0;
            // 
            // btnImportFieldMap
            // 
            this.btnImportFieldMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportFieldMap.Depth = 0;
            this.btnImportFieldMap.DrawShadows = true;
            this.btnImportFieldMap.HighEmphasis = true;
            this.btnImportFieldMap.Icon = null;
            this.btnImportFieldMap.Location = new System.Drawing.Point(576, 616);
            this.btnImportFieldMap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportFieldMap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportFieldMap.Name = "btnImportFieldMap";
            this.btnImportFieldMap.Size = new System.Drawing.Size(76, 36);
            this.btnImportFieldMap.TabIndex = 4;
            this.btnImportFieldMap.Text = "import";
            this.btnImportFieldMap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportFieldMap.UseAccentColor = false;
            this.btnImportFieldMap.UseVisualStyleBackColor = true;
            this.btnImportFieldMap.Click += new System.EventHandler(this.btnImportFieldMap_Click);
            // 
            // btnImportCancel
            // 
            this.btnImportCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportCancel.Depth = 0;
            this.btnImportCancel.DrawShadows = true;
            this.btnImportCancel.HighEmphasis = true;
            this.btnImportCancel.Icon = null;
            this.btnImportCancel.Location = new System.Drawing.Point(672, 616);
            this.btnImportCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportCancel.Name = "btnImportCancel";
            this.btnImportCancel.Size = new System.Drawing.Size(77, 36);
            this.btnImportCancel.TabIndex = 3;
            this.btnImportCancel.Text = "cancel";
            this.btnImportCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportCancel.UseAccentColor = false;
            this.btnImportCancel.UseVisualStyleBackColor = true;
            this.btnImportCancel.Click += new System.EventHandler(this.btnImportCancel_Click);
            // 
            // ImportFieldMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 669);
            this.Controls.Add(this.btnImportFieldMap);
            this.Controls.Add(this.btnImportCancel);
            this.Controls.Add(this.grpBxFieldMap);
            this.Controls.Add(this.grpBxData);
            this.Controls.Add(this.importOptionsgrpbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(785, 669);
            this.MinimumSize = new System.Drawing.Size(785, 669);
            this.Name = "ImportFieldMapping";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import ";
            this.Load += new System.EventHandler(this.ImportFieldMapping_Load);
            this.importOptionsgrpbx.ResumeLayout(false);
            this.importOptionsgrpbx.PerformLayout();
            this.grpBxData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbl)).EndInit();
            this.grpBxFieldMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFieldMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMapTbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox importOptionsgrpbx;
        private System.Windows.Forms.CheckBox checkBoxClearData;
        private System.Windows.Forms.CheckBox checkBoxContainsFirstRow;
        private System.Windows.Forms.ComboBox comboBoxTxtDef;
        private System.Windows.Forms.Label lblTxtDef;
        private System.Windows.Forms.ComboBox comboBoxDelimiter;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.GroupBox grpBxData;
        private System.Windows.Forms.GroupBox grpBxFieldMap;
        private System.Windows.Forms.DataGridView dataTbl;
        private System.Windows.Forms.DataGridView fieldMapTbl;
        public System.Windows.Forms.DataGridView dataGridViewImportData;
        public System.Windows.Forms.DataGridView dataGridViewFieldMap;
        private MaterialSkin.Controls.MaterialButton btnImportCancel;
        private MaterialSkin.Controls.MaterialButton btnImportFieldMap;
        private MaterialSkin.Controls.MaterialButton btnImportFieldMapClose;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label importTitle;
    }
}