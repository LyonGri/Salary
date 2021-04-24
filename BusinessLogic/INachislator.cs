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
        decimal Salary { get; }
        /// <summary>
        /// Начислить з/п
        /// </summary>
        //int Calculate();
    }
}
