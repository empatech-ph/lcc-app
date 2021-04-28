using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LCC.Library
{
    public class ClientLibrary
    {

        public const string PROTOCOL = "HTTPS";

        public readonly HttpClient oClient = new HttpClient();

        public async Task<string>get(string sUrl, Dictionary<dynamic, dynamic> oParam)
        {
            return await this.oClient.GetStringAsync(sUrl + "?" + this.getQueryParameters(oParam));
        }


        public async Task<string>send(string sUrl, Dictionary<dynamic, dynamic> oParam)
        {
            var sJson = JsonConvert.SerializeObject(oParam);
            StringContent oParameters = new StringContent(sJson, Encoding.UTF8, "application/json");
            var oResponse = await this.oClient.PostAsync(sUrl, oParameters);
            return await oResponse.Content.ReadAsStringAsync();
        }

        private string getQueryParameters(Dictionary<dynamic, dynamic> oParam)
        {
            string sQuery = "";
            foreach(KeyValuePair<dynamic, dynamic> oItem in oParam) {
                sQuery += "&" + oItem.Key + "=" + oItem.Value;
            }

            return sQuery;
        }
    }
}
