using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class PrefixFunctionTest
    {
        [TestMethod]
        public void Calculate_OrdinaryInput_Test()
        {
            var expected = new int[] { 0, 0, 0, 1, 2, 3, 4 };
            var actual = CalculatePrefixFunction("abcabca");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_RepeatedCharactersOnly_Test()
        {
            var expected = new int[] { 0, 1, 2, 3 };
            var actual = CalculatePrefixFunction("aaaa");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_EmptyInput_EmptyArrayReturned()
        {
            var expected = new int[] { };
            var actual = CalculatePrefixFunction("");
            CollectionAssert.AreEqual(expected, actual);
        }

        private int[] CalculatePrefixFunction(string input)
            => PrefixFunction.Calculate(input);
    }
}
