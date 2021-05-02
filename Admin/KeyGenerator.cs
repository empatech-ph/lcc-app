using LCC.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.Admin
{
    public partial class KeyGenerator : Form
    {
        private ClientLibrary oClient;

        private KeyGeneratorLibrary oKeyGen;

        public KeyGenerator()
        {
            InitializeComponent();
            this.oClient = new ClientLibrary(Properties.Resources.ResourceManager.GetString("webhost"));
            this.oKeyGen = new KeyGeneratorLibrary();
            this.cb_noOfUserCanAccess.SelectedIndex = 0;
            this.cb_licenseKeyLife.SelectedIndex = 0;
        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            this.generate();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (this.tb_licenseKey.TextLength <= 0 || this.tb_prodCode.TextLength <= 0 || this.tb_ownerName.TextLength <= 0)
            {
                MessageBox.Show("Please provide requered fields");
            }
            else
            {
                this.save();
            }
        }

        private async void generate()
        {
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "timestamp", UtilsLibrary.getTimestamp() }
            };
            var sLatestId = await this.oClient.get("/api/license/id", oParam);
            if (this.tb_prodCode.TextLength <= 0) this.tb_prodCode.Text = this.oKeyGen.getProductCode(Int32.Parse(sLatestId));
            if (this.tb_licenseKey.TextLength <= 0) this.tb_licenseKey.Text = this.oKeyGen.getGeneratedLicenseKey();
        }

        private async void save()
        {
            var oParam = new Dictionary<dynamic, dynamic>
                {
                    { "owner_name", this.tb_ownerName.Text },
                    { "product_code", this.tb_prodCode.Text },
                    { "license_key", this.tb_licenseKey.Text },
                    { "license_key_life", this.cb_licenseKeyLife.Text },
                    { "total_access", this.cb_noOfUserCanAccess.Text },
                    { "timestamp", UtilsLibrary.getTimestamp() },
                };

            var sResult = await this.oClient.send("/api/license", oParam);
            MessageBox.Show(sResult);
            this.clearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void clearFields()
        {
            this.tb_ownerName.Clear();
            this.tb_prodCode.Clear();
            this.tb_licenseKey.Clear();
        }
    }
}
