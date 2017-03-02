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
            File.WriteAllText(projectFilePath, bridge.SaveState());
        }

        private void saveAsBtn_Click(object sender, EventArgs e)
        {

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
                    bridge.Start();
                }
                else if (bridge.Paused)
                {
                    bridge.Resume();
                }
            }
            else
            {
                // running but not paused --> button should have been deactivated
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


            MessageBox.Show(Statics.OfflineBaseDir);

            Statics.DownloadDepth = (int)form_downloadDepthNum.Value;

            // Checkboxes
            for (int i = 0; i < form_downloadTypesChkList.Items.Count - 1; i++)
            {
                string name = (string)form_downloadTypesChkList.Items[i];
                string prefix = name.Split(':')[0];
                bool value = form_downloadTypesChkList.GetItemChecked(i);

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
                        MessageBox.Show("There seems to be a problem with your checkbox list");
                        break;
                }
            }

            Statics.ParallelDownloads = (int)form_parallelDownloadsNum.Value;
            Statics.ParallelEdits = (int)form_parallelEditsNum.Value;
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            bridge.Pause();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            bridge.Stop();
        }

        private void openBrowserBtn_Click(object sender, EventArgs e)
        {

        }

        private void openExplorerBtn_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
