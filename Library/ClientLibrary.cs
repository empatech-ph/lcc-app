using System;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LCC.Library
{
    public class ClientLibrary
    {

        public readonly HttpClient oClient = new HttpClient();

        public string sBaseUrl = "";

        public ClientLibrary()
        {
            this.sBaseUrl = Properties.Resources.ResourceManager.GetString("webhost");
        }

        public ClientLibrary(string sBaseUrl)
        {
            this.sBaseUrl = sBaseUrl;
        }

        public async Task<dynamic> get(string sUrl, Dictionary<dynamic, dynamic> oParam)
        {
            try
            {
                return JObject.Parse(await this.oClient.GetStringAsync(this.sBaseUrl + sUrl + "?" + this.getQueryParameters(oParam)));
            }
            catch (Exception)
            {
                var oDictionary = new Dictionary<dynamic, dynamic> {
                    { "success", false },
                    { "message", "Problem with connection" }
                };
                return JObject.Parse(JsonConvert.SerializeObject(oDictionary));
            }
        }


        public async Task<dynamic> send(string sUrl, Dictionary<dynamic, dynamic> oParam)
        {
            try
            {
                oParam.Add("hmac", EncryptionDecryptionLibrary.getHmac(this.getQueryParameters(oParam, false)));
                var sJson = JsonConvert.SerializeObject(oParam);
                StringContent sParameters = new StringContent(sJson, Encoding.UTF8, "application/json");
                var oResponse = await this.oClient.PostAsync(this.sBaseUrl + sUrl, sParameters);
                return JObject.Parse(await oResponse.Content.ReadAsStringAsync());
            }
            catch (Exception)
            {
                var oDictionary = new Dictionary<dynamic, dynamic> {
                    { "success", false },
                    { "message", "Problem with connection" }
                };
                return JObject.Parse(JsonConvert.SerializeObject(oDictionary));
            }
        }

        public string getQueryParameters(Dictionary<dynamic, dynamic> oParam, bool bWithHmac = true)
        {
            string sQuery = "";
            for (int i = 0; i < oParam.Count; i++)
            {
                if(String.IsNullOrEmpty(oParam.Values.ElementAt(i).ToString()) == false)
                sQuery += ((i != 0) ? "&" : "") + oParam.Keys.ElementAt(i) + "=" + oParam.Values.ElementAt(i);
            }
            if (bWithHmac == true) sQuery += ((oParam.Count != 0) ? "&" : "") + "hmac=" + EncryptionDecryptionLibrary.getHmac(sQuery);
            return sQuery.Replace("+", "%2B");
        }

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
    }
}
