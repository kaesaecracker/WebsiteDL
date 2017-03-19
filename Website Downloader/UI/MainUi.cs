namespace WebsiteDownloader.UI
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    internal partial class MainUi : Form
    {
        private Modules.Bridge bridge = new Modules.Bridge();
        private string projectFilePath = string.Empty;

        public MainUi()
        {
            this.InitializeComponent();
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
        
        // reads settings from ui and stores them in Statics.*
        private void ApplySettings()
        {
            Statics.StartUri = this.startUriField.Text;

            Statics.OfflineBaseDir = this.offlineLocationField.Text;
            if (!Statics.OfflineBaseDir.EndsWith("/") || !Statics.OfflineBaseDir.EndsWith("\\"))
            {
                Statics.OfflineBaseDir += "/";
            }

            Directory.CreateDirectory(Statics.OfflineBaseDir);

            Statics.Logger.Info("Starting download to " + Statics.OfflineBaseDir);

            Statics.DownloadDepth = (int)this.downloadDepthNum.Value;

            // Checkboxes
            for (int i = 0; i < this.downloadTypesChkList.Items.Count; i++)
            {
                string name = (string)this.downloadTypesChkList.Items[i];
                string prefix = name.Split(':')[0];
                bool value = this.downloadTypesChkList.GetItemChecked(i);

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

            Statics.ParallelDownloads = (int)this.parallelDownloadsNum.Value;
            Statics.ParallelEdits = (int)this.parallelEditsNum.Value;
        }
        
        private void MainUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bridge != null && this.bridge.Running)
            {
                this.bridge.Stop();
            }
        }

        private void MainUi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.bridge != null && this.bridge.Running)
            {
                this.bridge.WaitForShutdown();
            }

            Application.Exit();
        }

        private void SetButtonsStart()
        {
            this.startBtn.Enabled = this.openBtn.Enabled = false;
            this.pauseBtn.Enabled = this.stopBtn.Enabled = this.openBrowserBtn.Enabled = this.openExplorerBtn.Enabled = true;
        }

        private void SetButtonsStop()
        {
            this.startBtn.Enabled = this.openBtn.Enabled = true;
            this.pauseBtn.Enabled = this.stopBtn.Enabled = false;
        }

        private void SetButtonsPause()
        {
            this.pauseBtn.Enabled = false;
            this.startBtn.Enabled = true;
        }

        private void SetButtonsResume()
        {
            this.pauseBtn.Enabled = true;
            this.startBtn.Enabled = false;
        }

        private void settingsPage_Click(object sender, EventArgs e)
        {

        }

        private void MainUi_Load(object sender, EventArgs e)
        {

        }
    }
}
