using System;
using System.Windows.Forms;

namespace ManipulacionDeDatosApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#pragma warning disable CA1416
            Application.EnableVisualStyles();
#pragma warning restore CA1416
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
