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
			FileStream file = null;
			try
			{
				file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None);
                using TextReader tr = new StreamReader(file);
                try
                {
                    return (List<Worker>)_xmlSerializer.Deserialize(file);
                }
                catch
                {
                    throw new Exception("Файл поврежден!");
                }
            }
			finally
            {
                file?.Dispose();
            }
		}
	}
}
