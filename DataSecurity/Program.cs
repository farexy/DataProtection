using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSecurity
{
    class Program
    {
        public static string Readfile(string path){
            string fileContent;

            using (StreamReader reader = File.OpenText(path))
            {
                fileContent = reader.ReadToEnd();
            }

            return fileContent;
        }

        public static void CalculateFrequency(string text){
            var frequency = FrequencyCalculator.CalculateFriquency(text);

            foreach (var pair in frequency.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine("{0} - {1}", pair.Key, pair.Value);
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("----------Charachter frequency----------");

            Console.WriteLine("----------Artistic----------------------");
            string fileContent = Readfile("./texts/art.txt");
            CalculateFrequency(fileContent);

            Console.WriteLine("-----------Fairy tail-------------------");
            fileContent = Readfile("./texts/fairy-tail.txt");
            CalculateFrequency(fileContent);

            Console.WriteLine("-----------Technik documentation-----------");
            fileContent = Readfile("./texts/technik.txt");
            CalculateFrequency(fileContent);

            Console.WriteLine("-----------Public speech-----------");
            fileContent = Readfile("./texts/public-person.txt");
            CalculateFrequency(fileContent);

            Console.WriteLine("-----------------Ceasar encrypting--------------");
            Alphabet latinAlphabet = new Alphabet("abcdefghijklmnopqrstuvwxyz");
            string text = "some text for ceaser encryption";
            int shift = -2;

            Console.WriteLine("Text: {0}, shift: {1}", text, shift);
            Console.WriteLine(CeasarChipher.Encrypt(text, shift, latinAlphabet));
            
            Console.WriteLine("---------------XOR-------------");
            Console.WriteLine("1 xor 1 = {0}",Util.Xor(1, 1));
            Console.WriteLine("1 xor 0 = {0}", Util.Xor(1, 0));
            Console.WriteLine("0 xor 1 = {0}", Util.Xor(0, 1));
            Console.WriteLine("0 xor 0 = {0}", Util.Xor(0, 0));

            string key;
            var encryptedText =  OneTimePadChipher.Encrypt("Some text for pad encryption", out key);
            
            Console.WriteLine("----------One-time pad encrypting-----------");
            Console.WriteLine("Encrypted text: {0}", encryptedText);
            Console.WriteLine("Key text: {0}", key);
            Console.WriteLine("Decrypted text: {0}",OneTimePadChipher.Decrypt(encryptedText, key));
            Console.ReadLine();
        }
    }
}
