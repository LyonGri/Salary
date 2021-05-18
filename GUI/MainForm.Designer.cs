
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupDataGrid = new System.Windows.Forms.GroupBox();
            this.DataGridWorkers = new System.Windows.Forms.DataGridView();
            this.workerSurame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveWorker = new System.Windows.Forms.Button();
            this.AddWorker = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindPicture = new System.Windows.Forms.PictureBox();
            this.groupDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDataGrid
            // 
            this.groupDataGrid.Controls.Add(this.DataGridWorkers);
            this.groupDataGrid.Location = new System.Drawing.Point(12, 36);
            this.groupDataGrid.Name = "groupDataGrid";
            this.groupDataGrid.Size = new System.Drawing.Size(430, 310);
            this.groupDataGrid.TabIndex = 1;
            this.groupDataGrid.TabStop = false;
            this.groupDataGrid.Text = "Информация о заработной плате работников";
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
            this.DataGridWorkers.Size = new System.Drawing.Size(414, 281);
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
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.salary.DefaultCellStyle = dataGridViewCellStyle2;
            this.salary.HeaderText = "Зарплата (вычет НДФЛ)";
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            this.salary.Width = 90;
            // 
            // RemoveWorker
            // 
            this.RemoveWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveWorker.BackgroundImage")));
            this.RemoveWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveWorker.Location = new System.Drawing.Point(115, 6);
            this.RemoveWorker.Name = "RemoveWorker";
            this.RemoveWorker.Size = new System.Drawing.Size(24, 24);
            this.RemoveWorker.TabIndex = 2;
            this.RemoveWorker.UseVisualStyleBackColor = true;
            this.RemoveWorker.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // AddWorker
            // 
            this.AddWorker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWorker.BackgroundImage")));
            this.AddWorker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddWorker.Location = new System.Drawing.Point(85, 6);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(24, 24);
            this.AddWorker.TabIndex = 2;
            this.AddWorker.UseVisualStyleBackColor = true;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveButton.BackgroundImage")));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Location = new System.Drawing.Point(43, 6);
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
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(159, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(283, 23);
            this.SearchBox.TabIndex = 3;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(68, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(140, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // FindPicture
            // 
            this.FindPicture.BackColor = System.Drawing.Color.White;
            this.FindPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindPicture.BackgroundImage")));
            this.FindPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindPicture.Location = new System.Drawing.Point(421, 8);
            this.FindPicture.Name = "FindPicture";
            this.FindPicture.Size = new System.Drawing.Size(19, 19);
            this.FindPicture.TabIndex = 5;
            this.FindPicture.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 352);
            this.Controls.Add(this.FindPicture);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RemoveWorker);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddWorker);
            this.Controls.Add(this.groupDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Начисление заработной платы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox FindPicture;
    }
}

