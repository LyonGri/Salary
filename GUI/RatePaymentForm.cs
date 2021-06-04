using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	/// <summary>
	/// Форма оплаты по ставке
	/// </summary>
	public partial class RatePaymentForm : PaymentFormBase
	{ 
        /// <summary>
		/// Конструктор формы
		/// </summary>
		public RatePaymentForm()
		{
			InitializeComponent();
			#if !DEBUG
			{
				RandomHoursButton.Visible = false;
				RandomCostButton.Visible = false;
				AllRandomButton.Visible = false;
			}
			#endif

			AllRandomButton.Click += RandomDaysButton_Click;
			AllRandomButton.Click += RandomCostButton_Click;

			ButtonNext.Enabled = false;
			DaysBox.TextChanged += ButtonEnabler_TextChanged;
			CostBox.TextChanged += ButtonEnabler_TextChanged;
		}

		/// <summary>
		/// Кнопка продолжить
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonNext_Click(object sender, EventArgs e)
		{
			var salary = new RatePayment
			{
				DaysWorked = Int32.Parse(DaysBox.Text), 
				CostPerDay = Decimal.Parse(CostBox.Text)
			};
            OnSendDataFromFormEvent(new NachislatorEventArgs(salary));
            Close();
		}
		
		/// <summary>
		/// Рандом дней
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomDaysButton_Click(object sender, EventArgs e)
		{
			DaysBox.Text = Randomizer.GetRandomIntInRange(10, 50).ToString();
		}

		/// <summary>
		/// Рандом стоимости
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomCostButton_Click(object sender, EventArgs e)
		{
			CostBox.Text = Randomizer.GetRandomDecimalInRange(1000, 2000).ToString();
		}

		 //TODO: RSDN +

		/// <summary>
		/// Загрузка формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HourlyPaymentForm_Load(object sender, EventArgs e)
		{
			var tmpControls = groupBoxInformation.Controls.OfType<Button>().ToList();
			tmpControls.Add(AllRandomButton);
			ButtonLookImprovement.ButtonNiceLook(tmpControls);
		}

		/// <summary>
		/// Делает кнопку активной, когда заполнены все поля
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonEnabler_TextChanged(object sender, EventArgs e)
		{
			ButtonNext.Enabled = DaysBox.Text.Length > 0
				&& CostBox.Text.Length > 0;
        }
	}
}
