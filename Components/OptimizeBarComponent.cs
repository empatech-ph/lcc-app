using LCC.Library;
using LCC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCC.Components
{
    public partial class OptimizeBarComponent : UserControl
    {
        private bool bHasLastKerf = false;
        private int iIncr = 1;
        public OptimizeBarComponent()
        {
            InitializeComponent();
        }

        public string initializeBar(TempStocklengthModel oStockLength, int iIncrCounter = 1)
        {
            this.iIncr = iIncrCounter;
            this.labelInc.Text = "L" + iIncrCounter.ToString();
            this.labelLength.Text = oStockLength.length.ToString();
            this.labelRepeat.Text = oStockLength.repeated.ToString();
            this.labelRest.Text = oStockLength.rest.ToString();
            this.labelStockCode.Text = oStockLength.data.part_code;
            int iCounter = 0;
            int iNoCounter = 1;

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
            GLOBAL.oTempPartOptimized.Add(new TempPartOptimized
            {
                no = iNoCounter++,
                description = oStockLength.data.description,
                length = oStockLength.length,
                order_no = oStockLength.order_no,
                part_no = oStockLength.cutlength_length,
                repeat = oStockLength.total_cut,
                temp_stock_id = oStockLength.id
            });

            if (dRestScrap > 0)
            {
                GLOBAL.oTempPartOptimized.Add(new TempPartOptimized
                {
                    no = iNoCounter++,
                    description = oStockLength.data.description,
                    length = oStockLength.length,
                    order_no = oStockLength.order_no,
                    part_no = dRestScrap,
                    repeat = 1,
                    temp_stock_id = oStockLength.id
                });
            }
            
            this.generateDetails(oStockLength.total_cut, (oStockLength.kerf > 0) ? (oStockLength.total_cut * 2) - 1 : oStockLength.total_cut, oStockLength.cutlength_length, oStockLength.rest, oStockLength.data.part_code, oStockLength.trim_left, oStockLength.trim_right);
            this.dt_parts.DataSource = GLOBAL.oTempPartOptimized.Where(e => e.temp_stock_id == oStockLength.id).ToList();

            string sPublicPath = UtilsLibrary.getPublicPath() + @"\L" + iIncrCounter.ToString() + ".jpg";
            return new Uri(sPublicPath).AbsoluteUri;
        }

        private double generateDetails(int iTotalCutLabel, int iTotalCut, double fCutlengthLength, double dRest, string sStockCode, double dTrimLeft, double dTrimRight)
        {
            double dLength = 0;
            try
            {
                dLength = fCutlengthLength;
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedLabel(sStockCode + "\n" + dLength + " " + GLOBAL.getOptions().unit ?? "mm" + " x " + iTotalCutLabel), (dTrimLeft > 0) ? 1 : 0, 1);
                this.optimizeBarPanel.SetColumnSpan(this.optimizeBarPanel.GetControlFromPosition((dTrimLeft > 0) ? 1 : 0, 1), iTotalCut + ((bHasLastKerf == true) ? 1 : 0));

            }
            catch (Exception e) { }
            if (dRest > 0)
            {
                dLength = dRest;
                this.optimizeBarPanel.Controls.Add(this.getNewGeneratedLabel(dRest + " " + GLOBAL.getOptions().unit ?? "mm"), (dTrimLeft > 0) ? 2 : 1, 1);
                this.optimizeBarPanel.SetColumnSpan(this.optimizeBarPanel.GetControlFromPosition((dTrimLeft > 0) ? 2 : 1, 1), iTotalCut + ((bHasLastKerf == true) ? 1 : 0));
            }
            return dLength;

        }

        private double getDLength(int iTotalCutLabel, int iTotalCut, double fCutlengthLength, double dRest, string sStockCode, double dTrimLeft, double dTrimRight)
        {
            double dLength = 0;
            try
            {
                dLength = fCutlengthLength;
            }
            catch (Exception e) { }
            if (dRest > 0)
            {
                dLength = dRest;
            }
            return dLength;

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

        private void dt_parts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string sPublicPath = UtilsLibrary.getPublicPath() + @"\L" + this.iIncr.ToString() + "-COMPRESSED.jpg";
            using (Bitmap oImage = new Bitmap(this.mainPanel.Width, this.mainPanel.Height))
            {
                double dNewWidth = this.mainPanel.Width / 1.8;
                double dNewHeight = this.mainPanel.Height / 1.8;
                this.mainPanel.DrawToBitmap(oImage, new Rectangle(0, 0, this.mainPanel.Width, this.mainPanel.Height));
                FixedSize(oImage, (int)Math.Round(dNewWidth), (int)Math.Round(dNewHeight)).Save(sPublicPath, ImageFormat.Jpeg);
            }
            int iHeight = 0;
            int iRowHeight = 50;
            this.dt_parts.Columns["temp_stock_id"].Visible = false;
            foreach (DataGridViewRow row in this.dt_parts.Rows)
            {
                iHeight += row.Height;
            }
            iHeight += iRowHeight;

            this.dt_parts.Height = iHeight;
            this.Height += iHeight;
                this.mainPanel.Height = this.Height;


            sPublicPath = UtilsLibrary.getPublicPath() + @"\L" + this.iIncr.ToString() + ".jpg";
            using (Bitmap oImage = new Bitmap(this.mainPanel.Width, this.mainPanel.Height))
            {
                this.mainPanel.DrawToBitmap(oImage, new Rectangle(0, 0, this.mainPanel.Width, this.mainPanel.Height));
                oImage.Save(sPublicPath, ImageFormat.Jpeg);
            }
            this.Height = 180;

        }

        private void dt_parts_DataSourceChanged(object sender, EventArgs e)
        {
        }
        private Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.Width,
                             imgPhoto.Height);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }
    }
}
