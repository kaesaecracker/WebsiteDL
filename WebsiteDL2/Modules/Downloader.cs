namespace WebsiteDL.Modules
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;

    internal class Downloader : ModuleTemplate
    {
        // List that contains running download tasks
        private List<Task> currentDownloads = new List<Task>();

        // ConcurrentQueue = thread-safe queue (first-in-first-out)
        private ConcurrentQueue<OfflineFile> downloadQueue = new ConcurrentQueue<OfflineFile>();

        internal ConcurrentQueue<OfflineFile> FinishedTasks { get; private set; } = new ConcurrentQueue<OfflineFile>();

        internal int DownloadsInQueue
        {
            get
            {
                return this.currentDownloads.Count + this.downloadQueue.Count;
            }
        }

        internal int CurrentlyDownloading
        {
            get
            {
                return this.currentDownloads.Count;
            }
        }

        internal override void LoopAction()
        {
            this.RemoveFinishedTasks();
            this.StartNewTasks();
        }

        internal void Enqueue(OfflineFile file)
        {
            file.FileState = OfflineFile.State.DOWNLOAD;
            this.downloadQueue.Enqueue(file);
        }

        internal override void WaitForShutdown()
        {
            foreach (var task in this.currentDownloads)
            {
                task.Wait();
            }
        }

        private void Process(OfflineFile file)
        {
            // IMPROVE cancel download
            // Create folder if it does not exist
            string folder = file.OfflinePath.Substring(0, file.OfflinePath.LastIndexOf("/", System.StringComparison.Ordinal));
            Directory.CreateDirectory(folder);

            Statics.Logger.Debug("Downloader.Process starting " + "src=" + file.OnlineUri + ", target=" + file.OfflinePath);
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(file.OnlineUri, file.OfflinePath);
                }
                catch (WebException webEx)
                {
                    Statics.Logger.Warn("Download failed! URI=" + file.OnlineUri + ", OfflinePath=" + file.OfflinePath
                        + ", Exception Status: " + webEx.Status.ToString() + ", Exception Message: " + webEx.Message);

                    // TODO localisation
                    string fileContent = "<html><body>"
                        + "An error occured while downloading the file. The online version can be found <a href='" + file.OnlineUri + "'>here</a><br/>"
                        + "Some additional information: <br/>"
                        + "Status: " + webEx.Status.ToString() + "<br/>"
                        + "Message: " + webEx.Message + "<br/>";

                    if (webEx.Response != null)
                    {
                        fileContent += "HTTP Response: " + ((HttpWebResponse)webEx.Response).StatusCode.ToString();
                    }

                    file.ContentText = fileContent;
                }
            }

            this.FinishedTasks.Enqueue(file);

            Statics.Logger.Debug("Downloader.Process finished");
        }

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            for (int i = 0; i < this.currentDownloads.Count;)
            {
                var task = this.currentDownloads[i];

                if (task.IsCompleted)
                {
                    this.currentDownloads.Remove(task);
                }
                else
                {
                    i++;
                }
            }
        }

        private void StartNewTasks()
        {
            // add new tasks if max is not reached
            while (this.downloadQueue.Count > 0 && this.currentDownloads.Count < Statics.ParallelDownloads && !this.Paused && this.Running)
            {
                // add new task
                OfflineFile file;
                if (this.downloadQueue.TryDequeue(out file))
                {
                    var task = new Task(() => this.Process(file));
                    this.currentDownloads.Add(task);

                    task.Start();
                }
            }
        }
    }
}
