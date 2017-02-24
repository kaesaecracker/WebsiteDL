namespace WebsiteDownloader
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    using NUnit.Framework;

    // TODO: task listener tests
    [TestFixture]
    public static class Tests
    {
        private static string testBasePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
        private static string downloadTestFile = testBasePath + "dlTest.html";
        private static string editorTestFile = testBasePath + "editorTest.html";

        private static Thread uiThread;

        [SetUp]
        [STAThread]
        public static void Init()
        {
            (uiThread = new Thread(() =>
            {
                Application.Run();
            })).Start();
        }

        [TearDown]
        public static void Cleanup()
        {
            // delete test files
            string[] files = { downloadTestFile, editorTestFile };

            foreach (var file in files)
            {
                if (File.Exists(file))
                {
                   // File.Delete(file);
                }
            }
        }

        [Test]
        public static void DownloadTest()
        {
            Modules.Downloader dl = new Modules.Downloader();
            dl.Start();

            var info = new Helpers.DownloadTask("https://github.com/markbeaton/TidyManaged/search?utf8=%E2%9C%93&q=badimageformat", downloadTestFile);
            dl.EnqueueInfo(info);

            while (info.Status != Helpers.TaskStatus.FINISHED)
            {
            }

            FileAssert.Exists("test");
        }

        [Test]
        public static void OpenGui()
        {
            StartupUi ui = new StartupUi();
            Thread uiThread;

            (uiThread = new Thread(() =>
            {
                Application.Run();
            })).Start();

            ui.Visible = true;
            Assert.That(ui.Visible, Is.True);

            Assert.That(MessageBox.Show("Click yes to pass the test", "title", MessageBoxButtons.YesNo), Is.EqualTo(DialogResult.Yes));

            ui.Visible = false;
            Assert.That(ui.Visible, Is.False);

            ui.Dispose();
            Application.Exit();
        }

        [TestCase("<!DOCTYPE html><html><head><title>Basic Test</title></head><body><p>Non-closed paraghraph and html tag</body>")]
        public static void HtmlEditorTest(string fileContents)
        {
            File.WriteAllText(editorTestFile, fileContents);

            var file = new Helpers.OfflineFile(editorTestFile, null);
            var task = new Helpers.EditorTask(file, (Helpers.TaskTemplate t) =>
            {
                MessageBox.Show(t.Status.ToString());
            });

            var editor = new Modules.HtmlEditor();
            Assert.That(editor.Running, Is.False);
            Assert.That(editor.ShouldStop, Is.False);

            editor.Start();
            Assert.That(editor.Running, Is.True);
            Assert.That(editor.ShouldStop, Is.False);

            editor.Enqueue(task);
        }

        [Test]
        public static void TidyTest()
        {
            string path = testBasePath + "o.html";
            MessageBox.Show(path);

            File.WriteAllText(path, Modules.HtmlEditor.Cleanup("<html><head></head><body></body></html>"));
        }
    }
}
