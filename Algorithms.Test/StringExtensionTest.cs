using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ReverseTest()
        {
            Assert.AreEqual("hello", "olleh".Reverse());
            Assert.AreEqual("", "".Reverse());
            Assert.AreEqual("aaa", "aaa".Reverse());
            Assert.AreEqual("kek", "kek".Reverse());
        }

        [TestMethod]
        public void t()
        {
            Suffixes.CreateTable("«колокол");
        }
    }
}
