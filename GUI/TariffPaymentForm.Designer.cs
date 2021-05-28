
namespace GUI
{
    partial class TariffPaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariffPaymentForm));
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.RandomMounthButton = new System.Windows.Forms.Button();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.RandomCostButton = new System.Windows.Forms.Button();
            this.RandomDaysButton = new System.Windows.Forms.Button();
            this.LabelHours = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCost = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkingDaysBox = new System.Windows.Forms.TextBox();
            this.WorkedDaysBox = new System.Windows.Forms.TextBox();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.AllRandomButton = new System.Windows.Forms.Button();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.RandomMounthButton);
            this.groupBoxInformation.Controls.Add(this.MonthBox);
            this.groupBoxInformation.Controls.Add(this.RandomCostButton);
            this.groupBoxInformation.Controls.Add(this.RandomDaysButton);
            this.groupBoxInformation.Controls.Add(this.LabelHours);
            this.groupBoxInformation.Controls.Add(this.label1);
            this.groupBoxInformation.Controls.Add(this.LabelCost);
            this.groupBoxInformation.Controls.Add(this.CostBox);
            this.groupBoxInformation.Controls.Add(this.label2);
            this.groupBoxInformation.Controls.Add(this.WorkingDaysBox);
            this.groupBoxInformation.Controls.Add(this.WorkedDaysBox);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(245, 150);
            this.groupBoxInformation.TabIndex = 7;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Оплата по окладу";
            // 
            // RandomMounthButton
            // 
            this.RandomMounthButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomMounthButton.BackgroundImage")));
            this.RandomMounthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomMounthButton.Location = new System.Drawing.Point(77, 19);
            this.RandomMounthButton.Name = "RandomMounthButton";
            this.RandomMounthButton.Size = new System.Drawing.Size(24, 24);
            this.RandomMounthButton.TabIndex = 8;
            this.RandomMounthButton.UseVisualStyleBackColor = true;
            this.RandomMounthButton.Click += new System.EventHandler(this.RandomMounthButton_Click);
            // 
            // MonthBox
            // 
            this.MonthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Items.AddRange(new object[] {
            "Январь 2021",
            "Февраль 2021",
            "Март 2021",
            "Апрель 2021",
            "Май 2021",
            "Июнь 2021",
            "Июль 2021",
            "Август 2021",
            "Сентябрь 2021",
            "Октябрь 2021",
            "Ноябрь 2021",
            "Декабрь 2021"});
            this.MonthBox.Location = new System.Drawing.Point(107, 20);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(121, 23);
            this.MonthBox.TabIndex = 9;
            this.MonthBox.SelectionChangeCommitted += new System.EventHandler(this.MonthBox_SelectionChangeCommitted);
            this.MonthBox.SelectedValueChanged += new System.EventHandler(this.MonthBox_SelectedValueChanged);
            // 
            // RandomCostButton
            // 
            this.RandomCostButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomCostButton.BackgroundImage")));
            this.RandomCostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomCostButton.Location = new System.Drawing.Point(120, 119);
            this.RandomCostButton.Name = "RandomCostButton";
            this.RandomCostButton.Size = new System.Drawing.Size(24, 24);
            this.RandomCostButton.TabIndex = 8;
            this.RandomCostButton.UseVisualStyleBackColor = true;
            this.RandomCostButton.Click += new System.EventHandler(this.RandomCostButton_Click);
            // 
            // RandomDaysButton
            // 
            this.RandomDaysButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomDaysButton.BackgroundImage")));
            this.RandomDaysButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomDaysButton.Location = new System.Drawing.Point(161, 87);
            this.RandomDaysButton.Name = "RandomDaysButton";
            this.RandomDaysButton.Size = new System.Drawing.Size(24, 24);
            this.RandomDaysButton.TabIndex = 8;
            this.RandomDaysButton.UseVisualStyleBackColor = true;
            this.RandomDaysButton.Click += new System.EventHandler(this.RandomDaysButton_Click);
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Location = new System.Drawing.Point(10, 91);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(102, 15);
            this.LabelHours.TabIndex = 2;
            this.LabelHours.Text = "Отработано дней";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Месяц";
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(10, 122);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(41, 15);
            this.LabelCost.TabIndex = 2;
            this.LabelCost.Text = "Оклад";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(150, 119);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(78, 23);
            this.CostBox.TabIndex = 0;
            this.CostBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рабочих дней в месяце";
            // 
            // WorkingDaysBox
            // 
            this.WorkingDaysBox.Location = new System.Drawing.Point(191, 54);
            this.WorkingDaysBox.Name = "WorkingDaysBox";
            this.WorkingDaysBox.ReadOnly = true;
            this.WorkingDaysBox.Size = new System.Drawing.Size(37, 23);
            this.WorkingDaysBox.TabIndex = 0;
            this.WorkingDaysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkingDaysBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerBox_KeyPress);
            // 
            // WorkedDaysBox
            // 
            this.WorkedDaysBox.Location = new System.Drawing.Point(191, 87);
            this.WorkedDaysBox.Name = "WorkedDaysBox";
            this.WorkedDaysBox.Size = new System.Drawing.Size(37, 23);
            this.WorkedDaysBox.TabIndex = 0;
            this.WorkedDaysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WorkedDaysBox.TextChanged += new System.EventHandler(this.WorkedDaysBox_TextChanged);
            this.WorkedDaysBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerBox_KeyPress);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(181, 168);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 6;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // AllRandomButton
            // 
            this.AllRandomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllRandomButton.BackgroundImage")));
            this.AllRandomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllRandomButton.Location = new System.Drawing.Point(12, 168);
            this.AllRandomButton.Name = "AllRandomButton";
            this.AllRandomButton.Size = new System.Drawing.Size(24, 24);
            this.AllRandomButton.TabIndex = 8;
            this.AllRandomButton.UseVisualStyleBackColor = true;
            // 
            // TariffPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 206);
            this.Controls.Add(this.AllRandomButton);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.ButtonNext);
            this.Name = "TariffPaymentForm";
            this.Text = "Начисление з/п";
            this.Load += new System.EventHandler(this.TariffPaymentForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerBox_KeyPress);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.TextBox WorkedDaysBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button AllRandomButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WorkingDaysBox;
        private System.Windows.Forms.Button RandomCostButton;
        private System.Windows.Forms.Button RandomDaysButton;
        private System.Windows.Forms.Button RandomMounthButton;
    }
}