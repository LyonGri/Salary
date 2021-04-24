using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
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
		private static decimal InputSelection()
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


			return salary.Salary;
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
		/// Метод для преобразования точек в запятые
		/// </summary>
		/// <param name="inputValue">Строка для которой нужно преобразование</param>
		/// <returns>Строка с зяпятыми вместо точек</returns>
		private static string ConvertDecimalSeparator(string inputValue)
        {
			return inputValue.Replace(".", ",");
		}

		static void Main(string[] args)
		{
			var worker = new Worker();
			worker.Salary = InputSelection();
			Console.OutputEncoding = Encoding.Unicode;
			Console.WriteLine(string.Format(CultureInfo.CreateSpecificCulture("ru-RU"), 
				$"{worker.Name} {worker.Surname} получит зарплату {worker.Salary:C2}"));
		}
	}
}
