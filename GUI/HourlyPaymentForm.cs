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
    public partial class HourlyPaymentForm : Form
    {
        /// <summary>
        /// Событие для передачи данных
        /// </summary>
        public event EventHandler<UserEventArgs> SendDataFromFormEvent;

        public HourlyPaymentForm()
        {
            InitializeComponent();
            RandomHoursButton.FlatAppearance.BorderSize = 0;
            RandomHoursButton.FlatStyle = FlatStyle.Flat;
            RandomCostButton.FlatAppearance.BorderSize = 0;
            RandomCostButton.FlatStyle = FlatStyle.Flat;
#if !DEBUG
            {
                RandomHoursButton.Visible = false;
                RandomCostButton.Visible = false;
                AllRandomButton.Visible = false;
            }
#endif

            AllRandomButton.Click += new EventHandler(RandomHoursButton_Click);
            AllRandomButton.Click += new EventHandler(RandomCostButton_Click);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            var worker = new Worker();
            worker.TypeOfSalary = TypeOfSalary.HourlyPayment;
            var salary = new HourlyPayment();
            salary.HoursWorked = Int32.Parse(HoursBox.Text);
            salary.CostPerHour = Decimal.Parse(CostBox.Text);


            worker.Salary = salary.Salary;

            if (SendDataFromFormEvent != null)
            {
                SendDataFromFormEvent(this, new UserEventArgs(salary));
            }

            Close();
        }

        private void RandomHoursButton_Click(object sender, EventArgs e)
        {
            HoursBox.Text = Randomizer.GetRandomIntInRange(1, 999).ToString();
        }

        private void RandomCostButton_Click(object sender, EventArgs e)
        {
            CostBox.Text = Randomizer.GetRandomDecimalInRange(1, 300).ToString();
        }

        private void HoursBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string letterPattern = @"[^0-9]";
            Regex letterRegex = new Regex(letterPattern);

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
    


        private void CostBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const string mainPattern = @"[^,0-9]";
            const string commaPattern = @",";
            const string afterCommaPattern = @"\,\d\d+";
            Regex mainRegex = new Regex(mainPattern);
            Regex commaRegex = new Regex(commaPattern);
            Regex afterCommaRegex = new Regex(afterCommaPattern);
            if (commaRegex.Matches(CostBox.Text).Count < 1)
            {
                if (!mainRegex.IsMatch(e.KeyChar.ToString())
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
                if ((!mainRegex.IsMatch(e.KeyChar.ToString())
                    && !commaRegex.IsMatch(e.KeyChar.ToString()))
                    && !afterCommaRegex.IsMatch(CostBox.Text)
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
