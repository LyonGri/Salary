using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using BusinessLogic;


namespace CUI
{
	internal class Program
	{
		/// <summary>
		/// Метод для проверки ввода персоны
		/// </summary>
		/// <param name="outputMessage">Строка для вывода в консоль</param>
		/// <param name="validationAction">Делегат с заданием параметра</param>
		private static void ValidateInput(string outputMessage, Action validationAction)
		{
			while (true)
			{
				try
				{
					Console.Write(outputMessage);
					validationAction();
					return;
				}
				catch (Exception exception)
				{
					Console.WriteLine($"{exception.Message} Попробуйте снова.");
				}
			}
		}
		/// <summary>
		/// Метод для ввода с клавиатуры
		/// </summary>
		/// <returns>з/п</returns>
		private static Worker InputSelection()
		{
			var worker = new Worker();
			var validationWorkerActions = new List<Tuple<string, Action>>()
			{
				new Tuple<string, Action>
				(
					"Имя: ",
					() =>
					{
						worker.Name = Console.ReadLine();
					}
				),
				new Tuple<string, Action>
				(
					"Фамилия: ",
					() =>
					{
						worker.Surname = Console.ReadLine();
					}
				),
				new Tuple<string, Action>
				(
					"Тип зарплаты\n" +
					"\t1 - Почасовая\n" +
					"\t2 - Оклад\n" +
					"\t3 - Ставка\n" +
					"Введите 1, 2 или 3: ",
					() =>
					{
						switch (Console.ReadLine())
						{
							case "1":
							{
								worker.TypeOfSalary = TypeOfSalary.HourlyPayment;
								break;
							}
							case "2":
							{
								worker.TypeOfSalary = TypeOfSalary.TariffPayment;
								break;
							}
							case "3":
							{
								worker.TypeOfSalary = TypeOfSalary.RatePayment;
								break;
							}
							default:
							{
								throw new ArgumentException("Вам нужно выбрать 1, 2 или 3");
							}
						}
					}
				),
			};

			ActionForEach(validationWorkerActions);
			


			switch (worker.TypeOfSalary)
			{
				case TypeOfSalary.HourlyPayment:
				{
					var salary = new HourlyPayment();
					var validationHourlyPaymentActions = new List<Tuple<string, Action>>()
					{
						new Tuple<string, Action>
						(
							"Количество отработанных часов: ",
							() =>
							{
								salary.HoursWorked = Int32.Parse(Console.ReadLine());
							}
						),
						new Tuple<string, Action>
						(
							"Стоимость одного часа работы: ",
							() =>
							{
								//так еще будет проверка на null
								//salary.CostPerHour = Convert.ToDecimal(Console.ReadLine());
								salary.CostPerHour = Decimal.Parse(ConvertDecimalSeparator(Console.ReadLine()));
							}
						)
					};
					ActionForEach(validationHourlyPaymentActions);
					worker.Salary = salary.Salary;
					break;
				}
				case TypeOfSalary.RatePayment:
				{
					var salary = new RatePayment();
					var validationHourlyPaymentActions = new List<Tuple<string, Action>>()
					{
						new Tuple<string, Action>
						(
							"Количество отработанных дней: ",
							() =>
							{
								salary.DaysWorked = Int32.Parse(Console.ReadLine());
							}
						),
						new Tuple<string, Action>
						(
							"Стоимость одного дня работы: ",
							() =>
							{
								salary.CostPerDay = Decimal.Parse(ConvertDecimalSeparator(Console.ReadLine()));
							}
						)
					};
					ActionForEach(validationHourlyPaymentActions);
					worker.Salary = salary.Salary;
					break;
				}
				case TypeOfSalary.TariffPayment:
				{
					var salary = new TariffPayment();
					var validationTariffPaymentActions = new List<Tuple<string, Action>>()
					{
						new Tuple<string, Action>
						(
							"Оклад: ",
							() =>
							{
								salary.Tariff = Decimal.Parse(ConvertDecimalSeparator(Console.ReadLine()));
							}
						),
						new Tuple<string, Action>
						(
							"Введите номер месяца: ",
							() =>
							{
								salary.WorkingDaysInMonth = GetBusinessDays(CheckMounthInput(Console.ReadLine()));
								Console.WriteLine($"Количество рабочих дней: {salary.WorkingDaysInMonth}");
								//вывести сколько дней получилось

							}
						),
						new Tuple<string, Action>
						(
							"Количество отработанных дней (не больше чем рабочих): ",
							() =>
							{
								salary.DaysWorked = Int32.Parse(Console.ReadLine());
							}
						),
					};
					ActionForEach(validationTariffPaymentActions);
					worker.Salary = salary.Salary;
					break;
				}
			}

			
			return worker;
		}

