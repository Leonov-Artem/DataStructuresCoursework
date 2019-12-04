using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BoyerMoore
    {
        public static List<int> Find(string text, string pattern)
        {
            int MAX_POSSIBLE_SHIFT = text.Length - pattern.Length;
            var foundShifts = new List<int>();

            var badCharacter = ComputeBadCharacter(pattern);
            int[] goodSuffix = ComputeGoodSuffix(pattern);
            int shift = 0;

            while (shift <= MAX_POSSIBLE_SHIFT)
            {
                int j = pattern.Length - 1;
                while (j > 0 && pattern[j] == text[shift + j])
                    j--;

                if (j == 0)
                {
                    foundShifts.Add(shift);
                    shift += goodSuffix[0];
                }
                else
                    shift += Math.Max(goodSuffix[j], j - badCharacter[text[shift + j]]);
            }

            return foundShifts;
        }

        private static BadCharacterHeuristic ComputeBadCharacter(string pattern)
            => new BadCharacterHeuristic(pattern);

        private static int[] ComputeGoodSuffix(string pattern)
        {
            var goodSuffix = new GoodSuffixHeuristic(pattern);
            return goodSuffix.Compute();
        }
    }
}
