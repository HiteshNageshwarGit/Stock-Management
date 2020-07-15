using System;
using System.Threading;
using System.Windows.Forms;
using StockEntity.Helper;

namespace Stock_Management
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.Run(new MainForm());
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            if (e.Exception.InnerException != null)
            {
                MessageBox.Show(e.Exception.InnerException.Message.ToString() + "\n" + e.Exception.ExceptionInfo());
            }
            else
            {
                MessageBox.Show(e.Exception.ToString() + "\n" +e.Exception.ExceptionInfo());
            }
        }
    }
}
