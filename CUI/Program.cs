using System;
using BusinessLogic;


namespace CUI
{
    internal class Program
    {
        public static int ReceivedSalary(Worker worker)
        {
            switch (worker.TypeOfSalary)
            {
                case TypeOfSalary.HourlyPayment:
                    //case TypeOfSalary.TariffPayment:
                    //case TypeOfSalary.RatePayment:
                    {
                        return HourlyPayment.Calculate(
                            Int32.Parse(Console.ReadLine()),
                            Int32.Parse(Console.ReadLine()));
                    }

                default:
                    {
                        throw new ArgumentException("Недопустимый тип з/п");
                    }
            };
        }

        static void Main(string[] args)
        {
            var nikolay = new Worker();
            nikolay.Salary = ReceivedSalary(nikolay);

            Console.WriteLine($"У Коляна зарплата {nikolay.Salary} руб.");
        }
    }
}
