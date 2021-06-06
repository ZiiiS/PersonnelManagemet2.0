using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonnelManagement.Migrations
{
    public partial class Jopa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information_about_business_trips");

            migrationBuilder.DropTable(
                name: "Information_about_incentives");

            migrationBuilder.DropTable(
                name: "Information_about_information");

            migrationBuilder.DropTable(
                name: "Information_about_professional");

            migrationBuilder.DropTable(
                name: "Passport_data_of_employees");

            migrationBuilder.DropTable(
                name: "Social_Benefits");

            migrationBuilder.DropTable(
                name: "Staffing_schedule");

            migrationBuilder.DropColumn(
                name: "Код_отдела",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "Код_отделаId",
                table: "Staff",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InformationAboutBusiness",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Куда_командирован = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номер_Приказа = table.Column<int>(type: "int", nullable: false),
                    С_даты = table.Column<DateTime>(type: "datetime2", nullable: false),
                    По_дату = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Колличество_дней = table.Column<int>(type: "int", nullable: false),
                    Цель_командировки = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAboutBusiness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationAboutIncentives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Мотив_поощрения = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Дата = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номер_документа = table.Column<int>(type: "int", nullable: false),
                    Обоснование = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сумма = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAboutIncentives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationAboutInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Сведени_о_повышении_квалификации = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Вид_повышения = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Наименование_учреждения = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Дата_повышения = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAboutInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InformationAboutProfessional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название_профессии = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Классификация_професии = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationAboutProfessional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassportDataOfEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Серия_паспорта = table.Column<int>(type: "int", nullable: false),
                    Номер = table.Column<int>(type: "int", nullable: false),
                    Кем_выдан = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Когда_выдан = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassportDataOfEmployees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Наименование_льгот = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номер_документа = table.Column<int>(type: "int", nullable: false),
                    Дата_выдачи_документа = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialBenefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaffingSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Код_должности = table.Column<int>(type: "int", nullable: false),
                    Код_отдела = table.Column<int>(type: "int", nullable: false),
                    Колличество_сотрудников = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffingSchedule", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staff_Код_отделаId",
                table: "Staff",
                column: "Код_отделаId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Branch_Код_отделаId",
                table: "Staff",
                column: "Код_отделаId",
                principalTable: "Branch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Branch_Код_отделаId",
                table: "Staff");

            migrationBuilder.DropTable(
                name: "InformationAboutBusiness");

            migrationBuilder.DropTable(
                name: "InformationAboutIncentives");

            migrationBuilder.DropTable(
                name: "InformationAboutInformation");

            migrationBuilder.DropTable(
                name: "InformationAboutProfessional");

            migrationBuilder.DropTable(
                name: "PassportDataOfEmployees");

            migrationBuilder.DropTable(
                name: "SocialBenefits");

            migrationBuilder.DropTable(
                name: "StaffingSchedule");

            migrationBuilder.DropIndex(
                name: "IX_Staff_Код_отделаId",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Код_отделаId",
                table: "Staff");

            migrationBuilder.AddColumn<int>(
                name: "Код_отдела",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Information_about_business_trips",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Колличество_дней = table.Column<int>(type: "int", nullable: false),
                    Куда_командирован = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номер_Приказа = table.Column<int>(type: "int", nullable: false),
                    По_дату = table.Column<DateTime>(type: "datetime2", nullable: false),
                    С_даты = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Цель_командировки = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information_about_business_trips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_incentives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Дата = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Мотив_поощрения = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номер_документа = table.Column<int>(type: "int", nullable: false),
                    Обоснование = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сумма = table.Column<int>(type: "int", nullable: false),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information_about_incentives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_information",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Вид_повышения = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Дата_повышения = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Наименование_учреждения = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сведени_о_повышении_квалификации = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information_about_information", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_professional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Классификация_професии = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Название_профессии = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information_about_professional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passport_data_of_employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Кем_выдан = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Когда_выдан = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номер = table.Column<int>(type: "int", nullable: false),
                    Серия_паспорта = table.Column<int>(type: "int", nullable: false),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport_data_of_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Social_Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Дата_выдачи_документа = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Наименование_льгот = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номер_документа = table.Column<int>(type: "int", nullable: false),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Social_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffing_schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Код_должности = table.Column<int>(type: "int", nullable: false),
                    Код_отдела = table.Column<int>(type: "int", nullable: false),
                    Колличество_сотрудников = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffing_schedule", x => x.Id);
                });
        }
    }
}
