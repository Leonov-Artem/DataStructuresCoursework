using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm(AccessType accessType)
        {
            InitializeComponent();

            if (accessType == AccessType.Admin)
                accountsMenuItem.Visible = true;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => Application.Exit();

        private void ClearFieldsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AccountsMenuItem_Click(object sender, EventArgs e)
        {
            var changeAccounts = new ChangeAccounts();
            changeAccounts.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string text = TextFromRichTextBox();
            string pattern = PatternFromTextBox();
            var list = BoyerMoore.Find(text, pattern);
            MessageBox.Show($"Подстрока {pattern} найдена со сдвигом {list[0]}", "");

            this.text.Select(list[0], pattern.Length);
            this.text.SelectionColor = Color.Red;
        }

        private string PatternFromTextBox()
            => pattern.Text;

        private string TextFromRichTextBox()
            => text.Text;
    }
}
