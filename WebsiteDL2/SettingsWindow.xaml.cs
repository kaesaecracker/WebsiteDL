namespace WebsiteDownloader
{
    using System.IO;
    using System.Windows;

    public partial class SettingsWindow : Window
    {
        public  SettingsWindow()
        {
            InitializeComponent();
        }

        // reads settings from ui and stores them in Statics.*
        private void ApplySettings()
        {
            Statics.StartUri = this.startUrlBox.Text;

            Statics.OfflineBaseDir = this.offlineLocationBox.Text;
            if (!Statics.OfflineBaseDir.EndsWith("/", System.StringComparison.Ordinal) 
                || !Statics.OfflineBaseDir.EndsWith("\\", System.StringComparison.Ordinal))
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
    }
}
