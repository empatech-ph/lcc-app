
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
            this.optimizeBarPanel = new System.Windows.Forms.TableLayoutPanel();
            this.barLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.optimizeBarPanel.ColumnCount = 1;
            this.optimizeBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 46);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.RowCount = 2;
            this.optimizeBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.optimizeBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optimizeBarPanel.Size = new System.Drawing.Size(1874, 108);
            this.optimizeBarPanel.TabIndex = 0;
            // 
            // barLabel
            // 
            this.barLabel.AutoSize = true;
            this.barLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barLabel.Location = new System.Drawing.Point(8, 16);
            this.barLabel.Name = "barLabel";
            this.barLabel.Size = new System.Drawing.Size(0, 21);
            this.barLabel.TabIndex = 1;
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
            this.Controls.Add(this.barLabel);
            this.Controls.Add(this.optimizeBarPanel);
            this.Name = "OptimizeBarComponent";
            this.Size = new System.Drawing.Size(1874, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel optimizeBarPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label barLabel;
    }
}
