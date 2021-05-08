using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace LCC
{
    public partial class Main : Form
    {
        public Main(string sString = "")
        {
            InitializeComponent();
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            //this.richTextBox1.Text = Library.EncryptionDecryptionLibrary.decrypt(Library.EncryptionDecryptionLibrary.getDecryptBase64("RUZxTndHQlBUMThxbXNyYzJrMWxnbW5rUWlaamlUaGRiZG5XczVqRkxySmxUL0UwbjdGR0Z1WEVVR082Vm1yUEVYRDVHMGMxeUlDcXROZFBja0NZRm1YWG9uUUxXelhKMkNsU0JjeTlNQk9BZHhEQWs5N1J2bUVPaDdMejdTTGk="));
            this.richTextBox2.Text = sString;
        }
    }
}
