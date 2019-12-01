using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Suffixes
    {
        public static Dictionary<string, int> CreateTable(string pattern)
        {
            //int m = pattern.Length;
            //int[] pi = Prefix.CalculateFunction(pattern);
            //int[] pi1 = Prefix.CalculateFunction(pattern.Reverse());
            //int[] suffshift = new int[m];

            //for (int j = 0; j < m; j++)
            //    suffshift[j] = m - pi[m - 1];

            //for (int i = 1; i < m; i++)
            //{
            //    int j = m - pi1[i] - 1;
            //    suffshift[j] = Math.Min(suffshift[j], i - pi1[i]);
            //}

            var table = new Dictionary<string, int>();

            return table;

            //m = length(шаблон)
            //pi[] = префикс - функция(шаблон)
            //pi1[] = префикс - функция(обращение(шаблон))
            //for j = 0..m
            //  suffshift[j] = m - pi[m]
            //for i = 1..m
            //  j = m - pi1[i]
            //suffshift[j] = min(suffshift[j], i - pi1[i])

        }
    }
}
