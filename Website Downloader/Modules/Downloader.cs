namespace WebsiteDownloader.Modules
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    internal class Downloader : ModuleTemplate
    {
        // List that contains running download tasks
        private List<Task> downloadTasks = new List<Task>();

        // ConcurrentQueue = thread-safe queue (first-in-first-out)
        private ConcurrentQueue<Helpers.DownloadTask> infoQueue = new ConcurrentQueue<Helpers.DownloadTask>();

        internal ConcurrentQueue<Helpers.OfflineFile> FinishedTasks { get; private set; } = new ConcurrentQueue<Helpers.OfflineFile>();

        internal override void LoopAction()
        {
            this.RemoveFinishedTasks();
            this.StartNewTasks();
        }

        internal void Enqueue(Helpers.DownloadTask info)
        {
            this.infoQueue.Enqueue(info);
            info.Status = Helpers.TaskStatus.ENQUEUED;
        }

        private void Process(Helpers.DownloadTask info)
        {
            // IMPROVE cancel download
            
            info.Status = Helpers.TaskStatus.INPROGRESS;

            // Create folder if it does not exist
            string folder = info.Target.Substring(0, info.Target.LastIndexOf("/"));
            Directory.CreateDirectory(folder);

            System.Windows.Forms.MessageBox.Show("src=" + info.Source + ", target=" + info.Target);
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(info.Source, info.Target);
            }

            System.Windows.Forms.MessageBox.Show("test");

            this.FinishedTasks.Enqueue(new Helpers.OfflineFile(info));
            info.Status = Helpers.TaskStatus.FINISHED;
        }

        #region Start & Stop
        internal override void WaitForShutdown()
        {
            foreach (var task in downloadTasks)
            {
                task.Wait();
            }
        }
        #endregion

        #region Task add & remove

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            this.downloadTasks.ForEach((task) =>
            {
                if (task.IsCompleted)
                {
                    this.downloadTasks.Remove(task);
                }
            });
        }

        private void StartNewTasks()
        {
            // add new tasks if max is not reached
            while (this.downloadTasks.Count < Statics.ParallelDownloads && !this.Paused && this.Running)
            {
                // add new task
                Helpers.DownloadTask info;
                if (this.infoQueue.TryDequeue(out info))
                {
                    var task = new Task(() => Process(info));
                    this.downloadTasks.Add(task);

                    task.Start();
                }
            }
        }
        #endregion
    }
}
