namespace WebsiteDownloader.Helpers
{
    using System;

    internal class DownloadTask : TaskTemplate
    {
        internal DownloadTask(string source, string target, Action<TaskTemplate> listener = null) : base(listener) // listener is optional
        {
            this.Source = source;
            this.Target = target;
        }

        internal string Source { get; }

        internal string Target { get; }
    }
}
