namespace WebsiteDownloader
{
    using System.IO;
    using System.Xml;

    internal class OfflineFile
    {
        internal OfflineFile(string uri, int neededDepth)
        {
            this.OnlineUri = NormalizeUri(uri);
            this.OfflinePath = Modules.Storage.GetLocalPath(this.OnlineUri);
            this.NeededDepth = neededDepth;
        }

        internal enum State
        {
            FOUND = 10,
            DOWNLOAD = 50,
            EDIT = 80,
            FINISHED = 100
        }

        internal string OfflinePath { get; private set; }

        internal string OnlineUri { get; set; }

        internal State FileState { get; set; } = State.FOUND;

        internal string ContentText
        {
            get
            {
                if (this.FileState > State.DOWNLOAD)
                {
                    return File.ReadAllText(this.OfflinePath);
                }
                else
                {
                    Statics.Logger.Warn("OfflineFile - Tried to read unopened file");
                    return string.Empty;
                }
            }

            set
            {
                File.WriteAllText(this.OfflinePath, value);
            }
        }

        internal int NeededDepth { get; set; } // IMPROVE lower depth --> maybe additional downloads needed      

        internal XmlDocument GetXml()
        {
            var xdoc = new XmlDocument();
            xdoc.Load(this.OfflinePath);

            return xdoc;
        }

        // moves file to new location
        internal bool Move(string newPath)
        {
            try
            {
                File.Move(this.OfflinePath, newPath);
                this.OfflinePath = newPath;
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }

        // checks if a file should contain html by its file extension
        internal bool IsHtml()
        {
            var fileExt = Path.GetExtension(this.OfflinePath);

            Statics.Logger.Debug("OfflineFile.IsHtmlFile - ext of " + this.OfflinePath + " is " + fileExt);

            foreach (var ext in Statics.HtmlSuffixes)
            {
                if (fileExt.ToLower() == ext.ToLower())
                {
                    return true;
                }
            }

            return false;
        }

        private static string NormalizeUri(string uriStr)
        {
            // TODO port?
            if (uriStr.StartsWith("//"))
            {
                uriStr = uriStr.Remove(0, 2);
            }

            if (!uriStr.StartsWith("http"))
            {
                uriStr = "http://" + uriStr;
            }

            // TODO escape query
            System.Uri uri = new System.Uri(uriStr);

            return uri.Scheme + "://" + (uri.Host.StartsWith("www.") ? uri.Host.Remove(0, 4) : uri.Host) + uri.PathAndQuery;
        }
    }
}
