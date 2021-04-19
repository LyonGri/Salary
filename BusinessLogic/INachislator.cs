using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    /// <summary>
    /// Интерфейс начисления з/п
    /// </summary>
    public interface INachislator
    {
        public int Salary { get; }
        /// <summary>
        /// Начислить з/п
        /// </summary>
        public static int Calculate ()
        {
            return 0;
        }
    }
}
