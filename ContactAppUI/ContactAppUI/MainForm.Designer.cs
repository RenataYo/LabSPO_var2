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
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(1149, 783);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "ContactApp";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

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
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

