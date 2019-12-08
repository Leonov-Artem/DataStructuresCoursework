using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Security;

namespace GUI
{
    public partial class ChangeAccounts : Form
    {
        const string NOTIFICATION = "Уведомление";
        const string ERROR = "Ошибка!";

        UserManagement _userManagement;

        public ChangeAccounts()
        {
            InitializeComponent();
            _userManagement = new UserManagement();
            AddItemsToListBox();
        }

        private void AddNewUserButton_Click(object sender, EventArgs e)
        {
            string login = LoginFromTextBox();
            string password = PasswordFromTextBox();

            if (login != "" && password != "")
            {
                var user = new User(login, password);
                if (AddNewUser(user))
                {
                    AddItemsToListBox();
                    MessageBox.Show("Пользователь добавлен!", NOTIFICATION);
                }
                else
                    MessageBox.Show("Пользователь с таким логином уже существует!", ERROR);
            }
            else
                MessageBox.Show("Введите логин и пароль!", ERROR);

            ClearFields();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                string login = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(login);
                _userManagement.Delete(login);
                MessageBox.Show("Пользователь был успешно удален!", "Уведомление");
            }
            else
                MessageBox.Show("Выберите строку из списка!", "Ошибка!");
        }

        #region methods

        private bool AddNewUser(User user)
        {
            if (!_userManagement.FindLogin(user.Login))
            {
                _userManagement.Add(user);
                return true;
            }
            return false;
        }

        private void ClearFields()
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private string LoginFromTextBox()
            => loginTextBox.Text;

        private string PasswordFromTextBox()
            => passwordTextBox.Text;

        private List<string> GetUserLogins()
            => _userManagement.UserLogins();

        private void AddItemsToListBox()
        {
            ClearListBox();
            List<string> items = GetUserLogins();

            foreach (var item in items)
                listBox1.Items.Add(item);
        }

        private void ClearListBox()
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
        }

        #endregion
    }
}
