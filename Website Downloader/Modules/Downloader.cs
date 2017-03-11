namespace WebsiteDownloader.Modules
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    internal class Downloader : ModuleTemplate
    {
        // List that contains running download tasks
        private List<Task> downloadTasks = new List<Task>();

        // ConcurrentQueue = thread-safe queue (first-in-first-out)
        private ConcurrentQueue<OfflineFile> infoQueue = new ConcurrentQueue<OfflineFile>();

        internal ConcurrentQueue<OfflineFile> FinishedTasks { get; private set; } = new ConcurrentQueue<OfflineFile>();

        internal override void LoopAction()
        {
            this.RemoveFinishedTasks();
            this.StartNewTasks();
        }

        internal void Enqueue(OfflineFile file)
        {
            file.FileState = OfflineFile.State.DOWNLOAD;
            this.infoQueue.Enqueue(file);
        }

        internal override void WaitForShutdown()
        {
            foreach (var task in this.downloadTasks)
            {
                task.Wait();
            }
        }

        private void Process(OfflineFile file)
        {
            // IMPROVE cancel download
            // Create folder if it does not exist
            string folder = file.OfflinePath.Substring(0, file.OfflinePath.LastIndexOf("/"));
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
                    if (webEx.Status == WebExceptionStatus.NameResolutionFailure)
                    {
                        File.WriteAllText(file.OfflinePath, "<html><body>Could not resolve the address for the domain");
                    }

                    if (((HttpWebResponse)webEx.Response).StatusCode == HttpStatusCode.NotFound)
                    {
                        File.WriteAllText(file.OfflinePath, "<html><body>404 while trying to download");
                    }
                }
            }

            this.FinishedTasks.Enqueue(file);

            Statics.Logger.Debug("Downloader.Process finished");
        }

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            for (int i = 0; i < this.downloadTasks.Count;)
            {
                var task = this.downloadTasks[i];

                if (task.IsCompleted)
                {
                    this.downloadTasks.Remove(task);
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
            while (this.infoQueue.Count > 0 && this.downloadTasks.Count < Statics.ParallelDownloads && !this.Paused && this.Running)
            {
                // add new task
                OfflineFile file;
                if (this.infoQueue.TryDequeue(out file))
                {
                    var task = new Task(() => this.Process(file));
                    this.downloadTasks.Add(task);

                    task.Start();
                }
            }
        }
    }
}
