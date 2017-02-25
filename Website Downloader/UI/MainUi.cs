namespace WebsiteDownloader.UI
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class MainUi : Form
    {
        private Modules.Bridge bridge;
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
            if (!bridge.Running)
            {
                bridge.Start();
            }
            else if (bridge.Paused)
            {
                bridge.Resume();
            }
            else
            {
                // running but not paused --> button should have been deactivated
                throw new InvalidOperationException("Should not have reached this state");
            }

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
