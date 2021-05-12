using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

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
    }
}
