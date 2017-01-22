using System.Windows.Forms;

namespace WebsiteDownloader
{
    public partial class StartupUi
    {
        // to avoid naming like ribbon_start_file_create
        private class RibbonContents
        {
            internal Ribbon container;

            internal StartContents start = new StartContents();
            internal DownloadContents download = new DownloadContents();

            internal class StartContents
            {
                internal RibbonTab container;

                internal RibbonPanel about;
                internal RibbonButton about_btn;
                internal RibbonPanel file;
                internal RibbonButton file_load;
                internal RibbonButton file_create;
            }

            internal class DownloadContents
            {
                internal RibbonTab container;

                internal RibbonPanel status;
                internal RibbonButton status_start;
                internal RibbonButton status_stop;
                internal RibbonPanel open;
                internal RibbonButton open_browser;
                internal RibbonButton open_manager;
            }
        }

        private RibbonContents ribbon;
        private Panel top_panel;
        

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupUi));
            this.ribbon = new RibbonContents();
            this.top_panel = new Panel();
            this.ribbon.container = new Ribbon();
            this.ribbon.start.container = new RibbonTab();
            this.ribbon.start.file = new RibbonPanel();
            this.ribbon.start.file_load = new RibbonButton();
            this.ribbon.start.file_create = new RibbonButton();
            this.ribbon.start.about = new RibbonPanel();
            this.ribbon.start.about_btn = new RibbonButton();
            this.ribbon.download.container = new RibbonTab();
            this.ribbon.download.status = new RibbonPanel();
            this.ribbon.download.status_start = new RibbonButton();
            this.ribbon.download.status_stop = new RibbonButton();
            this.ribbon.download.open = new RibbonPanel();
            this.ribbon.download.open_browser = new RibbonButton();
            this.ribbon.download.open_manager = new RibbonButton();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.AccessibleRole = AccessibleRole.None;
            this.top_panel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.top_panel.Controls.Add(this.ribbon.container);
            this.top_panel.Location = new System.Drawing.Point(0, -23);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(595, 178);
            this.top_panel.TabIndex = 2;
            // 
            // ribbon
            // 
            this.ribbon.container.BackgroundImageLayout = ImageLayout.None;
            this.ribbon.container.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon.container.Location = new System.Drawing.Point(0, 0);
            this.ribbon.container.Minimized = false;
            this.ribbon.container.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.container.OrbDropDown.BorderRoundness = 8;
            this.ribbon.container.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.container.OrbDropDown.Name = string.Empty;
            this.ribbon.container.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon.container.OrbDropDown.TabIndex = 0;
            this.ribbon.container.OrbImage = null;
            this.ribbon.container.OrbStyle = RibbonOrbStyle.Office_2013;
            this.ribbon.container.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon.container.QuickAcessToolbar.Enabled = false;
            this.ribbon.container.QuickAcessToolbar.Visible = false;
            this.ribbon.container.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.container.Size = new System.Drawing.Size(595, 178);
            this.ribbon.container.TabIndex = 4;
            this.ribbon.container.Tabs.Add(this.ribbon.start.container);
            this.ribbon.container.Tabs.Add(this.ribbon.download.container);
            this.ribbon.container.TabsMargin = new Padding(1, 24, 1, 1);
            this.ribbon.container.TabSpacing = 5;
            this.ribbon.container.ThemeColor = RibbonTheme.Black;
            // 
            // ribbon_start
            // 
            this.ribbon.start.container.Panels.Add(this.ribbon.start.file);
            this.ribbon.start.container.Panels.Add(this.ribbon.start.about);
            this.ribbon.start.container.Text = global::WebsiteDownloader.Properties.Resources.ribbon_start;
            // 
            // ribbon.start.file
            // 
            this.ribbon.start.file.Items.Add(this.ribbon.start.file_load);
            this.ribbon.start.file.Items.Add(this.ribbon.start.file_create);
            this.ribbon.start.file.Text = global::WebsiteDownloader.Properties.Resources.ribbon_start_file;
            // 
            // ribbon.start.file_load
            // 
            this.ribbon.start.file_load.Image = global::WebsiteDownloader.Properties.Resources.icon_file_load;
            this.ribbon.start.file_load.MinSizeMode = RibbonElementSizeMode.Overflow;
            this.ribbon.start.file_load.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon.start.file_load.SmallImage")));
            this.ribbon.start.file_load.Text = global::WebsiteDownloader.Properties.Resources.ribbon_start_file_load;
            // 
            // ribbon.start.file_create
            // 
            this.ribbon.start.file_create.Image = global::WebsiteDownloader.Properties.Resources.icon_file_create;
            this.ribbon.start.file_create.MinSizeMode = RibbonElementSizeMode.Overflow;
            this.ribbon.start.file_create.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon.start.file_create.SmallImage")));
            this.ribbon.start.file_create.Text = global::WebsiteDownloader.Properties.Resources.ribbon_start_file_create;
            // 
            // ribbon.start.about
            // 
            this.ribbon.start.about.Items.Add(this.ribbon.start.about_btn);
            this.ribbon.start.about.Text = "About";
            // 
            // ribbon.start.about_btn
            // 
            this.ribbon.start.about_btn.Image = global::WebsiteDownloader.Properties.Resources.icon_info;
            this.ribbon.start.about_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_start_about_btn.SmallImage")));
            this.ribbon.start.about_btn.Click += new System.EventHandler(this.AboutClick);
            // 
            // ribbon_download
            // 
            this.ribbon.download.container.Panels.Add(this.ribbon.download.status);
            this.ribbon.download.container.Panels.Add(this.ribbon.download.open);
            this.ribbon.download.container.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download;
            // 
            // ribbon.download.status
            // 
            this.ribbon.download.status.Items.Add(this.ribbon.download.status_start);
            this.ribbon.download.status.Items.Add(this.ribbon.download.status_stop);
            this.ribbon.download.status.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_status;
            // 
            // ribbon.download.status_start
            // 
            this.ribbon.download.status_start.Image = global::WebsiteDownloader.Properties.Resources.icon_download_start;
            this.ribbon.download.status_start.MinSizeMode = RibbonElementSizeMode.Overflow;
            this.ribbon.download.status_start.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_status_start.SmallImage")));
            this.ribbon.download.status_start.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_status_start;
            // 
            // ribbon.download.status_stop
            // 
            this.ribbon.download.status_stop.Enabled = false;
            this.ribbon.download.status_stop.Image = global::WebsiteDownloader.Properties.Resources.icon_download_stop;
            this.ribbon.download.status_stop.MinSizeMode = RibbonElementSizeMode.Overflow;
            this.ribbon.download.status_stop.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_status_stop.SmallImage")));
            this.ribbon.download.status_stop.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_status_stop;
            // 
            // ribbon.download.open
            // 
            this.ribbon.download.open.Items.Add(this.ribbon.download.open_browser);
            this.ribbon.download.open.Items.Add(this.ribbon.download.open_manager);
            this.ribbon.download.open.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_open;
            // 
            // ribbon.download.open_browser
            // 
            this.ribbon.download.open_browser.Image = global::WebsiteDownloader.Properties.Resources.icon_browser;
            this.ribbon.download.open_browser.MinSizeMode = RibbonElementSizeMode.Overflow;
            this.ribbon.download.open_browser.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_open_browser.SmallImage")));
            this.ribbon.download.open_browser.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_open_browser;
            // 
            // ribbon.download.open_manager
            // 
            this.ribbon.download.open_manager.Image = global::WebsiteDownloader.Properties.Resources.icon_manager;
            this.ribbon.download.open_manager.MinSizeMode = RibbonElementSizeMode.Overflow;
            this.ribbon.download.open_manager.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_open_manager.SmallImage")));
            this.ribbon.download.open_manager.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_open_manager;
            // 
            // StartupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 400);
            this.Controls.Add(this.top_panel);
            this.MinimumSize = new System.Drawing.Size(425, 39);
            this.Name = "StartupUi";
            this.Text = "Website Downloader";
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}