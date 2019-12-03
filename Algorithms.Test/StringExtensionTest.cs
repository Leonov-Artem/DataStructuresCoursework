using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void Reverse_OrdinaryInput_Test()
        {
            Assert.AreEqual("hello", "olleh".Reverse());
        }

        [TestMethod]
        public void Reverse_EmptyInput_EmptyStringReturned()
        {
            Assert.AreEqual("", "".Reverse());      
        }

        [TestMethod]
        public void Reverse_RepeatedCharactersOnly_NothingChanged()
        {
            Assert.AreEqual("aaa", "aaa".Reverse());
        }
    }
}
