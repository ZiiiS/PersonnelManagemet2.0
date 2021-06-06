using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class Layoffs : BaseModel
	{
		public int Табельный_номер { get; set; }
		public DateTime Дата_увольнения { get; set; }
		public string Статья { get; set; }
		public string Причина_увольнения { get; set; }
	}
}
