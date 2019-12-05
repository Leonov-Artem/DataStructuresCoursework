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
    public partial class Authorization : Form
    {
        const string ADMIN_LOGIN = "admin";
        const string ADMIN_PASSWORD = "admin";
        const string ERROR = "Ошибка";

        UserManagement _userManagement;

        public Authorization()
        {
            InitializeComponent();
            _userManagement = new UserManagement();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            string login = LoginFromTextBox();
            string password = PasswordFromTextBox();

            if (login != "" && password != "")
            {
                var user = new User(login, password);
                if (FindUser(user))
                    ShowMainForm(user);
                else
                {
                    MessageBox.Show("Введите корректный логин и пароль!", ERROR);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль!", ERROR);
                return;
            }
        }

        private string LoginFromTextBox()
            => loginTextBox.Text;

        private string PasswordFromTextBox()
            => passwordTextBox.Text;

        private void ClearFields()
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private bool FindUser(User user)
        {
            if (user.Login == ADMIN_LOGIN && user.Password == ADMIN_PASSWORD
                || _userManagement.Find(user))
                return true;
            return false;
        }

        private AccessType GetAccessType(User user)
        {
            if (user.Login == ADMIN_LOGIN && user.Password == ADMIN_PASSWORD)
                return AccessType.Admin;
            return AccessType.User;
        }

        private void ShowMainForm(User user)
        {
            Hide();
            AccessType accessType = GetAccessType(user);
            var mainForm = new MainForm(accessType);
            mainForm.ShowDialog();
        }
    }
}
