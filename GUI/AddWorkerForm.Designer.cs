
namespace GUI
{
    partial class AddWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkerForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.TypeOfSalaryBox = new System.Windows.Forms.ComboBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelTypeOfSalary = new System.Windows.Forms.Label();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.RandomSurnameButton = new System.Windows.Forms.Button();
            this.RandomTypeOfSalaryButton = new System.Windows.Forms.Button();
            this.RandomNameButton = new System.Windows.Forms.Button();
            this.AllRandomButton = new System.Windows.Forms.Button();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(90, 55);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(138, 23);
            this.NameBox.TabIndex = 0;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(90, 22);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(138, 23);
            this.SurnameBox.TabIndex = 0;
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // TypeOfSalaryBox
            // 
            this.TypeOfSalaryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfSalaryBox.FormattingEnabled = true;
            this.TypeOfSalaryBox.Location = new System.Drawing.Point(90, 88);
            this.TypeOfSalaryBox.Name = "TypeOfSalaryBox";
            this.TypeOfSalaryBox.Size = new System.Drawing.Size(138, 23);
            this.TypeOfSalaryBox.TabIndex = 1;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(6, 58);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(31, 15);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Имя";
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(6, 25);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(58, 15);
            this.LabelSurname.TabIndex = 2;
            this.LabelSurname.Text = "Фамилия";
            // 
            // LabelTypeOfSalary
            // 
            this.LabelTypeOfSalary.AutoSize = true;
            this.LabelTypeOfSalary.Location = new System.Drawing.Point(6, 91);
            this.LabelTypeOfSalary.Name = "LabelTypeOfSalary";
            this.LabelTypeOfSalary.Size = new System.Drawing.Size(47, 15);
            this.LabelTypeOfSalary.TabIndex = 2;
            this.LabelTypeOfSalary.Text = "Тип з/п";
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(181, 141);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(75, 23);
            this.ButtonNext.TabIndex = 3;
            this.ButtonNext.Text = "Далее";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.RandomSurnameButton);
            this.groupBoxInformation.Controls.Add(this.RandomTypeOfSalaryButton);
            this.groupBoxInformation.Controls.Add(this.RandomNameButton);
            this.groupBoxInformation.Controls.Add(this.LabelTypeOfSalary);
            this.groupBoxInformation.Controls.Add(this.SurnameBox);
            this.groupBoxInformation.Controls.Add(this.LabelName);
            this.groupBoxInformation.Controls.Add(this.LabelSurname);
            this.groupBoxInformation.Controls.Add(this.NameBox);
            this.groupBoxInformation.Controls.Add(this.TypeOfSalaryBox);
            this.groupBoxInformation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(245, 123);
            this.groupBoxInformation.TabIndex = 4;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Информация о работнике";
            // 
            // RandomSurnameButton
            // 
            this.RandomSurnameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomSurnameButton.BackgroundImage")));
            this.RandomSurnameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomSurnameButton.Location = new System.Drawing.Point(65, 22);
            this.RandomSurnameButton.Name = "RandomSurnameButton";
            this.RandomSurnameButton.Size = new System.Drawing.Size(24, 23);
            this.RandomSurnameButton.TabIndex = 5;
            this.RandomSurnameButton.UseVisualStyleBackColor = true;
            this.RandomSurnameButton.Click += new System.EventHandler(this.RandomSurnameButton_Click);
            // 
            // RandomTypeOfSalaryButton
            // 
            this.RandomTypeOfSalaryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomTypeOfSalaryButton.BackgroundImage")));
            this.RandomTypeOfSalaryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomTypeOfSalaryButton.Location = new System.Drawing.Point(65, 88);
            this.RandomTypeOfSalaryButton.Name = "RandomTypeOfSalaryButton";
            this.RandomTypeOfSalaryButton.Size = new System.Drawing.Size(24, 23);
            this.RandomTypeOfSalaryButton.TabIndex = 5;
            this.RandomTypeOfSalaryButton.UseVisualStyleBackColor = true;
            this.RandomTypeOfSalaryButton.Click += new System.EventHandler(this.RandomTypeOfSalaryButton_Click);
            // 
            // RandomNameButton
            // 
            this.RandomNameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RandomNameButton.BackgroundImage")));
            this.RandomNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RandomNameButton.Location = new System.Drawing.Point(65, 54);
            this.RandomNameButton.Name = "RandomNameButton";
            this.RandomNameButton.Size = new System.Drawing.Size(24, 23);
            this.RandomNameButton.TabIndex = 5;
            this.RandomNameButton.UseVisualStyleBackColor = true;
            this.RandomNameButton.Click += new System.EventHandler(this.RandomNameButton_Click);
            // 
            // AllRandomButton
            // 
            this.AllRandomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllRandomButton.BackgroundImage")));
            this.AllRandomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllRandomButton.Location = new System.Drawing.Point(12, 140);
            this.AllRandomButton.Name = "AllRandomButton";
            this.AllRandomButton.Size = new System.Drawing.Size(24, 24);
            this.AllRandomButton.TabIndex = 5;
            this.AllRandomButton.UseVisualStyleBackColor = true;
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 175);
            this.Controls.Add(this.AllRandomButton);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.ButtonNext);
            this.Name = "AddWorkerForm";
            this.Text = "Начисление з/п";
            this.Load += new System.EventHandler(this.AddWorkerForm_Load);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.ComboBox TypeOfSalaryBox;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelTypeOfSalary;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Button RandomNameButton;
        private System.Windows.Forms.Button RandomTypeOfSalaryButton;
        private System.Windows.Forms.Button RandomSurnameButton;
        private System.Windows.Forms.Button AllRandomButton;
    }
}