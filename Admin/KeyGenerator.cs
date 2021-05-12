using LCC.Library;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.Admin
{
    public partial class KeyGenerator : MaterialForm
    {
        private ClientLibrary oClient;

        private KeyGeneratorLibrary oKeyGen;

        public KeyGenerator()
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

            this.oClient = new ClientLibrary();
            this.oKeyGen = new KeyGeneratorLibrary();
            this.cb_licenseKeyLife.SelectedIndex = 0;

        }

        private void b_generate_Click(object sender, EventArgs e)
        {
            this.generate();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            if (this.tb_ownerEmail.TextLength <= 0 || this.rt_allowedEmails.TextLength <= 0 || this.tb_licenseKey.TextLength <= 0 || this.tb_prodCode.TextLength <= 0 || this.tb_ownerName.TextLength <= 0)
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
            dynamic oResult = await this.oClient.get("/api/license/id", oParam);
            if (oResult.success == true)
            {
                if (this.tb_prodCode.TextLength <= 0) this.tb_prodCode.Text = this.oKeyGen.getProductCode((int) oResult.id);
                if (this.tb_licenseKey.TextLength <= 0) this.tb_licenseKey.Text = this.oKeyGen.getGeneratedLicenseKey();
            }
        }

        private async void save()
        {
            var oParamLicense = new Dictionary<dynamic, dynamic>
                {
                    { "owner_name", this.tb_ownerName.Text },
                    { "product_code", this.tb_prodCode.Text },
                    { "license_key", this.tb_licenseKey.Text },
                    { "license_key_life", this.cb_licenseKeyLife.Text },
                    { "allowed_emails", this.rt_allowedEmails.Text },
                    { "owner_email", this.tb_ownerEmail.Text },
                    { "timestamp", UtilsLibrary.getTimestamp() },
                };

            dynamic oResult = await this.oClient.send("/api/license", oParamLicense);
            if (oResult.success == true)
            {
                MessageBox.Show(oResult.message.ToString());
                var oParamUser = new Dictionary<dynamic, dynamic>
                {
                    { "name", this.tb_ownerName.Text },
                    { "email", this.tb_ownerEmail.Text },
                    { "user_type", 1 },
                    { "license_id", (int) oResult.id },
                    { "should_expired_at", (int) oResult.id },
                    { "timestamp", UtilsLibrary.getTimestamp() },
                };
                dynamic oUserResult = await this.oClient.send("/api/user", oParamUser);
                if(oUserResult.success == false)
                {
                    MessageBox.Show(oUserResult.message.ToString());
                }
                this.clearFields();
            }
            else
            { 
                MessageBox.Show(oResult.message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }

        private void clearFields()
        {
            this.tb_ownerEmail.Clear();
            this.rt_allowedEmails.Clear();
            this.tb_ownerName.Clear();
            this.tb_prodCode.Clear();
            this.tb_licenseKey.Clear();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            new KeyVerifier().ShowDialog();
        }

        private void rt_allowedEmails_Click(object sender, EventArgs e)
        {
            var oAssignRoles = new AssignRoles(this.rt_allowedEmails.Text);
            oAssignRoles.oAssignRoles = this.rt_allowedEmails;
            oAssignRoles.ShowDialog();
        }
    }
}
