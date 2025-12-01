using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_Sistema_de_Agencia_de_Tours
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Global exception handlers to capture runtime errors and write to a log
            Application.ThreadException += (sender, e) => LogException(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (sender, e) => 
            {
                var ex = e.ExceptionObject as Exception ?? new Exception(e.ExceptionObject.ToString());
                LogException(ex);
            };

            Application.Run(new Form1());
        }

        private static void LogException(Exception ex)
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_log.txt");
                var text = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {ex.GetType()}: {ex.Message}\n{ex.StackTrace}\n\n";
                File.AppendAllText(path, text);
            }
            catch
            {
                // No further action if logging fails
            }
        }
    }
}
