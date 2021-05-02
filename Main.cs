using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LCC.Library;
using System.Net.Http;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace LCC
{
    public partial class Main : Form
    {

        public ClientLibrary oClientLibrary;

        public Main()
        {
            InitializeComponent();
            //for(int i = 0; i <= 10; i++)
            //{
            //    sKey += new KeyGeneratorLibrary().getGeneratedLicenseKey() + "\n";
            //}

            //var hash = new HMACSHA256(Encoding.UTF8.GetBytes("---LCC-GIAEMPATECH-04-20-2021---"));
            //int timestamp = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
            //var aParamss = new Dictionary<dynamic, dynamic>
            //{
            //    { "sample", "true" },
            //    { "timestamp", timestamp }
            //};
            //var aParams = new Dictionary<dynamic, dynamic>
            //{
            //    { "sample", "true" },
            //    { "timestamp", timestamp },
            //    { "hmac", Convert.ToBase64String(hash.ComputeHash(Encoding.UTF8.GetBytes(new ClientLibrary().getQueryParameters(aParamss)))) }
            //};

            //this.richTextBox1.Text = new ClientLibrary().getQueryParameters(aParams);
            this.sample();

        }

        private async void sample()
        {
            var oParams = new Dictionary<dynamic, dynamic>
            {
                { "owner_name", "John Patrick Loyola" },
                { "product_codes", String.Join(",", new string[] { "2021-0000-0001" })},
                { "license_key", new KeyGeneratorLibrary().getGeneratedLicenseKey() },
                { "total_access", 5},
                { "timestamp", UtilsLibrary.getTimestamp() }
            };
            this.richTextBox1.Text = await new ClientLibrary(Properties.Resources.ResourceManager.GetString("webhost")).send("/api/license", oParams);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sample();
        }
    }
}
