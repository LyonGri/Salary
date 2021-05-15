using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Лист работников
        /// </summary>
        private List<Worker> _workerList = new List<Worker>();

        private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<Worker>));

        private const string _initialDirectory = @"E:\OOPfiles";
        private string _path = _initialDirectory + @"\WorkerList.gld" ;

        public MainForm()
        {
            InitializeComponent();
            DataGridWorkers.AutoGenerateColumns = false;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            OpenButton.FlatAppearance.BorderSize = 0;
            OpenButton.FlatStyle = FlatStyle.Flat;
            
        }


        private void AddWorker_Click(object sender, EventArgs e)
        {
            //Создаем дочернюю форму
            AddWorkerForm addWorkerForm = new AddWorkerForm();

            //Подключение обработчика события в дочерней форме
            addWorkerForm.SendDataFromFormEvent += new EventHandler<UserEventArgs>(AddWorkerEvent);

            //Выводим ее для заполнения текстовых полей
            addWorkerForm.ShowDialog();
        }


        //Обработчик события получения данных из дочерней формы
        private void AddWorkerEvent(object sender, UserEventArgs e)
        {
            _workerList.Add(e.SendingWorker);
            ShowList();
        }

        private void RemoveWorker_Click(object sender, EventArgs e)
        {
            var workerToRemove = DataGridWorkers.CurrentRow.DataBoundItem;
            _workerList.Remove((Worker)workerToRemove);
            ShowList();
        }

        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.gld)|*.gld|All files(*.*)|*.*";
            saveFileDialog.InitialDirectory = _initialDirectory;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _path = saveFileDialog.FileName.ToString();
            }

            //var xmlSerializer = new XmlSerializer(typeof(List<Worker>));
            var file = new FileStream(_path, FileMode.Create, FileAccess.Write, FileShare.None);
            _xmlSerializer.Serialize(file, _workerList);
            file.Close();

            //еще один способ
            //var writer = new XmlSerializer(typeof(Worker));
            //using (var file = File.Create(path))
            //{
            //    foreach(Worker worker in workerList)
            //    {
            //    writer.Serialize(file, worker);
            //    }
            //    file.Close();
            //}
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {

            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.gld)|*.gld|All files(*.*)|*.*";
            openFileDialog.InitialDirectory = _initialDirectory;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _path = openFileDialog.FileName.ToString();
            }

            var file = new FileStream(_path, FileMode.Open, FileAccess.Read, FileShare.None);
            _workerList = (List<Worker>)_xmlSerializer.Deserialize(file);
            file.Close();
            ShowList();

        }

        /// <summary>
        /// Вывод листа в DataGrid
        /// </summary>
        private void ShowList()
        {
            DataGridWorkers.DataSource = null;
            DataGridWorkers.DataSource = _workerList;
        }
    }
}
