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
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);
            this.oRegistry = new RegistryLibrary();
            this.oClient = new ClientLibrary();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if(this.tb_productCode.TextLength <= 0 || this.tb_licenseKey.TextLength <= 0)
            {
                MessageBox.Show("Please fill the required fields");
            }
            else
            {
                this.verify();
            }
        }

        private async void verify()
        {
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "product_code", this.tb_productCode.Text },
                { "license_key", this.tb_licenseKey.Text },
                { "timestamp", UtilsLibrary.getTimestamp() },
            };
            var sResult = await this.oClient.send("/api/license/verify-without-email", oParam);
            dynamic oJson = JObject.Parse(sResult);
            if (oJson.success == true)
            {
                this.oRegistry.register("key", this.tb_licenseKey.Text);
                this.oRegistry.register("code", this.tb_productCode.Text);
                MessageBox.Show("Hello " + oJson.data.owner_name + ", Thank you for purchasing our subscription.\n" +
                    "You can now proceed to the app, just use the email addresses that you\'ve provided.");
            }
            else
            {
                MessageBox.Show("It seems that your details inputted is incorrect, please verify!.");
            }
        }
    }
}
