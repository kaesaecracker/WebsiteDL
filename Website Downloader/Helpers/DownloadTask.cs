namespace WebsiteDownloader.Helpers
{
    using System;

    internal class DownloadTask : TaskTemplate
    {
        internal DownloadTask(string source, Action<TaskTemplate> listener = null, string target = null) : base(listener) // listener is optional
        {
            this.Source = Statics.NormalizeUri(source);

            this.Target = target == null ? Modules.Storage.GetLocalPath(source) : target;
        }

        internal string Source { get; }

        internal string Target { get; }
    }
}
