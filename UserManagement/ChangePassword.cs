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
            Library.ThemeLibrary.initMaterialDesign(this);

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
                    MessageBox.Show("Passwords do not match.");
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
                (new Login()).Show();
            }
        }

    }
}
