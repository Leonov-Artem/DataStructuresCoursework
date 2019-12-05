using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class EncryptedUser
    {
        public byte[] Login { get; private set; }
        
        public byte[] Password { get; private set; }

        public EncryptedUser(User user)
        {
            Login = Security.Encrypt(user.Login);
            Password = Security.Encrypt(user.Password);
        }
    }
}
