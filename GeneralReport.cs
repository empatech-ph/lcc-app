using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using JsonFlatFileDataStore;
using LCC.Model;
using Newtonsoft.Json;
using System.Linq;
using Microsoft.ReportingServices;
using System.Web;


namespace LCC
{
    public partial class GeneralReport : MaterialForm
    {
        public GeneralReport()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void GeneralReport_Load(object sender, EventArgs e)
        {

        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
