namespace WebsiteDownloader.Helpers
{
    using System.IO;
    using System.Xml;

    internal class OfflineFile
    {
        internal string OfflinePath { get; private set; }

        internal string OnlineUri { get; set; }

        internal string ContentText
        {
            get
            {
                return File.ReadAllText(this.OfflinePath);
            }

            set
            {
                File.WriteAllText(this.OfflinePath, value);
            }
        }

        public OfflineFile(string offlinePath, string onlineUri)
        {
            this.OfflinePath = offlinePath;
            this.OnlineUri = onlineUri;
        }

        internal XmlDocument GetXml()
        {
            var xdoc = new XmlDocument();
            xdoc.Load(this.OfflinePath);

            return xdoc;
        }

        internal bool Move(string newPath)
        {
            try
            {
                File.Move(OfflinePath, newPath);
                OfflinePath = newPath;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
