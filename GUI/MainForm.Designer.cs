namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clearFieldsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearFieldsMenuItem,
            this.helpMenuItem,
            this.accountsMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(552, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clearFieldsMenuItem
            // 
            this.clearFieldsMenuItem.Name = "clearFieldsMenuItem";
            this.clearFieldsMenuItem.Size = new System.Drawing.Size(117, 23);
            this.clearFieldsMenuItem.Text = "Очистить поля";
            this.clearFieldsMenuItem.Click += new System.EventHandler(this.ClearFieldsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(76, 23);
            this.helpMenuItem.Text = "Справка";
            this.helpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // accountsMenuItem
            // 
            this.accountsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUserMenuItem,
            this.DeleteUserMenuItem});
            this.accountsMenuItem.Name = "accountsMenuItem";
            this.accountsMenuItem.Size = new System.Drawing.Size(124, 23);
            this.accountsMenuItem.Text = "Учетные записи";
            this.accountsMenuItem.Visible = false;
            // 
            // AddNewUserMenuItem
            // 
            this.AddNewUserMenuItem.Name = "AddNewUserMenuItem";
            this.AddNewUserMenuItem.Size = new System.Drawing.Size(236, 24);
            this.AddNewUserMenuItem.Text = "Добавить пользователя";
            this.AddNewUserMenuItem.Click += new System.EventHandler(this.AddNewUserMenuItem_Click);
            // 
            // DeleteUserMenuItem
            // 
            this.DeleteUserMenuItem.Name = "DeleteUserMenuItem";
            this.DeleteUserMenuItem.Size = new System.Drawing.Size(236, 24);
            this.DeleteUserMenuItem.Text = "Удалить пользователя";
            this.DeleteUserMenuItem.Click += new System.EventHandler(this.DeleteUserMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Бойера — Мура";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearFieldsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteUserMenuItem;
    }
}