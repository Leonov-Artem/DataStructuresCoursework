using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Security.Test
{
    [TestClass]
    public class SecurityTest
    {
        [TestMethod]
        public void EncryptAndDecryptTest()
        {
            var expected = "someData";
            var byteArray = Security.Encrypt(expected);
            var actual = Security.Decrypt(byteArray);
            Assert.AreEqual(actual, expected);
        }
    }
}
