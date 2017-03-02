namespace WebsiteDownloader.Helpers
{
    using System.IO;
    using System.Xml;

    internal class OfflineFile
    {

        public OfflineFile(string offlinePath, string onlineUri)
        {
            this.OfflinePath = offlinePath;
            this.OnlineUri = onlineUri;
        }

        public OfflineFile(DownloadTask info):this(info.Target,info.Source)
        {            
        }

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

        internal int NeededDepth { get; set; } // IMPROVE lower depth --> maybe additional downloads needed      

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
                File.Move(this.OfflinePath, newPath);
                this.OfflinePath = newPath;
                return true;
            }
            catch (IOException)
            {
                return false;
            }
        }
    }
}
