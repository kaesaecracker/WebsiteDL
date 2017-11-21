namespace WebsiteDL
{
    using System.IO;
    using System.Windows;
    using System.Windows.Forms;
    using WinForms = System.Windows.Forms;
    using Unclassified.TxLib;

    public partial class SettingsWindow : Window
    {
        public  SettingsWindow()
        {
            Tx.LoadFromXmlFile("Dictionary.txd");
            InitializeComponent();
        }

        private void SelectOfflineFolderClick(object sender, RoutedEventArgs e)
        {
            using (var dlg = new WinForms.FolderBrowserDialog()
            {
                Description = "Choose the offline location",
                ShowNewFolderButton = true
            })
            {
                if (dlg.ShowDialog() == WinForms.DialogResult.OK)
                {
                    this.offlineLocationBox.Text = dlg.SelectedPath;
                }
            }
        }

        private void DownloadClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
