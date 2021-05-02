using System;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LCC.Library
{
    public class ClientLibrary
    {

        public readonly HttpClient oClient = new HttpClient();

        public async Task<string>get(string sUrl, Dictionary<dynamic, dynamic> oParam)
        {
            return await this.oClient.GetStringAsync(sUrl + "?" + this.getQueryParameters(oParam));
        }


        public async Task<string>send(string sUrl, Dictionary<dynamic, dynamic> oParam)
        {
            oParam.Add("hmac", EncryptionDecryptionLibrary.getHmac(this.getQueryParameters(oParam, false)));
            var sJson = JsonConvert.SerializeObject(oParam);
            StringContent sParameters = new StringContent(sJson, Encoding.UTF8, "application/json");
            var oResponse = await this.oClient.PostAsync(sUrl, sParameters);
            return await oResponse.Content.ReadAsStringAsync();
        }

        public string getQueryParameters(Dictionary<dynamic, dynamic> oParam, bool bWithHmac = true)
        {
            string sQuery = "";
            for(int i = 0; i < oParam.Count; i++)
            {
                sQuery += ((i != 0) ? "&" : "") + oParam.Keys.ElementAt(i) + "=" + oParam.Values.ElementAt(i);
            }
            if (bWithHmac == true) sQuery += ((oParam.Count != 0) ? "&" : "") + "hmac=" + EncryptionDecryptionLibrary.getHmac(sQuery);
            return sQuery.Replace("+", "%2B");
        }
    }
}
