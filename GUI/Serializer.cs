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
		/// Сериалайзер
		/// </summary>
		private static readonly XmlSerializer _xmlSerializer = new XmlSerializer(typeof(List<Worker>));

		/// <summary>
		/// Сохранение листа в файл
		/// </summary>
		/// <param name="workerList">Лист</param>
		/// <param name="path">Путь к файлу</param>
		public static void SaveFile(List<Worker> workerList, string path)
		{
			 //TODO: RSDN +
			using var file = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
			_xmlSerializer.Serialize(file, workerList);
		}

		/// <summary>
		/// Извлечение листа из файла
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public static List<Worker> OpenFile(string path)
		{
			using var file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
			try
			{
				 //TODO: RSDN +
				var workerList = (List<Worker>)_xmlSerializer.Deserialize(file);
				return workerList;
			}
			catch 
			{
				throw new Exception("Файл поврежден!");
			}
		}
	}
}
