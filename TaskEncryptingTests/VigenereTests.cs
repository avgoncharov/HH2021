using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskEncrypting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEncrypting.Tests
{
    [TestClass()]
    public class VigenereTests
    {
        [TestMethod()]
        public void EncryptDencryptTest()
        {
            string source = "ФРАЗА ДЛЯ ТЕСТА";
            string key = "КЛЮЧ";
            string encrypted, dencrypted;

            Vigenere v = new Vigenere();
            encrypted = v.Encrypt(source, key);
            dencrypted = v.Dencrypt(encrypted, key);


            Assert.AreEqual(source, dencrypted);
            
        }


    }
}