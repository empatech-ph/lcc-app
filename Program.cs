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
            if ((new Library.RegistryLibrary()).getRegistry("info") != "")
            {
                Application.Run(new UserManagement.Login());
            }
            else
            {
                Application.Run(new BootEnterLicenseKey());
            }

        }
    }
}
