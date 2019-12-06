﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Algorithms;

namespace GUI
{
    public partial class MainForm : Form
    {
        readonly FontFamily FONT_FAMILY = new FontFamily(GenericFontFamilies.Monospace);
        const float FONT_SIZE = 12;
        const string NOTIFICATION = "Уведомление";

        public MainForm(AccessType accessType)
        {
            InitializeComponent();

            if (accessType == AccessType.Admin)
                accountsMenuItem.Visible = true;

            patternTextBox.Font = new Font(FONT_FAMILY, FONT_SIZE);
            textRichTextBox.Font = new Font(FONT_FAMILY, FONT_SIZE);
        }

        #region handlers

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
            => Application.Exit();

        private void ClearFieldsMenuItem_Click(object sender, EventArgs e)
        {
            patternTextBox.Text = "";
            textRichTextBox.Text = "";
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AccountsMenuItem_Click(object sender, EventArgs e)
        {
            var changeAccounts = new ChangeAccounts();
            changeAccounts.ShowDialog();
        }

        private void MainForm_TextChanged(object sender, EventArgs e)
        {
            SetDefaultBackgroundTextColor();

            string text = TextFromRichTextBox();
            string pattern = PatternFromTextBox();

            if (text != "" && pattern != "")
            {
                var shifts = BoyerMoore.Find(text, pattern);
                coincidenceLabel.Text = $"Совпадений: {shifts.Count}";
                ShowFound(pattern, shifts);
            }
            else
                coincidenceLabel.Text = $"Совпадений: {0}";
        }

        #endregion

        #region methods

        private string PatternFromTextBox()
            => patternTextBox.Text;

        private string TextFromRichTextBox()
            => textRichTextBox.Text;

        private void ShowFound(string pattern, List<int> shifts)
        {
            if (shifts.Count != 0)
            {
                foreach (var shift in shifts)
                {
                    textRichTextBox.Select(shift, pattern.Length);
                    textRichTextBox.SelectionBackColor = Color.Yellow;
                    textRichTextBox.SelectionLength = 0;
                    textRichTextBox.SelectionStart = textRichTextBox.Text.Length;
                }
            }
        }

        private void SetDefaultBackgroundTextColor()
        {
            textRichTextBox.SelectAll();
            textRichTextBox.SelectionBackColor = Color.White;
            textRichTextBox.SelectionLength = 0;
            textRichTextBox.SelectionStart = textRichTextBox.Text.Length;
        }

        #endregion
    }
}
