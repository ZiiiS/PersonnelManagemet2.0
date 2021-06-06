using PersonnelManagement.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelManagement
{
	interface IRepository
	{
		public void CreateNew(ApplicationContext db);
	}

	class DynamicRepository<T> : IRepository where T : class
	{
		public void CreateNew(ApplicationContext db)
		{
			T newInstanse = Activator.CreateInstance(typeof(T)) as T;
			db.Set<T>().Add(newInstanse);
		}
	}
}
