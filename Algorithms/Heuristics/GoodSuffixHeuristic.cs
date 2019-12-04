using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Эфристика безопасного суффикса
    /// </summary>
    public class GoodSuffixHeuristic
    {
        readonly string _pattern;
        readonly int m;

        public GoodSuffixHeuristic(string pattern)
        {
            _pattern = pattern;
            m = _pattern.Length;
        }

        public int[] Compute()
        {
            var suffixShift = SuffixShiftInitialize();
            var z = ComputeZFunction();

            for (int j = m - 1; j > 0; j--)
                suffixShift[m - z[j]] = j;

            for (int j = 1, r = 0; j <= m - 1; j++)
            {
                if (j + z[j] == m)
                {
                    for (; r <= j; r++)
                    {
                        if (suffixShift[r] == m)
                            suffixShift[r] = j;
                    }
                }
            }

            var list = suffixShift.ToList();
            list.RemoveAt(0);

            return list.ToArray();
        }

        private int[] ComputeZFunction()
        {
            var z = new int[m];

            for (int j = 1, maxZidx = 0, maxZ = 0; j < m; ++j)
            {
                if (j <= maxZ) 
                    z[j] = Math.Min(maxZ - j + 1, z[j - maxZidx]);

                while (j + z[j] < m && _pattern[m - 1 - z[j]] == _pattern[m - 1 - (j + z[j])])
                    z[j]++;

                if (j + z[j] - 1 > maxZ)
                {
                    maxZidx = j;
                    maxZ = j + z[j] - 1;
                }
            }

            return z;
        }

        private int[] SuffixShiftInitialize()
        {
            var suffixShiftInitialize = new int[m + 1];
            for (int i = 0; i < suffixShiftInitialize.Length; i++)
                suffixShiftInitialize[i] = m;

            return suffixShiftInitialize;
        }
    }
}
