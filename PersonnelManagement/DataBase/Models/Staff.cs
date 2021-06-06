using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	public class Staff : BaseModel
	{
		public string ФИО { get; set; }
		public string Пол { get; set; }
		public string Семейное_положение { get; set; }
		public string Домашний_адрес { get; set; }
		public string Образование { get; set; }
		public string Должность { get; set; }
		public long Номер_телефона { get; set; }
		public int Стаж_работы { get; set; }
		public DateTime Дата_приёма { get; set; }
		public int Код_отдела { get; set; }
		public int Код_профессии { get; set; }


	}
}
