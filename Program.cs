using LCC.Library;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCC
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClientLibrary oClient = new ClientLibrary();
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                Application.Exit();
            }
            dynamic oInfo = new RegistryLibrary().getInfo();
            if (oInfo.ContainsKey("date_recheck") && oInfo.date_recheck.ToString() != "")
            {
                if ((Convert.ToInt32(oInfo.date_recheck.ToString()) >= UtilsLibrary.getTimestamp()) && oClient.IsConnectedToInternet() == false)
                {
                    Application.Run(new UserManagement.Login());
                }
                else
                {
                    try
                    {
                        var oParam = new Dictionary<dynamic, dynamic>
                        {
                            { "timestamp", UtilsLibrary.getTimestamp() },
                            { "license_key", oInfo.key.ToString() },
                            { "product_code", oInfo.code.ToString() },
                        };
                        dynamic oTask = oClient.get("/api/license/verify-without-email", oParam);
                        Task.WaitAll(oTask);
                        dynamic oResult = oTask.Result;
                        if (oResult.success == true && (Convert.ToInt32(oResult.data.should_expired_at.ToString()) >= UtilsLibrary.getTimestamp()))
                        {
                            Application.Run(new UserManagement.Login());
                        }
                        else
                        {
                            Application.Run(new BootEnterLicenseKey());
                        }
                    }
                    catch (Exception)
                    {
                        Application.Run(new BootEnterLicenseKey());
                    }
                }
            }
            else
            {
                Application.Run(new BootEnterLicenseKey());
            }
        }
    }
}
