using System;

namespace TaskEncrypting
{
    class Program
    {
        static void Main(string[] args)
        {
            Vigenere vigenere = new Vigenere();
            string source, key;

            Console.WriteLine("Шифрование Виженера\nВведите исходную фразу:");
            source = Console.ReadLine();
            Console.WriteLine("Введите ключ-фразу:");
            key = Console.ReadLine();
            Console.WriteLine(vigenere.Encrypt(source,key));

            Console.WriteLine("Введите зашифрованную фразу:");
            source = Console.ReadLine();
            Console.WriteLine("Введите ключ-фразу:");
            key = Console.ReadLine();
            Console.WriteLine(vigenere.Dencrypt(source, key));

        }
    }
}
