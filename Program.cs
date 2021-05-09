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
            if(System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                Application.Exit();
            }
            try
            {
                string sInfo = (new Library.RegistryLibrary()).getRegistry("info");
                dynamic oInfo = JObject.Parse(Library.EncryptionDecryptionLibrary.decrypt(Library.EncryptionDecryptionLibrary.getDecryptBase64(sInfo)));
                var oParam = new Dictionary<dynamic, dynamic>
                {
                    { "timestamp", UtilsLibrary.getTimestamp() },
                    { "license_key", oInfo.key.ToString() },
                    { "product_code", oInfo.code.ToString() },
                };
                ClientLibrary oClient = new ClientLibrary();
                dynamic oTask = oClient.get("/api/license/verify-without-email", oParam);
                Task.WaitAll(oTask);
                dynamic oResult = oTask.Result;

                if (oResult.success == true)
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
}
