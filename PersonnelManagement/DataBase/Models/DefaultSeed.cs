﻿using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PersonnelManagement.DataBase.Models
{
	public static class DefaultSeed
	{
		public static void EnsurePopulated()
		{
			using(var context = new ApplicationContext())
			{
				if (!context.Staff.Any())
				{
					context.Staff.AddRange
					(
						new Staff
						{
							ФИО = "Павел Полещук",
							Пол = "Мужской",
							Семейное_положение = "Не женат",
							Домашний_адрес = "г.Первоуральск ул.Пушкина 34/1 кв.395",
							Образование = "Неполное среднее",
							Должность = "Программист-стажер",
							Номер_телефона = 89654587832,
							Стаж_работы = 2,
							Дата_приёма = new System.DateTime(2021,06,10),
							Код_отдела = 1,
							Код_профессии = 4
							
						},
						new Staff
						{
							ФИО = "Михаил Давыдов",
							Пол = "Мужской",
							Семейное_положение = "Не женат",
							Домашний_адрес = "г.Ставрополь ул.Доваторцев 86/1 кв.563",
							Образование = "СПО",
							Должность = "Старший-программист",
							Номер_телефона = 89654587832,
							Стаж_работы = 2,
							Дата_приёма = new System.DateTime(2019, 01, 14),
							Код_отдела = 1,
							Код_профессии = 2

						}
					);
					context.Position.AddRange
					(
						new Position 
						{ 
							Наименование_должности = "Начальник отдела",
							Оклад = 85288,
						},
						new Position
						{
							Наименование_должности = "Старший-программист",
							Оклад = 50000,
						},
						new Position
						{
							Наименование_должности = "Программист",
							Оклад = 30000,
						},
						new Position
						{
							Наименование_должности = "Программист-стажер",
							Оклад = 11500,
						}
					);
					context.Branch.AddRange
					(
						new Branch 
						{ 
							Наименование_отдела = "Отдел разработки ПО",
							Номер_кабинета = 231,
							Номер_телефона_отдела = 23045
						},
						new Branch
						{
							Наименование_отдела = "Отдел тестирования ПО",
							Номер_кабинета = 225,
							Номер_телефона_отдела = 32145
						}
					);
					context.Holidays.AddRange
					(
						new Holidays 
						{
							Вид_отпуска = "Ежеполугодный (основной) оплачиваемый отпуск",
							Табельный_номер = 2,
							Дата_отпуска = new System.DateTime(2020,06,12),
							Колл_дней_отпуска = 14,
							Дата_окончания_отпуска = new System.DateTime(2020, 06, 26),
							Основание = "Плановый отпуск"
						},
						new Holidays
						{
							Вид_отпуска = "Ежеполугодный (основной) оплачиваемый отпуск",
							Табельный_номер = 2,
							Дата_отпуска = new System.DateTime(2020, 12, 12),
							Колл_дней_отпуска = 14,
							Дата_окончания_отпуска = new System.DateTime(2020, 12, 26),
							Основание = "Плановый отпуск"
						}
					);
					context.PassportDataOfEmployees.AddRange
					(
						new PassportDataOfEmployees 
						{
							Табельный_номер = 1,
							Серия_паспорта = 219213,
							Номер = 087765,
							Кем_выдан = "ОУФМС г.Первоуральска",
							Когда_выдан = new System.DateTime(2019, 08, 19)
						},
						new PassportDataOfEmployees
						{
							Табельный_номер = 2,
							Серия_паспорта = 123456,
							Номер = 458854,
							Кем_выдан = "ГУ МВД России по Ставпропольскому краю ",
							Когда_выдан = new System.DateTime(2019, 08, 19)
						}
					);
					context.InformationAboutBusiness.AddRange
					(
						new InformationAboutBusiness
						{
							Табельный_номер = 2,
							Куда_командирован = "Филиал Стил-Софт в Ереване",
							Номер_Приказа = 21234,
							С_даты = new System.DateTime(2019, 04, 02),
							По_дату = new System.DateTime(2019, 05, 29),
							Колличество_дней = 27,
							Цель_командировки = "Научиться играть в нарды"
						}
					);
					context.InformationAboutInformation.AddRange
					(
						new InformationAboutInformation 
						{
							Сведени_о_повышении_квалификации = "Изменение должности на программист",
							Вид_повышения = "Долгосрочное",
							Наименование_учреждения = "Стил-Софт",
							Табельный_номер = 2,
							Дата_повышения = new System.DateTime(2019, 06, 01)
						},
						new InformationAboutInformation
						{
							Сведени_о_повышении_квалификации = "Изменение должности на старший-программист",
							Вид_повышения = "Долгосрочное",
							Наименование_учреждения = "Стил-Софт",
							Табельный_номер = 2,
							Дата_повышения = new System.DateTime(2020, 08, 12)
						}
					);
					context.InformationAboutIncentives.AddRange
					(
						new InformationAboutIncentives
						{
							Табельный_номер = 2,
							Мотив_поощрения = "Премия",
							Дата = new System.DateTime(2020, 09, 22),
							Номер_документа = 231,
							Обоснование = "Обыграл начальника отдела в нарды",
							Сумма = 15000
						}
					);
					context.InformationAboutProfessional.AddRange
					(
						new InformationAboutProfessional
						{
							Название_профессии = "Начальник отдела",
							Классификация_професии = "Профессия, связана с управлением персонала"
						},
						new InformationAboutProfessional
						{
							Название_профессии = "Старший программист",
							Классификация_професии = "Профессия, связанная с применением автоматизированных и автоматических систем"
						},
						new InformationAboutProfessional
						{
							Название_профессии = "Программист",
							Классификация_професии = "Профессия, связанная с применением автоматизированных и автоматических систем"
						},
						new InformationAboutProfessional
						{
							Название_профессии = "Программист-стажер",
							Классификация_професии = "Профессия, связанная с применением автоматизированных и автоматических систем"
						}
					);
					context.SocialBenefits.AddRange
					(
						new SocialBenefits 
						{
							Табельный_номер = 1,
							Наименование_льгот = "Инвалид третьей категории",
							Номер_документа = 568489,
							Дата_выдачи_документа = new System.DateTime(2007, 05, 25),
						}
					);
					context.Layoffs.AddRange
					(
						new Layoffs 
						{
							Табельный_номер = 1,
							Дата_увольнения = new System.DateTime(2020, 12, 01),
							Статья = "231",
							Причина_увольнения = "Проиграл в нарды",
						}
					);
					context.SaveChanges();
				}
			}
			
		}
	}
}