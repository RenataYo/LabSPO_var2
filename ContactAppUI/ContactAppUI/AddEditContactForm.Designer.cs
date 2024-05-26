namespace ContactAppUI
{
	partial class AddEditContactForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditContactForm));
			this.BirthdayDateTime = new System.Windows.Forms.DateTimePicker();
			this.VkTextBox = new System.Windows.Forms.TextBox();
			this.EmailTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.label4BirthdayLabel = new System.Windows.Forms.Label();
			this.PhoneLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.VkLabel = new System.Windows.Forms.Label();
			this.OkButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BirthdayDateTime
			// 
			this.BirthdayDateTime.Location = new System.Drawing.Point(162, 152);
			this.BirthdayDateTime.Name = "BirthdayDateTime";
			this.BirthdayDateTime.Size = new System.Drawing.Size(358, 26);
			this.BirthdayDateTime.TabIndex = 28;
			this.BirthdayDateTime.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			// 
			// VkTextBox
			// 
			this.VkTextBox.Location = new System.Drawing.Point(162, 302);
			this.VkTextBox.Name = "VkTextBox";
			this.VkTextBox.Size = new System.Drawing.Size(622, 26);
			this.VkTextBox.TabIndex = 27;
			// 
			// EmailTextBox
			// 
			this.EmailTextBox.Location = new System.Drawing.Point(162, 247);
			this.EmailTextBox.Name = "EmailTextBox";
			this.EmailTextBox.Size = new System.Drawing.Size(622, 26);
			this.EmailTextBox.TabIndex = 26;
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(162, 201);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(622, 26);
			this.PhoneTextBox.TabIndex = 25;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(162, 103);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(620, 26);
			this.NameTextBox.TabIndex = 24;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(164, 56);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(620, 26);
			this.SurnameTextBox.TabIndex = 23;
			// 
			// SurnameLabel
			// 
			this.SurnameLabel.AutoSize = true;
			this.SurnameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SurnameLabel.Location = new System.Drawing.Point(56, 62);
			this.SurnameLabel.Name = "SurnameLabel";
			this.SurnameLabel.Size = new System.Drawing.Size(85, 20);
			this.SurnameLabel.TabIndex = 17;
			this.SurnameLabel.Text = "Фамилия:";
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Location = new System.Drawing.Point(96, 110);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(44, 20);
			this.NameLabel.TabIndex = 18;
			this.NameLabel.Text = "Имя:";
			// 
			// label4BirthdayLabel
			// 
			this.label4BirthdayLabel.AutoSize = true;
			this.label4BirthdayLabel.Location = new System.Drawing.Point(8, 159);
			this.label4BirthdayLabel.Name = "label4BirthdayLabel";
			this.label4BirthdayLabel.Size = new System.Drawing.Size(132, 20);
			this.label4BirthdayLabel.TabIndex = 19;
			this.label4BirthdayLabel.Text = "День рождения:";
			// 
			// PhoneLabel
			// 
			this.PhoneLabel.AutoSize = true;
			this.PhoneLabel.Location = new System.Drawing.Point(58, 207);
			this.PhoneLabel.Name = "PhoneLabel";
			this.PhoneLabel.Size = new System.Drawing.Size(83, 20);
			this.PhoneLabel.TabIndex = 20;
			this.PhoneLabel.Text = "Телефон:";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Location = new System.Drawing.Point(57, 253);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(84, 20);
			this.EmailLabel.TabIndex = 21;
			this.EmailLabel.Text = "Эл.почта:";
			// 
			// VkLabel
			// 
			this.VkLabel.AutoSize = true;
			this.VkLabel.Location = new System.Drawing.Point(96, 308);
			this.VkLabel.Name = "VkLabel";
			this.VkLabel.Size = new System.Drawing.Size(45, 20);
			this.VkLabel.TabIndex = 22;
			this.VkLabel.Text = "vkID:";
			// 
			// OkButton
			// 
			this.OkButton.Location = new System.Drawing.Point(487, 337);
			this.OkButton.Name = "OkButton";
			this.OkButton.Size = new System.Drawing.Size(127, 45);
			this.OkButton.TabIndex = 29;
			this.OkButton.Text = "ОК";
			this.OkButton.UseVisualStyleBackColor = true;
			this.OkButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Location = new System.Drawing.Point(623, 337);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(127, 45);
			this.CancelButton.TabIndex = 30;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// AddEditContactForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(798, 407);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OkButton);
			this.Controls.Add(this.BirthdayDateTime);
			this.Controls.Add(this.VkTextBox);
			this.Controls.Add(this.EmailTextBox);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.SurnameLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.label4BirthdayLabel);
			this.Controls.Add(this.PhoneLabel);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.VkLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddEditContactForm";
			this.Text = "Add/EditContact";
			this.Load += new System.EventHandler(this.AddEditContactForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker BirthdayDateTime;
		private System.Windows.Forms.TextBox VkTextBox;
		private System.Windows.Forms.TextBox EmailTextBox;
		private System.Windows.Forms.TextBox PhoneTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.Label SurnameLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label label4BirthdayLabel;
		private System.Windows.Forms.Label PhoneLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.Label VkLabel;
		private System.Windows.Forms.Button OkButton;
		private System.Windows.Forms.Button CancelButton;
	}
}