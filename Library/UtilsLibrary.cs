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
    }
}
