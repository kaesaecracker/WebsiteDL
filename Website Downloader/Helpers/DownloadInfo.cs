namespace WebsiteDownloader.Helpers
{
    using System;

    internal class DownloadInfo
    {
        internal DownloadInfo(string source, string target, Action<DownloadInfo> listener = null) // listener is optional
        {
            this.Source = source;
            this.Target = target;
            this.Listener = listener;
        }

        internal enum Status
        {
            UNSET = 0, // = DEFAULT VALUE, not yet queued
            QUEUED, // = waiting for finished worker thread
            WORKING, // = download in progress
            FINISHED, // = download finished
            ERROR
        }

        // ConcurrentBag = thread-safe list 
        internal Action<DownloadInfo> Listener { get; }

        internal string Source { get; }

        internal string Target { get; }

        internal Status DownloadStatus { get; set; }
    }
}
