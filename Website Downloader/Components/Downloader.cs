using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using WebsiteDownloader.Helpers;

namespace WebsiteDownloader
{
    class Downloader
    {
        internal bool Stop { get; set; } = false;

        internal bool IsRunning { get; private set; } = false;

        // ConcurrentQueue = thread-safe queue (first-in-first-out)
        private ConcurrentQueue<DownloadInfo> DownloadQueue { get; } = new ConcurrentQueue<DownloadInfo>();

        // List that contains running download tasks
        private List<Task> taskList = new List<Task>();

        internal void StartDownloader()
        {
            IsRunning = true;
            while (!Stop)
            {
                RemoveFinishedTasks();
                EnqueueNewTasks();
                
                if (Stop)
                {
                    Shutdown();
                }
            }

            IsRunning = false;
        }

        private void Process(DownloadInfo info)
        {
            info.DownloadStatus = DownloadInfo.Status.WORKING;

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(info.Source, info.Target);
            }
        }

        #region Helper Methods

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            taskList.ForEach((task) =>
            {
                if (task.IsCompleted)
                {
                    taskList.Remove(task);
                }
            });
        }

        private void EnqueueNewTasks()
        {
            // TODO max parallel downloads setting
            // var for stopping if error occurs
            bool intStop = false;
            // add new tasks if max is not reached
            while (taskList.Count < 10 && !DownloadQueue.IsEmpty && !intStop)
            {
                //add new task
                DownloadInfo info;
                if (DownloadQueue.TryDequeue(out info))
                {
                    var task = Task.Run(() => Process(info));
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
        }

        #endregion
    }
}
