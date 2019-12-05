﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void AddNewUserMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUserMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}