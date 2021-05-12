using LCC.Library;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LCC.UserManagement
{
    public partial class ChangePassword : MaterialForm
    {
        private int iId;
        private ClientLibrary oClient;

        public ChangePassword(int iId, string sEmail)
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

            this.iId = iId;
            this.l_email.Text = sEmail;
            this.oClient = new ClientLibrary();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if(this.tb_password.TextLength <= 0 || this.tb_confirmPassword.TextLength <= 0)
            {
                MessageBox.Show("Provide required fields.");
            }else
            {
                if(this.tb_password.Text == this.tb_confirmPassword.Text)
                {
                    this.changePassword();
                }
                else
                {
                    MessageBox.Show("Password doesn't match.");
                }
            }
        }

        private async void changePassword()
        {
            var oParam = new Dictionary<dynamic, dynamic>
            {   
                { "timestamp", UtilsLibrary.getTimestamp() },
                { "id", this.iId },
                { "password", this.tb_password.Text},
            };
            dynamic oResult = await this.oClient.send("/api/user/password/change", oParam);
            MessageBox.Show(oResult.message.ToString());
            if(oResult.success == true)
            {
                this.Hide();
            }
        }

    }
}
