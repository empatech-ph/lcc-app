using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TeixeiraSoftware.Finance;
using System.Linq;

namespace LCC
{
    public partial class Options : MaterialForm
    {
        public Options()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
        }

        private void Options_Load(object sender, EventArgs e)
        {
            //symbol data
            var allCurrencies = (from cur in Currency.AllCurrencies
                                 select new 
                                 {
                                     displayItem = cur.Sign + " "+ cur.Name
                                 });

            symbolDropdown.DataSource = allCurrencies.Select(x=> x.displayItem).ToList();
        }

        private void optOkBtn_Click(object sender, EventArgs e)
        {
            if (unitDropdown.SelectedItem.ToString() == "mm") {
                //
            }
        }
    }
}
