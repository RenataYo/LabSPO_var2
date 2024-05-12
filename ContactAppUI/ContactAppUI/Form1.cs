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

namespace ContactAppUI
{
	public partial class ContactApp : Form
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
	}
}
