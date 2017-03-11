namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;

    internal class HtmlEditor : ModuleTemplate
    {
        private List<Task> editTasks = new List<Task>();

        internal ConcurrentQueue<OfflineFile> Jobs { get; } = new ConcurrentQueue<OfflineFile>();

        internal ConcurrentQueue<OfflineFile> FoundLinks { get; } = new ConcurrentQueue<OfflineFile>();

        internal override void LoopAction()
        {
            this.StartNewTasks();
            this.RemoveFinishedTasks();
        }

        internal void Process(OfflineFile file)
        {
            Cleanup(file); // So you can load it in System.Xml without major problems
            this.ParseAndEdit(file);

            file.FileState = OfflineFile.State.FINISHED;
        }

        internal override void WaitForShutdown()
        {
            foreach (var task in this.editTasks)
            {
                task.Wait();
            }
        }

        internal void Enqueue(OfflineFile file)
        {
            file.FileState = OfflineFile.State.EDIT;
            this.Jobs.Enqueue(file);
        }

        private static void Cleanup(OfflineFile file)
        {
            string path = file.OfflinePath;

            // Create Process object
            var tidyProcess = new Process();
            tidyProcess.StartInfo.FileName = Statics.ExecutablePath + "/tidy/tidy.exe";
            tidyProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

            try
            {
                // IMPROVE HTML Tidy settings from ui
                List<string> args = new List<string>();
                args.Add("-quiet"); // do not print to console; maybe faster?
                args.Add("--tidy-mark false"); // dont create tidy meta
                args.Add("--write-back true"); // save formatted content to file
                args.Add("--output-xml true");
                args.Add("--drop-proprietary-attributes true");
                args.Add("--numeric-entities true"); // "&uuml;" --> "ü"
                args.Add(path);

                var argStr = string.Empty;
                foreach (var arg in args)
                {
                    argStr += arg + " ";
                }

                tidyProcess.StartInfo.Arguments = argStr;

                Statics.Logger.Debug("Starting html tidy: " + tidyProcess.StartInfo.FileName + " " + tidyProcess.StartInfo.Arguments);

                // Start tidy, wait for exit
                tidyProcess.Start();
                tidyProcess.WaitForExit();
            }
            catch (Exception e)
            {
                Statics.Logger.Error("Some error occured: " + e.Message);
                tidyProcess.Dispose();
                throw e;
            }

            tidyProcess.Dispose();

            Statics.Logger.Debug("HtmlEditor - Tidy finished");

            // Remove tags like "<![if gt IE 7]>" so Xml does not throw an error
            file.ContentText = System.Text.RegularExpressions.Regex.Replace(file.ContentText, @"<!\[(\w|\s|(\[(\w|\s)*\]))*\]>", string.Empty);
        }

        // Add files that are refered to by the file to UrisToDownload and point links to local paths
        private void ParseAndEdit(OfflineFile file)
        {
            Statics.Logger.Debug("HtmlEditor - Starting Parse of " + file.OfflinePath);

            // Load Xml
            XmlDocument doc = new XmlDocument();
            doc.Load(file.OfflinePath);

            // TODO max depth
            // IMPROVE convert relative links to  absolute ones - should be fine for now though

            // Add direct links
            this.ChangeUris(doc, file, "a", "href");

            // Add images
            if (Statics.DownloadImages)
            {
                this.ChangeUris(doc, file, "img", "src");
            }

            // Add scripts
            if (Statics.DownloadScripts)
            {
                this.ChangeUris(doc, file, "script", "src");
            }

            // Add objects
            if (Statics.DownloadObjects)
            {
                this.ChangeUris(doc, file, "object", "src");
            }

            // Add styles
            if (Statics.DownloadStyles)
            {
                this.ChangeUris(doc, file, "link", "href");
            }

            // Save changes
            doc.Save(file.OfflinePath);

            Statics.Logger.Debug("HtmlEditor - Finished Parse of " + file.OfflinePath);
        }

        private void ChangeUris(XmlDocument doc, OfflineFile file, string tagName, string attributeName)
        {
            foreach (XmlNode node in doc.GetElementsByTagName(tagName))
            {
                XmlAttribute attribute = node.Attributes[attributeName];
                string value = (attribute == null) ? null : attribute.Value;

                if (attribute != null && !value.StartsWith("#") && !value.StartsWith("data:") 
                    && !value.StartsWith("javascript:") && value != string.Empty)
                {
                    if (value.StartsWith("/") && !value.StartsWith("//"))
                    {
                        // IMPROVE links basepath from metadata
                        value = file.OnlineUri + value.Remove(0, 1); // add base path, remove one slash
                    }

                    var foundFile = new OfflineFile(value, file.NeededDepth + 1);

                    if (foundFile.NeededDepth <= Statics.DownloadDepth)
                    {
                        this.FoundLinks.Enqueue(foundFile);
                    }

                    attribute.Value = foundFile.OfflinePath;
                }
            }
        }

        private void StartNewTasks()
        {
            // add new tasks if max is not reached
            bool stopEnqueue = false;
            while (!stopEnqueue && this.editTasks.Count < Statics.ParallelEdits && !this.Paused && this.Running)
            {
                // add new task
                OfflineFile info;
                if (this.Jobs.TryDequeue(out info))
                {
                    var task = new Task(() => this.Process(info));
                    this.editTasks.Add(task);

                    task.Start();
                }
            }
        }

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            for (int i = 0; i < this.editTasks.Count;)
            {
                var task = editTasks[i];
                if (task.IsCompleted)
                {
                    this.editTasks.Remove(task);
                }
                else
                { i++; }

            }
        }
    }
}
