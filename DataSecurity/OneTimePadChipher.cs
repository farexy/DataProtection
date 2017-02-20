using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity
{
    class OneTimePadChipher
    {
        public static string Decrypt(string encryptedText, string key)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(encryptedText);
            byte[] keyBytes = Encoding.Unicode.GetBytes(key);

            byte[] result = new byte[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                result[i] = (byte)Util.Xor((int)keyBytes[i], (int)bytes[i]);
            }

            return Encoding.Unicode.GetString(result);
        }

        public static string Encrypt(string text, out string decryptKey)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);

            byte[] key = new byte[bytes.Length];
            Random r = new Random();
            r.NextBytes(key);

            byte[] result = new byte[bytes.Length];

            for (int i = 0; i < bytes.Length; i++)
            {
                result[i] = (byte)Util.Xor((int)bytes[i], (int)key[i]);
            }
            decryptKey = Encoding.Unicode.GetString(key);
            return Encoding.Unicode.GetString(result);

        }
    }
}
