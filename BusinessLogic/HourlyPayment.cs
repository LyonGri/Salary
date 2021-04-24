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
       

        //есть 2 варианта:
        //1. как сейчас реализовано
        //2. сделать поля (закомментированы) и как свойство определять Selary
        //но тогда не будет методов
        //и придется создавать экземпляр HourlyPayment




                /// <summary>
                /// Отработанные часы
                /// </summary>
        public int HoursWorked { get; set; }




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


        //private int _salary;
        public decimal Salary
        {
            get => HoursWorked * CostPerHour;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="hoursWorked">Количество отработанных часов</param>
        /// <param name="costPerHour">Стоимость одного часа работы</param>
        public HourlyPayment(int hoursWorked, int costPerHour)
        {
            HoursWorked = hoursWorked;
            CostPerHour = costPerHour;
        }

        /// <summary>
        /// Конструктор со значениями по умолчанию
        /// </summary>
        public HourlyPayment() : this(0, 0) { }


        //public int Calculate (int hoursWorked, int costPerHour)
        //{
        //    return hoursWorked * costPerHour;
        //    //return $"Начилено {Salary} руб.";
        //}


        /// <summary>
        /// Метод для проверки возраста
        /// </summary>
        /// <param name="value">Проверяемый возраст</param>
        /// <param name="minimumValue">Минимальный возраст</param>
        /// <param name="maximumValue">Максимальный возраст</param>
        protected static void ValidateAge(byte value, byte minimumValue, byte maximumValue)
        {
            const string pattern = @"\D";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(value.ToString()))
            {
                throw new ArgumentException("Возраст должен быть числом!");
            }

            if ((value > maximumValue) || (value < minimumValue))
            {
                throw new ArgumentException("Возраст должен быть больше или равен " +
                    $"{minimumValue} и меньше либо равен {maximumValue}!");
            }
        }

    }
}
