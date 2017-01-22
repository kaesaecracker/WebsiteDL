namespace WebsiteDownloader
{
    using System;
    using System.Windows.Forms;

    internal static class Starter
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupUi());
        }
    }
}
