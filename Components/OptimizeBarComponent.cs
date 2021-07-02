using LCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Components
{
    public partial class OptimizeBarComponent : UserControl
    {
        public OptimizeBarComponent()
        {
            InitializeComponent();
        }

        public void initializeBar(TempStocklengthModel oStockLength)
        {
            int iCounter = 0;
            this.optimizeBarPanel.ColumnCount = oStockLength.total_cut;
            foreach (int iVal in Enumerable.Range(1, oStockLength.total_cut))
            {
                float fPercent = (float)(oStockLength.cutlength_length / oStockLength.length) * 100;
                this.optimizeBarPanel.ColumnStyles.Insert(iCounter, new ColumnStyle(SizeType.Percent, fPercent));
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedPanel(Color.FromArgb(200, 63, 81, 181)), iCounter, 0);
                iCounter++;
            }
            this.generateWastePanel(iCounter, (float)(oStockLength.rest / oStockLength.length) * 100);
            this.generateDetails(oStockLength.total_cut, oStockLength.cutlength_length, oStockLength.rest, oStockLength.stock_code);
        }

        private void generateDetails(int iTotalCut, double fCutlengthLength, double dRest, string sStockCode)
        {
            this.optimizeBarPanel.Controls.Add(this.getNewGeneratedLabel(sStockCode + "\n" + fCutlengthLength + "mm x " + iTotalCut), 0, 1);
            this.optimizeBarPanel.SetColumnSpan(this.optimizeBarPanel.GetControlFromPosition(0, 1), iTotalCut);

            if (dRest > 0)
            {
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedLabel(dRest + "mm"), 1, 1);
                this.optimizeBarPanel.SetColumnSpan(this.optimizeBarPanel.GetControlFromPosition(1, 1), iTotalCut);
            }

        }

        private Label getNewGeneratedLabel(string sText)
        {
            Label oLabel = new Label();
            oLabel.Text = sText;
            oLabel.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            oLabel.TextAlign = ContentAlignment.MiddleCenter;
            oLabel.Dock = DockStyle.Fill;
            return oLabel;
        }

        private void generateWastePanel(int iLastRow, float fPercent)
        { 
            if (fPercent > 0)
            {
                Panel oPanel = this.getNewGeneratedPanel(Color.White);
                this.optimizeBarPanel.ColumnCount++;
                this.optimizeBarPanel.ColumnStyles.Insert(iLastRow, new ColumnStyle(SizeType.Percent, fPercent));
                oPanel.Paint += this.paintPanel;
                this.optimizeBarPanel.Controls.Add(oPanel, iLastRow, 0);
            }

        }

        private void paintPanel(object oObject, PaintEventArgs oPaint)
        {
            HatchBrush oBrush = new HatchBrush(HatchStyle.ForwardDiagonal, Color.Black, Color.White);
            oPaint.Graphics.FillRectangle(oBrush, 0, 0, 2000, 100);
        }

        private Panel getNewGeneratedPanel(Color oColor)
        {
            Panel oPanel = new Panel();
            oPanel.Dock = DockStyle.Fill;
            oPanel.BackColor = oColor;
            return oPanel;

        }



    }
}
