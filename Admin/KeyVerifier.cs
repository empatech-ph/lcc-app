﻿using LCC.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.Admin
{
    public partial class KeyVerifier : Form
    {
        private ClientLibrary oClient;

        public KeyVerifier()
        {
            InitializeComponent();
            this.oClient = new ClientLibrary();
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            this.verify();
        }

        private async void verify()
        {
            var oParam = new Dictionary<dynamic, dynamic>
            {
                { "product_code", this.tb_prodCode.Text },
                { "license_key", this.tb_LicenseKey.Text },
                { "timestamp", UtilsLibrary.getTimestamp() },
            };
            var sResult = await this.oClient.send("/api/license/verify", oParam);
            MessageBox.Show(sResult);
        }
    }
}
