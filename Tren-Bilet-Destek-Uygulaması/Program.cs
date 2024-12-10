using System;
using System.Windows.Forms;
using Tren_Destek_Bileti_Gercek;

namespace Tren_Destek_Bileti_Gerçek
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
