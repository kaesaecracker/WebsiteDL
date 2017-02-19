namespace WebsiteDownloader.Modules
{
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    internal class Downloader : ModuleTemplate
    {
        // List that contains running download tasks
        private List<Task> downloadTasks = new List<Task>();

        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        // ConcurrentQueue = thread-safe queue (first-in-first-out)
        private ConcurrentQueue<Helpers.DownloadInfo> infoQueue = new ConcurrentQueue<Helpers.DownloadInfo>();

        internal override void LoopAction()
        {
            this.RemoveFinishedTasks();
            this.StartNewTasks();
        }

        internal void EnqueueInfo(Helpers.DownloadInfo info)
        {
            this.infoQueue.Enqueue(info);
        }

        internal override void Stop()
        {
            // TODO stopp downloads
            this.tokenSource.Cancel();
        }

        private static void Process(Helpers.DownloadInfo info)
        {
            info.DownloadStatus = Helpers.DownloadInfo.Status.WORKING;
            info.Listener.Invoke(info);

            // TODO cancel if token is cancelled
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(info.Source, info.Target);
            }

            info.DownloadStatus = Helpers.DownloadInfo.Status.FINISHED;
            info.Listener.Invoke(info);
        }

        #region Helper Methods

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
            // TODO max parallel downloads setting
            // var for stopping if error occurs
            bool enqueueStop = false;

            // add new tasks if max is not reached
            while (this.downloadTasks.Count < 10 && !this.infoQueue.IsEmpty && !enqueueStop)
            {
                // add new task
                Helpers.DownloadInfo info;
                if (this.infoQueue.TryDequeue(out info))
                {
                    var task = Task.Run(() => Process(info), this.tokenSource.Token);
                    this.downloadTasks.Add(task);
                    System.Windows.Forms.MessageBox.Show("Enqueued Task");
                }
                else
                {
                    enqueueStop = true;
                }
            }
        }
        #endregion
    }
}
