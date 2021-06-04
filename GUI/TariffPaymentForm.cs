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
	/// Форма оплаты по окладу
	/// </summary>
	public partial class TariffPaymentForm : PaymentFormBase
	{
		/// <summary>
		/// Конструктор формы
		/// </summary>
		public TariffPaymentForm()
		{
			InitializeComponent();
			#if !DEBUG
			{
				RandomMounthButton.Visible = false;
				RandomDaysButton.Visible = false;
				RandomCostButton.Visible = false;
				AllRandomButton.Visible = false;
			}
			#endif

			AllRandomButton.Click += RandomMounthButton_Click;
			AllRandomButton.Click += RandomDaysButton_Click;
			AllRandomButton.Click += RandomCostButton_Click;
			
			WorkedDaysBox.TextChanged += ButtonEnabler_TextChanged;
			CostBox.TextChanged += ButtonEnabler_TextChanged;
			ButtonNext.Enabled = false;
			WorkedDaysBox.Enabled = false;
		}

		/// <summary>
		/// Кнопка продолжить
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonNext_Click(object sender, EventArgs e)
		{
            var salary = new TariffPayment
            {
                WorkingDaysInMonth = Int32.Parse(WorkingDaysBox.Text),
                DaysWorked = Int32.Parse(WorkedDaysBox.Text),
                Tariff = Decimal.Parse(CostBox.Text)
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
			WorkedDaysBox.Text = Randomizer.GetRandomIntInRange(10,
				Int32.Parse(WorkingDaysBox.Text)).ToString();
		}

		/// <summary>
		/// Рандом стоимости
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomCostButton_Click(object sender, EventArgs e)
		{
			CostBox.Text = Randomizer.GetRandomDecimalInRange(20000, 100000).ToString();
		}

		/// <summary>
		/// Расчет числа рабочих дней
		/// </summary>
		/// <param name="mounth">Номер месяца</param>
		/// <returns>Количество рабочих дней в месяце</returns>
		private static int GetBusinessDays(int mounth)
		{
			//расчет без учета праздников
			DateTime startDay = new DateTime(2021, mounth+1, 1);
			DateTime endDay = startDay.AddMonths(1).AddDays(-1);

			double calcBusinessDays =
				1 + ((endDay - startDay).TotalDays * 5 -
				(startDay.DayOfWeek - endDay.DayOfWeek) * 2) / 7;

			if (endDay.DayOfWeek == DayOfWeek.Saturday)
			{
				calcBusinessDays--;
			}
			if (startDay.DayOfWeek == DayOfWeek.Sunday)
			{
				calcBusinessDays--;
			}

			return Convert.ToInt32(calcBusinessDays);
		}

		/// <summary>
		/// Обработка события изменения выбора месяца
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonthBox_SelectedValueChanged(object sender, EventArgs e)
		{
			WorkingDaysBox.Text = GetBusinessDays(MonthBox.SelectedIndex).ToString();
		}

		/// <summary>
		/// Обработка изменения числа отработанных дней
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void WorkedDaysBox_TextChanged(object sender, EventArgs e)
		{
			if (WorkedDaysBox.Text == "" || Int32.Parse(WorkedDaysBox.Text) < 0)
			{
				WorkedDaysBox.Text = "0";
			}
			if (Int32.Parse(WorkedDaysBox.Text) > Int32.Parse(WorkingDaysBox.Text))
			{
				WorkedDaysBox.Text = WorkingDaysBox.Text;
			}
		}

		/// <summary>
		/// Делает кнопку не активной, пока не заполнены все поля
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonEnabler_TextChanged(object sender, EventArgs e)
		{
			ButtonNext.Enabled = WorkedDaysBox.Text.Length > 0
									&& CostBox.Text.Length > 0;
		}

		/// <summary>
		/// Обработчик выбора месяца
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MonthBox_SelectionChangeCommitted(object sender, EventArgs e)
		{
			WorkedDaysBox.Enabled = true;
			WorkedDaysBox.Text = "";
		}
		
		/// <summary>
		/// Загрузка формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TariffPaymentForm_Load(object sender, EventArgs e)
		{
			var tmpControls = groupBoxInformation.Controls.OfType<Button>().ToList();
			tmpControls.Add(AllRandomButton);
			ButtonLookImprovement.ButtonNiceLook(tmpControls);
		}

		/// <summary>
		/// Рандом месяца
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomMounthButton_Click(object sender, EventArgs e)
		{
			MonthBox.SelectedIndex = Randomizer.GetRandomIntInRange(0, MonthBox.Items.Count);
			WorkedDaysBox.Enabled = true;
		}
	}
}
