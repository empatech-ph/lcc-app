﻿using LCC.Library;
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
    public partial class KeyVerifier : MaterialForm
    {
        private ClientLibrary oClient;

        public KeyVerifier()
        {
            InitializeComponent();
            Library.ThemeLibrary.initMaterialDesign(this);

            this.oClient = new ClientLibrary();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (this.tb_prodCode.TextLength <= 0 || this.tb_LicenseKey.TextLength <= 0 || this.tb_allowedEmail.TextLength <= 0)
            {
                MessageBox.Show("Please provide required fields.");
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
                { "product_code", this.tb_prodCode.Text },
                { "license_key", this.tb_LicenseKey.Text },
                { "allowed_email", this.tb_allowedEmail.Text },
                { "timestamp", UtilsLibrary.getTimestamp() },
            };
            dynamic oResult = await this.oClient.get("/api/license/verify-with-email", oParam);
            MessageBox.Show(oResult.ToString());
        }
    }
}
