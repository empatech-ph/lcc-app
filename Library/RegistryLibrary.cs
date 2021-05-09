using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCC.Library
{
    class RegistryLibrary
    {

        public RegistryKey oRegistry;

        public RegistryLibrary()
        {
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\lcc-tool");
            this.oRegistry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\lcc-tool", true);
        }

        public void register(string sKey, string sValue)
        {
            this.oRegistry.SetValue(sKey, sValue);
        }

        public string getRegistry(string sKey)
        {
            if (this.oRegistry.GetValueNames().Contains(sKey) == true)
            {
                return this.oRegistry.GetValue(sKey).ToString();
            }
            return "";
        }

        public dynamic getInfo()
        {
            try
            {
                string sInfo = this.getRegistry("info");
                if(sInfo == "")
                {
                    throw new Exception();
                }
                return JObject.Parse(EncryptionDecryptionLibrary.decrypt(EncryptionDecryptionLibrary.getDecryptBase64(sInfo)));
            }
            catch (Exception)
            {
                var oInfo = new Dictionary<dynamic, dynamic>
                {
                    { "id",  ""},
                    { "code",  ""},
                    { "key", "" },
                    { "processor_id", "" },
                    { "date_end",  "" },
                    { "timestamp",  "" }
                };
                return JObject.Parse(JsonConvert.SerializeObject(oInfo));
            }
        }
    }
}
