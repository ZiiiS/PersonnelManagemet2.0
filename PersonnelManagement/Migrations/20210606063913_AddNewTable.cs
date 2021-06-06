using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonnelManagement.Migrations
{
    public partial class AddNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Staff",
                newName: "ФИО");

            migrationBuilder.AddColumn<DateTime>(
                name: "Дата_приёма",
                table: "Staff",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Должность",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Домашний_адрес",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Код_отдела",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Код_профессии",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Номер_телефона",
                table: "Staff",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Образование",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Пол",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Семейное_положение",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Стаж_работы",
                table: "Staff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Branch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Наименование_отдела = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Номер_кабинета = table.Column<int>(type: "int", nullable: false),
                    Номер_телефона_отдела = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Holidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Вид_отпуска = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Дата_отпуска = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Колл_дней_отпуска = table.Column<int>(type: "int", nullable: false),
                    Дата_окончания_отпуска = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Основание = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_business_trips",
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
                    table.PrimaryKey("PK_Information_about_business_trips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_incentives",
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
                    table.PrimaryKey("PK_Information_about_incentives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_information",
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
                    table.PrimaryKey("PK_Information_about_information", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Information_about_professional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Название_профессии = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Классификация_професии = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information_about_professional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Layoffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Табельный_номер = table.Column<int>(type: "int", nullable: false),
                    Дата_увольнения = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Статья = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Причина_увольнения = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Layoffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Passport_data_of_employees",
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
                    table.PrimaryKey("PK_Passport_data_of_employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Наименование_должности = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Оклад = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Social_Benefits",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Branch");

            migrationBuilder.DropTable(
                name: "Holidays");

            migrationBuilder.DropTable(
                name: "Information_about_business_trips");

            migrationBuilder.DropTable(
                name: "Information_about_incentives");

            migrationBuilder.DropTable(
                name: "Information_about_information");

            migrationBuilder.DropTable(
                name: "Information_about_professional");

            migrationBuilder.DropTable(
                name: "Layoffs");

            migrationBuilder.DropTable(
                name: "Passport_data_of_employees");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Social_Benefits");

            migrationBuilder.DropTable(
                name: "Staffing_schedule");

            migrationBuilder.DropColumn(
                name: "Дата_приёма",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Должность",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Домашний_адрес",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Код_отдела",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Код_профессии",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Номер_телефона",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Образование",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Пол",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Семейное_положение",
                table: "Staff");

            migrationBuilder.DropColumn(
                name: "Стаж_работы",
                table: "Staff");

            migrationBuilder.RenameColumn(
                name: "ФИО",
                table: "Staff",
                newName: "Name");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }
    }
}
