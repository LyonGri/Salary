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
	/// <summary>
	/// Основная форма
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Лист работников
		/// </summary>
		private List<Worker> _workerList = new List<Worker>();

		/// <summary>
		/// XML сериализатор
		/// </summary>
		private XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<Worker>));

		//TODO: + (тут были дефолтные пути)

		/// <summary>
		/// Текст для запроса
		/// </summary>
		private string _searchBoxDefaultText = "Введите запрос..." ;

		/// <summary>
		/// Инициализация компонентов
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
		}

		/// <summary>
		/// Кнопка добавлятор
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddWorker_Click(object sender, EventArgs e)
		{
			AddWorkerForm addWorkerForm = new AddWorkerForm();
			addWorkerForm.SendDataFromFormEvent += AddWorkerEvent;
			addWorkerForm.ShowDialog();
		}


		/// <summary>
		/// Обработчик события получения данных из дочерней формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddWorkerEvent(object sender, WorkerEventArgs e)
		{
			_workerList.Add(e.SendingWorker);
			ShowList();
		}

		/// <summary>
		/// Кнопа удалятор
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveWorker_Click(object sender, EventArgs e)
		{
			if (DataGridWorkers.CurrentRow is not null)
			{
				var workerToRemove = DataGridWorkers.CurrentRow.DataBoundItem;
				_workerList.Remove((Worker)workerToRemove);
				ShowList();
			}
		}

		/// <summary>
		/// Кнопка сохранения файла
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			var saveFileDialog = new SaveFileDialog
			{
				Filter = "Text files(*.gld)|*.gld|All files(*.*)|*.*"
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				var path = saveFileDialog.FileName.ToString();
				var file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
				_xmlSerializer.Serialize(file, _workerList);
				file.Close();
			}
		}

		/// <summary>
		/// Кнопка загрузки файла
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenButton_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Text files(*.gld)|*.gld|All files(*.*)|*.*"
			};
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var path = openFileDialog.FileName.ToString();
				var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
				try
                {
				_workerList = (List<Worker>)_xmlSerializer.Deserialize(file);
                }
				catch
                {
					MessageBox.Show("Файл поврежден!");
				}
				file.Close();
				ShowList();
			}
		}

		/// <summary>
		/// Вывод листа в DataGrid
		/// </summary>
		private void ShowList()
		{
			DataGridWorkers.DataSource = null;
			DataGridWorkers.DataSource = _workerList;
		}

		/// <summary>
		/// Событие изменения поля для поиска
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchBox_TextChanged(object sender, EventArgs e)
		{
			if (SearchBox.Text != _searchBoxDefaultText)
			{
				var searchedWorkersList = new List<Worker>();
				foreach (Worker worker in _workerList)
				{
					if (worker.SearchInfo.ToLower().Contains(SearchBox.Text.ToLower()))
					{
						searchedWorkersList.Add(worker);
					}
				}
				DataGridWorkers.DataSource = null;
				DataGridWorkers.DataSource = searchedWorkersList;
			}
		}

		/// <summary>
		/// Событие при активном поле для поиска 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchBox_Enter(object sender, EventArgs e)
		{
			if (SearchBox.Text != _searchBoxDefaultText) return;

			SearchBox.Text = "";
			SearchBox.ForeColor = Color.Black;
		}

		/// <summary>
		/// событие когда поле для поиска не активно
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SearchBox_Leave(object sender, EventArgs e)
		{
			if (SearchBox.Text != "") return;

			SearchBox.Text = _searchBoxDefaultText;
			SearchBox.ForeColor = Color.Gray;
		}

		/// <summary>
		/// Загрузка формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MainForm_Load(object sender, EventArgs e)
		{
			DataGridWorkers.AutoGenerateColumns = false;
			SearchBox.Text = _searchBoxDefaultText;
			SearchBox.ForeColor = Color.Gray;
			foreach (var button in Controls.OfType<Button>())
			{
				button.FlatAppearance.BorderSize = 0;
				button.FlatStyle = FlatStyle.Flat;
			}
		}
	}
}
