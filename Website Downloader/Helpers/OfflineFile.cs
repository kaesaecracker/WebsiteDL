namespace WebsiteDownloader.Helpers
{
    using System.IO;
    using System.Xml;

    internal class OfflineFile
    {
        internal string OfflinePath { get; private set; }

        internal string OnlineUri { get; set; }

        internal string GetText()
        {
            return File.ReadAllText(this.OfflinePath);
        }

        internal XmlDocument GetXml()
        {
            var xdoc = new XmlDocument();
            xdoc.Load(this.OfflinePath);

            return xdoc;
        }
    }
}
