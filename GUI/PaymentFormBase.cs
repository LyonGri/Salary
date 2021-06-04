using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	/// <summary>
	/// Базовый класс для форм начисления з/п
	/// </summary>
    public abstract class PaymentFormBase : Form
    {
        /// <summary>
        /// Событие для передачи данных
        /// </summary>
        public event EventHandler<NachislatorEventArgs> SendDataFromFormEvent;

		/// <summary>
		/// Конструктор формы
		/// </summary>
		public PaymentFormBase()
		{
			FormBorderStyle = FormBorderStyle.FixedDialog;
			ControlBox = false;
			MaximizeBox = false;
		}

		/// <summary>
		/// Проверка ввода часов
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void IntegerBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			const string letterPattern = @"[^0-9]";
			Regex letterRegex = new Regex(letterPattern); 
            if (letterRegex.IsMatch(e.KeyChar.ToString())
                && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

		/// <summary>
		/// Проверка ввода стоимости
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void CostBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			const string mainPattern = @"[^,0-9]";
			const string commaPattern = @",";
			const string afterCommaPattern = @"\,\d\d+";
			Regex mainRegex = new Regex(mainPattern);
			Regex commaRegex = new Regex(commaPattern);
			Regex afterCommaRegex = new Regex(afterCommaPattern);

			var tmpTextBoxText = ((TextBoxBase)sender).Text;
			if (commaRegex.Matches(tmpTextBoxText).Count < 1)
			{
                if (mainRegex.IsMatch(e.KeyChar.ToString())
                    && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
			else
			{
                if ((mainRegex.IsMatch(e.KeyChar.ToString())
                    || commaRegex.IsMatch(e.KeyChar.ToString())
                    || afterCommaRegex.IsMatch(tmpTextBoxText))
                    && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
		}

		/// <summary>
		/// Метод для передачи события
		/// </summary>
		/// <param name="e"></param>
		protected void OnSendDataFromFormEvent(NachislatorEventArgs e)
        {
            SendDataFromFormEvent?.Invoke(this, e);
        }
    }
}
