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
        private static Thread uiThread;

        [SetUp]
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
            if (File.Exists("test"))
            {
                File.Delete("test");
            }
        }

        [Test]
        [STAThread]
        public static void DownloadTest()
        {
            Modules.Downloader dl = new Modules.Downloader();
            dl.Start();

            var info = new Helpers.DownloadInfo("https://google.com", "test", DownloadTest_DownloadListener);
            dl.EnqueueInfo(info);
        }

        [Test]
        [STAThread]
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

        private static void DownloadTest_DownloadListener(Helpers.DownloadInfo info)
        {
            switch (info.DownloadStatus)
            {
                case Helpers.DownloadInfo.Status.FINISHED:
                    FileAssert.Exists("test");
                    break;
            }
        }
    }
}
