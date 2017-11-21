using System;
using System.Windows;
using System.Windows.Threading;

namespace WebsiteDL
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs args)
        {
            Console.Error.WriteLine("An unexpected application exception occurred: {0}", args.Exception);
            Console.ReadKey();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            WebsiteDL.Properties.Settings.Default.Save();
        }
    }
}
