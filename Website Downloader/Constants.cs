namespace WebsiteDownloader
{
    using System;

    internal static class Constants
    {
        internal static string AppData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/WebsiteDL/";

        internal static string ExecutablePath { get; } = AppDomain.CurrentDomain.BaseDirectory;
    }
}
