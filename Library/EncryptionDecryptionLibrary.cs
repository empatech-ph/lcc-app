﻿using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace LCC.Library
{
    class EncryptionDecryptionLibrary
    {
        private const string LCC_KEY = "---LCC-GIAEMPATECH-04-20-2021---";

        public static string encrypt(string sUnEncrypted) {

            byte[] aByte = new byte[16];
            byte[] aBUffer;

            using (Aes oAes = Aes.Create())
            {
                oAes.Key = Encoding.UTF8.GetBytes(LCC_KEY);
                oAes.IV = aByte;

                ICryptoTransform oEncryption = oAes.CreateEncryptor(oAes.Key, oAes.IV);

                using MemoryStream oMemoryStream = new MemoryStream();
                using CryptoStream oCryptoStream = new CryptoStream((Stream)oMemoryStream, oEncryption, CryptoStreamMode.Write);
                using (StreamWriter oStreamWriter = new StreamWriter((Stream)oCryptoStream))
                {
                    oStreamWriter.Write(sUnEncrypted);
                }

                aBUffer = oMemoryStream.ToArray();
            }

            return Convert.ToBase64String(aBUffer);
        }

        public static string decrypt(string sUnEncrypted)
        {
            byte[] aByte = new byte[16];
            byte[] aBuffer = Convert.FromBase64String(sUnEncrypted);

            using Aes oAes = Aes.Create();
            oAes.Key = Encoding.UTF8.GetBytes(LCC_KEY);
            oAes.IV = aByte;
            ICryptoTransform decryptor = oAes.CreateDecryptor(oAes.Key, oAes.IV);

            using MemoryStream oMemoryStream = new MemoryStream(aBuffer);
            using CryptoStream oCryptoStream = new CryptoStream((Stream)oMemoryStream, decryptor, CryptoStreamMode.Read);
            using StreamReader streamReader = new StreamReader((Stream)oCryptoStream);
            return streamReader.ReadToEnd();
        }

        public static string getEncryptBase64(string sContent)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(sContent));
        }
        public static string getEncryptBase64(byte[] aContent)
        {
            return Convert.ToBase64String(aContent);
        }

        public static string getDecryptBase64(string sContent)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(sContent));
        }

        public static string getHmac(string sContent)
        {
            HMACSHA256 oHmacSha256 = new HMACSHA256(Encoding.UTF8.GetBytes(LCC_KEY));
            return getEncryptBase64(oHmacSha256.ComputeHash(Encoding.UTF8.GetBytes(sContent)));
        }
    }
}
