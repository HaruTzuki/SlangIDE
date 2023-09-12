using System.Diagnostics;
using System.Windows.Shell;

namespace IDE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += Application_ThreadException;

            Application.Run(new Views.FrmSplashScreen(args));
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var exception = $"{e.Exception.Message} Inner Exception: {e.Exception.InnerException}";

            var startInfo = new ProcessStartInfo
            {
                FileName = "crashreport.exe",
                Arguments = $"\"{exception}\""
            };

            Process.Start(startInfo);
            Application.Exit();
        }
    }
}