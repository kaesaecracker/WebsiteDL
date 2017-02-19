namespace WebsiteDownloader
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    public partial class StartupUi : Form
    {
        private Modules.Bridge bridge;

        public StartupUi()
        {
            // To test different languages:
            ///System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("de-DE");

            this.InitializeComponent();
            this.bridge = new Modules.Bridge();
        }

        private void AboutClick(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }

        private void Save(string pathToFile)
        {
            File.WriteAllText(path: pathToFile, contents: this.bridge.SaveState());
        }
    }
}
