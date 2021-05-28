using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	/// <summary>
	/// Генератор случайностей
	/// </summary>
	public static class Randomizer
	{
		private static Random _random = new Random(DateTime.Now.Second);

		private static List<string> _rusNames = new List<string>()
		{
			"Алексей",
			"Роман",
			"Виктор",
			"Тимофей",
			"Максим",
			"Дмитрий",
			"Юрий",
			"Кирилл",
			"Артём",
			"Иван",
			"Мария",
			"Карина",
			"Юлия",
			"Яна",
			"Арина",
			"Марина",
			"Дарья",
			"Кира",
			"Евгения",
			"Надежда"
		};

		private static List<string> _rusSurnames = new List<string>()
		{
			"Лис",
			"Миллер",
			"Смитт",
			"Этвуд",
			"Блэк",
			"Форд",
			"Король",
			"Вагнер",
			"Киш",
			"Кремер"
		};

		
		/// <summary>
		/// Сгенерировать имя
		/// </summary>
		/// <returns>Имя</returns>
		public static string GetRandomName()
		{
			return _rusNames[_random.Next(0, _rusNames.Count)];
		}

		/// <summary>
		/// Сгенерировать фамилию
		/// </summary>
		/// <returns>Фамилия</returns>
		public static string GetRandomSurname()
		{
			return _rusSurnames[_random.Next(0, _rusSurnames.Count)];
		}

		/// <summary>
		/// Сгенерировать десятичное число в заданом диапазоне
		/// </summary>
		/// <param name="minimumValue">Минимальное значение</param>
		/// <param name="maximumValue">Максимальное значение</param>
		/// <returns>Десятичное число</returns>
		public static decimal GetRandomDecimalInRange(int minimumValue, int maximumValue)
		{
			return Convert.ToDecimal( _random.Next(minimumValue*100, maximumValue*100) * 0.01m);
		}

		/// <summary>
		/// Сгенерировать целое число в заданом диапазоне
		/// </summary>
		/// <param name="minimumValue">Минимальное значение</param>
		/// <param name="maximumValue">Максимальное значение</param>
		/// <returns>Целое число</returns>
		public static int GetRandomIntInRange(int minimumValue, int maximumValue)
		{
			return _random.Next(minimumValue, maximumValue);
		}
	}
}
