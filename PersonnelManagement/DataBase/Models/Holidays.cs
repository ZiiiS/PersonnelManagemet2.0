using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class Holidays : BaseModel
	{
		public string Вид_отпуска { get; set; }
		public int Табельный_номер { get; set; }
		public DateTime Дата_отпуска { get; set; }
		public int Колл_дней_отпуска { get; set; }
		public DateTime Дата_окончания_отпуска { get; set; }
		public string Основание { get; set; }
	}
}
