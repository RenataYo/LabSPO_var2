using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Service
{
	/// <summary>
	/// Класс для передачи объекта контакта между формами.
	/// </summary>
	public class TransferContact
	{
		/// <summary>
		/// Задает и возвращает контакт между формами.
		/// </summary>
		public static Contact Data { get; set; }
	}
}
