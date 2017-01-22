namespace WebsiteDownloader
{
    using System;
    using System.Windows.Forms;

    public partial class StartupUi : Form
    {
        public StartupUi()
        {
            // To test different languages:
            ///System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("de-DE");

            this.InitializeComponent();
        }

        private void AboutClick(object sender, EventArgs e)
        {
            (new AboutBox()).ShowDialog();
        }
    }
}
