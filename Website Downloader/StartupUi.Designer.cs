using WebsiteDownloader.Properties;

namespace WebsiteDownloader
{
    partial class StartupUi
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.ribbon_start = new System.Windows.Forms.RibbonTab();
            this.ribbon_project_file = new System.Windows.Forms.RibbonPanel();
            this.ribbon_project_file_load = new System.Windows.Forms.RibbonButton();
            this.ribbon_project_file_create = new System.Windows.Forms.RibbonButton();
            this.ribbon_start_about = new System.Windows.Forms.RibbonPanel();
            this.ribbon_start_about_btn = new System.Windows.Forms.RibbonButton();
            this.ribbon_download = new System.Windows.Forms.RibbonTab();
            this.ribbon_download_status = new System.Windows.Forms.RibbonPanel();
            this.ribbon_download_status_start = new System.Windows.Forms.RibbonButton();
            this.ribbon_download_status_stop = new System.Windows.Forms.RibbonButton();
            this.ribbon_download_open = new System.Windows.Forms.RibbonPanel();
            this.ribbon_download_open_browser = new System.Windows.Forms.RibbonButton();
            this.ribbon_download_open_manager = new System.Windows.Forms.RibbonButton();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.Controls.Add(this.ribbon);
            this.top_panel.Location = new System.Drawing.Point(0, -23);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(595, 178);
            this.top_panel.TabIndex = 2;
            // 
            // ribbon
            // 
            this.ribbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbImage = null;
            this.ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon.QuickAcessToolbar.Enabled = false;
            this.ribbon.QuickAcessToolbar.Visible = false;
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(595, 178);
            this.ribbon.TabIndex = 4;
            this.ribbon.Tabs.Add(this.ribbon_start);
            this.ribbon.Tabs.Add(this.ribbon_download);
            this.ribbon.TabsMargin = new System.Windows.Forms.Padding(1, 24, 1, 1);
            this.ribbon.TabSpacing = 5;
            this.ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // ribbon_start
            // 
            this.ribbon_start.Panels.Add(this.ribbon_project_file);
            this.ribbon_start.Panels.Add(this.ribbon_start_about);
            this.ribbon_start.Text = global::WebsiteDownloader.Properties.Resources.ribbon_start;
            // 
            // ribbon_project_file
            // 
            this.ribbon_project_file.Items.Add(this.ribbon_project_file_load);
            this.ribbon_project_file.Items.Add(this.ribbon_project_file_create);
            this.ribbon_project_file.Text = global::WebsiteDownloader.Properties.Resources.ribbon_project_file;
            // 
            // ribbon_project_file_load
            // 
            this.ribbon_project_file_load.Image = global::WebsiteDownloader.Properties.Resources.icon_file_load;
            this.ribbon_project_file_load.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.ribbon_project_file_load.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_project_file_load.SmallImage")));
            this.ribbon_project_file_load.Text = global::WebsiteDownloader.Properties.Resources.ribbon_project_file_load;
            // 
            // ribbon_project_file_create
            // 
            this.ribbon_project_file_create.Image = global::WebsiteDownloader.Properties.Resources.icon_file_create;
            this.ribbon_project_file_create.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.ribbon_project_file_create.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_project_file_create.SmallImage")));
            this.ribbon_project_file_create.Text = global::WebsiteDownloader.Properties.Resources.ribbon_project_file_create;
            // 
            // ribbon_start_about
            // 
            this.ribbon_start_about.Items.Add(this.ribbon_start_about_btn);
            this.ribbon_start_about.Text = "About";
            // 
            // ribbon_start_about_btn
            // 
            this.ribbon_start_about_btn.Image = global::WebsiteDownloader.Properties.Resources.icon_info;
            this.ribbon_start_about_btn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_start_about_btn.SmallImage")));
            this.ribbon_start_about_btn.Click += new System.EventHandler(this.ribbon_start_about_btn_Click);
            // 
            // ribbon_download
            // 
            this.ribbon_download.Panels.Add(this.ribbon_download_status);
            this.ribbon_download.Panels.Add(this.ribbon_download_open);
            this.ribbon_download.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download;
            // 
            // ribbon_download_status
            // 
            this.ribbon_download_status.Items.Add(this.ribbon_download_status_start);
            this.ribbon_download_status.Items.Add(this.ribbon_download_status_stop);
            this.ribbon_download_status.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_status;
            // 
            // ribbon_download_status_start
            // 
            this.ribbon_download_status_start.Image = global::WebsiteDownloader.Properties.Resources.icon_download_start;
            this.ribbon_download_status_start.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.ribbon_download_status_start.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_status_start.SmallImage")));
            this.ribbon_download_status_start.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_status_start;
            // 
            // ribbon_download_status_stop
            // 
            this.ribbon_download_status_stop.Enabled = false;
            this.ribbon_download_status_stop.Image = global::WebsiteDownloader.Properties.Resources.icon_download_stop;
            this.ribbon_download_status_stop.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.ribbon_download_status_stop.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_status_stop.SmallImage")));
            this.ribbon_download_status_stop.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_status_stop;
            // 
            // ribbon_download_open
            // 
            this.ribbon_download_open.Items.Add(this.ribbon_download_open_browser);
            this.ribbon_download_open.Items.Add(this.ribbon_download_open_manager);
            this.ribbon_download_open.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_open;
            // 
            // ribbon_download_open_browser
            // 
            this.ribbon_download_open_browser.Image = global::WebsiteDownloader.Properties.Resources.icon_browser;
            this.ribbon_download_open_browser.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.ribbon_download_open_browser.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_open_browser.SmallImage")));
            this.ribbon_download_open_browser.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_open_browser;
            // 
            // ribbon_download_open_manager
            // 
            this.ribbon_download_open_manager.Image = global::WebsiteDownloader.Properties.Resources.icon_manager;
            this.ribbon_download_open_manager.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Overflow;
            this.ribbon_download_open_manager.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbon_download_open_manager.SmallImage")));
            this.ribbon_download_open_manager.Text = global::WebsiteDownloader.Properties.Resources.ribbon_download_open_manager;
            // 
            // StartupUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 400);
            this.Controls.Add(this.top_panel);
            this.MinimumSize = new System.Drawing.Size(425, 39);
            this.Name = "StartupUi";
            this.Text = "Website Downloader";
            this.top_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab ribbon_start;
        private System.Windows.Forms.RibbonTab ribbon_download;
        private System.Windows.Forms.RibbonPanel ribbon_project_file;
        private System.Windows.Forms.RibbonButton ribbon_project_file_load;
        private System.Windows.Forms.RibbonButton ribbon_project_file_create;
        private System.Windows.Forms.RibbonPanel ribbon_download_status;
        private System.Windows.Forms.RibbonButton ribbon_download_status_start;
        private System.Windows.Forms.RibbonButton ribbon_download_status_stop;
        private System.Windows.Forms.RibbonPanel ribbon_download_open;
        private System.Windows.Forms.RibbonButton ribbon_download_open_browser;
        private System.Windows.Forms.RibbonButton ribbon_download_open_manager;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonPanel ribbon_start_about;
        private System.Windows.Forms.RibbonButton ribbon_start_about_btn;
    }
}

