namespace WebsiteDownloader
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Windows.Forms;

    using NUnit.Framework;

    [TestFixture]
    public static class Tests
    {
        private const bool DELTESTFILES = false;

        private static string testBasePath = Statics.AppData + "Test/";
        private static string downloadTestFile = testBasePath + "download.html";
        private static string editorTestFile = testBasePath + "editor.html";
        private static string cleanupTestFile = testBasePath + "cleanup.html";

        [SetUp]
        [STAThread]
        public static void Init()
        {
            Directory.CreateDirectory(testBasePath);

            (new Thread(() =>
            {
                Application.Run();
            })).Start();
        }

        [TearDown]
        public static void Cleanup()
        {
            // Close application
            Application.Exit();

            // delete test files
            string[] files = { downloadTestFile, editorTestFile, cleanupTestFile };

            if (DELTESTFILES)
            {
                foreach (var file in files)
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                    }
                }
            }
        }

        [Test]
        public static void DownloadTest()
        {
            /**var dl = new Modules.Downloader();
            dl.Start();

            var info = new OfflineFile(
                "https://github.com/markbeaton/TidyManaged/search?utf8=%E2%9C%93&q=badimageformat",
                downloadTestFile,
                0);

            dl.Enqueue(info);*/
        }

        [Test]
        public static void OpenGui()
        {
            var ui = new UI.MainUi();

            (new Thread(() =>
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

            var file = new OfflineFile(editorTestFile, 0);

            var editor = new Modules.HtmlEditor();
            Assert.That(editor.Running, Is.False);

            editor.Start();
            Assert.That(editor.Running, Is.True);

            editor.Enqueue(file);
        }

        [TestCase("google.com")]
        [TestCase("https://google.com/search?q=test")]
        [TestCase("www.google.com/help/index.html")]
        [TestCase("Www.GOoglE.Co.uK/foo/bar/foobar.js")]
        public static void LocalPathTest(string uri)
        {
            string path = Modules.Storage.GetLocalPath(uri);

            MessageBox.Show(path);
        }
    }
}
