using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEncrypting
{
    public class Vigenere
    {
        private readonly string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }
        public string Encrypt(string source, string key)
        {
            source = source.ToUpper();
            key = key.ToUpper();

            string output = "";
            var n = Alphabet.Length;
            var gamma = GetRepeatKey(key, source.Length);

            for (int i = 0; i < source.Length; i++)
            {
                var letterIndex = Alphabet.IndexOf(source[i]);
                var codeIndex = Alphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    
                    output += source[i].ToString();
                }
                else
                {
                    output += Alphabet[(n + letterIndex +  codeIndex) % n].ToString();
                }
            }

            return output;
        }

        public string Dencrypt(string encrypted, string key)
        {
            encrypted = encrypted.ToUpper();
            key = key.ToUpper();

            string output = "";
            var n = Alphabet.Length;
            var gamma = GetRepeatKey(key, encrypted.Length);

            for (int i = 0; i < encrypted.Length; i++)
            {
                var letterIndex = Alphabet.IndexOf(encrypted[i]);
                var codeIndex = Alphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    
                    output += encrypted[i].ToString();
                }
                else
                {
                    output += Alphabet[(n + letterIndex - codeIndex) % n].ToString();
                }
            }

            return output;
        }
        
    }
}
