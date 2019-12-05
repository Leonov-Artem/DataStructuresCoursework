using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Security
{
    public static class Security
    {
        public static byte[] Encrypt(string data)
        { 
            var encrypt = Encoding.UTF8.GetBytes(data);
            return ProtectedData.Protect(encrypt, null, DataProtectionScope.CurrentUser);
        }

        public static string Decrypt(byte[] data)
        {
            var decrypt = ProtectedData.Unprotect(data, null, DataProtectionScope.CurrentUser);
            return Encoding.UTF8.GetString(decrypt);
        }
    }
}
