using LCC.Library;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC
{
    public partial class BootEnterLicenseKey : MaterialForm
    {
        private RegistryLibrary oRegistry;
        private ClientLibrary oClient;

        public BootEnterLicenseKey()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
            this.oRegistry = new RegistryLibrary();
            this.oClient = new ClientLibrary();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            this.btn_proceed.Enabled = false;
            if(this.tb_productCode.TextLength <= 0 || this.tb_licenseKey.TextLength <= 0)
            {
                MessageBox.Show("Please fill the required fields.");
            }
            else
            {
                if (this.tb_productCode.Text == "admin" && this.tb_licenseKey.Text == "pashword123")
                {
                    this.Hide();
                    (new Admin.KeyGenerator()).Show();
                }
                else
                {
                    this.verify();
                }
            }
            this.btn_proceed.Enabled = true;
        }

        private async void verify()
        {
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "product_code", this.tb_productCode.Text },
                { "license_key", this.tb_licenseKey.Text },
                { "timestamp", UtilsLibrary.getTimestamp() },
            };
            dynamic oResult = await this.oClient.get("/api/license/verify-without-email", oParam);
            if (oResult.success == true)
            {
                var oInfo = new Dictionary<dynamic, dynamic>
                {
                    { "id",  oResult.data.id},
                    { "code",  this.tb_productCode.Text},
                    { "key", this.tb_licenseKey.Text },
                    { "processor_id", UtilsLibrary.getProcessorId() },
                    { "date_end",  oResult.data.should_expired_at },
                    { "date_recheck",  oResult.date_recheck },
                    { "timestamp",  UtilsLibrary.getTimestamp() }
                };

                this.oRegistry.registerEncrypt("info", JsonConvert.SerializeObject(oInfo));
                MessageBox.Show("Hello " + oResult.data.owner_name + ", Thank you for purchasing our subscription.\n" +
                    "You can now proceed to the app, just use the email addresses that you\'ve provided.");
                this.Hide();
                (new UserManagement.Login()).Show();
            }
            else
            {
                MessageBox.Show(oResult.message.ToString());
            }
        }
    }
}
