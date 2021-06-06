using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class InformationAboutIncentives : BaseModel
	{
		public int Табельный_номер { get; set; }
		public string Мотив_поощрения { get; set; }
		public DateTime Дата { get; set; }
		public int Номер_документа { get; set; }
		public string Обоснование { get; set; }
		public int Сумма { get; set; }
	}
}
