namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;

    internal class Storage : ModuleTemplate
    {
        private List<OfflineFile> files = new List<OfflineFile>();

        private ConcurrentQueue<OfflineFile> filesToAdd = new ConcurrentQueue<OfflineFile>();

        internal static string GetLocalPath(string uri)
        {
            UriBuilder uriBuilder = new UriBuilder(uri);

            string path = uriBuilder.Host.ToLower();

            if (path.StartsWith("www."))
            {
                path = path.Remove(0, 4);
            }

            path += uriBuilder.Path;

            if (path.EndsWith("/"))
            {
                path += "index.html";
            }

            return Statics.OfflineBaseDir + path;
        }

        internal override void LoopAction()
        {
            // IMPLEMENT Storage LoopAction
        }

        // returns yes if online uri is contained in one of the files
        internal bool IsDownloadedOrEnqueued(OfflineFile file)
        {
            foreach(var f in this.files)
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
