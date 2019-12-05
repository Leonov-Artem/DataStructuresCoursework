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
        Dictionary<string, byte[]> _users;

        public UserManagement()
        {
            _binaryFormatter = new BinaryFormatter();
            _users = GetUserList();
        }

        public void Add(User user)
        {
            if (!Find(user.Login))
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

        public void Delete(string login)
        {
            if (Find(login))
            {
                DeleteUser(login);
                SaveUserList();
            }
        }

        public bool Find(string login)
        {
            if (_users.ContainsKey(login))
                return true;

            return false;
        }

        public List<string> UserLogins()
            => _users.Keys.ToList();

        private Dictionary<string, byte[]> GetUserList()
        {
            var users = new Dictionary<string, byte[]>();
            using (var fileStream = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                if (fileStream.Length != 0)
                    users = (Dictionary<string, byte[]>)_binaryFormatter.Deserialize(fileStream);
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
            _users[user.Login] = encUser.Password;
        }

        private void DeleteUser(string login)
            => _users.Remove(login);
    }
}
