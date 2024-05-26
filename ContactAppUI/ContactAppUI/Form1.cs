﻿using ContactApp.Service;
using ContactApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactAppUI.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Resources;

namespace ContactAppUI
{
	/*public partial class ContactApp : Form
	{
		public ContactApp()
		{
			InitializeComponent();
		}
		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void btnSerialize_Click(object sender, EventArgs e)
		{
			string vkId = FindContactTextBox.Text; // Получение данных из TextBox

			if (!string.IsNullOrEmpty(vkId))
			{
				Contact contact = new Contact();
				contact.VkID = vkId;

				// Сохранение данных в файл
				List<Contact> contacts = new List<Contact>();
				contacts.Add(contact);
				Serializer.SaveToFile(contacts, "contacts.json");

				MessageBox.Show("Данные успешно сериализованы и сохранены в файл contacts.json");
			}
			else
			{
				MessageBox.Show("Введите VkID в TextBox");
			}
		}

		private void btnDeserialize_Click(object sender, EventArgs e)
		{
			// Загрузка данных из файла
			List<Contact> loadedContacts = Serializer.LoadFromFile("contacts.json");

			if (loadedContacts.Count > 0)
			{
				Contact loadedContact = loadedContacts[0];
				MessageBox.Show($"VkID из загруженного объекта: {loadedContact.VkID}");
			}
			else
			{
				MessageBox.Show("Нет данных для десериализации");
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void AddContactPicture_Click(object sender, EventArgs e)
		{

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}*/
	/// <summary>
	/// Класс главной формы приложения ContactApp.
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Дата по умолчанию.
		/// </summary>
		private DateTime DefaultDate { get; set; } = new DateTime(2000, 1, 1);

		/// <summary>
		/// Задает и возвращает класс формы About.
		/// </summary>
		private AboutForm AboutForm { get; set; }

		/// <summary>
		/// Список контактов.
		/// </summary>
		private List<Contact> Contacts { get; set; }

