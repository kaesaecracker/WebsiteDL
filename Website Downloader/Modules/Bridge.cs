namespace WebsiteDownloader.Modules
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml.Serialization;

    internal class Bridge : ModuleTemplate
    {
        private Downloader downloader = new Downloader();
        private Storage storage = new Storage();
        private HtmlEditor editor = new HtmlEditor();

        internal override void LoopAction()
        {
            bool stop = false;
            while (!stop && !downloader.FinishedTasks.IsEmpty)
            {
                Helpers.OfflineFile file = null;
                if (downloader.FinishedTasks.TryDequeue(out file))
                {
                    // if file is html -> parse etc
                    if (Storage.IsHtmlFile(file.OfflinePath))
                    {
                        editor.Enqueue(new Helpers.EditorTask(file));
                    }
                }
                else
                {
                    stop = true;
                }
            }

            stop = false;
            while (!stop && !editor.FoundUris.IsEmpty)
            {
                string uri = null;
                // is downloaded or enqueued?
                if (editor.FoundUris.TryDequeue(out uri) && !this.storage.IsDownloadedOrEnqueued(uri))
                {
                    // -> needs to be downloaded
                    var info = new Helpers.DownloadTask(uri);
                    this.downloader.Enqueue(info);
                    this.storage.AddFile(new Helpers.OfflineFile(info));

                }
                else
                {
                    stop = true;
                }
            }
        }

        #region Start, Stop, Shutdown
        internal override void WaitForShutdown()
        {
            this.downloader.WaitForShutdown();
            this.storage.WaitForShutdown();
            this.editor.WaitForShutdown();
        }

        protected internal override void AfterStart()
        {
            this.downloader.Start();
            this.storage.Start();
            this.editor.Start();

            var info = new Helpers.DownloadTask(Statics.StartUri);
            this.downloader.Enqueue(info);
            this.storage.AddFile(new Helpers.OfflineFile(info));
        }

        protected internal override void AfterStop()
        {
            this.downloader.Stop();
            this.storage.Stop();
            this.editor.Stop();
        }
        #endregion

        #region Save & Load
        private Type[] serializationExtraTypes =
            {
                typeof(Downloader),
                typeof(HtmlEditor),
                typeof(Storage),
                typeof(Statics),

                typeof(Helpers.OfflineFile),
                typeof(Helpers.DownloadTask),
                typeof(Helpers.EditorTask),

            };

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
        #endregion
    }
}
