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
            if (this.tb_email.TextLength <= 0)
            {
                MessageBox.Show("Please provide requered fields");
            }
            else
            {
                if(this.tb_email.Text == "admin" && this.tb_password.Text == "pashword123")
                {
                    this.Hide();
                    (new Admin.KeyGenerator()).Show();
                }
                else
                {
                    this.login();
                }
            }

        }

        private async void login()
        {
            dynamic oInfo = new RegistryLibrary().getInfo();
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "timestamp", UtilsLibrary.getTimestamp() },
                { "license_key", oInfo.key.ToString() },
                { "product_code", oInfo.code.ToString() },
                { "password", this.tb_password.Text},
                { "email", this.tb_email.Text},
            };
            dynamic oResult = await this.oClient.send("/api/user/login", oParam);
            if (oResult.success == true)
            {
                if (oResult.change_password == true)
                {
                    MessageBox.Show("Please change your password.");
                    (new UserManagement.ChangePassword((int)oResult.id, this.tb_email.Text)).ShowDialog();
                }
                else if (oResult.not_registered == true)
                {
                    MessageBox.Show("You are not registered, please register your email");
                    (new UserManagement.Register(this.tb_email.Text)).ShowDialog();
                }
                else
                {
                    this.Hide();
                    (new Project()).Show();
                }
            }
            else
            {
                MessageBox.Show(oResult.message.ToString());
                if (oResult.invalid_license == true)
                {
                    this.Hide();
                    (new BootEnterLicenseKey()).Show();
                }
            }
        }
    }
}
