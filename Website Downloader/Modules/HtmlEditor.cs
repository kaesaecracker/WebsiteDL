namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Concurrent;
    using System.Diagnostics;

    internal class HtmlEditor : ModuleTemplate
    {
        // TODO multithreading htmleditor
        internal ConcurrentQueue<Helpers.EditorTask> Jobs { get; } = new ConcurrentQueue<Helpers.EditorTask>();

        internal override void LoopAction()
        {
            Helpers.EditorTask job = null;
            if (this.Jobs.TryDequeue(out job))
            {
                job.Status = Helpers.TaskStatus.INPROGRESS;

                this.Cleanup(job.File.OfflinePath); // So you can load it in System.Xml without major problems

                string html = job.File.ContentText; // read
                this.ParseAndEdit(html); // the main task

                job.File.ContentText = html; // write

                job.Status = Helpers.TaskStatus.FINISHED;
            }
        }

        internal override void Shutdown()
        {
            // IMPLEMENT HtmlEditor Shutdown
            throw new NotImplementedException();
        }

        internal void Enqueue(Helpers.EditorTask task)
        {
            this.Jobs.Enqueue(task);
            task.Status = Helpers.TaskStatus.ENQUEUED;
        }

        private void Cleanup(string path)
        {
            // Create Process object
            var tidyProcess = new Process();
            tidyProcess.StartInfo.FileName = Constants.ExecutablePath + "/tidy/tidy.exe";
            tidyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            // IMPROVE HTML Tidy settings
            tidyProcess.StartInfo.Arguments = "-quiet --tidy-mark false --write-back true --output-html true " + path;

            System.Windows.Forms.MessageBox.Show(tidyProcess.StartInfo.FileName + " " + tidyProcess.StartInfo.Arguments);

            tidyProcess.Start();
            tidyProcess.WaitForExit();

            tidyProcess.Dispose();
        }

        private void ParseAndEdit(string html)
        {
            // IMPLEMENT HtmlEditor Parser
            throw new NotImplementedException();
        }
    }
}