		/// <summary>
		/// Конструктор формы.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			Contacts = Serializer.LoadFromFile(Paths.PathToFiles);
			UpdateContacts();
		}

		/// <summary>
		/// Обработчик выхода из программы.
		/// </summary>
		private void ExitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// Открытие формы About.
		/// </summary>
		private void AboutMenuItem_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms["AboutForm"] == null)
			{
				AboutForm = new AboutForm();
				AboutForm.Show();
			}
		}

		/// <summary>
		/// Событие наведении курсора на кнопку добавления контакта.
		/// </summary>
		private void AddContactPicture_MouseEnter(object sender, EventArgs e)
		{
			AddContactPicture.Image = Resources.AddContactIconContrast_512x512;
		}

		/// <summary>
		/// Событие ухода курсора из пределов кнопки добавления контакта.
		/// </summary>
		private void AddContactPicture_MouseLeave(object sender, EventArgs e)
		{
			AddContactPicture.Image = Resources.AddContactIcon_512x512;
		}

		/// <summary>
		/// Событие наведении курсора на кнопку добавления контакта.
		/// </summary>
		private void EditContactPicture_MouseEnter(object sender, EventArgs e)
		{
			EditContactPicture.Image = Resources.EditContactIconContrast_512x512;
		}

		/// <summary>
		/// Событие ухода курсора из пределов кнопки добавления контакта.
		/// </summary>
		private void EditContactPicture_MouseLeave(object sender, EventArgs e)
		{
			EditContactPicture.Image = Resources.EditContactIcon_512x512;
		}

		/// <summary>
		/// Событие наведении курсора на кнопку добавления контакта.
		/// </summary>
		private void DeleteContactPicture_MouseEnter(object sender, EventArgs e)
		{
			DeleteContactPicture.Image = Resources.DeleteContactIconContrast_512x512;
		}

		/// <summary>
		/// Событие ухода курсора из пределов кнопки добавления контакта.
		/// </summary>
		private void DeleteContactPicture_MouseLeave(object sender, EventArgs e)
		{
			DeleteContactPicture.Image = Resources.DeleteContactIcon_512x512;
		}

		/// <summary>
		/// Событие создания контакта.
		/// </summary>
		private void AddContact_Click(object sender, EventArgs e)
		{
			TransferContact.Data = new Contact();
			var addForm = new AddEditContactForm();
			addForm.ShowDialog();
			if (addForm.DialogResult == DialogResult.OK)
			{
				Contacts.Add(TransferContact.Data);
				Serializer.SaveToFile(Contacts, Paths.PathToFiles);
				UpdateContacts();
			}
		}

		/// <summary>
		/// Метод обновления контактов в ListBox.
		/// </summary>
		private void UpdateContacts()
		{
			ContactsListBox.Items.Clear();

			foreach (var contact in Contacts)
			{
				ContactsListBox.Items.Add(contact.Surname);
			}
		}

		/// <summary>
		/// Обновление полей с информацией об контакте.
		/// </summary>
		/// <param name="contact">Контакт.</param>
		private void UpdateContactInformation(Contact contact)
		{
			SurnameTextBox.Text = contact.Surname;
			NameTextBox.Text = contact.Name;
			BirthdayDateTime.Value = contact.Birthday;
			PhoneTextBox.Text = contact.PhoneNumber;
			EmailTextBox.Text = contact.Email;
			VkTextBox.Text = contact.VkID;
		}

		/// <summary>
		/// Обработчик выбора контакта из списка.
		/// </summary>
		private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = ContactsListBox.SelectedIndex;
			if (index >= 0)
			{
				UpdateContactInformation(Contacts[index]);
			}
		}

		/// <summary>
		/// Обработчик изменения даты в главном окне.
		/// </summary>
		private void BirthdayDateTime_ValueChanged(object sender, EventArgs e)
		{
			var index = ContactsListBox.SelectedIndex;
			if (index >= 0)
			{
				BirthdayDateTime.Value = Contacts[index].Birthday;
			}
			else
			{
				BirthdayDateTime.Value = DefaultDate;
			}
		}

		/// <summary>
		/// Изменение созданного контакта.
		/// </summary>
		private void EditContactPicture_Click(object sender, EventArgs e)
		{
			var index = ContactsListBox.SelectedIndex;
			if (index >= 0)
			{
				TransferContact.Data = Contacts[index];
				var addForm = new AddEditContactForm();
				addForm.ShowDialog();
				if (addForm.DialogResult == DialogResult.OK)
				{
					Contacts[index] = TransferContact.Data;
					Serializer.SaveToFile(Contacts, Paths.PathToFiles);
					UpdateContacts();
					ContactsListBox.SelectedIndex = index;
				}
			}
			else
			{
				MessageBox.Show("Необходимо выбрать контакт, который хотите редактировать",
					"Ошибка",
					MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Удаление контакта.
		/// </summary>
		private void DeleteContactPicture_Click(object sender, EventArgs e)
		{
			var index = ContactsListBox.SelectedIndex;
			if (index >= 0)
			{
				DialogResult warning = MessageBox.Show(
					$"Do you really want to remove this contact: {Contacts[index].Surname}",
					"Warning",
					MessageBoxButtons.YesNo);
				if (warning == DialogResult.Yes)
				{
					Contacts.RemoveAt(index);
					Serializer.SaveToFile(Contacts, Paths.PathToFiles);
					UpdateContacts();
					ContactsListBox.SelectedIndex = -1;
					ClearTextBoxes();
				}
			}
			else
			{
				MessageBox.Show("Необходимо выбрать контакт, который хотите удалить",
					"Ошибка",
					MessageBoxButtons.OK);
			}
		}

		/// <summary>
		/// Очищает поля контактов после удаления.
		/// </summary>
		private void ClearTextBoxes()
		{
			SurnameTextBox.Text = string.Empty;
			NameTextBox.Text = string.Empty;
			EmailTextBox.Text = string.Empty;
			VkTextBox.Text = string.Empty;
			PhoneTextBox.Text = string.Empty;
			BirthdayDateTime.Value = new DateTime(2000, 1, 1);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void FindContactTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
