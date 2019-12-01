using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Prefix
    {
        public static int[] CalculateFunction(string input)
        {
            int[] pi = new int[input.Length];
            for (int i = 1; i < input.Length; i++)
            {
                int k = pi[i - 1];
                while (k > 0 && input[k] != input[i])
                    k = pi[k - 1];

                if (input[k] == input[i])
                    k++;

                pi[i] = k;
            }

            return pi;
        }
    }
}
