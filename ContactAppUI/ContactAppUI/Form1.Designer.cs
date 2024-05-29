namespace ContactAppUI
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.ContactsListBox = new System.Windows.Forms.ListBox();
			this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
			this.VkTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BirthdayPanel = new System.Windows.Forms.Panel();
			this.BirthdayWarningLabel = new System.Windows.Forms.Label();
			this.AddContactPicture = new System.Windows.Forms.PictureBox();
			this.DeleteContactPicture = new System.Windows.Forms.PictureBox();
			this.EditContactPicture = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BirthdayBoyLabel = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.BirthdayPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeleteContactPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EditContactPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// FindContactTextBox
			// 
			this.FindContactTextBox.Location = new System.Drawing.Point(85, 9);
			this.FindContactTextBox.Name = "FindContactTextBox";
			this.FindContactTextBox.Size = new System.Drawing.Size(215, 26);
			this.FindContactTextBox.TabIndex = 0;
			this.FindContactTextBox.TextChanged += new System.EventHandler(this.FindContactTextBox_TextChanged);
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
			this.menuStrip1.Size = new System.Drawing.Size(1149, 33);
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
			this.ExitMenuItem.Size = new System.Drawing.Size(237, 34);
			this.ExitMenuItem.Text = "Выход";
			this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
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
			this.addContactToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
			this.addContactToolStripMenuItem.Text = "Добавить контакт";
			// 
			// editContactToolStripMenuItem
			// 
			this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
			this.editContactToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
			this.editContactToolStripMenuItem.Text = "Изменить контакт";
			// 
			// removeContactToolStripMenuItem
			// 
			this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
			this.removeContactToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
			this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(314, 34);
			this.removeContactToolStripMenuItem.Text = "Удалить контакт";
			this.removeContactToolStripMenuItem.Click += new System.EventHandler(this.DeleteContactPicture_Click);
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
			this.AboutMenuItem.Size = new System.Drawing.Size(254, 34);
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
			this.splitContainer1.Location = new System.Drawing.Point(20, 36);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.AddContactPicture);
			this.splitContainer1.Panel1.Controls.Add(this.ContactsListBox);
			this.splitContainer1.Panel1.Controls.Add(this.DeleteContactPicture);
			this.splitContainer1.Panel1.Controls.Add(this.EditContactPicture);
			this.splitContainer1.Panel1.Controls.Add(this.FindLabel);
			this.splitContainer1.Panel1.Controls.Add(this.FindContactTextBox);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.BirthdayPanel);
			this.splitContainer1.Panel2.Controls.Add(this.BirthdayDateTime);
			this.splitContainer1.Panel2.Controls.Add(this.VkTextBox);
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
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
			this.splitContainer1.Size = new System.Drawing.Size(1125, 735);
			this.splitContainer1.SplitterDistance = 340;
			this.splitContainer1.TabIndex = 11;
			// 
			// ContactsListBox
			// 
			this.ContactsListBox.FormattingEnabled = true;
			this.ContactsListBox.ItemHeight = 20;
			this.ContactsListBox.Location = new System.Drawing.Point(4, 57);
			this.ContactsListBox.Name = "ContactsListBox";
			this.ContactsListBox.Size = new System.Drawing.Size(327, 604);
			this.ContactsListBox.TabIndex = 5;
			this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
			// 
			// BirthdayDateTime
			// 
			this.BirthdayDateTime.Location = new System.Drawing.Point(156, 99);
			this.BirthdayDateTime.Name = "BirthdayDateTime";
			this.BirthdayDateTime.Size = new System.Drawing.Size(617, 26);
			this.BirthdayDateTime.TabIndex = 16;
			this.BirthdayDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// VkTextBox
			// 
			this.VkTextBox.Location = new System.Drawing.Point(156, 249);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.Size = new System.Drawing.Size(622, 26);
			this.VkTextBox.TabIndex = 15;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(156, 194);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(622, 26);
			this.EmailTextBox.TabIndex = 14;
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(156, 148);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(622, 26);
			this.PhoneTextBox.TabIndex = 13;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(156, 50);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(622, 26);
			this.NameTextBox.TabIndex = 12;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(156, 9);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(622, 26);
			this.SurnameTextBox.TabIndex = 11;
			// 
			// BirthdayPanel
			// 
			this.BirthdayPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BirthdayPanel.Controls.Add(this.BirthdayBoyLabel);
			this.BirthdayPanel.Controls.Add(this.BirthdayWarningLabel);
			this.BirthdayPanel.Controls.Add(this.pictureBox1);
			this.BirthdayPanel.Location = new System.Drawing.Point(6, 536);
			this.BirthdayPanel.Name = "BirthdayPanel";
			this.BirthdayPanel.Size = new System.Drawing.Size(767, 196);
			this.BirthdayPanel.TabIndex = 17;
			// 
			// BirthdayWarningLabel
			// 
			this.BirthdayWarningLabel.AutoSize = true;
			this.BirthdayWarningLabel.Location = new System.Drawing.Point(197, 80);
			this.BirthdayWarningLabel.Name = "BirthdayWarningLabel";
			this.BirthdayWarningLabel.Size = new System.Drawing.Size(200, 20);
			this.BirthdayWarningLabel.TabIndex = 1;
			this.BirthdayWarningLabel.Text = "Сегодня день рождения:";
			// 
			// AddContactPicture
			// 
			this.AddContactPicture.ErrorImage = null;
			this.AddContactPicture.Image = global::ContactAppUI.Properties.Resources.AddContactIcon_512x512;
			this.AddContactPicture.InitialImage = null;
			this.AddContactPicture.Location = new System.Drawing.Point(3, 666);
			this.AddContactPicture.Name = "AddContactPicture";
			this.AddContactPicture.Size = new System.Drawing.Size(57, 69);
			this.AddContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.AddContactPicture.TabIndex = 9;
			this.AddContactPicture.TabStop = false;
			this.AddContactPicture.Click += new System.EventHandler(this.AddContact_Click);
			// 
			// DeleteContactPicture
			// 
			this.DeleteContactPicture.Image = global::ContactAppUI.Properties.Resources.DeleteContactIcon_512x512;
			this.DeleteContactPicture.Location = new System.Drawing.Point(148, 666);
			this.DeleteContactPicture.Name = "DeleteContactPicture";
			this.DeleteContactPicture.Size = new System.Drawing.Size(56, 69);
			this.DeleteContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DeleteContactPicture.TabIndex = 8;
			this.DeleteContactPicture.TabStop = false;
			this.DeleteContactPicture.Click += new System.EventHandler(this.DeleteContactPicture_Click);
			// 
			// EditContactPicture
			// 
			this.EditContactPicture.Image = global::ContactAppUI.Properties.Resources.EditContactIcon_512x512;
			this.EditContactPicture.Location = new System.Drawing.Point(76, 666);
			this.EditContactPicture.Name = "EditContactPicture";
			this.EditContactPicture.Size = new System.Drawing.Size(57, 69);
			this.EditContactPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.EditContactPicture.TabIndex = 7;
			this.EditContactPicture.TabStop = false;
			this.EditContactPicture.Click += new System.EventHandler(this.EditContactPicture_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ContactAppUI.Properties.Resources.Warning_512x512;
			this.pictureBox1.Location = new System.Drawing.Point(0, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(191, 190);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BirthdayBoyLabel
			// 
			this.BirthdayBoyLabel.AutoSize = true;
			this.BirthdayBoyLabel.Location = new System.Drawing.Point(448, 80);
			this.BirthdayBoyLabel.Name = "BirthdayBoyLabel";
			this.BirthdayBoyLabel.Size = new System.Drawing.Size(0, 20);
			this.BirthdayBoyLabel.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1149, 783);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "ContactApp";
			this.Load += new System.EventHandler(this.MainForm_Load_1);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.BirthdayPanel.ResumeLayout(false);
			this.BirthdayPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddContactPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeleteContactPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EditContactPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
		private System.Windows.Forms.TextBox VkTextBox;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox PhoneTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.DateTimePicker BirthdayDateTime;
		private System.Windows.Forms.ListBox ContactsListBox;
		private System.Windows.Forms.PictureBox DeleteContactPicture;
		private System.Windows.Forms.PictureBox EditContactPicture;
		private System.Windows.Forms.PictureBox AddContactPicture;
		private System.Windows.Forms.Panel BirthdayPanel;
		private System.Windows.Forms.Label BirthdayWarningLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label BirthdayBoyLabel;
	}
}

