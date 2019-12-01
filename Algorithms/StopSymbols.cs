using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StopSymbols
    {
        public static Dictionary<char, int> CalculateTable(string input)
        {
            var table = new Dictionary<char, int>();
            string pattern = WithoutLastSymbol(input);

            for (int i = 0; i < pattern.Length; i++)
                table[pattern[i]] = i + 1;
            table['*'] = 0;

            return table;
        }

        protected static string WithoutLastSymbol(string input)
            => input.Substring(0, input.Length - 1);
    }
}
