
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupDataGrid = new System.Windows.Forms.GroupBox();
            this.RemoveWorker = new System.Windows.Forms.Button();
            this.DataGridWorkers = new System.Windows.Forms.DataGridView();
            this.workerSurame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddWorker = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.groupDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDataGrid
            // 
            this.groupDataGrid.Controls.Add(this.RemoveWorker);
            this.groupDataGrid.Controls.Add(this.DataGridWorkers);
            this.groupDataGrid.Controls.Add(this.AddWorker);
            this.groupDataGrid.Location = new System.Drawing.Point(12, 36);
            this.groupDataGrid.Name = "groupDataGrid";
            this.groupDataGrid.Size = new System.Drawing.Size(430, 310);
            this.groupDataGrid.TabIndex = 1;
            this.groupDataGrid.TabStop = false;
            this.groupDataGrid.Text = "Информация о заработной плате работников";
            // 
            // RemoveWorker
            // 
            this.RemoveWorker.Location = new System.Drawing.Point(87, 281);
            this.RemoveWorker.Name = "RemoveWorker";
            this.RemoveWorker.Size = new System.Drawing.Size(75, 23);
            this.RemoveWorker.TabIndex = 2;
            this.RemoveWorker.Text = "Удалить";
            this.RemoveWorker.UseVisualStyleBackColor = true;
            this.RemoveWorker.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // DataGridWorkers
            // 
            this.DataGridWorkers.AllowUserToAddRows = false;
            this.DataGridWorkers.AllowUserToDeleteRows = false;
            this.DataGridWorkers.AllowUserToResizeColumns = false;
            this.DataGridWorkers.AllowUserToResizeRows = false;
            this.DataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerSurame,
            this.workerName,
            this.typeOfSalary,
            this.salary});
            this.DataGridWorkers.Location = new System.Drawing.Point(7, 23);
            this.DataGridWorkers.Name = "DataGridWorkers";
            this.DataGridWorkers.ReadOnly = true;
            this.DataGridWorkers.RowHeadersVisible = false;
            this.DataGridWorkers.RowTemplate.Height = 25;
            this.DataGridWorkers.Size = new System.Drawing.Size(414, 252);
            this.DataGridWorkers.TabIndex = 0;
            // 
            // workerSurame
            // 
            this.workerSurame.DataPropertyName = "Surname";
            this.workerSurame.HeaderText = "Фамилия";
            this.workerSurame.Name = "workerSurame";
            this.workerSurame.ReadOnly = true;
            // 
            // workerName
            // 
            this.workerName.DataPropertyName = "Name";
            this.workerName.HeaderText = "Имя";
            this.workerName.Name = "workerName";
            this.workerName.ReadOnly = true;
            // 
            // typeOfSalary
            // 
            this.typeOfSalary.DataPropertyName = "TypeOfSalaryRussian";
            this.typeOfSalary.HeaderText = "Тип заработной платы";
            this.typeOfSalary.Name = "typeOfSalary";
            this.typeOfSalary.ReadOnly = true;
            this.typeOfSalary.Width = 120;
            // 
            // salary
            // 
            this.salary.DataPropertyName = "Salary";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.salary.DefaultCellStyle = dataGridViewCellStyle1;
            this.salary.HeaderText = "Зарплата (вычет НДФЛ)";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 90;
            // 
            // AddWorker
            // 
            this.AddWorker.Location = new System.Drawing.Point(6, 281);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(75, 23);
            this.AddWorker.TabIndex = 2;
            this.AddWorker.Text = "Добавить";
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Location = new System.Drawing.Point(39, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(24, 24);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenButton.BackgroundImage")));
            this.OpenButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenButton.Location = new System.Drawing.Point(13, 6);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(24, 24);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 352);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupDataGrid);
            this.Name = "MainForm";
            this.Text = "Начисление заработной платы";
            this.groupDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDataGrid;
        private System.Windows.Forms.DataGridView DataGridWorkers;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button RemoveWorker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerSurame;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}

