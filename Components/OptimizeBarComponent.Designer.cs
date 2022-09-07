
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
            this.SuspendLayout();
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.optimizeBarPanel.ColumnCount = 1;
            this.optimizeBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 0);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.RowCount = 2;
            this.optimizeBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.optimizeBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.optimizeBarPanel.Size = new System.Drawing.Size(1876, 84);
            this.optimizeBarPanel.TabIndex = 0;
            // 
            // OptimizeBarComponent
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.Controls.Add(this.optimizeBarPanel);
            this.Name = "OptimizeBarComponent";
            this.Size = new System.Drawing.Size(1876, 84);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel optimizeBarPanel;
    }
}
