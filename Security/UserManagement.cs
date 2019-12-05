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
        Dictionary<string, string> _users;

        public UserManagement()
        {
            _binaryFormatter = new BinaryFormatter();
            _users = new Dictionary<string, string>();
            GetUserList();
        }

        public void Add(User user)
        {
            if (!FindLogin(user.Login))
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
            if (FindLogin(login))
            {
                DeleteUser(login);
                SaveUserList();
            }
        }

        public bool Find(User user)
        {
            string login = user.Login;
            if (FindLogin(login))
            {
                string password = Hash.Compute(user.Password);
                if (password == _users[login])
                    return true;
            }

            return false;
        }

        public bool FindLogin(string login)
        {
            if (_users.ContainsKey(login))
                return true;
            return false;
        }

        public List<string> UserLogins()
        {
            var list = new List<string>();
            foreach (var user in _users)
                list.Add(user.Key);

            return list;
        }

        private void GetUserList()
        {
            using (var fileStream = new FileStream(PATH, FileMode.OpenOrCreate))
            {
                if (fileStream.Length != 0)
                    _users = (Dictionary<string, string>)_binaryFormatter.Deserialize(fileStream);
            }
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
            string password = Hash.Compute(user.Password);
            _users[user.Login] = password;
        }

        private void DeleteUser(string login)
            => _users.Remove(login);
    }
}
