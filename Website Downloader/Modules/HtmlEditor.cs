namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml;

    internal class HtmlEditor : ModuleTemplate
    {
        // IMPROVE user-specified blacklist
        private static string[] blacklistedUriRegexes = { @"(//\.)|(//.*\./)", "tel:.*", "tel://.*", "twitter.com/share" };

        private List<Task> currentEdits = new List<Task>();
        private ConcurrentQueue<OfflineFile> editQueue = new ConcurrentQueue<OfflineFile>();

        internal ConcurrentQueue<OfflineFile> FoundLinks { get; } = new ConcurrentQueue<OfflineFile>();

        internal int EditsInQueue
        {
            get
            {
                return this.currentEdits.Count + this.editQueue.Count;
            }
        }

        internal int CurrentlyEditing
        {
            get
            {
                return this.currentEdits.Count;
            }
        }

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
            foreach (var task in this.currentEdits)
            {
                task.Wait();
            }
        }

        internal void Enqueue(OfflineFile file)
        {
            file.FileState = OfflineFile.State.EDIT;
            this.editQueue.Enqueue(file);
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
                args.Add("--doctype html5");
                args.Add("--uppercase-tags true");
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

            // manual cleanup
            var text = file.ContentText;

            // Remove tags like "<![if gt IE 7]>" so Xml does not throw an error
            text = Regex.Replace(text, @"<!\[(\w|\s|(\[(\w|\s)*\]))*\]>", string.Empty);

            // ensure that the doctype is written in caps
            text = Regex.Replace(text, "<!doctype html>", "<!DOCTYPE html>");

            // dunno why, but the google play website is weird
            /*text = Regex.Replace(text, "\\\"", "\"");
            text = Regex.Replace(text, "/(\\r\\n)|(\\n\\r)|\\r|\\n/g", "\n");*/

            // Save changes
            file.ContentText = text;
        }

        private static bool IsBlacklistedUri(string uriString)
        {
            if (uriString.StartsWith("#") || uriString.StartsWith("data:") || uriString.StartsWith("javascript:"))
            {
                return true;
            }

            if (!Uri.IsWellFormedUriString(uriString, UriKind.RelativeOrAbsolute))
            {
                return true;
            }

            foreach (string regexStr in blacklistedUriRegexes)
            {
                if (Regex.IsMatch(uriString, regexStr))
                {
                    return true;
                }
            }

            return false;
        }

        private static string MakePathAbsolute(string value, string basepath)
        {
            // Absolute URI
            if (value.StartsWith("//"))
            {
                return value;
            }
            else if (value.StartsWith("./") || (value.StartsWith("/") && !value.StartsWith("//")))
            {
                // IMPROVE links basepath from metadata
                value = basepath + value.Remove(0, 1); // add base path, remove one slash
            }
            else if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
            {
                // if still relative: foo/bar.html -> http://base.path/stuff/foo/bar
                value = basepath + value;
            }

            return value;
        }

        // Add files that are refered to by the file to UrisToDownload and point links to local paths
        private void ParseAndEdit(OfflineFile file)
        {
            Statics.Logger.Debug("HtmlEditor - Starting Parse of " + file.OfflinePath);

            // Load Xml
            XmlDocument doc = new XmlDocument();
            using (var sr = new StringReader(file.ContentText))
            using (var xtr = new XmlTextReader(sr)
            {
                Namespaces = false,
                DtdProcessing = DtdProcessing.Ignore,
                Normalization = true,
                WhitespaceHandling = WhitespaceHandling.None
            })
            {
                doc.Load(xtr);
            }


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
            using (var sw = new StringWriter())
            {
                using (var xtw = new XmlTextWriter(sw) { Namespaces = false })
                {
                    doc.Save(xtw);
                    xtw.Flush();
                }

                file.ContentText = sw.ToString();
            }

            Statics.Logger.Debug("HtmlEditor - Finished Parse of " + file.OfflinePath);
        }

        private void ChangeUris(XmlDocument doc, OfflineFile file, string tagName, string attributeName)
        {
            foreach (XmlNode node in doc.GetElementsByTagName(tagName.ToUpper()))
            {
                XmlAttribute attribute = node.Attributes[attributeName];
                string value = (attribute == null) ? string.Empty : attribute.Value;

                if (attribute != null && !string.IsNullOrEmpty(value) && !IsBlacklistedUri(value))
                {
                    value = MakePathAbsolute(value, file.OnlineUri);

                    var foundFile = new OfflineFile(value, file.NeededDepth + 1);

                    if (foundFile.NeededDepth <= Statics.DownloadDepth)
                    {
                        this.FoundLinks.Enqueue(foundFile);
                    }

                    attribute.Value = foundFile.OfflinePath;
                }

                XmlAttribute srcset = node.Attributes["srcset"];
                if (srcset != null)
                {
                    srcset.Value = string.Empty;
                }
            }
        }

        private void StartNewTasks()
        {
            // add new tasks if max is not reached
            OfflineFile info;
            while (this.editQueue.Count > 0 && this.currentEdits.Count < Statics.ParallelEdits && !this.Paused && this.Running)
            {
                if (this.editQueue.TryDequeue(out info))
                {
                    // add new task
                    var task = new Task(() => this.Process(info));
                    this.currentEdits.Add(task);

                    task.Start();
                }
            }
        }

        private void RemoveFinishedTasks()
        {
            // cycle through task list to see if any of them has finished
            for (int i = 0; i < this.currentEdits.Count;)
            {
                var task = this.currentEdits[i];
                if (task.IsCompleted)
                {
                    this.currentEdits.Remove(task);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
