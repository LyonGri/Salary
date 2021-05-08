using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogic 
{
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

		public static Exception ExceptionGenerator(int lowerLimit)
        {
			throw new ArgumentException($"Значение не может быть меньше {lowerLimit}!");
		}
	}
}
