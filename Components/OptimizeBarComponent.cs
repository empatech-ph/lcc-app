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
        private bool bHasLastKerf = false;
        public OptimizeBarComponent()
        {
            InitializeComponent();
        }

        public void initializeBar(TempStocklengthModel oStockLength)
        {
            int iCounter = 0;
            if (oStockLength.trim_left > 0)
            {
                Panel oPanel = this.getNewGeneratedPanel(Color.White);
                oPanel.Dock = DockStyle.Fill;
                oPanel.Margin = new Padding(0);
                this.optimizeBarPanel.ColumnCount++;
                this.optimizeBarPanel.ColumnStyles.Insert(iCounter, new ColumnStyle(SizeType.Percent, (float)(oStockLength.trim_left / oStockLength.length) * 100));
                oPanel.Paint += this.paintPanelTrim;
                this.optimizeBarPanel.Controls.Add(oPanel, iCounter, 0);
                iCounter++;
            }
             
            foreach (int iVal in Enumerable.Range(1, oStockLength.total_cut))
            {
                float fPercent = (float)(oStockLength.cutlength_length / oStockLength.length) * 100;
                this.optimizeBarPanel.ColumnCount++;
                this.optimizeBarPanel.ColumnStyles.Insert(iCounter, new ColumnStyle(SizeType.Percent, fPercent));
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedPanel(Color.FromArgb(200, 63, 81, 181)), iCounter, 0);
                iCounter++;
                if (oStockLength.rest >= oStockLength.kerf && oStockLength.kerf != 0)
                {
                    this.bHasLastKerf = true;
                }
                else
                {
                    this.bHasLastKerf = false;
                }
                if (oStockLength.kerf > 0 || this.bHasLastKerf == true)
                {
                    Panel oPanel = this.getNewGeneratedPanel(Color.White);
                    oPanel.Dock = DockStyle.Fill;
                    oPanel.Margin = new Padding(0);
                    this.optimizeBarPanel.ColumnCount++;
                    this.optimizeBarPanel.ColumnStyles.Insert(iCounter, new ColumnStyle(SizeType.Percent, (float)(oStockLength.kerf / oStockLength.length) * 100));
                    oPanel.Paint += this.paintPanelKerf;
                    this.optimizeBarPanel.Controls.Add(oPanel, iCounter, 0);
                    iCounter++;
                } 
            }
            double dRestScrap = ((oStockLength.rest <= 0) ? oStockLength.scrap : oStockLength.rest);
            this.generateWastePanel(iCounter++, (float)(dRestScrap / oStockLength.length) * 100);
            if (oStockLength.trim_right > 0)
            {
                Panel oPanel = this.getNewGeneratedPanel(Color.White);
                oPanel.Dock = DockStyle.Fill;
                oPanel.Margin = new Padding(0);
                this.optimizeBarPanel.ColumnCount++;
                this.optimizeBarPanel.ColumnStyles.Insert(iCounter, new ColumnStyle(SizeType.Percent, (float)(oStockLength.trim_right / oStockLength.length) * 100));
                oPanel.Paint += this.paintPanelTrim;
                this.optimizeBarPanel.Controls.Add(oPanel, iCounter, 0);
                iCounter++;
            }
            this.generateDetails(oStockLength.total_cut, (oStockLength.kerf > 0) ? (oStockLength.total_cut * 2) - 1 : oStockLength.total_cut, oStockLength.cutlength_length, dRestScrap, oStockLength.stock_code, oStockLength.trim_left, oStockLength.trim_right);
        }

        private void generateDetails(int iTotalCutLabel, int iTotalCut, double fCutlengthLength, double dRest, string sStockCode, double dTrimLeft, double dTrimRight)
        {
            try
            {
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedLabel(sStockCode + "\n" + fCutlengthLength + " mm x " + iTotalCutLabel), (dTrimLeft > 0) ? 1 : 0, 1);
                this.optimizeBarPanel.SetColumnSpan(this.optimizeBarPanel.GetControlFromPosition((dTrimLeft > 0) ? 1 : 0, 1), iTotalCut + ((bHasLastKerf == true) ? 1 : 0));
            }
            catch (Exception e) { }
            if (dRest > 0)
            {
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedLabel(dRest + " mm"), (dTrimLeft > 0) ? 2 : 1, 1);
                this.optimizeBarPanel.SetColumnSpan(this.optimizeBarPanel.GetControlFromPosition((dTrimLeft > 0) ? 2 : 1, 1), iTotalCut  + ((bHasLastKerf == true) ? 1 : 0));
            }

        }

        private Label getNewGeneratedLabel(string sText)
        {
            Label oLabel = new Label();
            oLabel.Text = sText;
            oLabel.Font = new Font(FontFamily.GenericSansSerif, 12F, FontStyle.Regular);
            oLabel.TextAlign = ContentAlignment.MiddleCenter;
            oLabel.Dock = DockStyle.Fill;
            return oLabel;
        }

        private void generateWastePanel(int iLastRow, float fPercent)
        {
            if (fPercent > 0)
            {
                Panel oPanel = this.getNewGeneratedPanel(Color.White);
                oPanel.Dock = DockStyle.Fill;
                oPanel.Margin = new Padding(0);
                this.optimizeBarPanel.ColumnStyles.Insert(iLastRow, new ColumnStyle(SizeType.Percent, fPercent));
                oPanel.Paint += this.paintPanelWaste;
                this.optimizeBarPanel.Controls.Add(oPanel, iLastRow, 0);
            }else
            {
                this.optimizeBarPanel.ColumnCount--;
            }

        }

        private void paintPanelWaste(object oObject, PaintEventArgs oPaint)
        {
            HatchBrush oBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Gray, Color.White);
            oPaint.Graphics.FillRectangle(oBrush, 0, 0, 2000, 100);
        }  
        
        private void paintPanelTrim(object oObject, PaintEventArgs oPaint)
        {
            HatchBrush oBrush = new HatchBrush(HatchStyle.Percent30, Color.Gray, Color.White);
            oPaint.Graphics.FillRectangle(oBrush, 0, 0, 2000, 100);
        }        
        
        private void paintPanelKerf(object oObject, PaintEventArgs oPaint)
        {
            HatchBrush oBrush = new HatchBrush(HatchStyle.Percent05, Color.Gray, Color.White);
            oPaint.Graphics.FillRectangle(oBrush, 0, 0, 2000, 100);
        }

        private Panel getNewGeneratedPanel(Color oColor)
        {
            Panel oPanel = new Panel();
            oPanel.Dock = DockStyle.Fill;
            oPanel.Margin = new Padding(0);
            oPanel.BackColor = oColor;
            return oPanel;

        }

    }
}
