using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    /// <summary>
    /// Используется как аргумент для передачи данных в событиях
    /// </summary>
    public class UserEventArgs : EventArgs
    {
        /// <summary>
        /// Worker для передачи
        /// </summary>
        public readonly Worker SendingWorker;

        /// <summary>
        /// Salary для передачи
        /// </summary>
        public readonly INachislator SendingSalary;

        /// <summary>
        /// Конструктор для передачи Worker
        /// </summary>
        /// <param name="sendingWorker">Worker</param>
        public UserEventArgs(Worker sendingWorker)
        {
            SendingWorker = sendingWorker;
        }

        /// <summary>
        /// Конструктор для передачи Salary
        /// </summary>
        /// <param name="sendingSalary">Salary</param>
        public UserEventArgs(INachislator sendingSalary)
        {
            SendingSalary = sendingSalary;
        }
    }
}
