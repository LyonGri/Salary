using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public abstract class ValidatingNumbers
	{




		private decimal _decimalNumber;
		public decimal decimalNumber
		{
			get => _decimalNumber;
			set
			{
				_decimalNumber = value;
			}
		}

		/// <summary>
		/// Метод для проверки возраста
		/// </summary>
		/// <param name="value">Проверяемый возраст</param>
		/// <param name="minimumValue">Минимальный возраст</param>
		/// <param name="maximumValue">Максимальный возраст</param>
		public static void ValidateDecimalNumber(decimal value)
		{
			const string pattern = @"[^,.][\D]";
			Regex regex = new Regex(pattern);
			if (regex.IsMatch(value.ToString()))
			{
				throw new ArgumentException("Неверный формат данных! " +
					"В данном поле можно использовать только десятичные дроби " +
					"с запятой в качестве разделителя!");
			}

			if ((value > 5))
			{
				throw new ArgumentException("купи слона!");
			}
		}



	}
}
