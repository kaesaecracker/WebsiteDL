namespace WebsiteDL.Modules
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    internal class Bridge : ModuleTemplate
    {
        private Downloader downloader = new Downloader();
        private Storage storage = new Storage();
        private HtmlEditor editor = new HtmlEditor();

        private Type[] serializationExtraTypes =
            {
                typeof(Downloader),
                typeof(HtmlEditor),
                typeof(Storage),
                typeof(Statics),

                typeof(OfflineFile)
            };

        internal int DownloadsInQueue
        {
            get
            {
                return this.downloader.DownloadsInQueue;
            }
        }

        internal int EditsInQueue
        {
            get
            {
                return this.editor.EditsInQueue;
            }
        }

        internal int DownloadedFilesCount
        {
            get
            {
                return this.storage.DownloadedFilesCount;
            }
        }

        internal override void LoopAction()
        {
            OfflineFile file = null;
            if (this.downloader.FinishedTasks.TryDequeue(out file))
            {
                Statics.Logger.Debug("Bridge.LoopAction - Dequeued finished task");

                // if file is html -> parse etc
                if (file.IsHtml())
                {
                    Statics.Logger.Debug("File is an HTML document");

                    this.editor.Enqueue(file);
                }
                else
                {
                    Statics.Logger.Debug("File " + file.OfflinePath + " is not an HTML document");
                }
            }

            // get found URIs from Editor and enqueue them in Downloader
            OfflineFile foundFile = null;

            // is downloaded or enqueued?
            if (this.editor.FoundLinks.TryDequeue(out foundFile)
                && !this.storage.IsDownloadedOrEnqueued(foundFile))
            {
                // -> needs to be downloaded
                this.downloader.Enqueue(foundFile);
                this.storage.AddFile(foundFile);
            }
        }

        internal override void WaitForShutdown()
        {
            this.downloader.WaitForShutdown();
            this.storage.WaitForShutdown();
            this.editor.WaitForShutdown();
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
            using (var memStream = new MemoryStream())
            {
                var memWriter = new StreamWriter(memStream);
                memWriter.Write(save);
                memWriter.Flush();

                var ser = new XmlSerializer(typeof(Bridge), extraTypes: this.serializationExtraTypes);

                return (Bridge)ser.Deserialize(memStream);
            }
        }

        protected internal override void AfterStart()
        {
            Statics.Logger.Info("Bridge started");

            this.downloader.Start();
            this.storage.Start();
            this.editor.Start();

            Statics.Logger.Info("Modules started");

            var startFile = new OfflineFile(Statics.StartUri, 0);
            this.downloader.Enqueue(startFile);
            this.storage.AddFile(startFile);
        }

        protected internal override void AfterStop()
        {
            Statics.Logger.Info("Bridge stopped");

            this.downloader.Stop();
            this.storage.Stop();
            this.editor.Stop();

            Statics.Logger.Info("Modules stopped");
        }
    }
}
