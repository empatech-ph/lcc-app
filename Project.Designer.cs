using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.projectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fileMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commLengthListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.logoutBtn = new MaterialSkin.Controls.MaterialButton();
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
            this.optionsBtn = new MaterialSkin.Controls.MaterialButton();
            this.statusBarLbl = new System.Windows.Forms.Label();
            this.fileBtn = new MaterialSkin.Controls.MaterialButton();
            this.windowsPanel = new System.Windows.Forms.Panel();
            this.login_details_label = new System.Windows.Forms.Label();
            this.searchString = new MaterialSkin.Controls.MaterialTextBox();
            this.progressOptimize = new System.Windows.Forms.ProgressBar();
            this.tabOptiPlus = new MaterialSkin.Controls.MaterialTabControl();
            this.projTab = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cellClickLabel = new System.Windows.Forms.Label();
            this.projectTable = new System.Windows.Forms.DataGridView();
            this.project_reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rev_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete_column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addProject = new MaterialSkin.Controls.MaterialButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton6 = new MaterialSkin.Controls.MaterialButton();
            this.cutLengthTab = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cutLengthsTable = new System.Windows.Forms.DataGridView();
            this.cutlength_partcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_uncut_qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cutlength_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addCutlength = new MaterialSkin.Controls.MaterialButton();
            this.materialTab = new System.Windows.Forms.TabPage();
            this.materialComponent1 = new LCC.Components.MaterialComponent();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.optimizeComponent1 = new LCC.Components.OptimizeComponent();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.optiplusComponent1 = new LCC.Components.OptiplusComponent();
            this.oProjectTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.l_currentProject = new MaterialSkin.Controls.MaterialLabel();
            this.panelOptimize = new System.Windows.Forms.Panel();
            this.stopButton = new MaterialSkin.Controls.MaterialButton();
            this.optimizeBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exportBtn = new MaterialSkin.Controls.MaterialButton();
            this.storageBtn = new MaterialSkin.Controls.MaterialButton();
            this.printerBtn = new MaterialSkin.Controls.MaterialButton();
            this.redoBtn = new MaterialSkin.Controls.MaterialButton();
            this.undoBtn = new MaterialSkin.Controls.MaterialButton();
            this.importBtn = new MaterialSkin.Controls.MaterialButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.headerHandlerBar = new System.Windows.Forms.Panel();
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.cleasrCutlengthsBtn = new MaterialSkin.Controls.MaterialButton();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.fileMenuStrip.SuspendLayout();
            this.windowsPanel.SuspendLayout();
            this.tabOptiPlus.SuspendLayout();
            this.projTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.cutLengthTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutLengthsTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.materialTab.SuspendLayout();
            this.tabResult.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelOptimize.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.headerHandlerBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Depth = 0;
            this.materialButton3.DrawShadows = true;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(0, 0);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(75, 23);
            this.materialButton3.TabIndex = 0;
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(42, 44);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(205, 24);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Optimized Cut Lengths";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dataGridView3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(536, 372);
            this.panel7.TabIndex = 15;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(210, 197);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 1;
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportItem,
            this.inventoryListItem,
            this.commLengthListItem});
            this.fileMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(201, 70);
            this.fileMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileMenuStrip_ItemClicked);
            this.fileMenuStrip.Click += new System.EventHandler(this.fileMenuStrip_Click);
            // 
            // exportItem
            // 
            this.exportItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportProjects});
            this.exportItem.Name = "exportItem";
            this.exportItem.Size = new System.Drawing.Size(200, 22);
            this.exportItem.Text = "Export";
            // 
            // exportProjects
            // 
            this.exportProjects.Name = "exportProjects";
            this.exportProjects.Size = new System.Drawing.Size(132, 22);
            this.exportProjects.Text = "Cutlenghts";
            this.exportProjects.Click += new System.EventHandler(this.exportProjects_Click);
            // 
            // inventoryListItem
            // 
            this.inventoryListItem.Name = "inventoryListItem";
            this.inventoryListItem.Size = new System.Drawing.Size(200, 22);
            this.inventoryListItem.Text = "Inventory List";
            this.inventoryListItem.Click += new System.EventHandler(this.inventoryListItem_Click);
            // 
            // commLengthListItem
            // 
            this.commLengthListItem.Name = "commLengthListItem";
            this.commLengthListItem.Size = new System.Drawing.Size(200, 22);
            this.commLengthListItem.Text = "Commercial Length List";
            this.commLengthListItem.Click += new System.EventHandler(this.commLengthListItem_Click);
            // 
            // oBackgroundWorker
            // 
            this.oBackgroundWorker.WorkerReportsProgress = true;
            this.oBackgroundWorker.WorkerSupportsCancellation = true;
            this.oBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.oBackgroundWorker_DoWork);
            this.oBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.oBackgroundWorker_ProgressChanged);
            this.oBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.oBackgroundWorker_RunWorkerCompleted);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = false;
            this.logoutBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logoutBtn.Depth = 0;
            this.logoutBtn.DrawShadows = true;
            this.logoutBtn.HighEmphasis = true;
            this.logoutBtn.Icon = null;
            this.logoutBtn.Location = new System.Drawing.Point(336, 16);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logoutBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.logoutBtn.Size = new System.Drawing.Size(80, 36);
            this.logoutBtn.TabIndex = 17;
            this.logoutBtn.Text = "logout";
            this.logoutBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logoutBtn.UseAccentColor = false;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.AutoSize = false;
            this.helpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBtn.Depth = 0;
            this.helpBtn.DrawShadows = true;
            this.helpBtn.HighEmphasis = true;
            this.helpBtn.Icon = null;
            this.helpBtn.Location = new System.Drawing.Point(248, 16);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpBtn.Size = new System.Drawing.Size(80, 36);
            this.helpBtn.TabIndex = 18;
            this.helpBtn.Text = "help";
            this.helpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpBtn.UseAccentColor = false;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.AutoSize = false;
            this.optionsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionsBtn.Depth = 0;
            this.optionsBtn.DrawShadows = true;
            this.optionsBtn.HighEmphasis = true;
            this.optionsBtn.Icon = null;
            this.optionsBtn.Location = new System.Drawing.Point(160, 16);
            this.optionsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.optionsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.optionsBtn.Size = new System.Drawing.Size(80, 36);
            this.optionsBtn.TabIndex = 14;
            this.optionsBtn.Text = "options";
            this.optionsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.optionsBtn.UseAccentColor = false;
            this.optionsBtn.UseVisualStyleBackColor = true;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // statusBarLbl
            // 
            this.statusBarLbl.AutoSize = true;
            this.statusBarLbl.Location = new System.Drawing.Point(740, 661);
            this.statusBarLbl.Name = "statusBarLbl";
            this.statusBarLbl.Size = new System.Drawing.Size(0, 15);
            this.statusBarLbl.TabIndex = 19;
            // 
            // fileBtn
            // 
            this.fileBtn.AutoSize = false;
            this.fileBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileBtn.Depth = 0;
            this.fileBtn.DrawShadows = true;
            this.fileBtn.HighEmphasis = true;
            this.fileBtn.Icon = null;
            this.fileBtn.Location = new System.Drawing.Point(78, 16);
            this.fileBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.fileBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fileBtn.Size = new System.Drawing.Size(74, 38);
            this.fileBtn.TabIndex = 12;
            this.fileBtn.Text = "File";
            this.fileBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.fileBtn.UseAccentColor = false;
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            this.fileBtn.MouseHover += new System.EventHandler(this.fileBtn_MouseHover);
            // 
            // windowsPanel
            // 
            this.windowsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsPanel.BackColor = System.Drawing.Color.White;
            this.windowsPanel.Controls.Add(this.login_details_label);
            this.windowsPanel.Controls.Add(this.searchString);
            this.windowsPanel.Controls.Add(this.progressOptimize);
            this.windowsPanel.Controls.Add(this.tabOptiPlus);
            this.windowsPanel.Controls.Add(this.oProjectTabSelector);
            this.windowsPanel.Controls.Add(this.l_currentProject);
            this.windowsPanel.Controls.Add(this.panelOptimize);
            this.windowsPanel.Controls.Add(this.panel2);
            this.windowsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.windowsPanel.Location = new System.Drawing.Point(0, 64);
            this.windowsPanel.Name = "windowsPanel";
            this.windowsPanel.Size = new System.Drawing.Size(1099, 610);
            this.windowsPanel.TabIndex = 21;
            // 
            // login_details_label
            // 
            this.login_details_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.login_details_label.AutoSize = true;
            this.login_details_label.Location = new System.Drawing.Point(8, 587);
            this.login_details_label.Name = "login_details_label";
            this.login_details_label.Size = new System.Drawing.Size(38, 15);
            this.login_details_label.TabIndex = 13;
            this.login_details_label.Text = "label1";
            // 
            // searchString
            // 
            this.searchString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchString.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchString.Depth = 0;
            this.searchString.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchString.Hint = "Search";
            this.searchString.Location = new System.Drawing.Point(888, 64);
            this.searchString.MaxLength = 50;
            this.searchString.MouseState = MaterialSkin.MouseState.OUT;
            this.searchString.Multiline = false;
            this.searchString.Name = "searchString";
            this.searchString.Size = new System.Drawing.Size(205, 36);
            this.searchString.TabIndex = 11;
            this.searchString.Text = "";
            this.searchString.UseTallSize = false;
            this.searchString.TextChanged += new System.EventHandler(this.searchString_TextChanged);
            // 
            // progressOptimize
            // 
            this.progressOptimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressOptimize.Location = new System.Drawing.Point(736, 587);
            this.progressOptimize.Name = "progressOptimize";
            this.progressOptimize.Size = new System.Drawing.Size(359, 19);
            this.progressOptimize.TabIndex = 12;
            // 
            // tabOptiPlus
            // 
            this.tabOptiPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabOptiPlus.Controls.Add(this.projTab);
            this.tabOptiPlus.Controls.Add(this.cutLengthTab);
            this.tabOptiPlus.Controls.Add(this.materialTab);
            this.tabOptiPlus.Controls.Add(this.tabResult);
            this.tabOptiPlus.Controls.Add(this.tabPage1);
            this.tabOptiPlus.Depth = 0;
            this.tabOptiPlus.Location = new System.Drawing.Point(8, 112);
            this.tabOptiPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabOptiPlus.Multiline = true;
            this.tabOptiPlus.Name = "tabOptiPlus";
            this.tabOptiPlus.SelectedIndex = 0;
            this.tabOptiPlus.Size = new System.Drawing.Size(1088, 467);
            this.tabOptiPlus.TabIndex = 8;
            this.tabOptiPlus.SelectedIndexChanged += new System.EventHandler(this.projectTab_SelectedIndexChanged);
            // 
            // projTab
            // 
            this.projTab.BackColor = System.Drawing.Color.White;
            this.projTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projTab.Controls.Add(this.materialLabel1);
            this.projTab.Controls.Add(this.cellClickLabel);
            this.projTab.Controls.Add(this.projectTable);
            this.projTab.Controls.Add(this.addProject);
            this.projTab.Controls.Add(this.panel3);
            this.projTab.Location = new System.Drawing.Point(4, 24);
            this.projTab.Name = "projTab";
            this.projTab.Padding = new System.Windows.Forms.Padding(3);
            this.projTab.Size = new System.Drawing.Size(1080, 439);
            this.projTab.TabIndex = 0;
            this.projTab.Text = "Project";
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
            this.projectTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projectTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.projectTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.projectTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.projectTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.delete_column});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.projectTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.projectTable.Location = new System.Drawing.Point(3, 64);
            this.projectTable.MultiSelect = false;
            this.projectTable.Name = "projectTable";
            this.projectTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.projectTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.projectTable.RowHeadersVisible = false;
            this.projectTable.RowTemplate.Height = 25;
            this.projectTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.projectTable.Size = new System.Drawing.Size(1072, 370);
            this.projectTable.TabIndex = 3;
            this.projectTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTblView_CellClick);
            this.projectTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTable_CellEndEdit);
            this.projectTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectTable_CellValueChanged);
            this.projectTable.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_RowValidated);
            this.projectTable.SelectionChanged += new System.EventHandler(this.projectTable_SelectionChanged);
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
            this.edit_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "Edit";
            this.edit_column.DefaultCellStyle = dataGridViewCellStyle2;
            this.edit_column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_column.HeaderText = "";
            this.edit_column.MinimumWidth = 100;
            this.edit_column.Name = "edit_column";
            this.edit_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit_column.ToolTipText = "Edit";
            this.edit_column.UseColumnTextForButtonValue = true;
            // 
            // delete_column
            // 
            this.delete_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "Delete";
            this.delete_column.DefaultCellStyle = dataGridViewCellStyle3;
            this.delete_column.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_column.HeaderText = "";
            this.delete_column.MinimumWidth = 100;
            this.delete_column.Name = "delete_column";
            this.delete_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete_column.ToolTipText = "Delete";
            this.delete_column.UseColumnTextForButtonValue = true;
            // 
            // addProject
            // 
            this.addProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addProject.Depth = 0;
            this.addProject.DrawShadows = true;
            this.addProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProject.HighEmphasis = true;
            this.addProject.Icon = global::LCC.Properties.Resources.add;
            this.addProject.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addProject.Location = new System.Drawing.Point(985, 24);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1072, 431);
            this.panel3.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.materialButton2);
            this.panel6.Controls.Add(this.materialButton5);
            this.panel6.Controls.Add(this.materialButton6);
            this.panel6.Location = new System.Drawing.Point(54, -135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 56);
            this.panel6.TabIndex = 4;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = global::LCC.Properties.Resources.folders;
            this.materialButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialButton2.Location = new System.Drawing.Point(10, 9);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(44, 36);
            this.materialButton2.TabIndex = 0;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.projectBtn_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Depth = 0;
            this.materialButton5.DrawShadows = true;
            this.materialButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = global::LCC.Properties.Resources.open_box;
            this.materialButton5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialButton5.Location = new System.Drawing.Point(166, 9);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.Size = new System.Drawing.Size(44, 36);
            this.materialButton5.TabIndex = 3;
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            // 
            // materialButton6
            // 
            this.materialButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton6.Depth = 0;
            this.materialButton6.DrawShadows = true;
            this.materialButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton6.HighEmphasis = true;
            this.materialButton6.Icon = global::LCC.Properties.Resources.paper_crafts;
            this.materialButton6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.materialButton6.Location = new System.Drawing.Point(62, 9);
            this.materialButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton6.Name = "materialButton6";
            this.materialButton6.Size = new System.Drawing.Size(44, 36);
            this.materialButton6.TabIndex = 1;
            this.materialButton6.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton6.UseAccentColor = false;
            this.materialButton6.UseVisualStyleBackColor = true;
            // 
            // cutLengthTab
            // 
            this.cutLengthTab.BackColor = System.Drawing.Color.White;
            this.cutLengthTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cutLengthTab.Controls.Add(this.materialLabel2);
            this.cutLengthTab.Controls.Add(this.cutLengthsTable);
            this.cutLengthTab.Controls.Add(this.panel5);
            this.cutLengthTab.Location = new System.Drawing.Point(4, 24);
            this.cutLengthTab.Name = "cutLengthTab";
            this.cutLengthTab.Padding = new System.Windows.Forms.Padding(3);
            this.cutLengthTab.Size = new System.Drawing.Size(1080, 439);
            this.cutLengthTab.TabIndex = 1;
            this.cutLengthTab.Text = "Cut Lengths";
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
            this.cutLengthsTable.AllowUserToResizeColumns = false;
            this.cutLengthsTable.AllowUserToResizeRows = false;
            this.cutLengthsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cutLengthsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cutLengthsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cutLengthsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.cutLengthsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cutLengthsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cutlength_partcode,
            this.cutlength_description,
            this.cutlength_grade,
            this.cutlength_qty,
            this.cutlength_uncut_qty,
            this.cutlength_length,
            this.cutlength_order_no,
            this.cutlength_note,
            this.cutlength_delete});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = "-";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cutLengthsTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.cutLengthsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.cutLengthsTable.Location = new System.Drawing.Point(3, 56);
            this.cutLengthsTable.Name = "cutLengthsTable";
            this.cutLengthsTable.RowHeadersVisible = false;
            this.cutLengthsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cutLengthsTable.RowTemplate.Height = 25;
            this.cutLengthsTable.Size = new System.Drawing.Size(1072, 370);
            this.cutLengthsTable.TabIndex = 0;
            this.cutLengthsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_CellClick);
            this.cutLengthsTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_CellEndEdit);
            this.cutLengthsTable.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_CellLeave);
            this.cutLengthsTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_CellValueChanged);
            this.cutLengthsTable.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.cutLengthsTable_DataError);
            this.cutLengthsTable.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.cutLengthsTable_RowValidated);
            this.cutLengthsTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.cutLengthsTable_UserAddedRow);
            // 
            // cutlength_partcode
            // 
            this.cutlength_partcode.DataPropertyName = "part_code";
            this.cutlength_partcode.FillWeight = 58.51429F;
            this.cutlength_partcode.HeaderText = "Part Code";
            this.cutlength_partcode.Name = "cutlength_partcode";
            // 
            // cutlength_description
            // 
            this.cutlength_description.DataPropertyName = "description";
            this.cutlength_description.FillWeight = 58.51429F;
            this.cutlength_description.HeaderText = "Description";
            this.cutlength_description.Name = "cutlength_description";
            // 
            // cutlength_grade
            // 
            this.cutlength_grade.DataPropertyName = "grade";
            this.cutlength_grade.FillWeight = 58.51429F;
            this.cutlength_grade.HeaderText = "Grade";
            this.cutlength_grade.Name = "cutlength_grade";
            // 
            // cutlength_qty
            // 
            this.cutlength_qty.DataPropertyName = "quantity";
            this.cutlength_qty.FillWeight = 58.51429F;
            this.cutlength_qty.HeaderText = "Quantity";
            this.cutlength_qty.Name = "cutlength_qty";
            // 
            // cutlength_uncut_qty
            // 
            this.cutlength_uncut_qty.DataPropertyName = "uncut_quantity";
            this.cutlength_uncut_qty.FillWeight = 58.51429F;
            this.cutlength_uncut_qty.HeaderText = "Uncut Quantity";
            this.cutlength_uncut_qty.Name = "cutlength_uncut_qty";
            // 
            // cutlength_length
            // 
            this.cutlength_length.DataPropertyName = "length";
            this.cutlength_length.FillWeight = 58.51429F;
            this.cutlength_length.HeaderText = "Length";
            this.cutlength_length.Name = "cutlength_length";
            // 
            // cutlength_order_no
            // 
            this.cutlength_order_no.DataPropertyName = "order_number";
            this.cutlength_order_no.FillWeight = 58.51429F;
            this.cutlength_order_no.HeaderText = "Order No.";
            this.cutlength_order_no.Name = "cutlength_order_no";
            // 
            // cutlength_note
            // 
            this.cutlength_note.DataPropertyName = "note";
            this.cutlength_note.FillWeight = 58.51429F;
            this.cutlength_note.HeaderText = "Note";
            this.cutlength_note.Name = "cutlength_note";
            // 
            // cutlength_delete
            // 
            this.cutlength_delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.NullValue = "Remove";
            this.cutlength_delete.DefaultCellStyle = dataGridViewCellStyle7;
            this.cutlength_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutlength_delete.HeaderText = "";
            this.cutlength_delete.MinimumWidth = 100;
            this.cutlength_delete.Name = "cutlength_delete";
            this.cutlength_delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cutlength_delete.Text = "Remove";
            this.cutlength_delete.UseColumnTextForButtonValue = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cleasrCutlengthsBtn);
            this.panel5.Controls.Add(this.addCutlength);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1072, 431);
            this.panel5.TabIndex = 12;
            // 
            // addCutlength
            // 
            this.addCutlength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCutlength.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCutlength.Depth = 0;
            this.addCutlength.DrawShadows = true;
            this.addCutlength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCutlength.HighEmphasis = true;
            this.addCutlength.Icon = global::LCC.Properties.Resources.add;
            this.addCutlength.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addCutlength.Location = new System.Drawing.Point(782, 11);
            this.addCutlength.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCutlength.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCutlength.Name = "addCutlength";
            this.addCutlength.Size = new System.Drawing.Size(78, 36);
            this.addCutlength.TabIndex = 2;
            this.addCutlength.Text = "Add";
            this.addCutlength.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addCutlength.UseAccentColor = false;
            this.addCutlength.UseVisualStyleBackColor = true;
            this.addCutlength.Click += new System.EventHandler(this.addCutlength_Click);
            // 
            // materialTab
            // 
            this.materialTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialTab.Controls.Add(this.materialComponent1);
            this.materialTab.Location = new System.Drawing.Point(4, 24);
            this.materialTab.Name = "materialTab";
            this.materialTab.Size = new System.Drawing.Size(1080, 439);
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
            this.materialComponent1.Size = new System.Drawing.Size(1078, 437);
            this.materialComponent1.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.optimizeComponent1);
            this.tabResult.Location = new System.Drawing.Point(4, 24);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(1080, 439);
            this.tabResult.TabIndex = 3;
            this.tabResult.Text = "Results Summary";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // optimizeComponent1
            // 
            this.optimizeComponent1.BackColor = System.Drawing.Color.White;
            this.optimizeComponent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizeComponent1.Location = new System.Drawing.Point(3, 3);
            this.optimizeComponent1.Name = "optimizeComponent1";
            this.optimizeComponent1.Size = new System.Drawing.Size(1074, 433);
            this.optimizeComponent1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.optiplusComponent1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1080, 439);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Opti Plus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // optiplusComponent1
            // 
            this.optiplusComponent1.BackColor = System.Drawing.Color.White;
            this.optiplusComponent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optiplusComponent1.Location = new System.Drawing.Point(3, 3);
            this.optiplusComponent1.Name = "optiplusComponent1";
            this.optiplusComponent1.Size = new System.Drawing.Size(1074, 433);
            this.optiplusComponent1.TabIndex = 0;
            // 
            // oProjectTabSelector
            // 
            this.oProjectTabSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oProjectTabSelector.BaseTabControl = this.tabOptiPlus;
            this.oProjectTabSelector.Depth = 0;
            this.oProjectTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.oProjectTabSelector.Location = new System.Drawing.Point(8, 56);
            this.oProjectTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.oProjectTabSelector.Name = "oProjectTabSelector";
            this.oProjectTabSelector.Size = new System.Drawing.Size(1087, 48);
            this.oProjectTabSelector.TabIndex = 11;
            this.oProjectTabSelector.TabIndicatorHeight = 5;
            // 
            // l_currentProject
            // 
            this.l_currentProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_currentProject.BackColor = System.Drawing.Color.Transparent;
            this.l_currentProject.Depth = 0;
            this.l_currentProject.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.l_currentProject.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.l_currentProject.Location = new System.Drawing.Point(480, 0);
            this.l_currentProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.l_currentProject.Name = "l_currentProject";
            this.l_currentProject.Size = new System.Drawing.Size(618, 56);
            this.l_currentProject.TabIndex = 10;
            this.l_currentProject.Text = "Current Project : No selected project";
            this.l_currentProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelOptimize
            // 
            this.panelOptimize.Controls.Add(this.stopButton);
            this.panelOptimize.Controls.Add(this.optimizeBtn);
            this.panelOptimize.Location = new System.Drawing.Point(336, 0);
            this.panelOptimize.Name = "panelOptimize";
            this.panelOptimize.Size = new System.Drawing.Size(64, 56);
            this.panelOptimize.TabIndex = 6;
            // 
            // stopButton
            // 
            this.stopButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stopButton.Depth = 0;
            this.stopButton.DrawShadows = true;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.HighEmphasis = true;
            this.stopButton.Icon = global::LCC.Properties.Resources.stop_480px;
            this.stopButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.stopButton.Location = new System.Drawing.Point(10, 9);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stopButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(44, 36);
            this.stopButton.TabIndex = 0;
            this.stopButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stopButton.UseAccentColor = false;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
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
            this.optimizeBtn.Visible = false;
            this.optimizeBtn.Click += new System.EventHandler(this.optimizeBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exportBtn);
            this.panel2.Controls.Add(this.storageBtn);
            this.panel2.Controls.Add(this.printerBtn);
            this.panel2.Controls.Add(this.redoBtn);
            this.panel2.Controls.Add(this.undoBtn);
            this.panel2.Controls.Add(this.importBtn);
            this.panel2.Location = new System.Drawing.Point(8, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 56);
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
            this.exportBtn.Location = new System.Drawing.Point(110, 9);
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
            // storageBtn
            // 
            this.storageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.storageBtn.Depth = 0;
            this.storageBtn.DrawShadows = true;
            this.storageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storageBtn.HighEmphasis = true;
            this.storageBtn.Icon = global::LCC.Properties.Resources.open_box;
            this.storageBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.storageBtn.Location = new System.Drawing.Point(162, 9);
            this.storageBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.storageBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.storageBtn.Name = "storageBtn";
            this.storageBtn.Size = new System.Drawing.Size(44, 36);
            this.storageBtn.TabIndex = 3;
            this.storageBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.storageBtn.UseAccentColor = false;
            this.storageBtn.UseVisualStyleBackColor = true;
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
            // redoBtn
            // 
            this.redoBtn.AutoSize = false;
            this.redoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.redoBtn.Depth = 0;
            this.redoBtn.DrawShadows = true;
            this.redoBtn.HighEmphasis = true;
            this.redoBtn.Icon = global::LCC.Properties.Resources.redo_removebg_preview;
            this.redoBtn.Location = new System.Drawing.Point(262, 8);
            this.redoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.redoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.redoBtn.Size = new System.Drawing.Size(44, 38);
            this.redoBtn.TabIndex = 16;
            this.redoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.redoBtn.UseAccentColor = false;
            this.redoBtn.UseVisualStyleBackColor = true;
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.AutoSize = false;
            this.undoBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.undoBtn.Depth = 0;
            this.undoBtn.DrawShadows = true;
            this.undoBtn.HighEmphasis = true;
            this.undoBtn.Icon = global::LCC.Properties.Resources.undo__1_;
            this.undoBtn.Location = new System.Drawing.Point(213, 8);
            this.undoBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.undoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.undoBtn.Size = new System.Drawing.Size(44, 38);
            this.undoBtn.TabIndex = 15;
            this.undoBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.undoBtn.UseAccentColor = false;
            this.undoBtn.UseVisualStyleBackColor = true;
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
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
            this.importBtn.Location = new System.Drawing.Point(58, 9);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::LCC.Properties.Resources.logo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(8, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 40);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.windowsPanel);
            this.panel1.Controls.Add(this.fileBtn);
            this.panel1.Controls.Add(this.helpBtn);
            this.panel1.Controls.Add(this.optionsBtn);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 676);
            this.panel1.TabIndex = 13;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.headerHandlerBar);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1099, 62);
            this.panel8.TabIndex = 22;
            // 
            // headerHandlerBar
            // 
            this.headerHandlerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.headerHandlerBar.Controls.Add(this.minimizeBtn);
            this.headerHandlerBar.Controls.Add(this.closeButton);
            this.headerHandlerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerHandlerBar.Location = new System.Drawing.Point(0, 0);
            this.headerHandlerBar.Name = "headerHandlerBar";
            this.headerHandlerBar.Size = new System.Drawing.Size(1099, 16);
            this.headerHandlerBar.TabIndex = 0;
            this.headerHandlerBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerHandlerBar_MouseMove);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(1048, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(28, 16);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "—";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(120)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1072, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 16);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "  X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Clicked);
            // 
            // cleasrCutlengthsBtn
            // 
            this.cleasrCutlengthsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cleasrCutlengthsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cleasrCutlengthsBtn.Depth = 0;
            this.cleasrCutlengthsBtn.DrawShadows = true;
            this.cleasrCutlengthsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cleasrCutlengthsBtn.HighEmphasis = true;
            this.cleasrCutlengthsBtn.Icon = global::LCC.Properties.Resources.cancel_80px;
            this.cleasrCutlengthsBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cleasrCutlengthsBtn.Location = new System.Drawing.Point(868, 11);
            this.cleasrCutlengthsBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cleasrCutlengthsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cleasrCutlengthsBtn.Name = "cleasrCutlengthsBtn";
            this.cleasrCutlengthsBtn.Size = new System.Drawing.Size(192, 36);
            this.cleasrCutlengthsBtn.TabIndex = 3;
            this.cleasrCutlengthsBtn.Text = "Clear Cutlengths";
            this.cleasrCutlengthsBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.cleasrCutlengthsBtn.UseAccentColor = false;
            this.cleasrCutlengthsBtn.UseVisualStyleBackColor = true;
            this.cleasrCutlengthsBtn.Click += new System.EventHandler(this.cleasrCutlengthsBtn_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 682);
            this.Controls.Add(this.statusBarLbl);
            this.Controls.Add(this.panel1);
            this.DrawerShowIconsWhenHidden = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1105, 682);
            this.Name = "Project";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Project_FormClosing);
            this.Load += new System.EventHandler(this.Project_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Project_KeyDown);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.fileMenuStrip.ResumeLayout(false);
            this.windowsPanel.ResumeLayout(false);
            this.windowsPanel.PerformLayout();
            this.tabOptiPlus.ResumeLayout(false);
            this.projTab.ResumeLayout(false);
            this.projTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.cutLengthTab.ResumeLayout(false);
            this.cutLengthTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutLengthsTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.materialTab.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelOptimize.ResumeLayout(false);
            this.panelOptimize.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.headerHandlerBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip projectToolTip;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockLength_cutlength_desc;
      
        private System.Windows.Forms.ContextMenuStrip fileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportItem;
        private System.Windows.Forms.ToolStripMenuItem exportProjects;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private System.ComponentModel.BackgroundWorker oBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem inventoryListItem;
        private System.Windows.Forms.ToolStripMenuItem commLengthListItem;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton logoutBtn;
        private MaterialSkin.Controls.MaterialButton helpBtn;
        private MaterialSkin.Controls.MaterialButton optionsBtn;
        private Label statusBarLbl;
        private MaterialSkin.Controls.MaterialButton fileBtn;
        private Panel windowsPanel;
        private MaterialSkin.Controls.MaterialTextBox searchString;
        private ProgressBar progressOptimize;
        public MaterialSkin.Controls.MaterialTabControl tabOptiPlus;
        private TabPage projTab;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label cellClickLabel;
        public DataGridView projectTable;
        private MaterialSkin.Controls.MaterialButton addProject;
        private Panel panel3;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton6;
        public TabPage cutLengthTab;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DataGridView cutLengthsTable;
        private Panel panel5;
        private MaterialSkin.Controls.MaterialButton addCutlength;
        private TabPage materialTab;
        private Components.MaterialComponent materialComponent1;
        private TabPage tabResult;
        private Components.OptimizeComponent optimizeComponent1;
        private TabPage tabPage1;
        private Components.OptiplusComponent optiplusComponent1;
        private MaterialSkin.Controls.MaterialTabSelector oProjectTabSelector;
        private MaterialSkin.Controls.MaterialLabel l_currentProject;
        private Panel panelOptimize;
        private MaterialSkin.Controls.MaterialButton stopButton;
        private MaterialSkin.Controls.MaterialButton optimizeBtn;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton exportBtn;
        private MaterialSkin.Controls.MaterialButton storageBtn;
        private MaterialSkin.Controls.MaterialButton printerBtn;
        private MaterialSkin.Controls.MaterialButton redoBtn;
        private MaterialSkin.Controls.MaterialButton undoBtn;
        private MaterialSkin.Controls.MaterialButton importBtn;
        private Button button1;
        private Panel panel1;
        private Panel panel8;
        private Panel handleHeaderBar;
        private Panel headerHandlerBar;
        private Label closeButton;
        private MaterialSkin.Controls.MaterialButton adminBtn;
        private LinkLabel accessAdminLinkBtn;
        private Button logoBtn;
        private Label minimizeBtn;
        private DataGridViewTextBoxColumn project_reference;
        private DataGridViewTextBoxColumn project_name;
        private DataGridViewTextBoxColumn scope;
        private DataGridViewTextBoxColumn rev_no;
        private DataGridViewButtonColumn edit_column;
        private DataGridViewButtonColumn delete_column;
        private DataGridViewTextBoxColumn cutlength_partcode;
        private DataGridViewTextBoxColumn cutlength_description;
        private DataGridViewTextBoxColumn cutlength_grade;
        private DataGridViewTextBoxColumn cutlength_qty;
        private DataGridViewTextBoxColumn cutlength_uncut_qty;
        private DataGridViewTextBoxColumn cutlength_length;
        private DataGridViewTextBoxColumn cutlength_order_no;
        private DataGridViewTextBoxColumn cutlength_note;
        private DataGridViewButtonColumn cutlength_delete;
        private Label login_details_label;
        private MaterialSkin.Controls.MaterialButton cleasrCutlengthsBtn;
    }
}