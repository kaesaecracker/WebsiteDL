namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Generic;
    using Helpers;
    using System.Collections.Concurrent;
    using System.IO;

    internal class Storage : ModuleTemplate
    {
        private List<OfflineFile> files = new List<OfflineFile>();

        private ConcurrentQueue<OfflineFile> filesToAdd = new ConcurrentQueue<OfflineFile>();

        internal override void LoopAction()
        {
            //IMPLEMENT Storage LoopAction
        }

        // checks if a file should contain html by its file extension
        internal static bool IsHtmlFile(string offlinePath)
        {
            var fileExt = Path.GetExtension(offlinePath);

            foreach (var ext in Statics.HtmlSuffixes)
            {
                if (fileExt.ToLower() == ext.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        // returns yes if online uri is contained in one of the files
        internal bool IsDownloadedOrEnqueued(string uri)
        {
            foreach (var file in this.files)
            {
                if (Statics.NormalizeUri(file.OnlineUri) == Statics.NormalizeUri(uri))
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
            files.Add(file);
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

            if (path.EndsWith("/"))
            {
                path += "index.html";
            }

            return Statics.OfflineBaseDir + path;

        }
    }
}
