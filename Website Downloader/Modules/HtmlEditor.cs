namespace WebsiteDownloader.Modules
{
    using System;
    using System.Collections.Concurrent;

    using TidyManaged;

    class HtmlEditor : ModuleTemplate
    {
        // TODO multithreading htmleditor
        internal ConcurrentQueue<Helpers.EditorTask> Jobs { get; private set; } = new ConcurrentQueue<Helpers.EditorTask>();

        internal override void LoopAction()
        {
            Helpers.EditorTask job = null;
            if (Jobs.TryDequeue(out job))
            {
                job.Status = Helpers.TaskStatus.WORKING;

                string html = job.File.ContentText; // read

                Cleanup(html); // So you can load it in System.Xml without major problems
                ParseAndEdit(html); // the main task

                job.File.ContentText = html; // write

                job.Status = Helpers.TaskStatus.FINISHED;
            }
        }

        internal override void Stop()
        {
            throw new NotImplementedException();
        }

        internal void Enqueue(Helpers.EditorTask task)
        {
            Jobs.Enqueue(task);
            task.Status = Helpers.TaskStatus.QUEUED;
        }

        internal static string Cleanup(string htmlStr)
        {
            var htmlDoc = Document.FromString(htmlStr);

            // TODO: Add settings for some of this stuff, especially the removal of comments
            // http://tidy.sourceforge.net/docs/quickref.html
            /*htmlDoc.MakeBare = true;
            htmlDoc.MakeClean = true;
            htmlDoc.DocType = DocTypeMode.Auto;
            htmlDoc.EncloseBlockText = true;
            htmlDoc.EncloseBodyText = true;
            htmlDoc.FixUrlBackslashes = true;
            htmlDoc.RemoveComments = true;
            htmlDoc.JoinClasses = true;
            htmlDoc.JoinStyles = true;
            htmlDoc.UseLogicalEmphasis = true;
            htmlDoc.LowerCaseLiterals = true;
            htmlDoc.MergeDivs = AutoBool.Auto;
            htmlDoc.MergeSpans = AutoBool.Auto;            
            htmlDoc.QuoteAmpersands = true;
            htmlDoc.QuoteMarks = true;
            htmlDoc.QuoteNonBreakingSpaces = true;
            htmlDoc.UseColorNames = true;
            htmlDoc.Markup = true;
            htmlDoc.TabSize = 4;
            htmlDoc.OutputCharacterEncoding = EncodingType.Utf8;*/

            htmlDoc.OutputXhtml = true;

            htmlDoc.CleanAndRepair();
            string prettyHtml = htmlDoc.Save();

            return prettyHtml;
        }

        private void ParseAndEdit(string html)
        {
            //throw new NotImplementedException();
        }
    }
}
