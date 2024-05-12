namespace ContactAppUI
{
	partial class AboutForm
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
			this.NameApplication = new System.Windows.Forms.Label();
			this.VersionLabel = new System.Windows.Forms.Label();
			this.AuthorLabel = new System.Windows.Forms.Label();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.EmailLink = new System.Windows.Forms.LinkLabel();
			this.GitLabel = new System.Windows.Forms.Label();
			this.GitLink = new System.Windows.Forms.LinkLabel();
			this.LowerInfo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NameApplication
			// 
			this.NameApplication.AutoSize = true;
			this.NameApplication.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
			this.NameApplication.Location = new System.Drawing.Point(13, 39);
			this.NameApplication.Name = "NameApplication";
			this.NameApplication.Size = new System.Drawing.Size(179, 40);
			this.NameApplication.TabIndex = 0;
			this.NameApplication.Text = "ContactApp";
			// 
			// VersionLabel
			// 
			this.VersionLabel.AutoSize = true;
			this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.VersionLabel.Location = new System.Drawing.Point(13, 93);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new System.Drawing.Size(68, 25);
			this.VersionLabel.TabIndex = 1;
			this.VersionLabel.Text = "v. 1.0.0";
			// 
			// AuthorLabel
			// 
			this.AuthorLabel.AutoSize = true;
			this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AuthorLabel.Location = new System.Drawing.Point(12, 195);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new System.Drawing.Size(187, 25);
			this.AuthorLabel.TabIndex = 2;
			this.AuthorLabel.Text = "Автор: Титова Рената";
			// 
			// EmailLabel
			// 
			this.EmailLabel.AutoSize = true;
			this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.EmailLabel.Location = new System.Drawing.Point(12, 274);
			this.EmailLabel.Name = "EmailLabel";
			this.EmailLabel.Size = new System.Drawing.Size(158, 25);
			this.EmailLabel.TabIndex = 3;
			this.EmailLabel.Text = "e-mail для связи:  ";
			// 
			// EmailLink
			// 
			this.EmailLink.AutoSize = true;
			this.EmailLink.Location = new System.Drawing.Point(157, 279);
			this.EmailLink.Name = "EmailLink";
			this.EmailLink.Size = new System.Drawing.Size(207, 20);
			this.EmailLink.TabIndex = 4;
			this.EmailLink.TabStop = true;
			this.EmailLink.Text = "darknessneteru@gmail.com";
			// 
			// GitLabel
			// 
			this.GitLabel.AutoSize = true;
			this.GitLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.GitLabel.Location = new System.Drawing.Point(12, 314);
			this.GitLabel.Name = "GitLabel";
			this.GitLabel.Size = new System.Drawing.Size(72, 25);
			this.GitLabel.TabIndex = 5;
			this.GitLabel.Text = "GitHub:";
			// 
			// GitLink
			// 
			this.GitLink.AutoSize = true;
			this.GitLink.Location = new System.Drawing.Point(76, 314);
			this.GitLink.Name = "GitLink";
			this.GitLink.Size = new System.Drawing.Size(406, 20);
			this.GitLink.TabIndex = 6;
			this.GitLink.TabStop = true;
			this.GitLink.Text = "https://github.com/RenataYo/LabSPO_var2/tree/develop";
			// 
			// LowerInfo
			// 
			this.LowerInfo.AutoSize = true;
			this.LowerInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.LowerInfo.Location = new System.Drawing.Point(12, 530);
			this.LowerInfo.Name = "LowerInfo";
			this.LowerInfo.Size = new System.Drawing.Size(188, 25);
			this.LowerInfo.TabIndex = 7;
			this.LowerInfo.Text = "2024 Титова Рената©";
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 568);
			this.Controls.Add(this.LowerInfo);
			this.Controls.Add(this.GitLink);
			this.Controls.Add(this.GitLabel);
			this.Controls.Add(this.EmailLink);
			this.Controls.Add(this.EmailLabel);
			this.Controls.Add(this.AuthorLabel);
			this.Controls.Add(this.VersionLabel);
			this.Controls.Add(this.NameApplication);
			this.Location = new System.Drawing.Point(12, 274);
			this.Name = "AboutForm";
			this.Text = "AboutForms";
			this.Load += new System.EventHandler(this.AboutForms_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label NameApplication;
		private System.Windows.Forms.Label VersionLabel;
		private System.Windows.Forms.Label AuthorLabel;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.LinkLabel EmailLink;
		private System.Windows.Forms.Label GitLabel;
		private System.Windows.Forms.LinkLabel GitLink;
		private System.Windows.Forms.Label LowerInfo;
	}
}