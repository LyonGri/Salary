using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// Тип зарплаты
/// </summary>
public enum TypeOfSalary
{
	//почасовая
	HourlyPayment,
	//оклад
	TariffPayment,
	//ставка
	RatePayment
}

namespace BusinessLogic
{
	/// <summary>
	/// Класс описывает некоего работника
	/// </summary>
	public class Worker 
	{
		private string _name;

		public string Name
		{
			get => _name;
			set
			{
				_name = ValidateName(value);
			}
		}

		private string _surname;

		public string Surname
		{
			get => _surname;
			set
			{
				_surname = ValidateName(value);
			}
		}


		private decimal _salary;


		public decimal Salary
		{
			get => _salary;
			set
			{
				_salary = value;
			}
		}




		private TypeOfSalary _typeOfSalary = TypeOfSalary.HourlyPayment;


		public TypeOfSalary TypeOfSalary
		{
			get => _typeOfSalary;
			set
			{
				_typeOfSalary = value;
			}
		}



		public Worker(string name, string surname, int salary, TypeOfSalary typeOfSalary)
        {
			Name = name;
			Surname = surname;
			Salary = salary;
			TypeOfSalary = typeOfSalary;
        }

		/// <summary>
		/// Конструктор со значениями по умолчанию 
		/// </summary>
		public Worker() : this ("Ибрагим", "Кузнецов", 0, TypeOfSalary.HourlyPayment) {}



		private static string ValidateName(string expression)
		{
			if (expression == "" || expression == null)
			{
				throw new ArgumentException("Это поле не должно быть пустым!");
			}
			const string letterPattern = @"[^а-я^ё^А-Я^Ё^-]";
			const string hyphenPattern = @"-";
			Regex letterRegex = new Regex(letterPattern);
			Regex hyphenRegex = new Regex(hyphenPattern);
			if (letterRegex.IsMatch(expression.ToLower()) ||
				hyphenRegex.Matches(expression.ToLower()).Count > 1)
			{
				throw new ArgumentException("Поле заполнено некорректно.");
			}
			return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(expression.ToLower());
		}

		

		//фуфло какое-то
		//private int ReceivedSalary ()
		//{
		//	switch (TypeOfSalary)
		//	{
		//		case TypeOfSalary.HourlyPayment:
		//		//case TypeOfSalary.TariffPayment:
		//		//case TypeOfSalary.RatePayment:
		//		{
		//			return HourlyPayment.Calculate();
		//		}
		//		default:
		//		{
		//			throw new ArgumentException("Недопустимый тип з/п");
		//		};
		//	}

		//}
	}
}
