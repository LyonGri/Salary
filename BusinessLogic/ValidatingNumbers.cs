using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic 
{
	/// <summary>
	/// Класс для проверки числовых значений
	/// </summary>
	public static class ValidatingNumbers 
	{

		/// <summary>
		/// Метод для проверки десятичных чисел
		/// </summary>
		/// <param name="value"></param>
		public static void ValidateDecimalNumber(decimal value)
		{
			const int lowerLimit = 0;
			if (value < lowerLimit)
            {
				ExceptionGenerator(lowerLimit);
			}
		}

		/// <summary>
		/// Метод для проверки натуральных чисел
		/// </summary>
		/// <param name="value"></param>
		public static void ValidateIntNumber(int value)
		{
			const int lowerLimit = 1;
			if (value < lowerLimit)
			{
				ExceptionGenerator(lowerLimit);
			}
		}

		/// <summary>
		/// Исключения
		/// </summary>
		/// <param name="lowerLimit">передаваемый параметр для отображения в ошибке</param>
		/// <returns>Исключение</returns>
		private static Exception ExceptionGenerator(int lowerLimit)
        {
			throw new ArgumentException($"Значение не может быть меньше {lowerLimit}!");
		}
	}
}
