using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class PrefixFunction
    {
        public static int[] Calculate(string P)
        {
            int[] pi = new int[P.Length];
            int k = 0;

            for (int q = 1; q < P.Length; q++)
            {
                while (k > 0 && P[k] != P[q])
                    k = pi[k - 1];

                if (P[k] == P[q])
                    k++;

                pi[q] = k;
            }

            return pi;
        }
    }
}
