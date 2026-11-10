using System;
using System.Windows.Forms;
using WindowsFormsApp10;

namespace SolarSystemReference
{
    static class Program
    {
        // точка входа в приложение
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // запуск главной формы
        }
    }
}
