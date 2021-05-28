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
	/// Форма добаления работника
	/// </summary>
	public partial class AddWorkerForm : Form
	{
		/// <summary>
		/// Событие для передачи данных
		/// </summary>
		public event EventHandler<WorkerEventArgs> SendDataFromFormEvent;

		/// <summary>
		/// Почасовая оплата
		/// </summary>
		private const string _hourlyPaymentItem = "Почасовая";

		/// <summary>
		/// Оклад
		/// </summary>
		private const string _tariffPaymentItem = "Оклад";

		/// <summary>
		/// Ставка
		/// </summary>
		private const string _ratePaymenttItem = "Ставка";

		/// <summary>
		/// Работник
		/// </summary>
		private readonly Worker _worker = new Worker();

		/// <summary>
		/// Конструктор формы
		/// </summary>
		public AddWorkerForm()
		{
			InitializeComponent();
			TypeOfSalaryBox.Items.Add(_hourlyPaymentItem);
			TypeOfSalaryBox.Items.Add(_tariffPaymentItem);
			TypeOfSalaryBox.Items.Add(_ratePaymenttItem);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;

			#if !DEBUG
			{ 
				RandomNameButton.Visible = false ;
				RandomSurnameButton.Visible = false ;
				RandomTypeOfSalaryButton.Visible = false ;
				AllRandomButton.Visible = false ;

			}
			#endif

			AllRandomButton.Click += RandomNameButton_Click;
			AllRandomButton.Click += RandomTypeOfSalaryButton_Click;
			AllRandomButton.Click += RandomSurnameButton_Click;

			NameBox.TextChanged += ButtonEnabler_TextChanged;
			SurnameBox.TextChanged += ButtonEnabler_TextChanged;
			TypeOfSalaryBox.SelectedIndexChanged += ButtonEnabler_TextChanged;
		}

		/// <summary>
		/// Кнопка для продолжения ввода
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonNext_Click(object sender, EventArgs e)
		{
			_worker.Name = NameBox.Text;
			_worker.Surname = SurnameBox.Text;

			switch (TypeOfSalaryBox.Text)
			{
				case _hourlyPaymentItem:
				{
					_worker.TypeOfSalary = TypeOfSalary.HourlyPayment;
					var paymentForm = new HourlyPaymentForm();
					paymentForm.SendDataFromFormEvent += AddWorkerSalaryEvent;
					paymentForm.ShowDialog();
					break;
				}
				case _tariffPaymentItem:
				{
					_worker.TypeOfSalary = TypeOfSalary.TariffPayment;
					var paymentForm = new TariffPaymentForm();
					paymentForm.SendDataFromFormEvent += AddWorkerSalaryEvent;
					paymentForm.ShowDialog();
					break;
				}
				case _ratePaymenttItem:
				{
					_worker.TypeOfSalary = TypeOfSalary.RatePayment;
					var paymentForm = new RatePaymentForm();
					paymentForm.SendDataFromFormEvent += AddWorkerSalaryEvent;
					paymentForm.ShowDialog();
					break;
				}
			}

            SendDataFromFormEvent?.Invoke(this, new WorkerEventArgs(_worker));

            Close();
		}

		/// <summary>
		/// Обработчик события получения данных из дочерней формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddWorkerSalaryEvent(object sender, NachislatorEventArgs e)
		{
			_worker.Salary = e.SendingSalary.Salary;
		}

		/// <summary>
		/// Кнопка рандома имени
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomNameButton_Click(object sender, EventArgs e)
		{
			NameBox.Text = Randomizer.GetRandomName();
		}

		/// <summary>
		/// Рандом типа зарплаты
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomTypeOfSalaryButton_Click(object sender, EventArgs e)
		{
			TypeOfSalaryBox.Text = TypeOfSalaryBox.
				Items[Randomizer.GetRandomIntInRange(0, TypeOfSalaryBox.Items.Count)].
				ToString();
		}

		/// <summary>
		/// Рандом фамилии
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RandomSurnameButton_Click(object sender, EventArgs e)
		{
			SurnameBox.Text = Randomizer.GetRandomSurname();
		}

		/// <summary>
		/// Обработчик ввода имени и фамилии
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			const string letterPattern = @"[^а-я^ё^А-Я^Ё^-]";
			const string hyphenPattern = @"-";
			Regex letterRegex = new Regex(letterPattern);
			Regex hyphenRegex = new Regex(hyphenPattern);
			if (hyphenRegex.Matches(NameBox.Text).Count < 1)
            {
                if (letterRegex.IsMatch(e.KeyChar.ToString()) 
                    && e.KeyChar != (char) Keys.Back)
                {
                    e.Handled = true;
                }
            }
			else
            {
                if ((letterRegex.IsMatch(e.KeyChar.ToString()) 
                     || hyphenRegex.IsMatch(e.KeyChar.ToString())) 
                    && e.KeyChar != (char) Keys.Back)
                {
                    e.Handled = true;
                }
            }
		}

		/// <summary>
		/// Загрузка формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddWorkerForm_Load(object sender, EventArgs e)
		{
			ButtonNext.Enabled = false;
			//TODO: Duplication
            var tmpControls = groupBoxInformation.Controls.OfType<Button>().ToList();
			tmpControls.Add(AllRandomButton);

			foreach (var button in tmpControls)
			{
				buttonNiceLook(button);
			}
		}

		//TODO: Duplication
		/// <summary>
		/// Наведение красоты у кнопок
		/// </summary>
		/// <param name="button"></param>
		private void buttonNiceLook (Button button)
		{
			button.FlatAppearance.BorderSize = 0;
			button.FlatStyle = FlatStyle.Flat;
		}


		/// <summary>
		/// Делает кнопку активной, когда заполнены все поля
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonEnabler_TextChanged(object sender, EventArgs e)
        {
            ButtonNext.Enabled = NameBox.Text.Length > 0
                                 && SurnameBox.Text.Length > 0
                                 && TypeOfSalaryBox.SelectedIndex >= 0;
		}
	}
}
