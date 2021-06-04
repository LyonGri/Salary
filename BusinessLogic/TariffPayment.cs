using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	/// <summary>
	/// 
	/// </summary>
	public class TariffPayment : INachislator
	{
		private int _daysWorked;

		/// <summary>
		/// Отработанные дни
		/// </summary>
		public int DaysWorked
		{
			get => _daysWorked;
			set
			{
				ValidateDaysWorked(value, WorkingDaysInMonth);
				_daysWorked = value;
			}
		}

		private decimal _tariff;

		/// <summary>
		/// Оклад
		/// </summary>
		public decimal Tariff
		{
			get => _tariff;
			set
			{
				ValidatingNumbers.ValidateDecimalNumber(value);
				_tariff = value;
			}
		}

		private int _workingDaysInMonth;

		/// <summary>
		/// Количество рабочих дней в месяце
		/// </summary>
		public int WorkingDaysInMonth
		{
			get => _workingDaysInMonth;
			set
			{
				ValidatingNumbers.ValidateIntNumber(value);
				_workingDaysInMonth = value;
			}
		}

		/// <summary>
		/// Зарплата 
		/// </summary>
		public decimal Salary => DaysWorked * Tariff / WorkingDaysInMonth  * 0.87m;

        /// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="tariff">Тарифная ставка</param>
		/// <param name="workingDaysInMonth">Количество рабочих дней в месяце</param>
		/// <param name="daysWorked">Отработано дней</param>
		public TariffPayment(decimal tariff, int workingDaysInMonth,int daysWorked)
		{
			Tariff = tariff;
			WorkingDaysInMonth = workingDaysInMonth;
			DaysWorked = daysWorked;
		}

		/// <summary>
		/// Конструктор со значениями по умолчанию
		/// </summary>
		public TariffPayment() : this(1, 1, 1) { }
		
		/// <summary>
		/// Проверка ввода количества дней
		/// </summary>
		/// <param name="daysWorked">Отработанные дни</param>
		/// <param name="workingDaysInMonth">Рабочие дни месяца</param>
		private static void ValidateDaysWorked(int daysWorked, int workingDaysInMonth)
		{
			ValidatingNumbers.ValidateIntNumber(daysWorked);
			if (daysWorked > workingDaysInMonth)
			{
				throw new ArgumentException($"Значение не может быть меньше количества " +
					$"рабочих дней в месяце ({workingDaysInMonth})!");
			}
		}
	}
}
