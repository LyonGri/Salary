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
    public class NachislatorEventArgs : EventArgs
    {
        private INachislator _sendingSalary;

        /// <summary>
        /// INachislator для передачи
        /// </summary>
        public INachislator SendingSalary
        {
            get => _sendingSalary;
            private set
            {
                _sendingSalary = value;
            }
        }

        /// <summary>
        /// Конструктор для передачи Salary
        /// </summary>
        /// <param name="sendingSalary">Salary</param>
        public NachislatorEventArgs(INachislator sendingSalary)
        {
            SendingSalary = sendingSalary;
        }
    }
}
