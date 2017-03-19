namespace WebsiteDownloader.UI
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    internal partial class MainUi
    {
        private void OpenBtn_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog()
            {
                Filter = "WebsiteDL Projects | *.wdlp,*.xml"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // TODO check if stuff is running before loading state
                this.bridge.LoadState(dlg.FileName);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // TODO check if stuff is runnign
            File.WriteAllText(this.projectFilePath, this.bridge.SaveState());
        }

        private void SaveAsBtn_Click(object sender, EventArgs e)
        {
            // TODO check if stuff is running
            if (this.saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                this.projectFilePath = this.saveFileDlg.FileName;
                File.WriteAllText(this.projectFilePath, this.bridge.SaveState());
            }
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog();
            about.Dispose();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (this.bridge.Paused || !this.bridge.Running)
            {
                this.ApplySettings();

                if (!this.bridge.Running)
                {
                    this.SetButtonsStart();
                    this.bridge.Start();
                }
                else if (this.bridge.Paused)
                {
                    this.SetButtonsResume();
                    this.bridge.Resume();
                }
            }
            else
            {
                Statics.Logger.Error("MainUi - Start button was active although it shouldnt have been - FIXME");
                throw new InvalidOperationException("Should not have reached this state");
            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            this.SetButtonsPause();
            this.bridge.Pause();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            this.bridge.Stop();
            this.bridge.WaitForShutdown();
            this.SetButtonsStop();
        }

        private void OpenBrowserBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Modules.Storage.GetLocalPath(Statics.StartUri));
        }

        private void OpenExplorerBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Statics.OfflineBaseDir);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (this.bridge == null)
            {
                this.downloadsInQueueLbl.Text = this.editsInQueueLbl.Text = this.downloadedTotalLbl.Text = "<not running>";
            }
            else
            {
                this.downloadsInQueueLbl.Text = this.bridge.DownloadsInQueue + " files";
                this.editsInQueueLbl.Text = this.bridge.EditsInQueue + " files";
                this.downloadedTotalLbl.Text = this.bridge.DownloadedFilesCount + " files";
            }
        }

        private void OfflineLocationBtn_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog()
            {
                Description = "Choose the offline location",
                ShowNewFolderButton = true
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.offlineLocationField.Text = dlg.SelectedPath;
            }
        }
    }
}
