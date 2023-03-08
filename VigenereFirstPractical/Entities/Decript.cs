using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VigenereFirstPractical.Services;

namespace VigenereFirstPractical.Entities
{
    public class Decript
    {
        private Alphabet abc = new Alphabet();
        private char[] EncriptedMessage;
        private char[] Key;
        private string PlainText;

        public Decript(string decriptedMSM, string key)
        {
            StringServices StrServices = new StringServices();
            EncriptedMessage = StrServices.IgnorWhiteSpaces(decriptedMSM);
            Key = StrServices.IgnorWhiteSpaces(key);
            Key = GenerateKey();
        }
        public char[] GenerateKey()
        {
            char[] newKey = new char[EncriptedMessage.Length];
            int i, j;
            for (i = 0, j = 0; i < EncriptedMessage.Length; ++i, ++j)
            {
                if (j == Key.Length)
                {
                    j = 0;
                }
                newKey[i] = Key[j];
            }
            Key = newKey;
            return newKey;
        }
        public string DeEncription()
        {
            char[] decryptedMessage = new char[EncriptedMessage.Length];

            for (int i = 0; i < EncriptedMessage.Length; i++)
            {
                char letter = abc.alphabet[((Array.IndexOf(abc.alphabet, EncriptedMessage[i]) - Array.IndexOf(abc.alphabet, Key[i])) +55) % 55];
                decryptedMessage[i] = letter;
            }
            return new string(decryptedMessage);
        }
    }
}
