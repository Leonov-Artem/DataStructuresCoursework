using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class BoyerMooreTest
    {
        [TestMethod]
        public void Find_OrdinaryPatternAndText_1PositionsReturned()
        {
            string text = "GCATCGCAGAGAGTATACAGTACG";
            string pattern = "GCAGAGAG";

            var expected = new List<int>() { 5 };
            var actual = BoyerMoore.Find(text, pattern);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Find_SearchNonexistentSubstring_EmptyListReturned()
        {
            string text = "abcde";
            string pattern = "ghf";

            var expected = new List<int>();
            var actual = BoyerMoore.Find(text, pattern);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Find_MultiplePatternOccurrences_3PositionsReturned()
        {
            string text = "hi adb hi 48 hiabc";
            string pattern = "hi";

            var expected = new List<int>() { 0, 7, 13 };
            var actual = BoyerMoore.Find(text, pattern);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Find_OnlyIdenticalCharactersInText_4PositionsReturned()
        {
            string text = "aaaa";
            string pattern = "a";

            var expected = new List<int>() { 0, 1, 2, 3 };
            var actual = BoyerMoore.Find(text, pattern);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Find_PatternWithWhiteSpaces_1PositionsReturned()
        {
            string text = "sd bd de hello world 53 5 sdf";
            string pattern = "hello world";

            var expected = new List<int>() { 9 };
            var actual = BoyerMoore.Find(text, pattern);

            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Find_DifferentCases_EmptyListReturned()
        {
            string text = "abd Hello world adt";
            string pattern = "hello world";

            var expected = new List<int>();
            var actual = BoyerMoore.Find(text, pattern);

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
