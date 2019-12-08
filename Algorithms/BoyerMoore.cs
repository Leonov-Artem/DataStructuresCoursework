using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BoyerMoore
    {
        public static List<int> Find(string text, string pattern, bool ignoreCase=false)
        {
            if (ignoreCase)
            {
                text = text.ToLower();
                pattern = pattern.ToLower();
            }

            int MAX_POSSIBLE_SHIFT = text.Length - pattern.Length;
            var shifts = new List<int>();

            var badCharacter = ComputeBadCharacter(pattern);
            int[] goodSuffix = ComputeGoodSuffix(pattern);
            int currentShift = 0;
            
            while (currentShift <= MAX_POSSIBLE_SHIFT)
            {
                int j = pattern.Length;
                while (j > 0 && pattern[j - 1] == text[currentShift + j - 1])
                    j--;

                if (j == 0)
                {
                    shifts.Add(currentShift);
                    currentShift += goodSuffix[0];
                }
                else
                    currentShift += Math.Max
                        (
                            goodSuffix[j - 1], 
                            j - badCharacter[text[currentShift + j - 1]]
                        );
            }

            return shifts;
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