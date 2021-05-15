
namespace GUI
{
    partial class HourlyPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourlyPaymentForm));
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.RandomCostButton = new System.Windows.Forms.Button();
            this.RandomHoursButton = new System.Windows.Forms.Button();
            this.LabelHours = new System.Windows.Forms.Label();
            this.HoursBox = new System.Windows.Forms.TextBox();
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
            this.groupBoxInformation.Controls.Add(this.HoursBox);
            this.groupBoxInformation.Controls.Add(this.CostBox);
            this.groupBoxInformation.Controls.Add(this.LabelCost);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(245, 123);
            this.groupBoxInformation.TabIndex = 7;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Почасовая оплата";
            // 
            // RandomCostButton
            // 
            this.RandomCostButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomCostButton.BackgroundImage")));
            this.RandomCostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomCostButton.Location = new System.Drawing.Point(120, 55);
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
            this.RandomHoursButton.Location = new System.Drawing.Point(120, 22);
            this.RandomHoursButton.Name = "RandomHoursButton";
            this.RandomHoursButton.Size = new System.Drawing.Size(24, 23);
            this.RandomHoursButton.TabIndex = 8;
            this.RandomHoursButton.UseVisualStyleBackColor = true;
            this.RandomHoursButton.Click += new System.EventHandler(this.RandomHoursButton_Click);
            // 
            // LabelHours
            // 
            this.LabelHours.AutoSize = true;
            this.LabelHours.Location = new System.Drawing.Point(6, 26);
            this.LabelHours.Name = "LabelHours";
            this.LabelHours.Size = new System.Drawing.Size(108, 15);
            this.LabelHours.TabIndex = 2;
            this.LabelHours.Text = "Отработано часов";
            // 
            // HoursBox
            // 
            this.HoursBox.Location = new System.Drawing.Point(150, 23);
            this.HoursBox.Name = "HoursBox";
            this.HoursBox.Size = new System.Drawing.Size(78, 23);
            this.HoursBox.TabIndex = 0;
            this.HoursBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursBox_KeyPress);
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(150, 56);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(78, 23);
            this.CostBox.TabIndex = 0;
            this.CostBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostBox_KeyPress);
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Location = new System.Drawing.Point(6, 59);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(95, 15);
            this.LabelCost.TabIndex = 2;
            this.LabelCost.Text = "Стоимость часа";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(181, 141);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 6;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // AllRandomButton
            // 
            this.AllRandomButton.Location = new System.Drawing.Point(12, 141);
            this.AllRandomButton.Name = "AllRandomButton";
            this.AllRandomButton.Size = new System.Drawing.Size(99, 23);
            this.AllRandomButton.TabIndex = 8;
            this.AllRandomButton.Text = "Лютый рандом";
            this.AllRandomButton.UseVisualStyleBackColor = true;
            // 
            // HourlyPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 178);
            this.Controls.Add(this.AllRandomButton);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.ButtonNext);
            this.Name = "HourlyPaymentForm";
            this.Text = "Начисление з/п";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoursBox_KeyPress);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.TextBox HoursBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button RandomHoursButton;
        private System.Windows.Forms.Button RandomCostButton;
        private System.Windows.Forms.Button AllRandomButton;
    }
}