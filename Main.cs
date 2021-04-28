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

namespace LCC
{
    public partial class Main : Form
    {

        public ClientLibrary oClientLibrary;

        public Main()
        {
            InitializeComponent();
            this.label1.Text = new KeyGeneratorLibrary().getGeneratedLicenseKey();
        }

        private async void sample() {

            var aParams = new Dictionary<dynamic, dynamic>
            {
                { 1, "John Patrick Loyola" }
            };
            this.Text = await new ClientLibrary().send("https://webhook.site/8d3650d3-25ac-458d-ae23-16d7559444b4", aParams);
        }
    }
}
