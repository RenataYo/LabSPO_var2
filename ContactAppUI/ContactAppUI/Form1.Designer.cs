namespace ContactAppUI
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.FindContactTextBox = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FindLabel = new System.Windows.Forms.Label();
			this.SurnameLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.label4BirthdayLabel = new System.Windows.Forms.Label();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.VkLabel = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.VkTextBoxox5 = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
			this.ContactsListBox = new System.Windows.Forms.ListBox();
			this.AddContactPicture = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// FindContactTextBox
			// 
			this.FindContactTextBox.Location = new System.Drawing.Point(85, 9);
			this.FindContactTextBox.Name = "FindContactTextBox";
			this.FindContactTextBox.Size = new System.Drawing.Size(215, 26);
			this.FindContactTextBox.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(804, 33);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// ExitMenuItem
			// 
			this.ExitMenuItem.Name = "ExitMenuItem";
			this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
			this.ExitMenuItem.Size = new System.Drawing.Size(270, 34);
			this.ExitMenuItem.Text = "Выход";
			// 
			// EditMenuItem
			// 
			this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
			this.EditMenuItem.Name = "EditMenuItem";
			this.EditMenuItem.Size = new System.Drawing.Size(107, 29);
			this.EditMenuItem.Text = "Изменить";
			// 
			// addContactToolStripMenuItem
			// 
			this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
			this.addContactToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.addContactToolStripMenuItem.Text = "Добавить контакт";
			// 
			// editContactToolStripMenuItem
			// 
			this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
			this.editContactToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.editContactToolStripMenuItem.Text = "Изменить контакт";
			// 
			// removeContactToolStripMenuItem
			// 
			this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
			this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
			this.removeContactToolStripMenuItem.Text = "Удалить контакт";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
			this.helpToolStripMenuItem.Text = "О программе...";
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.AboutMenuItem.Size = new System.Drawing.Size(270, 34);
			this.AboutMenuItem.Text = "Информация";
			// 
			// FindLabel
			// 
			this.FindLabel.AutoSize = true;
			this.FindLabel.Location = new System.Drawing.Point(15, 15);
			this.FindLabel.Name = "FindLabel";
			this.FindLabel.Size = new System.Drawing.Size(59, 20);
			this.FindLabel.TabIndex = 4;
			this.FindLabel.Text = "Поиск:";
			// 
			// SurnameLabel
			// 
			this.SurnameLabel.AutoSize = true;
			this.SurnameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SurnameLabel.Location = new System.Drawing.Point(50, 9);
			this.SurnameLabel.Name = "SurnameLabel";
			this.SurnameLabel.Size = new System.Drawing.Size(85, 20);
			this.SurnameLabel.TabIndex = 5;
			this.SurnameLabel.Text = "Фамилия:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(90, 57);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(44, 20);
			this.NameLabel.TabIndex = 6;
			this.NameLabel.Text = "Имя:";
			// 
			// label4BirthdayLabel
			// 
			this.label4BirthdayLabel.AutoSize = true;
			this.label4BirthdayLabel.Location = new System.Drawing.Point(2, 106);
			this.label4BirthdayLabel.Name = "label4BirthdayLabel";
			this.label4BirthdayLabel.Size = new System.Drawing.Size(132, 20);
			this.label4BirthdayLabel.TabIndex = 7;
			this.label4BirthdayLabel.Text = "День рождения:";
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Location = new System.Drawing.Point(52, 154);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(83, 20);
			this.PhoneLabel.TabIndex = 8;
			this.PhoneLabel.Text = "Телефон:";
			this.PhoneLabel.Click += new System.EventHandler(this.label5_Click);
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(51, 200);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(84, 20);
			this.EmailLabel.TabIndex = 9;
			this.EmailLabel.Text = "Эл.почта:";
			// 
			// VkLabel
			// 
			this.VkLabel.AutoSize = true;
			this.VkLabel.Location = new System.Drawing.Point(90, 255);
			this.VkLabel.Name = "VkLabel";
			this.VkLabel.Size = new System.Drawing.Size(45, 20);
			this.VkLabel.TabIndex = 10;
			this.VkLabel.Text = "vkID:";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 50);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.AddContactPicture);
			this.splitContainer1.Panel1.Controls.Add(this.ContactsListBox);
			this.splitContainer1.Panel1.Controls.Add(this.FindLabel);
			this.splitContainer1.Panel1.Controls.Add(this.FindContactTextBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.BirthdayDateTime);
			this.splitContainer1.Panel2.Controls.Add(this.VkTextBoxox5);
			this.splitContainer1.Panel2.Controls.Add(this.EmailTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.PhoneTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.NameTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.SurnameTextBox);
			this.splitContainer1.Panel2.Controls.Add(this.SurnameLabel);
			this.splitContainer1.Panel2.Controls.Add(this.NameLabel);
			this.splitContainer1.Panel2.Controls.Add(this.label4BirthdayLabel);
			this.splitContainer1.Panel2.Controls.Add(this.PhoneLabel);
			this.splitContainer1.Panel2.Controls.Add(this.EmailLabel);
			this.splitContainer1.Panel2.Controls.Add(this.VkLabel);
			this.splitContainer1.Size = new System.Drawing.Size(776, 612);
			this.splitContainer1.SplitterDistance = 310;
			this.splitContainer1.TabIndex = 11;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(156, 9);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(287, 26);
			this.SurnameTextBox.TabIndex = 11;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(156, 50);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(287, 26);
			this.NameTextBox.TabIndex = 12;
			this.NameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(156, 148);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(287, 26);
			this.PhoneTextBox.TabIndex = 13;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(156, 194);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(287, 26);
			this.EmailTextBox.TabIndex = 14;
			// 
			// VkTextBoxox5
			// 
			this.VkTextBoxox5.Location = new System.Drawing.Point(156, 249);
			this.VkTextBoxox5.Name = "VkTextBoxox5";
			this.VkTextBoxox5.Size = new System.Drawing.Size(287, 26);
			this.VkTextBoxox5.TabIndex = 15;
			// 
			// BirthdayDateTime
			// 
			this.BirthdayDateTime.Location = new System.Drawing.Point(156, 99);
			this.BirthdayDateTime.Name = "BirthdayDateTime";
			this.BirthdayDateTime.Size = new System.Drawing.Size(200, 26);
			this.BirthdayDateTime.TabIndex = 16;
			this.BirthdayDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// ContactsListBox
			// 
			this.ContactsListBox.FormattingEnabled = true;
			this.ContactsListBox.ItemHeight = 20;
			this.ContactsListBox.Location = new System.Drawing.Point(3, 50);
			this.ContactsListBox.Name = "ContactsListBox";
			this.ContactsListBox.Size = new System.Drawing.Size(307, 464);
			this.ContactsListBox.TabIndex = 5;
			// 
			// AddContactPicture
			// 
			this.AddContactPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.AddContactPicture.Image = ((System.Drawing.Image)(resources.GetObject("AddContactPicture.Image")));
			this.AddContactPicture.ImageLocation = "TOP";
			this.AddContactPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("AddContactPicture.InitialImage")));
			this.AddContactPicture.Location = new System.Drawing.Point(4, 520);
			this.AddContactPicture.Name = "AddContactPicture";
			this.AddContactPicture.Size = new System.Drawing.Size(70, 89);
			this.AddContactPicture.TabIndex = 6;
			this.AddContactPicture.TabStop = false;
			this.AddContactPicture.Click += new System.EventHandler(this.AddContactPicture_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 674);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.splitContainer1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FindContactTextBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.Label FindLabel;
		private System.Windows.Forms.Label SurnameLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label label4BirthdayLabel;
		private System.Windows.Forms.Label PhoneLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label VkLabel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox VkTextBoxox5;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox PhoneTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DateTimePicker BirthdayDateTime;
		private System.Windows.Forms.ListBox ContactsListBox;
		private System.Windows.Forms.PictureBox AddContactPicture;
	}
}

