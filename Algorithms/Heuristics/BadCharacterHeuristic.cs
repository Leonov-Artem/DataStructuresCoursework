using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Эвристика стоп-символа
    /// </summary>
    public class BadCharacterHeuristic
    {
        Dictionary<char, int> _table;

        public BadCharacterHeuristic(string pattern)
        {
            _table = CreateTable(pattern);
        }

        private Dictionary<char, int> CreateTable(string pattern)
        {
            var table = new Dictionary<char, int>();
            for (int i = 0; i < pattern.Length; i++)
                table[pattern[i]] = i + 1;

            return table;
        }

        public int this[char character]
        {
            get
            {
                if (_table.ContainsKey(character))
                    return _table[character];
                else
                    return 0;
            }
        }
    }
}
