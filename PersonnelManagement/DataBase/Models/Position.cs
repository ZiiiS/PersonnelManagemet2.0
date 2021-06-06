using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class Position : BaseModel
	{
		public string Наименование_должности { get; set; }
		public int  Оклад { get; set; }
	}
}
