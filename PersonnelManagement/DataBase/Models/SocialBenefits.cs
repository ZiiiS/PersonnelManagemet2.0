using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class SocialBenefits : BaseModel
	{
		public int Табельный_номер { get; set; }
		public string Наименование_льгот { get; set; }
		public int Номер_документа { get; set; }
		public DateTime Дата_выдачи_документа { get; set; }
	}
}
