using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class GoodSuffixHeuristicTest
    {
        [TestMethod]
        public void Compute_OrdinaryPattern_Test()
        {
            var expected = new int[] { 7, 7, 7, 2, 7, 4, 7, 1 };
            var actual = ComputeGoodSuffix("GCAGAGAG");
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Compute_OnlyIdenticalCharacters_Test()
        {
            var expected = new int[] { 1, 2, 3, 4 };
            var actual = ComputeGoodSuffix("aaaa");
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Compute_EmptyPattern_EmptyArrayReturned()
        {
            var expected = new int[] { };
            var actual = ComputeGoodSuffix("");
            CollectionAssert.AreEqual(actual, expected);
        }

        private int[] ComputeGoodSuffix(string pattern)
        {
            var goodSuff = new  GoodSuffixHeuristic(pattern);
            return goodSuff.Compute();
        }
    }
}
