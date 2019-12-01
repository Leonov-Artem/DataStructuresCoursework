using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class PrefixTest
    {
        [TestMethod]
        public void CalculateFunctionTest1()
        {
            var expected = new int[] { 0, 0, 0, 1, 2, 3, 4 };
            var actual = Prefix.CalculateFunction("abcabca");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunctionTest12()
        {
            var expected = new int[] { 0, 0, 0, 1, 1, 2, 3, 4, 2 };
            var actual = Prefix.CalculateFunction("abbaabbab");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunctionTest3()
        {
            var expected = new int[] { 0, 0, 0, 1, 2, 3, 0 };
            var actual = Prefix.CalculateFunction("abcabcd");
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
