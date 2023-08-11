namespace Slang.IDE.Tools.CrashReport
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var exceptionString = "";
            if(args.Length > 0)
                exceptionString = args[0];
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain(exceptionString));
        }
    }
}