using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonnelManagement.DataBase.Models
{
	class ApplicationContext : DbContext
	{
        public DbSet<InformationAboutInformation> InformationAboutInformation { get; set; }
        public DbSet<StaffingSchedule> StaffingSchedule { get; set; }
        public DbSet<Layoffs> Layoffs { get; set; }
        public DbSet<SocialBenefits> SocialBenefits { get; set; }
        public DbSet<InformationAboutProfessional> InformationAboutProfessional { get; set; }
        public DbSet<InformationAboutIncentives> InformationAboutIncentives { get; set; }
        public DbSet<InformationAboutBusiness> InformationAboutBusiness { get; set; }
        public DbSet<PassportDataOfEmployees> PassportDataOfEmployees { get; set; }
        public DbSet<Holidays> Holidays { get; set; }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<Staff> Staff { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
