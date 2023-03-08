using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigenereFirstPractical.Services;

namespace VigenereFirstPractical.Entities
{
    public class Encript
    {
        private Alphabet abc = new Alphabet();
        private char[] PlainText;
        private char[] Key;
        private string EncriptedMessage;

        public Encript(string plainText, string key)
        {
            StringServices StrServices = new StringServices();
            PlainText = StrServices.IgnorWhiteSpaces(plainText);
            Key = StrServices.IgnorWhiteSpaces(key);
            Key = GenerateKey();
        }
        public char[] GenerateKey()
        {
            char[] newKey = new char[PlainText.Length];
            int i, j;
            for (i = 0, j = 0; i < PlainText.Length; ++i, ++j)
            {
                if (j == Key.Length)
                {
                    j = 0;
                }
               newKey[i] = Key[j];
            }
            Key= newKey;
            return newKey;
        }
        public string Encription()
        {
            char[] encryptedMessage = new char[PlainText.Length];

            for(int i = 0; i < PlainText.Length; i++)
            {
                char letter = abc.alphabet[(Array.IndexOf(abc.alphabet, PlainText[i]) + Array.IndexOf(abc.alphabet, Key[i])) % 55];
                encryptedMessage[i] = letter;
            }
            return new string(encryptedMessage);
        }
    }
}
