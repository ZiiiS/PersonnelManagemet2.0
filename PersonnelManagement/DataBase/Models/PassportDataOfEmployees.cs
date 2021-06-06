using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class PassportDataOfEmployees : BaseModel
	{
		public int Табельный_номер { get; set; }
		public int Серия_паспорта { get; set; }
		public int Номер { get; set; }
		public string Кем_выдан { get; set; }
		public DateTime Когда_выдан { get; set; }

	}
}
