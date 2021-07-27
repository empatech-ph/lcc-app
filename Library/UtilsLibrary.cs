using JsonFlatFileDataStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Management;
using System.Text;
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

            return new DataStore(AppDomain.CurrentDomain.BaseDirectory + sFileName);
        }
    }
}
