using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// ���������� � ����������
    /// </summary>
    public static class DataWorker
    {
        private static List<Worker> _workerList = new List<Worker>();

        /// <summary>
        /// ���� � �����������
        /// </summary>
        public static List<Worker> WorkerList
        {
            get => _workerList;
            set
            {
                _workerList = value;
            }
        }
    }

    /// <summary>
    /// ����� Program
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
