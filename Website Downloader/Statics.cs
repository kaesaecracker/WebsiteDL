namespace WebsiteDownloader
{
    using System;
    using NLog;

    internal static class Statics
    {
        internal static string AppData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/WebsiteDL/";

        internal static string ExecutablePath { get; } = AppDomain.CurrentDomain.BaseDirectory;

        // IMPROVE user-set html suffixes
        internal static string[] HtmlSuffixes { get; } = { ".html", ".htm", ".php", ".aspx" };

        internal static string StartUri { get; set; }

        internal static string OfflineBaseDir { get; set; }

        internal static int DownloadDepth { get; set; }

        internal static int ParallelDownloads { get; set; }

        internal static int ParallelEdits { get; set; }

        internal static bool DownloadImages { get; set; } = true;

        internal static bool DownloadScripts { get; set; } = true;

        internal static bool DownloadStyles { get; set; } = true;

        internal static bool DownloadObjects { get; set; } = true;

        internal static Logger Logger { get; } = LogManager.GetCurrentClassLogger();
    }
}
