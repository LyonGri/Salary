using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	/// <summary>
	/// Класс оплаты по ставке
	/// </summary>
    public class RatePayment : INachislator
	{
		private int _daysWorked;

		/// <summary>
		/// Дни часы
		/// </summary>
		public int DaysWorked
		{
			get => _daysWorked;
			set
			{
				ValidatingNumbers.ValidateIntNumber(value);
				_daysWorked = value;
			}
		}

		private decimal _costPerDay;

		/// <summary>
		/// Стоимость дня
		/// </summary>
		public decimal CostPerDay
		{
			get => _costPerDay;
			set
			{
				ValidatingNumbers.ValidateDecimalNumber(value);
				_costPerDay = value;
			}
		}

		/// <summary>
		/// Зарплата 
		/// </summary>
		public decimal Salary
		{
			//TODO:
			get => DaysWorked * CostPerDay * 87 / 100;
		}

		//TODO: XML комментарии?
		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="hoursWorked">Количество отработанных дней</param>
		/// <param name="costPerHour">Стоимость одного дня работы</param>
		public RatePayment(int daysWorked, decimal costPerDay)
		{
			DaysWorked = daysWorked;
			CostPerDay = costPerDay;
		}

		/// <summary>
		/// Конструктор со значениями по умолчанию
		/// </summary>
		public RatePayment() : this(1, 1) { }
	}
}
