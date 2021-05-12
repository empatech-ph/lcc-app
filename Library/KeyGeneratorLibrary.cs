using com.sun.net.ssl;
using System;
using System.Linq;

namespace LCC.Library
{
    class KeyGeneratorLibrary
    {
        private static readonly Random RANDOM = new Random();
        private int KEY_LENGTH = 5;
        private int TOTAL_DASH = 5;
        private string CHARS_INCLUDED = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public KeyGeneratorLibrary(int iKeyLength = 5, int iTotalDashed = 5) {
            KEY_LENGTH = iKeyLength;
            TOTAL_DASH = iTotalDashed;
        }

        public string getGeneratedLicenseKey() {
            string sLicenseKey = "";
            for (var i = 0; i <= TOTAL_DASH; i++) {
                sLicenseKey += this.getRandom() + ((i != TOTAL_DASH) ? "-" : "");
            }
            return sLicenseKey;
        }

        public string getProductCode(int iBaseInt) {

            return DateTime.Now.Year + "-" + this.getRandom() + "-" + String.Format("{0:000000}", iBaseInt + 1);
        }

        private string getRandom() {
            return new string(Enumerable.Repeat(CHARS_INCLUDED, KEY_LENGTH)
              .Select(sLicenseKey => sLicenseKey[RANDOM.Next(sLicenseKey.Length)]).ToArray());
        }

    }
}
