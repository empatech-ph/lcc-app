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

namespace LCC.UserManagement
{
    public partial class Login : MaterialForm
    {
        private ClientLibrary oClient;

        public Login()
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
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tb_email.TextLength <= 0)
            {
                MessageBox.Show("Please provide requered fields");
            }
            else
            {
                this.login();
            }

        }

        private async void login()
        {
            string sInfo = (new Library.RegistryLibrary()).getRegistry("info");
            dynamic oInfo = JObject.Parse(Library.EncryptionDecryptionLibrary.decrypt(Library.EncryptionDecryptionLibrary.getDecryptBase64(sInfo)));
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "timestamp", UtilsLibrary.getTimestamp() },
                { "license_key", oInfo.key },
                { "product_code", oInfo.code },
                { "password", this.tb_password.Text},
                { "email", this.tb_email.Text},
            };
            dynamic oResult = await this.oClient.send("/api/user/login", oParam);
            if (oResult.success == true)
            {
                if (oResult.change_password == true)
                {
                    MessageBox.Show("Please change your password.");
                    new UserManagement.ChangePassword().ShowDialog();
                }
                else if (oResult.not_registered == true)
                {
                    MessageBox.Show("You are not registered, please register your email");
                    new UserManagement.Register().ShowDialog();
                }
                else
                {
                    this.Hide();
                    new Main().Show();
                }
            }
            else
            {
                MessageBox.Show(oResult.message);
            }
        }
    }
}
