using LCC.Library;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC
{
    public partial class SplashScreen : Form
    {
        dynamic oInfo;
        dynamic oLogin;
        public SplashScreen()
        {
            InitializeComponent();
            this.oInfo = new RegistryLibrary().getInfo();
            this.oLogin = new RegistryLibrary().getLogin();
            if (this.oInfo.key.ToString() == "")
            {
                this.l_appStatus.Text = "Unlicensed";
                this.l_licenseCode.Text = "";
                this.l_currentLoggedUser.Text = "None";
            }
            else
            {
                this.l_appStatus.Text = "Licensed";
                this.l_licenseCode.Text = oInfo.code.ToString();
                if(oLogin.email.ToString() != "")
                {
                    this.l_currentLoggedUser.Text = oLogin.email.ToString();
                }
            }
            this.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            this.progressBar.BackColor = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
        }

        private void startApp()
        {
            if (this.oInfo.ContainsKey("date_recheck") && this.oInfo.date_recheck.ToString() != "")
            {
                ClientLibrary oClient = new ClientLibrary();
                dynamic oLoginInfo = new RegistryLibrary().getLogin();
                if ((Convert.ToInt32(this.oInfo.date_recheck.ToString()) >= UtilsLibrary.getTimestamp()))
                {
                    if (oLoginInfo.id.ToString() != "")
                    {
                        (new Project()).Show();
                    }
                    else
                    {
                        (new UserManagement.Login()).Show();
                    }
                }
                else if (oClient.IsConnectedToInternet() == true)
                {
                    try
                    {
                        var oParam = new Dictionary<dynamic, dynamic>
                        {
                            { "timestamp", UtilsLibrary.getTimestamp() },
                            { "license_key", this.oInfo.key.ToString() },
                            { "product_code", this.oInfo.code.ToString() },
                        };
                        dynamic oTask = oClient.get("/api/license/verify-without-email", oParam);
                        Task.WaitAll(oTask);
                        dynamic oResult = oTask.Result;
                        if (oResult.success == true && (Convert.ToInt32(oResult.data.should_expired_at.ToString()) >= UtilsLibrary.getTimestamp()))
                        {
                            (new UserManagement.Login()).Show();
                        }
                        else
                        {
                            (new BootEnterLicenseKey()).Show();
                        }
                    }
                    catch (Exception e)
                    {
                        (new BootEnterLicenseKey()).Show();
                    }
                }
                else
                {
                    (new BootEnterLicenseKey()).Show();
                }
            }
            else
            {
                (new BootEnterLicenseKey()).Show();
            }
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar.Width >= 467)
            {
                this.timer1.Enabled = false;
                this.startApp();
            }
            this.progressBar.Width += 20;
        }
    }
}
