
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
            this.optimizeBarPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.optimizeBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // optimizeBarPanel
            // 
            this.optimizeBarPanel.Controls.Add(this.panel2);
            this.optimizeBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimizeBarPanel.Location = new System.Drawing.Point(0, 0);
            this.optimizeBarPanel.Name = "optimizeBarPanel";
            this.optimizeBarPanel.Size = new System.Drawing.Size(477, 27);
            this.optimizeBarPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 18);
            this.panel2.TabIndex = 0;
            // 
            // OptimizeBarComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.optimizeBarPanel);
            this.Name = "OptimizeBarComponent";
            this.Size = new System.Drawing.Size(477, 27);
            this.optimizeBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel optimizeBarPanel;
        private System.Windows.Forms.Panel panel2;
    }
}
