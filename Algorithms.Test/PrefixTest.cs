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
            var actual = GetPrefixFunction("abcabca");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunctionTest12()
        {
            var expected = new int[] { 0, 0, 0, 1, 1, 2, 3, 4, 2 };
            var actual = GetPrefixFunction("abbaabbab");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunctionTest3()
        {
            var expected = new int[] { 0, 0, 0, 1, 2, 3, 0 };
            var actual = GetPrefixFunction("abcabcd");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateFunctionTest4()
        {
            var expected = new int[] { 0, 0, 0, 1, 2, 0 };
            var actual = GetPrefixFunction("abcabd");
            CollectionAssert.AreEqual(expected, actual);
        }

        private int[] GetPrefixFunction(string input)
            => Prefix.CalculateFunction(input);
    }
}
