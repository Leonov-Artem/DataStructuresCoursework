using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public static class Hash
    {
        public static string Compute(string data)
            => data.GetHashCode().ToString();
    }
}
