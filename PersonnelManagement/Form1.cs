using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PersonnelManagement.DataBase;
using PersonnelManagement.DataBase.Models;
using ApplicationContext = PersonnelManagement.DataBase.Models.ApplicationContext;

namespace PersonnelManagement
{
	
	public partial class PersonnelManagement : Form
	{
		StaffFilterPanel uc;
		private IRepository repository;
		private ApplicationContext db = new ApplicationContext();
		public PersonnelManagement()
		{
			InitializeComponent();
			uc = new StaffFilterPanel();
			Controls.Add(uc);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void UpdateTable<T>() where T : class
		{
			DefaultSeed.EnsurePopulated();
			db.Set<T>().Load();
			BindingSource bs = new BindingSource();
			bs.DataSource = db.Set<T>().Local.ToBindingList();
			dataGridView1.DataSource = bs;
			repository = new DynamicRepository<T>();
		}
		private void HolidaysButtan_Click(object sender, EventArgs e)
		{
			UpdateTable<Holidays>();
		}

		private void PassportDataOfEmployeesButton_Click(object sender, EventArgs e)
		{
			UpdateTable<PassportDataOfEmployees>();
		}

		private void InformationAboutBusinessButton_Click(object sender, EventArgs e)
		{
			UpdateTable<InformationAboutBusiness>();
		}

		private void InformationAboutInformationButton_Click(object sender, EventArgs e)
		{
			UpdateTable<InformationAboutInformation>();
		}

		private void ButtonInformationAboutIncentives_Click(object sender, EventArgs e)
		{
			UpdateTable<InformationAboutIncentives>();
		}

		private void ButtonInformationAboutProfessional_Click(object sender, EventArgs e)
		{
			UpdateTable<InformationAboutProfessional>();
		}

		private void ButtonSocialBenefits_Click(object sender, EventArgs e)
		{
			UpdateTable<SocialBenefits>();
		}

		private void ButtonLayoffs_Click(object sender, EventArgs e)
		{
			UpdateTable<Layoffs>();
		}

		private void ButtonStaffingSchedule_Click(object sender, EventArgs e)
		{
			UpdateTable<StaffingSchedule>();
		}

		private void ButtoBbranch_Click(object sender, EventArgs e)
		{
			UpdateTable<Branch>();
		}

		private void PositionButton_Click(object sender, EventArgs e)
		{
			UpdateTable<Position>();
		}

		private void StaffButton_Click(object sender, EventArgs e)
		{
			UpdateTable<Staff>();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			repository.CreateNew(db);
			db.SaveChanges();
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			db.SaveChanges();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
			db.SaveChanges();
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}
	}
}
