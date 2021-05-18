using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
	/// <summary>
	/// Каласс для почасовой оплаты
	/// </summary>
	public class HourlyPayment : INachislator
	{
		private int _hoursWorked;

		/// <summary>
		/// Отработанные часы
		/// </summary>
		public int HoursWorked
		{
			get => _hoursWorked;
			set
			{
				ValidatingNumbers.ValidateIntNumber(value);
				_hoursWorked = value;
			}
		}

		private decimal _costPerHour;

		/// <summary>
		/// Стоимость часа
		/// </summary>
		public decimal CostPerHour
		{
			get => _costPerHour;
			set
			{
				ValidatingNumbers.ValidateDecimalNumber(value);
				_costPerHour = value;
			}
		}

		/// <summary>
		/// Зарплата 
		/// </summary>
		public decimal Salary
		{
			get => HoursWorked * CostPerHour * 0.87m;
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="hoursWorked">Количество отработанных часов</param>
		/// <param name="costPerHour">Стоимость одного часа работы</param>
		public HourlyPayment(int hoursWorked, decimal costPerHour)
		{
			HoursWorked = hoursWorked;
			CostPerHour = costPerHour;
		}

		/// <summary>
		/// Конструктор со значениями по умолчанию
		/// </summary>
		public HourlyPayment() : this(1, 1) { }

	}
}
