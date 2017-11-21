namespace WebsiteDL.Modules
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    internal class Storage : ModuleTemplate
    {
        private List<OfflineFile> files = new List<OfflineFile>();

        private ConcurrentQueue<OfflineFile> filesToAdd = new ConcurrentQueue<OfflineFile>();

        public int DownloadedFilesCount
        {
            get
            {
                return this.files.Count + this.filesToAdd.Count;
            }
        }

        internal static string GetLocalPath(string uri)
        {
            UriBuilder uriBuilder = new UriBuilder(uri);

            string path = uriBuilder.Host.ToLower();

            if (path.StartsWith("www."))
            {
                path = path.Remove(0, 4);
            }

            path += uriBuilder.Path;

            // path is a folder without / at the end
            if (!path.Substring(path.LastIndexOf('/')).Contains("."))
            {
                path += "/";
            }

            // path is a folder
            if (path.EndsWith("/"))
            {
                path += "index.html";
            }

            // HACK URIs with ':' proper escaping
            path = path.Replace(':', ';');

            return Statics.OfflineBaseDir + path;
        }

        internal override void LoopAction()
        {
            // IMPROVE Storage adding etc via LoopAction
        }

        // returns yes if online uri is contained in one of the files
        internal bool IsDownloadedOrEnqueued(OfflineFile file)
        {
            foreach (var f in this.files)
            {
                if (f.OfflinePath == file.OfflinePath)
                {
                    return true;
                }
            }

            return false;
        }

        internal override void WaitForShutdown()
        {
        }

        internal void AddFile(OfflineFile file)
        {
            this.files.Add(file);
        }
    }
}
