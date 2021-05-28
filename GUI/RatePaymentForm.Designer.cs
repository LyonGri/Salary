
namespace GUI
{
    partial class RatePaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatePaymentForm));
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.RandomCostButton = new System.Windows.Forms.Button();
            this.RandomHoursButton = new System.Windows.Forms.Button();
            this.LabelHours = new System.Windows.Forms.Label();
            this.DaysBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.LabelCost = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.AllRandomButton = new System.Windows.Forms.Button();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.RandomCostButton);
            this.groupBoxInformation.Controls.Add(this.RandomHoursButton);
            this.groupBoxInformation.Controls.Add(this.LabelHours);
            this.groupBoxInformation.Controls.Add(this.DaysBox);
            this.groupBoxInformation.Controls.Add(this.CostBox);
            this.groupBoxInformation.Controls.Add(this.LabelCost);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(203, 91);
            this.groupBoxInformation.TabIndex = 7;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Оплата по ставке";
            // 
            // RandomCostButton
            // 
            this.RandomCostButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomCostButton.BackgroundImage")));
            this.RandomCostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomCostButton.Location = new System.Drawing.Point(98, 55);
            this.RandomCostButton.Name = "RandomCostButton";
            this.RandomCostButton.Size = new System.Drawing.Size(24, 23);
            this.RandomCostButton.TabIndex = 8;
            this.RandomCostButton.UseVisualStyleBackColor = true;
            this.RandomCostButton.Click += new System.EventHandler(this.RandomCostButton_Click);
            // 
            // RandomHoursButton
            // 
            this.RandomHoursButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomHoursButton.BackgroundImage")));
            this.RandomHoursButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomHoursButton.Location = new System.Drawing.Point(127, 21);
            this.RandomHoursButton.Name = "RandomHoursButton";
            this.RandomHoursButton.Size = new System.Drawing.Size(24, 23);
            this.RandomHoursButton.TabIndex = 8;
            this.RandomHoursButton.UseVisualStyleBackColor = true;
            this.RandomHoursButton.Click += new System.EventHandler(this.RandomDaysButton_Click);
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Location = new System.Drawing.Point(6, 26);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(102, 15);
            this.LabelHours.TabIndex = 2;
            this.LabelHours.Text = "Отработано дней";
            // 
            // DaysBox
            // 
            this.DaysBox.Location = new System.Drawing.Point(157, 22);
            this.DaysBox.Name = "DaysBox";
            this.DaysBox.Size = new System.Drawing.Size(34, 23);
            this.DaysBox.TabIndex = 0;
            this.DaysBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DaysBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerBox_KeyPress);
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(128, 56);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(63, 23);
            this.CostBox.TabIndex = 0;
            this.CostBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(6, 59);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(89, 15);
            this.LabelCost.TabIndex = 2;
            this.LabelCost.Text = "Стоимость дня";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(140, 109);
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
            this.AllRandomButton.Location = new System.Drawing.Point(12, 109);
            this.AllRandomButton.Name = "AllRandomButton";
            this.AllRandomButton.Size = new System.Drawing.Size(24, 24);
            this.AllRandomButton.TabIndex = 8;
            this.AllRandomButton.UseVisualStyleBackColor = true;
            // 
            // RatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 145);
            this.Controls.Add(this.AllRandomButton);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.ButtonNext);
            this.Name = "RatePaymentForm";
            this.Text = "Начисление з/п";
            this.Load += new System.EventHandler(this.HourlyPaymentForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntegerBox_KeyPress);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.TextBox DaysBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button RandomHoursButton;
        private System.Windows.Forms.Button RandomCostButton;
        private System.Windows.Forms.Button AllRandomButton;
    }
}