namespace WebsiteDownloader.Modules
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    internal class Bridge : ModuleTemplate
    {
        private Downloader downloader = new Downloader();
        private OfflineStorage storage = new OfflineStorage();

        private Type[] serializationExtraTypes =
            {
                typeof(Downloader),
                typeof(Helpers.OfflineFile),
                typeof(Helpers.DownloadInfo)
            };

        internal Bridge()
        {
            this.downloader.Start();
            this.storage.Start();
        }

        internal override void LoopAction()
        {
            throw new NotImplementedException();
        }

        internal override void Stop()
        {
            this.downloader.ShouldStop = true;
        }

        internal string SaveState()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Bridge), extraTypes: this.serializationExtraTypes);

            using (MemoryStream mem = new MemoryStream())
            {
                ser.Serialize(mem, this);

                mem.Position = 0;
                return new StreamReader(mem).ReadToEnd();
            }
        }

        internal Bridge LoadState(string save)
        {
            var memStream = new MemoryStream();
            var memWriter = new StreamWriter(memStream);
            memWriter.Write(save);
            memWriter.Flush();

            var ser = new XmlSerializer(typeof(Bridge), extraTypes: this.serializationExtraTypes);

            return (Bridge)ser.Deserialize(memStream);
        }
    }
}
