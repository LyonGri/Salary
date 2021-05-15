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
	public partial class AddWorkerForm : Form
	{
		/// <summary>
		/// Событие для передачи данных
		/// </summary>
		public event EventHandler<UserEventArgs> SendDataFromFormEvent;

		private const string hourlyPaymentItem = "Почасовая";
		private const string tariffPaymentItem = "Оклад";
		private const string ratePaymenttItem = "Ставка";

		private Worker _worker = new Worker();

		/// <summary>
		/// Конструктор формы
		/// </summary>
		public AddWorkerForm()
		{
			InitializeComponent();
			TypeOfSalaryBox.Items.Add(hourlyPaymentItem);
			TypeOfSalaryBox.Items.Add(tariffPaymentItem);
			TypeOfSalaryBox.Items.Add(ratePaymenttItem);
			RandomNameButton.FlatAppearance.BorderSize = 0;
			RandomNameButton.FlatStyle = FlatStyle.Flat;
			RandomSurnameButton.FlatAppearance.BorderSize = 0;
			RandomSurnameButton.FlatStyle = FlatStyle.Flat;
			RandomTypeOfSalaryButton.FlatAppearance.BorderSize = 0;
			RandomTypeOfSalaryButton.FlatStyle = FlatStyle.Flat;

#if !DEBUG
			{ 
				RandomNameButton.Visible = false ;
				RandomSurnameButton.Visible = false ;
				RandomTypeOfSalaryButton.Visible = false ;
				AllRandomButton.Visible = false ;

			}
#endif

			AllRandomButton.Click += new EventHandler(RandomNameButton_Click);
			AllRandomButton.Click += new EventHandler(RandomTypeOfSalaryButton_Click);
			AllRandomButton.Click += new EventHandler(RandomSurnameButton_Click);
		}

		private void ButtonNext_Click(object sender, EventArgs e)
		{
			_worker.Name = NameBox.Text;
			_worker.Surname = SurnameBox.Text;

			//кривой момент, так как создается не нужная форма
			//var paymentForm = new Form();

			switch (TypeOfSalaryBox.Text)
			{
				case hourlyPaymentItem:
				{
					_worker.TypeOfSalary = TypeOfSalary.HourlyPayment;
					var paymentForm = new HourlyPaymentForm();
					paymentForm.SendDataFromFormEvent += new EventHandler<UserEventArgs>(AddWorkerSalaryEvent);
					paymentForm.ShowDialog();
					break;
				}
				case tariffPaymentItem:
				{
					_worker.TypeOfSalary = TypeOfSalary.TariffPayment;
					var paymentForm = new TariffPaymentForm();
					paymentForm.SendDataFromFormEvent += new EventHandler<UserEventArgs>(AddWorkerSalaryEvent);
					paymentForm.ShowDialog();
					break;
				}
				case ratePaymenttItem:
				{
					_worker.TypeOfSalary = TypeOfSalary.RatePayment;
					break;
				}
			}


			//Подключение обработчика события в дочерней форме
			//paymentForm.SendDataFromFormEvent += new EventHandler<UserEventArgs>(AddWorkerSalaryEvent);

			//Выводим ее для заполнения текстовых полей
			//paymentForm.ShowDialog();

			if (SendDataFromFormEvent != null)
			{
				SendDataFromFormEvent(this, new UserEventArgs(_worker));
			}

			Close();
		}

		private void AddWorkerSalaryEvent(object sender, UserEventArgs e)
		{
			_worker.Salary = e.SendingSalary.Salary;
		}

		private void NameBox_TextChanged(object sender, EventArgs e)
		{
			//{
			//    try
			//    {
			//        if (NameBox.Text == "" || NameBox.Text == null)
			//        {
			//            throw new ArgumentException("Это поле не должно быть пустым!");
			//        }
			//        const string letterPattern = @"[^а-я^ё^А-Я^Ё^-]";
			//        const string hyphenPattern = @"-";
			//        Regex letterRegex = new Regex(letterPattern);
			//        Regex hyphenRegex = new Regex(hyphenPattern);
			//        if (letterRegex.IsMatch(NameBox.Text.ToLower()) ||
			//            hyphenRegex.Matches(NameBox.Text.ToLower()).Count > 1)
			//        {
			//            throw new ArgumentException("Поле заполнено некорректно.");
			//        }
			//    }
			//    catch (Exception exception)
			//    {
			//        //var toolTip1 = new ToolTip();
			//        //toolTip1.Show($"{exception.Message}", this.NameBox);
			//        MessageBox.Show($"{exception.Message}");
			//    }
			//}
		}

		private void RandomNameButton_Click(object sender, EventArgs e)
		{
			NameBox.Text = Randomizer.GetRandomName();
		}

		private void RandomTypeOfSalaryButton_Click(object sender, EventArgs e)
		{
			TypeOfSalaryBox.Text = TypeOfSalaryBox.
				Items[Randomizer.GetRandomIntInRange(0, TypeOfSalaryBox.Items.Count)].
				ToString();
		}

		private void RandomSurnameButton_Click(object sender, EventArgs e)
		{
			SurnameBox.Text = Randomizer.GetRandomSurname();
		}

		private void NameBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			const string letterPattern = @"[^а-я^ё^А-Я^Ё^-]";
			const string hyphenPattern = @"-";
			Regex letterRegex = new Regex(letterPattern);
			Regex hyphenRegex = new Regex(hyphenPattern);
			if (hyphenRegex.Matches(NameBox.Text).Count < 1)
			{
				if (!letterRegex.IsMatch(e.KeyChar.ToString())
					|| e.KeyChar == (char)Keys.Back)
				{
					return;
				}
				else
				{
					e.Handled = true;
				}
			}
			else
			{
				if ((!letterRegex.IsMatch(e.KeyChar.ToString())
					&& !hyphenRegex.IsMatch(e.KeyChar.ToString()))
					|| e.KeyChar == (char)Keys.Back)
				{
					return;
				}
				else
				{
					e.Handled = true;
				}
			}
		}
	}
}
