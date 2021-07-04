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
    public partial class Register : MaterialForm
    {

        private ClientLibrary oClient;
        private string sUserType;

        public Register(string sEmail = "", string sUserType = "")
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);

            this.tb_email.Text = sEmail;
            this.sUserType = sUserType;
            this.Text = "Register as " + sUserType;
            this.oClient = new ClientLibrary();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (this.tb_email.TextLength <= 0 || this.tb_name.TextLength <= 0 || this.tb_password.TextLength <= 0 || this.tb_confirmPassword.TextLength <= 0)
            {
                MessageBox.Show("Provide the required fields.");
            }
            else
            {
                if (this.tb_password.Text != this.tb_confirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                }
                else
                {
                    this.register();
                }
            }

        }

        private async void register()
        {
            dynamic oInfo = new RegistryLibrary().getInfo();
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "product_code", oInfo.code.ToString() },
                { "license_key", oInfo.key.ToString() },
                { "allowed_email", this.tb_email.Text },
                { "timestamp", UtilsLibrary.getTimestamp() },
            };
            dynamic oResult = await this.oClient.get("/api/license/verify-with-email", oParam);
            if(oResult.success == true)
            {
                var oParamUser = new Dictionary<dynamic, dynamic>
                {
                    { "name", this.tb_name.Text },
                    { "email", this.tb_email.Text },
                    { "password", this.tb_confirmPassword.Text },
                    { "user_type", this.getUserType(this.sUserType) },
                    { "is_new", false },
                    { "license_id", oInfo.id.ToString() },
                    { "timestamp", UtilsLibrary.getTimestamp() },
                };
                MessageBox.Show(JsonConvert.SerializeObject(oParamUser));
                dynamic oUserResult = await this.oClient.send("/api/user", oParamUser);
                MessageBox.Show(oUserResult.message.ToString());
                if (oUserResult.success == true)
                {
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Your email is not associated with your subscription.");
            }
        }

        private int getUserType(string sUserType)
        {
            switch (sUserType)
            {
                case "System Administrator": return 1;
                case "Moderator": return 2;
                case "Estimator": return 3;
                default: return 0;
            }
        }

    }
}
