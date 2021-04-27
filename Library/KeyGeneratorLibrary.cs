using System;
using System.Linq;

namespace LCC.Library
{
    class KeyGeneratorLibrary
    {
        private static readonly Random RANDOM = new Random();
        private const int KEY_LENGTH = 5;
        private const string CHARS_INCLUDED = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public string getGeneratedLicenseKey() {
            string sLicenseKey = "";
            for(var i = 0; i <= 5; i++) {
                sLicenseKey += this.getRandom() + ((i != 5) ? "-" : "");
            }
            return sLicenseKey;
        }

        private string getRandom() {
            return new string(Enumerable.Repeat(CHARS_INCLUDED, KEY_LENGTH)
              .Select(sLicenseKey => sLicenseKey[RANDOM.Next(sLicenseKey.Length)]).ToArray());
        }

    }
}
