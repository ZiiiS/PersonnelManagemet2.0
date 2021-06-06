using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class InformationAboutBusiness : BaseModel
	{
		public int Табельный_номер { get; set; }
		public string Куда_командирован { get; set; }
		public int Номер_Приказа { get; set; }
		public DateTime С_даты { get; set; }
		public DateTime По_дату { get; set; }
		public int Колличество_дней { get; set; }
		public string Цель_командировки { get; set; }
	}
}
