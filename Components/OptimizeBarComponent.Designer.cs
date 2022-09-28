
namespace LCC.Components
{
    partial class OptimizeBarComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dt_parts = new System.Windows.Forms.DataGridView();
            this.layout_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_part_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_order_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layout_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelUpperHolder = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRepeat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStockCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optimizeBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_parts)).BeginInit();
            this.panelUpperHolder.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dt_parts);
            this.mainPanel.Controls.Add(this.panelUpperHolder);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1874, 215);
            this.mainPanel.TabIndex = 15;
            // 
            // dt_parts
            // 
            this.dt_parts.AllowUserToAddRows = false;
            this.dt_parts.AllowUserToDeleteRows = false;
            this.dt_parts.AllowUserToOrderColumns = true;
            this.dt_parts.AllowUserToResizeColumns = false;
            this.dt_parts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_parts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_parts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dt_parts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_parts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layout_no,
            this.layout_part_no,
            this.layout_description,
            this.layout_order_no,
            this.layout_length,
            this.layout_count});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_parts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dt_parts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt_parts.GridColor = System.Drawing.Color.White;
            this.dt_parts.Location = new System.Drawing.Point(0, 176);
            this.dt_parts.MultiSelect = false;
            this.dt_parts.Name = "dt_parts";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_parts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dt_parts.RowHeadersVisible = false;
            this.dt_parts.RowTemplate.Height = 25;
            this.dt_parts.RowTemplate.ReadOnly = true;
            this.dt_parts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dt_parts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dt_parts.Size = new System.Drawing.Size(1874, 39);
            this.dt_parts.TabIndex = 16;
            this.dt_parts.DataSourceChanged += new System.EventHandler(this.dt_parts_DataSourceChanged);
            this.dt_parts.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dt_parts_DataBindingComplete);
            // 
            // layout_no
            // 
            this.layout_no.DataPropertyName = "no";
            this.layout_no.HeaderText = "#";
            this.layout_no.Name = "layout_no";
            // 
            // layout_part_no
            // 
            this.layout_part_no.DataPropertyName = "part_no";
            this.layout_part_no.HeaderText = "Part No.";
            this.layout_part_no.Name = "layout_part_no";
            // 
            // layout_description
            // 
            this.layout_description.DataPropertyName = "description";
            this.layout_description.HeaderText = "Description";
            this.layout_description.Name = "layout_description";
            // 
            // layout_order_no
            // 
            this.layout_order_no.DataPropertyName = "order_no";
            this.layout_order_no.HeaderText = "Order Number";
            this.layout_order_no.Name = "layout_order_no";
            // 
            // layout_length
            // 
            this.layout_length.DataPropertyName = "length";
            this.layout_length.HeaderText = "Length";
            this.layout_length.Name = "layout_length";
            // 
            // layout_count
            // 
            this.layout_count.DataPropertyName = "repeat";
            this.layout_count.HeaderText = "Count";
            this.layout_count.Name = "layout_count";
            // 
            // panelUpperHolder
            // 
            this.panelUpperHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUpperHolder.Controls.Add(this.panel2);
            this.panelUpperHolder.Controls.Add(this.optimizeBarPanel);
            this.panelUpperHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpperHolder.Location = new System.Drawing.Point(0, 0);
            this.panelUpperHolder.Name = "panelUpperHolder";
            this.panelUpperHolder.Size = new System.Drawing.Size(1874, 176);
            this.panelUpperHolder.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.labelRepeat);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.labelLength);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelRest);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.labelStockCode);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelInc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1872, 64);
            this.panel2.TabIndex = 3;
            // 
            // labelRepeat
            // 
            this.labelRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRepeat.AutoSize = true;
            this.labelRepeat.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRepeat.Location = new System.Drawing.Point(465, 30);
            this.labelRepeat.Name = "labelRepeat";
            this.labelRepeat.Size = new System.Drawing.Size(22, 25);
            this.labelRepeat.TabIndex = 13;
            this.labelRepeat.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(385, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Repeat:";
            // 
            // labelLength
            // 
            this.labelLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLength.Location = new System.Drawing.Point(246, 30);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(22, 25);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(174, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Length:";
            // 
            // labelRest
            // 
            this.labelRest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRest.AutoSize = true;
            this.labelRest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRest.Location = new System.Drawing.Point(61, 30);
            this.labelRest.Name = "labelRest";
            this.labelRest.Size = new System.Drawing.Size(22, 25);
            this.labelRest.TabIndex = 9;
            this.labelRest.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rest:";
            // 
            // labelStockCode
            // 
            this.labelStockCode.AutoSize = true;
            this.labelStockCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStockCode.Location = new System.Drawing.Point(286, 5);
            this.labelStockCode.Name = "labelStockCode";
            this.labelStockCode.Size = new System.Drawing.Size(63, 25);
            this.labelStockCode.TabIndex = 7;
            this.labelStockCode.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(174, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock Code:";
            // 
            // labelInc
            // 
            this.labelInc.AutoSize = true;
            this.labelInc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInc.Location = new System.Drawing.Point(86, 5);
            this.labelInc.Name = "labelInc";
            this.labelInc.Size = new System.Drawing.Size(63, 25);
            this.labelInc.TabIndex = 5;
            this.labelInc.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Layout";
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.optimizeBarPanel.ColumnCount = 1;
            this.optimizeBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 66);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.RowCount = 2;
            this.optimizeBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.optimizeBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optimizeBarPanel.Size = new System.Drawing.Size(1872, 108);
            this.optimizeBarPanel.TabIndex = 2;
            // 
            // OptimizeBarComponent
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CausesValidation = false;
            this.Controls.Add(this.mainPanel);
            this.Name = "OptimizeBarComponent";
            this.Size = new System.Drawing.Size(1874, 215);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_parts)).EndInit();
            this.panelUpperHolder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUpperHolder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRepeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStockCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel optimizeBarPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dt_parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_part_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_order_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn layout_count;
    }
}
