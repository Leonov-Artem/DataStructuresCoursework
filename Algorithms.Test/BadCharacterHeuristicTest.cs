using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Test
{
    [TestClass]
    public class BadCharacterHeuristicTest
    { 
        [TestMethod]
        public void Indexer_OrdinaryPattern_Test()
        {
            var heuristic = ComputeBadCharacter("hello");
            Assert.AreEqual(heuristic['h'], 1);
            Assert.AreEqual(heuristic['e'], 2);
            Assert.AreEqual(heuristic['l'], 4);
            Assert.AreEqual(heuristic['o'], 5);
        }

        [TestMethod]
        public void Indexer_PatternWithWhiteSpaces_Test()
        {
            var heuristic = ComputeBadCharacter("abc abe e");
            Assert.AreEqual(heuristic['a'], 5);
            Assert.AreEqual(heuristic['b'], 6);
            Assert.AreEqual(heuristic['c'], 3);
            Assert.AreEqual(heuristic[' '], 8);
            Assert.AreEqual(heuristic['e'], 9);
        }

        [TestMethod]
        public void Indexer_MissingCharacters_0Returned()
        {
            var heuristic = ComputeBadCharacter("abce");
            Assert.AreEqual(heuristic['n'], 0);
            Assert.AreEqual(heuristic['t'], 0);
            Assert.AreEqual(heuristic['u'], 0);
        }

        [TestMethod]
        public void Indexer_EmptyPattern_0Returned()
        {
            var heuristic = ComputeBadCharacter("");
            Assert.AreEqual(heuristic['r'], 0);
        }

        private BadCharacterHeuristic ComputeBadCharacter(string pattern)
            => new BadCharacterHeuristic(pattern);
    }
}
