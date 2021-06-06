using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement.DataBase.Models
{
	class StaffingSchedule : BaseModel
	{
		public int Код_должности { get; set; }
		public int Код_отдела { get; set; }
		public int Колличество_сотрудников { get; set; }
	}
}
