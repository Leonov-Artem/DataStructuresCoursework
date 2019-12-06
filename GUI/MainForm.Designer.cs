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
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coincidenceLabel = new System.Windows.Forms.Label();
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
            this.menuStrip.Size = new System.Drawing.Size(513, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clearFieldsMenuItem
            // 
            this.clearFieldsMenuItem.Name = "clearFieldsMenuItem";
            this.clearFieldsMenuItem.Size = new System.Drawing.Size(117, 24);
            this.clearFieldsMenuItem.Text = "Очистить поля";
            this.clearFieldsMenuItem.Click += new System.EventHandler(this.ClearFieldsMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(76, 24);
            this.helpMenuItem.Text = "Справка";
            this.helpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // accountsMenuItem
            // 
            this.accountsMenuItem.Name = "accountsMenuItem";
            this.accountsMenuItem.Size = new System.Drawing.Size(124, 23);
            this.accountsMenuItem.Text = "Учетные записи";
            this.accountsMenuItem.Visible = false;
            this.accountsMenuItem.Click += new System.EventHandler(this.AccountsMenuItem_Click);
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.Location = new System.Drawing.Point(208, 60);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(298, 300);
            this.textRichTextBox.TabIndex = 2;
            this.textRichTextBox.Text = "";
            this.textRichTextBox.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(17, 60);
            this.patternTextBox.Multiline = true;
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(177, 300);
            this.patternTextBox.TabIndex = 1;
            this.patternTextBox.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Шаблон поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(318, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Текст";
            // 
            // coincidenceLabel
            // 
            this.coincidenceLabel.AutoSize = true;
            this.coincidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coincidenceLabel.Location = new System.Drawing.Point(14, 371);
            this.coincidenceLabel.Name = "coincidenceLabel";
            this.coincidenceLabel.Size = new System.Drawing.Size(120, 20);
            this.coincidenceLabel.TabIndex = 5;
            this.coincidenceLabel.Text = "Совпадений: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 403);
            this.Controls.Add(this.coincidenceLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.textRichTextBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Бойера — Мура";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TextChanged += new System.EventHandler(this.MainForm_TextChanged);
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
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label coincidenceLabel;
    }
}