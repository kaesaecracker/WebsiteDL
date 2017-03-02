namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Threading;
    using System.Threading.Tasks;

    internal class HtmlEditor : ModuleTemplate
    {
        private List<Task> editTasks = new List<Task>();

        // TODO multithreading htmleditor
        internal ConcurrentQueue<Helpers.EditorTask> Jobs { get; } = new ConcurrentQueue<Helpers.EditorTask>();

        internal ConcurrentQueue<string> FoundUris { get; } = new ConcurrentQueue<string>();

        internal override void LoopAction()
        {
            StartNewTasks();
            RemoveFinishedTasks();
        }

        internal static void Process(Helpers.EditorTask task)
        {
            task.Status = Helpers.TaskStatus.INPROGRESS;

            Cleanup(task.File.OfflinePath); // So you can load it in System.Xml without major problems

            string html = task.File.ContentText; // read
            ParseAndEdit(out html); // the main task
            task.File.ContentText = html; // write

            task.Status = Helpers.TaskStatus.FINISHED;
        }

        internal override void WaitForShutdown()
        {
            foreach (var task in editTasks)
            {
                task.Wait();
            }
        }

        internal void Enqueue(Helpers.EditorTask task)
        {
            this.Jobs.Enqueue(task);
            task.Status = Helpers.TaskStatus.ENQUEUED;
        }

        private static void Cleanup(string path)
        {
            // Create Process object
            var tidyProcess = new Process();
            tidyProcess.StartInfo.FileName = Statics.ExecutablePath + "/tidy/tidy.exe";
            tidyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // IMPROVE HTML Tidy settings
            tidyProcess.StartInfo.Arguments = "-quiet --tidy-mark false --write-back true --output-html true " + path;

            System.Windows.Forms.MessageBox.Show(tidyProcess.StartInfo.FileName + " " + tidyProcess.StartInfo.Arguments);

            tidyProcess.Start();
            tidyProcess.WaitForExit();

            tidyProcess.Dispose();
        }

        private static void ParseAndEdit(out string html)
        {
            // TODO max depth

            // Add files that are refered to by the file to UrisToDownload

            // Add direct links
            {

            }

            // Add images
            if (Statics.DownloadImages)
            {
                // TODO dl img
            }

            // Add scripts
            if (Statics.DownloadScripts)
            {
                // TODO dl js
            }

            // Add objects
            if (Statics.DownloadObjects)
            {
                // TODO dl obj
            }

            // Add styles
            if (Statics.DownloadStyles)
            {
                // TODO dl css
            }

            // IMPLEMENT HtmlEditor Parser
            throw new NotImplementedException();
        }

        private void StartNewTasks()
        {
            // add new tasks if max is not reached
            bool stopEnqueue = false;
            while (!stopEnqueue && this.editTasks.Count < Statics.ParallelEdits && !this.Paused && this.Running)
            {
                // add new task
                Helpers.EditorTask info;
                if (this.Jobs.TryDequeue(out info))
                {
                    var task = new Task(() => Process(info));
                    this.editTasks.Add(task);

                    task.Start();
                }
            }
        }

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            this.editTasks.ForEach((task) =>
            {
                if (task.IsCompleted)
                {
                    this.editTasks.Remove(task);
                }
            });
        }
    }
}
