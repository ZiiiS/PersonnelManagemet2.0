using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	public class Branch : BaseModel
	{
		public string Наименование_отдела { get; set; }
		public int Номер_кабинета { get; set; }
		public int Номер_телефона_отдела { get; set; }
	}
}
