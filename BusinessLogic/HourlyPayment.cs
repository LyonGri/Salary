using System;

namespace BusinessLogic
{
    /// <summary>
    /// Каласс для почасовой оплаты
    /// </summary>
    public class HourlyPayment : INachislator
    {
        //public HourlyPayment (int hoursWorked, int costPerHour)
        //{
        //    HoursWorked =  hoursWorked;
        //    CostPerHour = costPerHour;
        //}

        //есть 2 варианта:
        //1. как сейчас реализовано
        //2. сделать поля (закомментированы) и как свойство определять Selary
        //но тогда не будет методов
        //и придется создавать экземпляр HourlyPayment

        
        //private int _salary;
        public int Salary
        {
            get => HoursWorked * CostPerHour;
        }


        public int HoursWorked { get; set; }


        public int CostPerHour { get; set; }

        public static int Calculate (int hoursWorked, int costPerHour)
        {
            return hoursWorked * costPerHour;
            //return $"Начилено {Salary} руб.";
        }


    }
}
