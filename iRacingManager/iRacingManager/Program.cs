using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace iRacingManager
{
    static class Program
    {

        public const int HWND_BROADCAST = 0xffff;
        public static readonly int WM_SHOWIRMNG = RegisterWindowMessage("WM_SHOWIRMNG");
        [DllImport("user32")]
        public static extern bool PostMessage(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam);
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string message);

        // SIA
        static Mutex _Mutex = new Mutex(true, "{17D09F24-0B72-4852-ABE2-C13799194FE2}");

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var hasMutex = false;

            try
            {
                hasMutex = Program._Mutex.WaitOne(TimeSpan.Zero, true);
            } catch(AbandonedMutexException)
            {
                hasMutex = true;
            }

            if (hasMutex)
            {
                try
                {
                    Program.Logger = LogManager.GetLogger("iRacingManager");
                    Program.Logger.Info("Application started.");

                    // Errorhandling
                    Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
                    AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new ManagerForm());
                } finally
                {
                    Program._Mutex.ReleaseMutex();
                }
            } else {
                // send our Win32 message to make the currently running instance
                // jump on top of all the other windows
                Program.PostMessage(
                    (IntPtr)Program.HWND_BROADCAST,
                    Program.WM_SHOWIRMNG,
                    IntPtr.Zero,
                    IntPtr.Zero);

                return;
            }
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
