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
	/// Форма почасовой оплаты
	/// </summary>
	public partial class HourlyPaymentForm : PaymentFormBase
	{
		/// <summary>
		/// Конструктор формы
		/// </summary>
		public HourlyPaymentForm() : base()
		{
			InitializeComponent();

			#if !DEBUG
			{
				RandomHoursButton.Visible = false;
				RandomCostButton.Visible = false;
				AllRandomButton.Visible = false;
			}
			#endif

			AllRandomButton.Click += RandomHoursButton_Click;
			AllRandomButton.Click += RandomCostButton_Click;

			ButtonNext.Enabled = false;
			HoursBox.TextChanged += ButtonEnabler_TextChanged;
			CostBox.TextChanged += ButtonEnabler_TextChanged;
		}

		/// <summary>
		/// Кнопка продолжить
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonNext_Click(object sender, EventArgs e)
		{
            var salary = new HourlyPayment
            {
                HoursWorked = Int32.Parse(HoursBox.Text), 
                CostPerHour = Decimal.Parse(CostBox.Text)
            };
			OnSendDataFromFormEvent(new NachislatorEventArgs(salary));
			Close();
		}

		/// <summary>
		/// Рандом часов
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomHoursButton_Click(object sender, EventArgs e)
		{
			HoursBox.Text = Randomizer.GetRandomIntInRange(100, 200).ToString();
		}

		/// <summary>
		/// Рандом стоимости
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomCostButton_Click(object sender, EventArgs e)
		{
			CostBox.Text = Randomizer.GetRandomDecimalInRange(100, 500).ToString();
		}

		//TODO: RSDN naming +
		//TODO: Duplication +

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
			ButtonNext.Enabled = HoursBox.Text.Length > 0
								&& CostBox.Text.Length > 0;
        }
	}
}