		/// <summary>
		/// Метод для выполнения всех записей в листе с делегатами
		/// </summary>
		private static void ActionForEach(List<Tuple<string, Action>> validationActions)
		{
			foreach (var actionItem in validationActions)
			{
				ValidateInput(actionItem.Item1, actionItem.Item2);
			}
		}

		/// <summary>
		/// Метод для проверки ввода
		/// </summary>
		/// <param name="inputValue">Строка для которой нужно преобразование</param>
		/// <returns>Строка с зяпятыми вместо точек</returns>
		private static string ConvertDecimalSeparator(string inputValue)
		{
			const string symbolPattern = @"[^,.0-9]";
			const string commaPattern = @",";
			Regex symbolRegex = new Regex(symbolPattern);
			Regex commaRegex = new Regex(commaPattern);
			if (symbolRegex.IsMatch(inputValue.ToString()) ||
				commaRegex.Matches(inputValue).Count > 1)
			{
				throw new ArgumentException("Неверный формат данных! " +
					"В данном поле можно использовать только десятичные дроби " +
					"с запятой в качестве разделителя!");
			}
			return inputValue.Replace(".", ",");
		}

		/// <summary>
		/// Метод для проверки ввода месяцев
		/// </summary>
		/// <param name="inputValue">Строка для проверки</param>
		/// <returns>Номер месяца</returns>
		private static int CheckMounthInput(string inputValue)
		{
			const string symbolPattern = @"[^0-9]";
			Regex symbolRegex = new Regex(symbolPattern);
			if (symbolRegex.IsMatch(inputValue.ToString()))
			{
				throw new ArgumentException("Неверный формат данных! " +
					"В данном поле можно использовать только целые числа!");
			}
			Convert.ToInt32(inputValue);
			if (Convert.ToInt32(inputValue) < 1 || Convert.ToInt32(inputValue) > 12)
            {
				throw new ArgumentException("В году 12 месяцев! " +
					"Введите номер месяца от 1 до 12!");
			}
			return Convert.ToInt32(inputValue);
		}

		/// <summary>
		/// Метод для переключения между вводом работников и выводом содержимого
		/// </summary>
		/// <returns></returns>
		private static bool WhatToDoNext ()
		{
			Console.WriteLine("\nНажмите" +
				"\tEnter - для продолжения ввода работников\n" +
				"\tF - для вывода списка зарплаты работникам");
			var input = Console.ReadKey();
			switch (input.Key) //Switch on Key enum
			{
				case ConsoleKey.Enter:
					return true;
				case ConsoleKey.F:
					return false;
				default:
					Console.WriteLine(" - НЕ КОРРЕКТНЫЙ ВВОД!");
					return WhatToDoNext();
			}
		}


		/// <summary>
		/// Расчет числа рабочих дней
		/// </summary>
		/// <param name="mounth">Номер месяца</param>
		/// <returns>Количество рабочих дней в месяце</returns>
		public static int GetBusinessDays(int mounth)
		{
			//расчет без учета праздников

			DateTime startDay = new DateTime(2021, mounth, 1);
			DateTime endDay = startDay.AddMonths(1).AddDays(-1);

			double calcBusinessDays =
				1 + ((endDay - startDay).TotalDays * 5 -
				(startDay.DayOfWeek - endDay.DayOfWeek) * 2) / 7;

			if (endDay.DayOfWeek == DayOfWeek.Saturday)
			{
				calcBusinessDays--;
			}
			if (startDay.DayOfWeek == DayOfWeek.Sunday)
			{
				calcBusinessDays--;
			}

			return Convert.ToInt32(calcBusinessDays);
		}


		/// <summary>
		/// Тело программы
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.Unicode;
			var keyInput = true;
			var workerList = new List<Worker>();
			while (keyInput)
			{
				Console.WriteLine("Введите данные о работнике на русском языке\n" +
					"В качестве десятичного разделителя используйте запятую");
				var worker = InputSelection();
				workerList.Add(worker);
				Console.WriteLine(string.Format(CultureInfo.CreateSpecificCulture("ru-RU"),
					$"\n{worker.Name} {worker.Surname} получит зарплату {worker.Salary:C2} " +
					$"с учетом НДФЛ\n"));
				keyInput = WhatToDoNext();
				Console.Clear();
			}
			foreach (var worker in workerList)
			{
				Console.WriteLine(worker.Info);
				Console.WriteLine();
			}
			Console.WriteLine("\nНажмите любую клавишу, чтобы завершить работу программы...");
			Console.ReadKey();
		}
	}
}
