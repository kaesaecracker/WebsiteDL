namespace WebsiteDL
{
    using System;
    using NLog;

    internal static class Statics
    {
        internal static string AppData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/WebsiteDL/";

        internal static string ExecutablePath { get; } = AppDomain.CurrentDomain.BaseDirectory;

        // IMPROVE user-set html suffixes
        internal static string[] HtmlSuffixes
        {
            get
            {
                return Properties.Settings.Default.HtmlExtensions;
            }
        }

        internal static string StartUri
        {
            get
            {
                return Properties.Settings.Default.StartUrl;
            }
        }

        internal static string OfflineBaseDir
        {
            get
            {
                return Properties.Settings.Default.OfflineLocation;
            }
        }

        internal static int DownloadDepth
        {
            get
            {
                return Properties.Settings.Default.DownloadDepth;
            }
        }

        internal static int ParallelDownloads
        {
            get
            {
                return Properties.Settings.Default.ConcurrentDownloads;
            }
        }

        internal static int ParallelEdits
        {
            get
            {
                return Properties.Settings.Default.ConcurrentEdits;
            }
        }

        internal static bool DownloadImages
        {
            get
            {
                return Properties.Settings.Default.Pictures;
            }
        }

        internal static bool DownloadScripts
        {
            get
            {
                return Properties.Settings.Default.Scripts;
            }
        }

        internal static bool DownloadStyles
        {
            get
            {
                return Properties.Settings.Default.Stylesheets;
            }
        }

        internal static bool DownloadObjects
        {
            get
            {
                return Properties.Settings.Default.Objects;
            }
        }

        internal static Logger Logger { get; } = LogManager.GetCurrentClassLogger();
    }
}
