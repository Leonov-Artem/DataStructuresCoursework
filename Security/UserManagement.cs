using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class UserManagement
    {
        static readonly string PATH = "passwords.dat";

        BinaryFormatter _binaryFormatter;
        Dictionary<byte[], byte[]> _users;

        public UserManagement()
        {
            _binaryFormatter = new BinaryFormatter();
            _users = GetUserList();
        }

        public void Add(User user)
        {
            if (!Find(user))
            {
                AddUser(user);
                SaveUserList();
            }
        }

        public void AddRange(User[] users)
        {
            foreach (var user in users)
                Add(user);
        }

        public void Delete(User user)
        {
            if (Find(user))
                DeleteUser(user);
        }

        public bool Find(User user)
        {
            var encUser = new EncryptedUser(user);
            if (_users.ContainsKey(encUser.Login))
                return true;

            return false;
        }

        public List<string> UserLogins()
        {
            var list = new List<string>();
            foreach(var user in _users)
            {
                string login = Security.Decrypt(user.Key);
                list.Add(login);
            }

            return list;
        }

        private Dictionary<byte[], byte[]> GetUserList()
        {
            var users = new Dictionary<byte[], byte[]>();
            using (var fileStream = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                if (fileStream.Length != 0)
                    users = (Dictionary<byte[], byte[]>)_binaryFormatter.Deserialize(fileStream);
            }

            return users;
        }

        private void SaveUserList()
        {
            using (var fileStream = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.Write))
            {
                _binaryFormatter.Serialize(fileStream, _users);
            }
        }

        private void AddUser(User user)
        {
            var encUser = new EncryptedUser(user);
            _users[encUser.Login] = encUser.Password;
        }

        private void DeleteUser(User user)
        {
            var encUser = new EncryptedUser(user);
            _users.Remove(encUser.Login);
        }
    }
}
