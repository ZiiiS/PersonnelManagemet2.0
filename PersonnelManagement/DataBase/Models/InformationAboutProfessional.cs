using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class InformationAboutProfessional : BaseModel
	{
		public string Название_профессии { get; set; }
		public string Классификация_професии { get; set; }
	}
}
