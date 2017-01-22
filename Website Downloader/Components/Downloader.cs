namespace WebsiteDownloader
{
    using Helpers;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    internal class Downloader
    {
        // List that contains running download tasks
        private List<Task> taskList = new List<Task>();

        private CancellationTokenSource tokenSource = new CancellationTokenSource();

        // ConcurrentQueue = thread-safe queue (first-in-first-out)
        private ConcurrentQueue<DownloadInfo> downloadQueue = new ConcurrentQueue<DownloadInfo>();

        internal bool Stop { get; set; } = false;

        internal bool IsRunning { get; private set; } = false;

        internal void StartDownloader()
        {
            this.IsRunning = true;
            while (!this.Stop)
            {
                this.RemoveFinishedTasks();
                this.EnqueueNewTasks();

                if (this.Stop)
                {
                    this.Shutdown();
                }
            }

            this.IsRunning = false;
        }

        private static void Process(DownloadInfo info)
        {
            info.DownloadStatus = DownloadInfo.Status.WORKING;

            // TODO cancel if token is cancelled
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(info.Source, info.Target);
            }

            info.DownloadStatus = DownloadInfo.Status.FINISHED;
        }

        #region Helper Methods

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            this.taskList.ForEach((task) =>
            {
                if (task.IsCompleted)
                {
                    this.taskList.Remove(task);
                }
            });
        }

        private void EnqueueNewTasks()
        {
            // TODO max parallel downloads setting
            // var for stopping if error occurs
            bool intStop = false;

            // add new tasks if max is not reached
            while (this.taskList.Count < 10 && !this.downloadQueue.IsEmpty && !intStop)
            {
                // add new task
                DownloadInfo info;
                if (this.downloadQueue.TryDequeue(out info))
                {
                    var task = Task.Run(() => Process(info), this.tokenSource.Token);
                    taskList.Add(task);
                }
                else
                {
                    intStop = true;
                }
            }
        }

        private void Shutdown()
        {
            // TODO stopp downloads
            this.tokenSource.Cancel();
        }

        #endregion
    }
}
