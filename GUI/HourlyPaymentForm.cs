﻿using BusinessLogic;
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
        public event EventHandler<NachislatorEventArgs> SendDataFromFormEvent;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public HourlyPaymentForm()
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
            var salary = new HourlyPayment();
            salary.HoursWorked = Int32.Parse(HoursBox.Text);
            salary.CostPerHour = Decimal.Parse(CostBox.Text);
            if (SendDataFromFormEvent != null)
            {
                SendDataFromFormEvent(this, new NachislatorEventArgs(salary));
            }
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

        /// <summary>
        /// Проверка ввода часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    
        /// <summary>
        /// Проверка ввода стоимости
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Наведение красоты у кнопок
        /// </summary>
        /// <param name="button"></param>
        private void buttonNiceLook(Button button)
        {
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HourlyPaymentForm_Load(object sender, EventArgs e)
        {
            foreach (var button in groupBoxInformation.Controls.OfType<Button>())
            {
                buttonNiceLook(button);
            }
            buttonNiceLook(AllRandomButton);
        }

        /// <summary>
        /// Делает кнопку активной, когда заполнены все поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEnabler_TextChanged(object sender, EventArgs e)
        {
            if (HoursBox.Text.Length > 0
                && CostBox.Text.Length > 0)
            {
                ButtonNext.Enabled = true;
            }
            else
            {
                ButtonNext.Enabled = false;
            }
        }
    }
}
