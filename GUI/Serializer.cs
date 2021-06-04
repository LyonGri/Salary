using BusinessLogic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GUI
{
    /// <summary>
    /// Класс для сериализации и десериализации
    /// </summary>
    public static class Serializer
    {
		/// <summary>
		/// Сохранение листа в файл
		/// </summary>
		/// <param name="workerList">Лист</param>
		/// <param name="path">Путь к файлу</param>
		public static void SaveFile(List<Worker> workerList, string path)
		{
			 //TODO: RSDN
			// теперь тут дублирование
			var _xmlSerializer = new XmlSerializer(typeof(List<Worker>));
			var file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
			_xmlSerializer.Serialize(file, workerList);
			file.Close();
		}

		/// <summary>
		/// Извлечение листа из файла
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static List<Worker> OpenFile(string path)
		{
			 //TODO: RSDN
			var _xmlSerializer = new XmlSerializer(typeof(List<Worker>));
			var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
			try
			{
				 //TODO: RSDN
				var _workerList = (List<Worker>)_xmlSerializer.Deserialize(file);
				file.Close();
				return _workerList;
			}
			catch 
			{
				file.Close();
				throw new Exception("Файл поврежден!");
			}
		}
	}
}
