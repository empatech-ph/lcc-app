
namespace LCC
{
    partial class Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.projectBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialBtn = new MaterialSkin.Controls.MaterialButton();
            this.assemblyBtn = new MaterialSkin.Controls.MaterialButton();
            this.storageBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportBtn = new MaterialSkin.Controls.MaterialButton();
            this.printerBtn = new MaterialSkin.Controls.MaterialButton();
            this.filterBtn = new MaterialSkin.Controls.MaterialButton();
            this.importBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.optimizeBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.fileBtn = new MaterialSkin.Controls.MaterialButton();
            this.projectTab = new MaterialSkin.Controls.MaterialTabControl();
            this.projTab = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cellClickLabel = new System.Windows.Forms.Label();
            this.projectTable = new System.Windows.Forms.DataGridView();
            this.project_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rev_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.view_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addProject = new MaterialSkin.Controls.MaterialButton();
            this.cutLengthTab = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cutLengthsTable = new System.Windows.Forms.DataGridView();
            this.materialTab = new System.Windows.Forms.TabPage();
            this.materialComponent1 = new LCC.Components.MaterialComponent();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.projectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.l_currentProject = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.projectTab.SuspendLayout();
            this.projTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTable)).BeginInit();
            this.cutLengthTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutLengthsTable)).BeginInit();
            this.materialTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectBtn
            // 
            this.projectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.projectBtn.Depth = 0;
            this.projectBtn.DrawShadows = true;
            this.projectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectBtn.HighEmphasis = true;
            this.projectBtn.Icon = global::LCC.Properties.Resources.folders;
            this.projectBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.projectBtn.Location = new System.Drawing.Point(10, 9);
            this.projectBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.projectBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectBtn.Name = "projectBtn";
            this.projectBtn.Size = new System.Drawing.Size(44, 36);
            this.projectBtn.TabIndex = 0;
            this.projectBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.projectBtn.UseAccentColor = false;
            this.projectBtn.UseVisualStyleBackColor = true;
            this.projectBtn.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // materialBtn
            // 
            this.materialBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialBtn.Depth = 0;
            this.materialBtn.DrawShadows = true;
            this.materialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialBtn.HighEmphasis = true;
            this.materialBtn.Icon = global::LCC.Properties.Resources.paper_crafts;
            this.materialBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialBtn.Location = new System.Drawing.Point(62, 9);
            this.materialBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialBtn.Name = "materialBtn";
            this.materialBtn.Size = new System.Drawing.Size(44, 36);
            this.materialBtn.TabIndex = 1;
            this.materialBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialBtn.UseAccentColor = false;
            this.materialBtn.UseVisualStyleBackColor = true;
            // 
            // assemblyBtn
            // 
            this.assemblyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assemblyBtn.Depth = 0;
            this.assemblyBtn.DrawShadows = true;
            this.assemblyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assemblyBtn.HighEmphasis = true;
            this.assemblyBtn.Icon = global::LCC.Properties.Resources.partnership;
            this.assemblyBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.assemblyBtn.Location = new System.Drawing.Point(114, 9);
            this.assemblyBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.assemblyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.assemblyBtn.Name = "assemblyBtn";
            this.assemblyBtn.Size = new System.Drawing.Size(44, 36);
            this.assemblyBtn.TabIndex = 2;
            this.assemblyBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.assemblyBtn.UseAccentColor = false;
            this.assemblyBtn.UseVisualStyleBackColor = true;
            // 
            // storageBtn
            // 
            this.storageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.storageBtn.Depth = 0;
            this.storageBtn.DrawShadows = true;
            this.storageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageBtn.HighEmphasis = true;
            this.storageBtn.Icon = global::LCC.Properties.Resources.open_box;
            this.storageBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.storageBtn.Location = new System.Drawing.Point(166, 9);
            this.storageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.storageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.storageBtn.Name = "storageBtn";
            this.storageBtn.Size = new System.Drawing.Size(44, 36);
            this.storageBtn.TabIndex = 3;
            this.storageBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.storageBtn.UseAccentColor = false;
            this.storageBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.projectBtn);
            this.panel1.Controls.Add(this.storageBtn);
            this.panel1.Controls.Add(this.materialBtn);
            this.panel1.Controls.Add(this.assemblyBtn);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 56);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exportBtn);
            this.panel2.Controls.Add(this.printerBtn);
            this.panel2.Controls.Add(this.filterBtn);
            this.panel2.Controls.Add(this.importBtn);
            this.panel2.Location = new System.Drawing.Point(241, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 56);
            this.panel2.TabIndex = 5;
            // 
            // exportBtn
            // 
            this.exportBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportBtn.Depth = 0;
            this.exportBtn.DrawShadows = true;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.HighEmphasis = true;
            this.exportBtn.Icon = global::LCC.Properties.Resources.export;
            this.exportBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.exportBtn.Location = new System.Drawing.Point(166, 9);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exportBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(44, 36);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exportBtn.UseAccentColor = false;
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // printerBtn
            // 
            this.printerBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printerBtn.Depth = 0;
            this.printerBtn.DrawShadows = true;
            this.printerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printerBtn.HighEmphasis = true;
            this.printerBtn.Icon = global::LCC.Properties.Resources.printer;
            this.printerBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.printerBtn.Location = new System.Drawing.Point(10, 9);
            this.printerBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printerBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.printerBtn.Name = "printerBtn";
            this.printerBtn.Size = new System.Drawing.Size(44, 36);
            this.printerBtn.TabIndex = 0;
            this.printerBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printerBtn.UseAccentColor = false;
            this.printerBtn.UseVisualStyleBackColor = true;
            this.printerBtn.Click += new System.EventHandler(this.printerBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterBtn.Depth = 0;
            this.filterBtn.DrawShadows = true;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.HighEmphasis = true;
            this.filterBtn.Icon = global::LCC.Properties.Resources.filter;
            this.filterBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.filterBtn.Location = new System.Drawing.Point(62, 9);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.filterBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(44, 36);
            this.filterBtn.TabIndex = 1;
            this.filterBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.filterBtn.UseAccentColor = false;
            this.filterBtn.UseVisualStyleBackColor = true;
            // 
            // importBtn
            // 
            this.importBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importBtn.Depth = 0;
            this.importBtn.DrawShadows = true;
            this.importBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importBtn.HighEmphasis = true;
            this.importBtn.Icon = global::LCC.Properties.Resources.import;
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.importBtn.Location = new System.Drawing.Point(114, 9);
            this.importBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.importBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(44, 36);
            this.importBtn.TabIndex = 2;
            this.importBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.importBtn.UseAccentColor = false;
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.optimizeBtn);
            this.panel3.Location = new System.Drawing.Point(477, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 56);
            this.panel3.TabIndex = 6;
            // 
            // optimizeBtn
            // 
            this.optimizeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optimizeBtn.Depth = 0;
            this.optimizeBtn.DrawShadows = true;
            this.optimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optimizeBtn.HighEmphasis = true;
            this.optimizeBtn.Icon = global::LCC.Properties.Resources.play;
            this.optimizeBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optimizeBtn.Location = new System.Drawing.Point(10, 9);
            this.optimizeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optimizeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.optimizeBtn.Name = "optimizeBtn";
            this.optimizeBtn.Size = new System.Drawing.Size(44, 36);
            this.optimizeBtn.TabIndex = 0;
            this.optimizeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.optimizeBtn.UseAccentColor = false;
            this.optimizeBtn.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.materialButton4);
            this.panel4.Controls.Add(this.materialButton3);
            this.panel4.Controls.Add(this.materialButton2);
            this.panel4.Controls.Add(this.materialButton1);
            this.panel4.Controls.Add(this.fileBtn);
            this.panel4.Location = new System.Drawing.Point(157, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 32);
            this.panel4.TabIndex = 7;
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Depth = 0;
            this.materialButton4.DrawShadows = true;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(157, 3);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialButton4.Size = new System.Drawing.Size(40, 25);
            this.materialButton4.TabIndex = 4;
            this.materialButton4.Text = "help";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(202, 3);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialButton3.Size = new System.Drawing.Size(40, 25);
            this.materialButton3.TabIndex = 3;
            this.materialButton3.Text = "view";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(112, 3);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialButton2.Size = new System.Drawing.Size(40, 25);
            this.materialButton2.TabIndex = 2;
            this.materialButton2.Text = "Edit";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(55, 3);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.materialButton1.Size = new System.Drawing.Size(53, 25);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Tools";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // fileBtn
            // 
            this.fileBtn.AutoSize = false;
            this.fileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileBtn.Depth = 0;
            this.fileBtn.DrawShadows = true;
            this.fileBtn.HighEmphasis = true;
            this.fileBtn.Icon = null;
            this.fileBtn.Location = new System.Drawing.Point(7, 3);
            this.fileBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileBtn.Size = new System.Drawing.Size(40, 25);
            this.fileBtn.TabIndex = 0;
            this.fileBtn.Text = "File";
            this.fileBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fileBtn.UseAccentColor = false;
            this.fileBtn.UseVisualStyleBackColor = true;
            // 
            // projectTab
            // 
            this.projectTab.Controls.Add(this.projTab);
            this.projectTab.Controls.Add(this.cutLengthTab);
            this.projectTab.Controls.Add(this.materialTab);
            this.projectTab.Depth = 0;
            this.projectTab.Location = new System.Drawing.Point(11, 181);
            this.projectTab.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectTab.Multiline = true;
            this.projectTab.Name = "projectTab";
            this.projectTab.SelectedIndex = 0;
            this.projectTab.Size = new System.Drawing.Size(1088, 476);
            this.projectTab.TabIndex = 8;
            // 
            // projTab
            // 
            this.projTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projTab.Controls.Add(this.materialLabel1);
            this.projTab.Controls.Add(this.cellClickLabel);
            this.projTab.Controls.Add(this.projectTable);
            this.projTab.Controls.Add(this.addProject);
            this.projTab.Location = new System.Drawing.Point(4, 24);
            this.projTab.Name = "projTab";
            this.projTab.Padding = new System.Windows.Forms.Padding(3);
            this.projTab.Size = new System.Drawing.Size(1080, 448);
            this.projTab.TabIndex = 0;
            this.projTab.Text = "Project";
            this.projTab.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(12, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(153, 24);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Manage Projects";
            // 
            // cellClickLabel
            // 
            this.cellClickLabel.AutoSize = true;
            this.cellClickLabel.BackColor = System.Drawing.Color.Transparent;
            this.cellClickLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cellClickLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellClickLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cellClickLabel.Location = new System.Drawing.Point(12, 28);
            this.cellClickLabel.Name = "cellClickLabel";
            this.cellClickLabel.Size = new System.Drawing.Size(0, 21);
            this.cellClickLabel.TabIndex = 9;
            // 
            // projectTable
            // 
            this.projectTable.AllowUserToAddRows = false;
            this.projectTable.AllowUserToDeleteRows = false;
            this.projectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.projectTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.projectTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.project_reference,
            this.project_name,
            this.scope,
            this.rev_no,
            this.edit_column,
            this.view_column});
            this.projectTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectTable.Location = new System.Drawing.Point(3, 36);
            this.projectTable.MultiSelect = false;
            this.projectTable.Name = "projectTable";
            this.projectTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.projectTable.RowTemplate.Height = 25;
            this.projectTable.Size = new System.Drawing.Size(1072, 407);
            this.projectTable.TabIndex = 3;
            this.projectTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTblView_CellClick);
            this.projectTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTable_CellEndEdit);
            this.projectTable.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_RowValidated);
            this.projectTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.cutLengthsTable_UserAddedRow);
            // 
            // project_reference
            // 
            this.project_reference.DataPropertyName = "project_reference";
            this.project_reference.HeaderText = "Project Reference #";
            this.project_reference.Name = "project_reference";
            // 
            // project_name
            // 
            this.project_name.DataPropertyName = "project_name";
            this.project_name.HeaderText = "Project Name";
            this.project_name.Name = "project_name";
            // 
            // scope
            // 
            this.scope.DataPropertyName = "scope";
            this.scope.HeaderText = "Scope of Works";
            this.scope.Name = "scope";
            // 
            // rev_no
            // 
            this.rev_no.DataPropertyName = "rev_no";
            this.rev_no.HeaderText = "Revision #";
            this.rev_no.Name = "rev_no";
            // 
            // edit_column
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Edit";
            this.edit_column.DefaultCellStyle = dataGridViewCellStyle2;
            this.edit_column.HeaderText = "";
            this.edit_column.Name = "edit_column";
            this.edit_column.Text = "Edit";
            // 
            // view_column
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "View";
            this.view_column.DefaultCellStyle = dataGridViewCellStyle3;
            this.view_column.HeaderText = "";
            this.view_column.Name = "view_column";
            // 
            // addProject
            // 
            this.addProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProject.Depth = 0;
            this.addProject.DrawShadows = true;
            this.addProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProject.HighEmphasis = true;
            this.addProject.Icon = global::LCC.Properties.Resources.add;
            this.addProject.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addProject.Location = new System.Drawing.Point(985, 15);
            this.addProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(78, 36);
            this.addProject.TabIndex = 1;
            this.addProject.Text = "Add";
            this.addProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addProject.UseAccentColor = false;
            this.addProject.UseVisualStyleBackColor = true;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // cutLengthTab
            // 
            this.cutLengthTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cutLengthTab.Controls.Add(this.materialLabel2);
            this.cutLengthTab.Controls.Add(this.cutLengthsTable);
            this.cutLengthTab.Location = new System.Drawing.Point(4, 24);
            this.cutLengthTab.Name = "cutLengthTab";
            this.cutLengthTab.Padding = new System.Windows.Forms.Padding(3);
            this.cutLengthTab.Size = new System.Drawing.Size(1080, 448);
            this.cutLengthTab.TabIndex = 1;
            this.cutLengthTab.Text = "Cut Lengths";
            this.cutLengthTab.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(12, 18);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(187, 24);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Manage Cut Lengths";
            // 
            // cutLengthsTable
            // 
            this.cutLengthsTable.AllowUserToOrderColumns = true;
            this.cutLengthsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cutLengthsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cutLengthsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cutLengthsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cutLengthsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.cutLengthsTable.Location = new System.Drawing.Point(3, 36);
            this.cutLengthsTable.Name = "cutLengthsTable";
            this.cutLengthsTable.RowTemplate.Height = 25;
            this.cutLengthsTable.Size = new System.Drawing.Size(1072, 407);
            this.cutLengthsTable.TabIndex = 0;
            this.cutLengthsTable.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_RowValidated);
            this.cutLengthsTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.cutLengthsTable_UserAddedRow);
            // 
            // materialTab
            // 
            this.materialTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialTab.Controls.Add(this.materialComponent1);
            this.materialTab.Location = new System.Drawing.Point(4, 24);
            this.materialTab.Name = "materialTab";
            this.materialTab.Size = new System.Drawing.Size(1080, 448);
            this.materialTab.TabIndex = 2;
            this.materialTab.Text = "Materials";
            this.materialTab.UseVisualStyleBackColor = true;
            // 
            // materialComponent1
            // 
            this.materialComponent1.BackColor = System.Drawing.Color.White;
            this.materialComponent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialComponent1.Location = new System.Drawing.Point(0, 0);
            this.materialComponent1.Name = "materialComponent1";
            this.materialComponent1.Padding = new System.Windows.Forms.Padding(3);
            this.materialComponent1.Size = new System.Drawing.Size(1078, 446);
            this.materialComponent1.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.projectTab;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 127);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1083, 48);
            this.materialTabSelector1.TabIndex = 11;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // l_currentProject
            // 
            this.l_currentProject.BackColor = System.Drawing.Color.Transparent;
            this.l_currentProject.Depth = 0;
            this.l_currentProject.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_currentProject.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.l_currentProject.Location = new System.Drawing.Point(677, 65);
            this.l_currentProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_currentProject.Name = "l_currentProject";
            this.l_currentProject.Size = new System.Drawing.Size(418, 56);
            this.l_currentProject.TabIndex = 10;
            this.l_currentProject.Text = "Current Project : No selected project";
            this.l_currentProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 663);
            this.Controls.Add(this.l_currentProject);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.projectTab);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DrawerShowIconsWhenHidden = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1105, 663);
            this.Name = "Project";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinearCut1D";
            this.Load += new System.EventHandler(this.Project_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.projectTab.ResumeLayout(false);
            this.projTab.ResumeLayout(false);
            this.projTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTable)).EndInit();
            this.cutLengthTab.ResumeLayout(false);
            this.cutLengthTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutLengthsTable)).EndInit();
            this.materialTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton projectBtn;
        private MaterialSkin.Controls.MaterialButton materialBtn;
        private MaterialSkin.Controls.MaterialButton assemblyBtn;
        private MaterialSkin.Controls.MaterialButton storageBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton printerBtn;
        private MaterialSkin.Controls.MaterialButton filterBtn;
        private MaterialSkin.Controls.MaterialButton importBtn;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton optimizeBtn;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton fileBtn;
        private System.Windows.Forms.TabPage projTab;
        private System.Windows.Forms.Label cellClickLabel;
        private MaterialSkin.Controls.MaterialButton exportBtn;
        public System.Windows.Forms.DataGridView projectTable;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip projectToolTip;
        private MaterialSkin.Controls.MaterialButton addProject;
        public MaterialSkin.Controls.MaterialTabControl projectTab;
        public System.Windows.Forms.TabPage cutLengthTab;
        private System.Windows.Forms.DataGridView cutLengthsTable;
        private System.Windows.Forms.TabPage materialTab;
        private Components.MaterialComponent materialComponent1;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn scope;
        private System.Windows.Forms.DataGridViewTextBoxColumn rev_no;
        private System.Windows.Forms.DataGridViewButtonColumn edit_column;
        private System.Windows.Forms.DataGridViewButtonColumn view_column;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel l_currentProject;
    }
}