namespace WebsiteDownloader.UI
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class MainUi : Form
    {
        private Modules.Bridge bridge = new Modules.Bridge();
        private string projectFilePath = string.Empty;

        public MainUi()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUi());
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                // TODO check if stuff is running before loading state
                bridge.LoadState(openFileDlg.FileName);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            // TODO check if stuff is runnign
            File.WriteAllText(projectFilePath, bridge.SaveState());
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {
            // TODO check if stuff is running
            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                projectFilePath = saveFileDlg.FileName;
                File.WriteAllText(projectFilePath, bridge.SaveState());
            }
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
            about.Dispose();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (bridge.Paused || !bridge.Running)
            {
                ApplySettings();

                if (!bridge.Running)
                {
                    this.SetButtonsStart();
                    bridge.Start();
                }
                else if (bridge.Paused)
                {
                    this.SetButtonsResume();
                    bridge.Resume();
                }
            }
            else
            {
                Statics.Logger.Error("MainUi - Start button was active although it shouldnt have been - FIXME");
                throw new InvalidOperationException("Should not have reached this state");
            }
        }

        // reads settings from ui and stores them in Statics.*
        private void ApplySettings()
        {
            Statics.StartUri = form_startUriText.Text;

            Statics.OfflineBaseDir = form_downloadBaseDir.Text;
            if (!Statics.OfflineBaseDir.EndsWith("/") || !Statics.OfflineBaseDir.EndsWith("\\"))
            {
                Statics.OfflineBaseDir += "/";
            }

            Directory.CreateDirectory(Statics.OfflineBaseDir);

            Statics.Logger.Info("Starting download to " + Statics.OfflineBaseDir);

            Statics.DownloadDepth = (int)form_downloadDepthNum.Value;

            // Checkboxes
            for (int i = 0; i < form_downloadTypesChkList.Items.Count; i++)
            {
                string name = (string)form_downloadTypesChkList.Items[i];
                string prefix = name.Split(':')[0];
                bool value = form_downloadTypesChkList.GetItemChecked(i);

                Statics.Logger.Info("MainUi - Download " + prefix + "=" + value);

                switch (prefix)
                {
                    case "img":
                        Statics.DownloadImages = value;
                        break;
                    case "js":
                        Statics.DownloadScripts = value;
                        break;
                    case "css":
                        Statics.DownloadStyles = value;
                        break;
                    case "obj":
                        Statics.DownloadObjects = value;
                        break;

                    default:
                        Statics.Logger.Error("MainUi - Unknown checkbox list item: " + prefix);
                        MessageBox.Show("There seems to be a problem with your checkbox list");
                        break;
                }
            }

            Statics.ParallelDownloads = (int)form_parallelDownloadsNum.Value;
            Statics.ParallelEdits = (int)form_parallelEditsNum.Value;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            this.SetButtonsPause();
            bridge.Pause();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            bridge.Stop();
            bridge.WaitForShutdown();
            this.SetButtonsStop();
        }

        private void openBrowserBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Modules.Storage.GetLocalPath(Statics.StartUri));
        }

        private void openExplorerBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Statics.OfflineBaseDir);
        }

        private void MainUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bridge != null && bridge.Running)
            {
                bridge.Stop();
            }
        }

        private void MainUi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bridge != null && bridge.Running)
            {
                bridge.WaitForShutdown();
            }

            Application.Exit();
        }

        private void SetButtonsStart()
        {
            startBtn.Enabled = openBtn.Enabled = false;
            pauseBtn.Enabled = stopBtn.Enabled = openBrowserBtn.Enabled = openExplorerBtn.Enabled = true;
        }

        private void SetButtonsStop()
        {
            startBtn.Enabled = openBtn.Enabled = true;
            pauseBtn.Enabled = stopBtn.Enabled = false;
        }

        private void SetButtonsPause()
        {
            pauseBtn.Enabled = false;
            startBtn.Enabled = true;
        }

        private void SetButtonsResume()
        {
            pauseBtn.Enabled = true;
            startBtn.Enabled = false;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (bridge == null)
            {
                downloadsInQueueLbl.Text = editsInQueueLbl.Text = downloadedTotalLbl.Text = "<not running>";
            }
            else
            {
                downloadsInQueueLbl.Text = bridge.DownloadsInQueue + " files";
                editsInQueueLbl.Text = bridge.EditsInQueue + " files";
                downloadedTotalLbl.Text = bridge.DownloadedFilesCount + " files";
            }
        }
    }
}
