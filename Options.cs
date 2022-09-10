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
using LCC.Model;
using JsonFlatFileDataStore;
using LCC.Library;

namespace LCC
{
    public partial class Options : MaterialForm
    {
        private DataStore oFile;
        public Options()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
            this.oFile = UtilsLibrary.getUserFile();
            this.precisionDropdown.SelectedIndex = 0;
            this.typeDropdown.SelectedIndex = 0;
            this.unitDropdown.SelectedIndex = 0;
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

            OptionSettingsModel oOptions = GLOBAL.getOptions();
            this.precisionDropdown.Text = oOptions.precision;
            this.typeDropdown.Text = oOptions.type;
            this.unitDropdown.Text = oOptions.unit;
        }

        private void optOkBtn_Click(object sender, EventArgs e)
        {

            var collection = this.oFile.GetCollection<OptionSettingsModel>();
            if (collection.Count > 0)
            {
                collection.UpdateOne(x => x.id == 0, new OptionSettingsModel
                {
                    id = 0,
                    precision = this.precisionDropdown.Text,
                    type = this.typeDropdown.Text,
                    unit = this.unitDropdown.Text,
                    zero_supression_leading = false,
                    zero_supression_trailing = false
                });
            } else
            {
                collection.InsertOne(new OptionSettingsModel
                {
                    id = 0,
                    precision = this.precisionDropdown.Text,
                    type = this.typeDropdown.Text,
                    unit = this.unitDropdown.Text,
                    zero_supression_leading = false,
                    zero_supression_trailing = false
                });
            }
            MessageBox.Show("Setting was updated. Changes might be reflected after the app restarted.");
            this.Hide();
        }

        private void cancelOptBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
