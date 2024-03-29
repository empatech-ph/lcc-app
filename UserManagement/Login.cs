﻿using LCC.Library;
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
        private RegistryLibrary oRegistry;

        public Login()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);
            this.oClient = new ClientLibrary();
            this.oRegistry = new RegistryLibrary();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.btn_login.Enabled = false;
            if (this.tb_email.TextLength <= 0)
            {
                MessageBox.Show("Please provide required fields.");
            }
            else
            {
                this.login();
            }
            this.btn_login.Enabled = true;

        }

        private async void login()
        {
            dynamic oInfo = this.oRegistry.getInfo();
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
                    this.Hide();
                    (new ChangePassword((int)oResult.id, this.tb_email.Text)).Show();
                }
                else if (oResult.not_registered == true)
                {
                    MessageBox.Show("You are not registered, please register your email.");
                    this.Hide();
                    (new Register(this.tb_email.Text, oResult.user_type.ToString())).Show();
                }
                else if (this.getUserType(oResult.user_type.ToString()) == 1)
                {
                    this.Hide();
                    (new Admin.AdminDashboard()).Show();
                }
                else
                {
                    this.Hide();
                    var oLogin = new Dictionary<dynamic, dynamic>
                    {
                        { "id",  oResult.id.ToString()},
                        { "file_name", EncryptionDecryptionLibrary.getEncryptBase64(oResult.id.ToString() + oResult.email.ToString())},
                        { "user_type", this.getUserType(oResult.user_type.ToString())},
                        { "email", oResult.email.ToString()},
                        { "timestamp",  UtilsLibrary.getTimestamp() }
                    };
                    this.oRegistry.registerEncrypt("login", JsonConvert.SerializeObject(oLogin));
                    dynamic oInfoFile = new RegistryLibrary().getInfo();
                    oInfoFile.date_recheck = int.Parse(oInfoFile.date_recheck.ToString()) + 864000;
                    this.oRegistry.registerEncrypt("info", oInfoFile.ToString());
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

        private void btn_enterlicense_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Library.RegistryLibrary().deleteRegistry("info");
            (new BootEnterLicenseKey()).Show();
        }
        private int getUserType(string sUserType)
        {
            switch (sUserType)
            {
                case "SystemAdministrator": return 1;
                case "Moderator": return 2;
                case "Estimator": return 3;
                default: return 0;
            }
        }

        private void tb_email_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.login();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
