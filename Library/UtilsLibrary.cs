using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace LCC.Library
{
    class UtilsLibrary
    {

        public static int getTimestamp()
        {
            return (int)DateTimeOffset.Now.ToUnixTimeSeconds();
        }

        public static string getProcessorId()
        {
            var oManagemetnObjectSearcher = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection oManagementList = oManagemetnObjectSearcher.Get();
            string sProcessorId = "";
            foreach (ManagementObject oItem in oManagementList)
            {
                sProcessorId = oItem["ProcessorId"].ToString();
                break;
            }
            return sProcessorId;
        }

        public static DataStore getUserFile()
        {
            string sFileName = "";
            if (System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToString() != "DesignToolsServer")
            {
                dynamic oLoginInfo = new RegistryLibrary().getLogin();
                sFileName = (oLoginInfo.file_name != "") ? oLoginInfo.file_name.ToString() : "data.json";
            }
            else
            {
                sFileName = "data.json";
            }
            return new DataStore(AppDomain.CurrentDomain.BaseDirectory + sFileName, reloadBeforeGetCollection: true);
        }

        public static List<Control> getAllControls(Control oListControls, Type oType)
        {
            var oControls = oListControls.Controls.Cast<Control>();
            return oControls.SelectMany(oControl => getAllControls(oControl, oType))
                                      .Concat(oControls)
                                      .Where(oControl => oControl.GetType() == oType)
                                      .ToList();
        }

        public static string getPublicPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        private static Random random = new Random();
        public static string CreateRandomString(int stringLength = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, stringLength)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static int getUserTypeInt(string sUserType)
        {
            switch (sUserType)
            {
                case "SystemAdministrator": return 1;
                case "Moderator": return 2;
                case "Estimator": return 3;
                default: return 0;
            }
        }

        public static string getUserTypeString(int iUserType)
        {
            switch (iUserType)
            {
                case 1: return "SystemAdministrator";
                case 2: return "Moderator";
                case 3 : return "Estimator";
                default: return "";
            }
        }
    }
}
