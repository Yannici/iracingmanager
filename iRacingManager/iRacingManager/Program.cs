using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace iRacingManager
{
    static class Program
    {

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.Logger = LogManager.GetLogger("iRacingManager");
            Program.Logger.Info("Application started.");

            // Errorhandling
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerForm());
        }

        internal static Logger Logger
        {
            get; set;
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Program.Logger.Fatal(e.Exception, "Thread error!");
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Program.Logger.Error((Exception)e.ExceptionObject, "Unhandled error!");
        }

    }
}
