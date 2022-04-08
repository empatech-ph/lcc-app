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
            this.comboBoxTxtDef = new System.Windows.Forms.ComboBox();
            this.lblTxtDef = new System.Windows.Forms.Label();
            this.comboBoxDelimiter = new System.Windows.Forms.ComboBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.checkBoxClearData = new System.Windows.Forms.CheckBox();
            this.checkBoxContainsFirstRow = new System.Windows.Forms.CheckBox();
            this.grpBxData = new System.Windows.Forms.GroupBox();
            this.dataGridViewImportData = new System.Windows.Forms.DataGridView();
            this.dataTbl = new System.Windows.Forms.DataGridView();
            this.grpBxFieldMap = new System.Windows.Forms.GroupBox();
            this.dataGridViewFieldMap = new System.Windows.Forms.DataGridView();
            this.fieldMapTbl = new System.Windows.Forms.DataGridView();
            this.btnImportCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnImportFieldMap = new MaterialSkin.Controls.MaterialButton();
            this.btnImportFieldMapClose = new MaterialSkin.Controls.MaterialButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
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
            this.importOptionsgrpbx.Controls.Add(this.comboBoxTxtDef);
            this.importOptionsgrpbx.Controls.Add(this.lblTxtDef);
            this.importOptionsgrpbx.Controls.Add(this.comboBoxDelimiter);
            this.importOptionsgrpbx.Controls.Add(this.lblDelimiter);
            this.importOptionsgrpbx.Controls.Add(this.checkBoxClearData);
            this.importOptionsgrpbx.Controls.Add(this.checkBoxContainsFirstRow);
            this.importOptionsgrpbx.Location = new System.Drawing.Point(25, 77);
            this.importOptionsgrpbx.Name = "importOptionsgrpbx";
            this.importOptionsgrpbx.Size = new System.Drawing.Size(743, 95);
            this.importOptionsgrpbx.TabIndex = 0;
            this.importOptionsgrpbx.TabStop = false;
            this.importOptionsgrpbx.Text = "Options";
            // 
            // comboBoxTxtDef
            // 
            this.comboBoxTxtDef.Enabled = false;
            this.comboBoxTxtDef.FormattingEnabled = true;
            this.comboBoxTxtDef.Location = new System.Drawing.Point(661, 49);
            this.comboBoxTxtDef.Name = "comboBoxTxtDef";
            this.comboBoxTxtDef.Size = new System.Drawing.Size(63, 23);
            this.comboBoxTxtDef.TabIndex = 5;
            // 
            // lblTxtDef
            // 
            this.lblTxtDef.AutoSize = true;
            this.lblTxtDef.Location = new System.Drawing.Point(523, 52);
            this.lblTxtDef.Name = "lblTxtDef";
            this.lblTxtDef.Size = new System.Drawing.Size(134, 15);
            this.lblTxtDef.TabIndex = 4;
            this.lblTxtDef.Text = "Text definition character";
            // 
            // comboBoxDelimiter
            // 
            this.comboBoxDelimiter.Enabled = false;
            this.comboBoxDelimiter.FormattingEnabled = true;
            this.comboBoxDelimiter.Location = new System.Drawing.Point(661, 20);
            this.comboBoxDelimiter.Name = "comboBoxDelimiter";
            this.comboBoxDelimiter.Size = new System.Drawing.Size(63, 23);
            this.comboBoxDelimiter.TabIndex = 3;
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(523, 23);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(134, 15);
            this.lblDelimiter.TabIndex = 2;
            this.lblDelimiter.Text = "Field delimiter character";
            // 
            // checkBoxClearData
            // 
            this.checkBoxClearData.AutoSize = true;
            this.checkBoxClearData.Enabled = false;
            this.checkBoxClearData.Location = new System.Drawing.Point(19, 47);
            this.checkBoxClearData.Name = "checkBoxClearData";
            this.checkBoxClearData.Size = new System.Drawing.Size(196, 19);
            this.checkBoxClearData.TabIndex = 1;
            this.checkBoxClearData.Text = "Clear current data before import";
            this.checkBoxClearData.UseVisualStyleBackColor = true;
            // 
            // checkBoxContainsFirstRow
            // 
            this.checkBoxContainsFirstRow.AutoSize = true;
            this.checkBoxContainsFirstRow.Enabled = false;
            this.checkBoxContainsFirstRow.Location = new System.Drawing.Point(19, 22);
            this.checkBoxContainsFirstRow.Name = "checkBoxContainsFirstRow";
            this.checkBoxContainsFirstRow.Size = new System.Drawing.Size(183, 19);
            this.checkBoxContainsFirstRow.TabIndex = 0;
            this.checkBoxContainsFirstRow.Text = "First row contains field names";
            this.checkBoxContainsFirstRow.UseVisualStyleBackColor = true;
            // 
            // grpBxData
            // 
            this.grpBxData.Controls.Add(this.dataGridViewImportData);
            this.grpBxData.Controls.Add(this.dataTbl);
            this.grpBxData.Location = new System.Drawing.Point(25, 178);
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
            this.grpBxFieldMap.Location = new System.Drawing.Point(25, 351);
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
            // btnImportCancel
            // 
            this.btnImportCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportCancel.Depth = 0;
            this.btnImportCancel.DrawShadows = true;
            this.btnImportCancel.Enabled = false;
            this.btnImportCancel.HighEmphasis = true;
            this.btnImportCancel.Icon = null;
            this.btnImportCancel.Location = new System.Drawing.Point(452, 611);
            this.btnImportCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportCancel.Name = "btnImportCancel";
            this.btnImportCancel.Size = new System.Drawing.Size(77, 36);
            this.btnImportCancel.TabIndex = 3;
            this.btnImportCancel.Text = "cancel";
            this.btnImportCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportCancel.UseAccentColor = false;
            this.btnImportCancel.UseVisualStyleBackColor = true;
            // 
            // btnImportFieldMap
            // 
            this.btnImportFieldMap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportFieldMap.Depth = 0;
            this.btnImportFieldMap.DrawShadows = true;
            this.btnImportFieldMap.HighEmphasis = true;
            this.btnImportFieldMap.Icon = null;
            this.btnImportFieldMap.Location = new System.Drawing.Point(537, 612);
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
            // btnImportFieldMapClose
            // 
            this.btnImportFieldMapClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImportFieldMapClose.Depth = 0;
            this.btnImportFieldMapClose.DrawShadows = true;
            this.btnImportFieldMapClose.HighEmphasis = true;
            this.btnImportFieldMapClose.Icon = null;
            this.btnImportFieldMapClose.Location = new System.Drawing.Point(672, 611);
            this.btnImportFieldMapClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImportFieldMapClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImportFieldMapClose.Name = "btnImportFieldMapClose";
            this.btnImportFieldMapClose.Size = new System.Drawing.Size(66, 36);
            this.btnImportFieldMapClose.TabIndex = 5;
            this.btnImportFieldMapClose.Text = "close";
            this.btnImportFieldMapClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImportFieldMapClose.UseAccentColor = false;
            this.btnImportFieldMapClose.UseVisualStyleBackColor = true;
            this.btnImportFieldMapClose.Click += new System.EventHandler(this.btnImportFieldMapClose_Click);
            // 
            // ImportFieldMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 666);
            this.Controls.Add(this.btnImportFieldMapClose);
            this.Controls.Add(this.btnImportFieldMap);
            this.Controls.Add(this.btnImportCancel);
            this.Controls.Add(this.grpBxFieldMap);
            this.Controls.Add(this.grpBxData);
            this.Controls.Add(this.importOptionsgrpbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
    }
}