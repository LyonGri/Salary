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

		/// <summary>
		/// Имя
		/// </summary>
		public string Name
		{
			get => _name;
			set
			{
				_name = ValidateName(value);
			}
		}

		private string _surname;

		/// <summary>
		/// Фамилия
		/// </summary>
		public string Surname
		{
			get => _surname;
			set
			{
				_surname = ValidateName(value);
			}
		}

		private decimal _salary;

		/// <summary>
		/// Зарплата
		/// </summary>
		public decimal Salary
		{
			get => _salary;
			set
			{
				_salary = value;
			}
		}

		private TypeOfSalary _typeOfSalary;

		/// <summary>
		/// Тип начисляемой зарплаты
		/// </summary>
		public TypeOfSalary TypeOfSalary
		{
			get => _typeOfSalary;
			set
			{
				_typeOfSalary = value;
			}
		}

		/// <summary>
		/// Информация о работнике
		/// </summary>
		public string Info
		{
			get
			{
				return $"{Name} {Surname}\n" +
						$"Тип начисляемой зарплаты: {TypeOfSalaryRus(TypeOfSalary)}\n" +
						$"Зарплата после вычета НДФЛ: {Salary:C2}\n";
			}
		}

		/// <summary>
		/// Конструктор класса Worker
		/// </summary>
		/// <param name="name">Имя</param>
		/// <param name="surname">Фамилия</param>
		/// <param name="salary">Зарплата</param>
		/// <param name="typeOfSalary">Тип зарплаты</param>
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

		/// <summary>
		/// Проверка имени и фамилии
		/// </summary>
		/// <param name="expression">Проверяемое имя или фамилия</param>
		/// <returns></returns>
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

		/// <summary>
		/// Руссификация типа начисляемой зарплаты
		/// </summary>
		/// <param name="typeOfSalary">Тип зарплаты</param>
		/// <returns>Руссифицированная з/п</returns>
		private static string TypeOfSalaryRus(TypeOfSalary typeOfSalary)
		{
			switch (typeOfSalary)
			{
				case TypeOfSalary.HourlyPayment:
				{
					return "Почасовая оплата";
				}
				case TypeOfSalary.TariffPayment:
				{
					return "Оплата по окладу";
				}
				case TypeOfSalary.RatePayment:
				{
					return "Оплата по ставке";
				}
			}
			return "Донат";
		}

	}
}
