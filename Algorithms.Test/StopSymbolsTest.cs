using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class StopSymbolsTest : StopSymbols
    {
        [TestMethod]
        public void WithoutLastSymbolTest()
        {
            var expected = "abc";
            var actual = WithoutLastSymbol("abcd");
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculateTableTest()
        {
            var expected = new Dictionary<char, int>()
            {
                ['a'] = 5,
                ['b'] = 2,
                ['c'] = 7,
                ['d'] = 6,
                [OTHER_CHARACTERS] = 0
            };
            var actual = StopSymbols.CreateTable("abcdadcd");
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
