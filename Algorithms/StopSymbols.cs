using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class StopSymbols
    {
        protected const char OTHER_CHARACTERS = '*';

        public static Dictionary<char, int> CreateTable(string input)
        {
            string pattern = WithoutLastSymbol(input);
            var table = new Dictionary<char, int>();

            for (int i = 0; i < pattern.Length; i++)
                table[pattern[i]] = i + 1;
            table[OTHER_CHARACTERS] = 0;

            return table;
        }

        protected static string WithoutLastSymbol(string input)
            => input.Remove(input.Length - 1, 1);
    }
}
