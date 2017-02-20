using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity
{
    class CeasarChipher
    {
        public static string Encrypt(string fullText, int shift, Alphabet alphabet)
        {
            string[] chunks = fullText.Split(' ');
            string encryptedText = "";
            foreach (string text in chunks)
            {
                foreach (char i in text)
                {
                    int index;
                    if (alphabet[i] + shift > 0)
                    {
                        index = alphabet[i] + shift;
                    }
                    else
                    {
                        index = alphabet.Length - alphabet[i] + shift;
                    }
                    encryptedText += alphabet[index % alphabet.Length];
                }
                encryptedText += " ";
            }

            return encryptedText;
        }
    }
}
