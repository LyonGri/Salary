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
    public class WorkerEventArgs : EventArgs
    {
        private Worker _sendingWorker;

        /// <summary>
        /// Worker для передачи
        /// </summary>
        public Worker SendingWorker
        {
            get => _sendingWorker;
            private set
            {
                _sendingWorker = value;
            }
        }

        /// <summary>
        /// Конструктор для передачи Worker
        /// </summary>
        /// <param name="sendingWorker">Worker</param>
        public WorkerEventArgs(Worker sendingWorker)
        {
            SendingWorker = sendingWorker;
        }
    }
}
