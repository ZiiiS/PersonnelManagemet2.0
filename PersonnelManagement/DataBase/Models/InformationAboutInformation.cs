using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class InformationAboutInformation : BaseModel
	{
		public string Сведени_о_повышении_квалификации { get; set; }
		public string Вид_повышения { get; set; }
		public string Наименование_учреждения { get; set; }
		public int Табельный_номер { get; set; }
		public DateTime Дата_повышения { get; set; }
	}
}
