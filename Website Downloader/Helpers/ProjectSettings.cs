namespace WebsiteDownloader.Helpers
{
    class ProjectSettings
    {
        internal string StartUri { get; private set; }

        internal int DownloadDepth { get; private set; }

        internal int ParallelDownloads { get; private set; }
        internal int ParallelEdits { get; private set; }

        internal bool DownloadImages { get; private set; } = true;
        internal bool DownloadScripts { get; private set; } = true;
        internal bool DownloadStyles { get; private set; } = true;
        internal bool DownloadObjects { get; private set; } = true;

        public ProjectSettings(string startUri, int depth, int parallelDls, int parallelEdits)
        {
            this.StartUri = startUri;
            this.DownloadDepth = depth;
            this.ParallelDownloads = parallelDls;
            this.ParallelEdits = parallelEdits;
        }
    }
}
