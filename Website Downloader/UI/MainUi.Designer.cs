namespace WebsiteDownloader.UI
{
    internal partial class MainUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Components
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton saveAsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aboutBtn;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TableLayoutPanel settingsTable;
        private System.Windows.Forms.Label startUriLbl;
        private System.Windows.Forms.TextBox startUriField;
        private System.Windows.Forms.Label downloadDepthLbl;
        private System.Windows.Forms.Label parallelEditsLbl;
        private System.Windows.Forms.NumericUpDown downloadDepthNum;
        private System.Windows.Forms.Label downloadTypesLbl;
        private System.Windows.Forms.CheckedListBox downloadTypesChkList;
        private System.Windows.Forms.NumericUpDown parallelEditsNum;
        private System.Windows.Forms.Label parallelDownloadsLbl;
        private System.Windows.Forms.NumericUpDown parallelDownloadsNum;
        private System.Windows.Forms.TabPage progressPage;
        private System.Windows.Forms.ToolStrip fileStrip;
        private System.Windows.Forms.ToolStrip downloadStrip;
        private System.Windows.Forms.ToolStripButton startBtn;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton openBrowserBtn;
        private System.Windows.Forms.ToolStripButton openExplorerBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label queuedDownloadsLbl;
        private System.Windows.Forms.Label queuedEditsLbl;
        private System.Windows.Forms.Label filesTotalLbl;
        private System.Windows.Forms.ToolStripButton pauseBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label downloadsInQueueLbl;
        private System.Windows.Forms.Label editsInQueueLbl;
        private System.Windows.Forms.Label downloadedTotalLbl;

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
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.settingsTable = new System.Windows.Forms.TableLayoutPanel();
            this.startUriLbl = new System.Windows.Forms.Label();
            this.downloadDepthLbl = new System.Windows.Forms.Label();
            this.parallelEditsLbl = new System.Windows.Forms.Label();
            this.downloadDepthNum = new System.Windows.Forms.NumericUpDown();
            this.downloadTypesLbl = new System.Windows.Forms.Label();
            this.downloadTypesChkList = new System.Windows.Forms.CheckedListBox();
            this.parallelEditsNum = new System.Windows.Forms.NumericUpDown();
            this.parallelDownloadsLbl = new System.Windows.Forms.Label();
            this.parallelDownloadsNum = new System.Windows.Forms.NumericUpDown();
            this.startUriField = new System.Windows.Forms.TextBox();
            this.progressPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.queuedDownloadsLbl = new System.Windows.Forms.Label();
            this.queuedEditsLbl = new System.Windows.Forms.Label();
            this.filesTotalLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.downloadsInQueueLbl = new System.Windows.Forms.Label();
            this.editsInQueueLbl = new System.Windows.Forms.Label();
            this.downloadedTotalLbl = new System.Windows.Forms.Label();
            this.fileStrip = new System.Windows.Forms.ToolStrip();
            this.downloadStrip = new System.Windows.Forms.ToolStrip();
            this.startBtn = new System.Windows.Forms.ToolStripButton();
            this.pauseBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openBrowserBtn = new System.Windows.Forms.ToolStripButton();
            this.openExplorerBtn = new System.Windows.Forms.ToolStripButton();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.offlineLocationField = new System.Windows.Forms.TextBox();
            this.offlineLocationBtn = new System.Windows.Forms.Button();
            this.offlineLocationTable = new System.Windows.Forms.TableLayoutPanel();
            this.offlineLocationLbl = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.settingsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadDepthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelEditsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelDownloadsNum)).BeginInit();
            this.progressPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.fileStrip.SuspendLayout();
            this.downloadStrip.SuspendLayout();
            this.offlineLocationTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(380, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(383, 25);
            this.miniToolStrip.TabIndex = 1;
            // 
            // openBtn
            // 
            this.openBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_folder_open;
            this.openBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(93, 37);
            this.openBtn.Text = "Open File";
            this.openBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_save;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 37);
            this.saveBtn.Text = "Save File";
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Enabled = false;
            this.saveAsBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_page_new;
            this.saveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(83, 37);
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.Click += new System.EventHandler(this.SaveAsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_information_circle;
            this.aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(76, 37);
            this.aboutBtn.Text = "About";
            this.aboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.settingsPage);
            this.tabControl.Controls.Add(this.progressPage);
            this.tabControl.Location = new System.Drawing.Point(0, 80);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1176, 366);
            this.tabControl.TabIndex = 0;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.settingsTable);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(1168, 340);
            this.settingsPage.TabIndex = 0;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            this.settingsPage.Click += new System.EventHandler(this.settingsPage_Click);
            // 
            // settingsTable
            // 
            this.settingsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsTable.ColumnCount = 2;
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.settingsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.settingsTable.Controls.Add(this.startUriLbl, 0, 0);
            this.settingsTable.Controls.Add(this.downloadDepthLbl, 0, 2);
            this.settingsTable.Controls.Add(this.parallelEditsLbl, 0, 4);
            this.settingsTable.Controls.Add(this.downloadDepthNum, 1, 2);
            this.settingsTable.Controls.Add(this.downloadTypesLbl, 0, 1);
            this.settingsTable.Controls.Add(this.downloadTypesChkList, 1, 1);
            this.settingsTable.Controls.Add(this.parallelEditsNum, 1, 4);
            this.settingsTable.Controls.Add(this.parallelDownloadsLbl, 0, 3);
            this.settingsTable.Controls.Add(this.parallelDownloadsNum, 1, 3);
            this.settingsTable.Controls.Add(this.offlineLocationLbl, 0, 5);
            this.settingsTable.Controls.Add(this.offlineLocationTable, 1, 5);
            this.settingsTable.Controls.Add(this.startUriField, 1, 0);
            this.settingsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTable.Location = new System.Drawing.Point(3, 3);
            this.settingsTable.Margin = new System.Windows.Forms.Padding(0);
            this.settingsTable.Name = "settingsTable";
            this.settingsTable.RowCount = 6;
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.settingsTable.Size = new System.Drawing.Size(1162, 334);
            this.settingsTable.TabIndex = 5;
            // 
            // startUriLbl
            // 
            this.startUriLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUriLbl.Location = new System.Drawing.Point(3, 0);
            this.startUriLbl.Name = "startUriLbl";
            this.startUriLbl.Size = new System.Drawing.Size(51, 13);
            this.startUriLbl.TabIndex = 0;
            this.startUriLbl.Text = "Start-URI";
            // 
            // downloadDepthLbl
            // 
            this.downloadDepthLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadDepthLbl.Location = new System.Drawing.Point(3, 96);
            this.downloadDepthLbl.Name = "downloadDepthLbl";
            this.downloadDepthLbl.Size = new System.Drawing.Size(87, 13);
            this.downloadDepthLbl.TabIndex = 4;
            this.downloadDepthLbl.Text = "Download Depth";
            // 
            // parallelEditsLbl
            // 
            this.parallelEditsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parallelEditsLbl.Location = new System.Drawing.Point(3, 148);
            this.parallelEditsLbl.Name = "parallelEditsLbl";
            this.parallelEditsLbl.Size = new System.Drawing.Size(67, 13);
            this.parallelEditsLbl.TabIndex = 7;
            this.parallelEditsLbl.Text = "Parallel Edits";
            // 
            // downloadDepthNum
            // 
            this.downloadDepthNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadDepthNum.Location = new System.Drawing.Point(153, 99);
            this.downloadDepthNum.Margin = new System.Windows.Forms.Padding(0);
            this.downloadDepthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.downloadDepthNum.Name = "downloadDepthNum";
            this.downloadDepthNum.Size = new System.Drawing.Size(867, 20);
            this.downloadDepthNum.TabIndex = 5;
            this.downloadDepthNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // downloadTypesLbl
            // 
            this.downloadTypesLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadTypesLbl.Location = new System.Drawing.Point(3, 26);
            this.downloadTypesLbl.Name = "downloadTypesLbl";
            this.downloadTypesLbl.Size = new System.Drawing.Size(99, 13);
            this.downloadTypesLbl.TabIndex = 2;
            this.downloadTypesLbl.Text = "Download file types";
            // 
            // downloadTypesChkList
            // 
            this.downloadTypesChkList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadTypesChkList.FormattingEnabled = true;
            this.downloadTypesChkList.Items.AddRange(new object[] {
            "img: Images (<img src=* />)",
            "js:    JavaScript (<script src=* ></script>)",
            "css: Stylesheets (<link rel=stylesheet href=* />)",
            "obj: Objects (<object data=*>)"});
            this.downloadTypesChkList.Location = new System.Drawing.Point(153, 29);
            this.downloadTypesChkList.Margin = new System.Windows.Forms.Padding(0);
            this.downloadTypesChkList.Name = "downloadTypesChkList";
            this.downloadTypesChkList.Size = new System.Drawing.Size(867, 64);
            this.downloadTypesChkList.TabIndex = 3;
            // 
            // parallelEditsNum
            // 
            this.parallelEditsNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parallelEditsNum.Location = new System.Drawing.Point(153, 151);
            this.parallelEditsNum.Margin = new System.Windows.Forms.Padding(0);
            this.parallelEditsNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.parallelEditsNum.Name = "parallelEditsNum";
            this.parallelEditsNum.Size = new System.Drawing.Size(867, 20);
            this.parallelEditsNum.TabIndex = 9;
            this.parallelEditsNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // parallelDownloadsLbl
            // 
            this.parallelDownloadsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parallelDownloadsLbl.Location = new System.Drawing.Point(3, 122);
            this.parallelDownloadsLbl.Name = "parallelDownloadsLbl";
            this.parallelDownloadsLbl.Size = new System.Drawing.Size(97, 13);
            this.parallelDownloadsLbl.TabIndex = 6;
            this.parallelDownloadsLbl.Text = "Parallel Downloads";
            // 
            // parallelDownloadsNum
            // 
            this.parallelDownloadsNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parallelDownloadsNum.Location = new System.Drawing.Point(153, 125);
            this.parallelDownloadsNum.Margin = new System.Windows.Forms.Padding(0);
            this.parallelDownloadsNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.parallelDownloadsNum.Name = "parallelDownloadsNum";
            this.parallelDownloadsNum.Size = new System.Drawing.Size(867, 20);
            this.parallelDownloadsNum.TabIndex = 8;
            this.parallelDownloadsNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // startUriField
            // 
            this.startUriField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startUriField.Location = new System.Drawing.Point(153, 3);
            this.startUriField.Margin = new System.Windows.Forms.Padding(0);
            this.startUriField.Name = "startUriField";
            this.startUriField.Size = new System.Drawing.Size(867, 20);
            this.startUriField.TabIndex = 1;
            this.startUriField.Text = "https://wikipedia.org/";
            // 
            // progressPage
            // 
            this.progressPage.Controls.Add(this.tableLayoutPanel2);
            this.progressPage.Location = new System.Drawing.Point(4, 22);
            this.progressPage.Name = "progressPage";
            this.progressPage.Padding = new System.Windows.Forms.Padding(3);
            this.progressPage.Size = new System.Drawing.Size(1023, 316);
            this.progressPage.TabIndex = 1;
            this.progressPage.Text = "Progress";
            this.progressPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.13473F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.86527F));
            this.tableLayoutPanel2.Controls.Add(this.queuedDownloadsLbl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.queuedEditsLbl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.filesTotalLbl, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.refreshBtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.downloadsInQueueLbl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.editsInQueueLbl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.downloadedTotalLbl, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(689, 235);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // queuedDownloadsLbl
            // 
            this.queuedDownloadsLbl.AutoSize = true;
            this.queuedDownloadsLbl.Location = new System.Drawing.Point(3, 35);
            this.queuedDownloadsLbl.Name = "queuedDownloadsLbl";
            this.queuedDownloadsLbl.Size = new System.Drawing.Size(101, 13);
            this.queuedDownloadsLbl.TabIndex = 0;
            this.queuedDownloadsLbl.Text = "Queued Downloads";
            // 
            // queuedEditsLbl
            // 
            this.queuedEditsLbl.AutoSize = true;
            this.queuedEditsLbl.Location = new System.Drawing.Point(3, 55);
            this.queuedEditsLbl.Name = "queuedEditsLbl";
            this.queuedEditsLbl.Size = new System.Drawing.Size(71, 13);
            this.queuedEditsLbl.TabIndex = 1;
            this.queuedEditsLbl.Text = "Queued Edits";
            // 
            // filesTotalLbl
            // 
            this.filesTotalLbl.AutoSize = true;
            this.filesTotalLbl.Location = new System.Drawing.Point(3, 75);
            this.filesTotalLbl.Name = "filesTotalLbl";
            this.filesTotalLbl.Size = new System.Drawing.Size(55, 13);
            this.filesTotalLbl.TabIndex = 4;
            this.filesTotalLbl.Text = "Files Total";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.refreshBtn, 2);
            this.refreshBtn.Location = new System.Drawing.Point(3, 3);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(683, 29);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // downloadsInQueueLbl
            // 
            this.downloadsInQueueLbl.AutoSize = true;
            this.downloadsInQueueLbl.Location = new System.Drawing.Point(189, 35);
            this.downloadsInQueueLbl.Name = "downloadsInQueueLbl";
            this.downloadsInQueueLbl.Size = new System.Drawing.Size(76, 13);
            this.downloadsInQueueLbl.TabIndex = 6;
            this.downloadsInQueueLbl.Text = "<click refresh>";
            // 
            // editsInQueueLbl
            // 
            this.editsInQueueLbl.AutoSize = true;
            this.editsInQueueLbl.Location = new System.Drawing.Point(189, 55);
            this.editsInQueueLbl.Name = "editsInQueueLbl";
            this.editsInQueueLbl.Size = new System.Drawing.Size(76, 13);
            this.editsInQueueLbl.TabIndex = 7;
            this.editsInQueueLbl.Text = "<click refresh>";
            // 
            // downloadedTotalLbl
            // 
            this.downloadedTotalLbl.AutoSize = true;
            this.downloadedTotalLbl.Location = new System.Drawing.Point(189, 75);
            this.downloadedTotalLbl.Name = "downloadedTotalLbl";
            this.downloadedTotalLbl.Size = new System.Drawing.Size(76, 13);
            this.downloadedTotalLbl.TabIndex = 8;
            this.downloadedTotalLbl.Text = "<click refresh>";
            // 
            // fileStrip
            // 
            this.fileStrip.AutoSize = false;
            this.fileStrip.BackColor = System.Drawing.Color.Transparent;
            this.fileStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fileStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsBtn,
            this.openBtn,
            this.saveBtn,
            this.toolStripSeparator1,
            this.aboutBtn});
            this.fileStrip.Location = new System.Drawing.Point(0, 0);
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fileStrip.Size = new System.Drawing.Size(1176, 40);
            this.fileStrip.TabIndex = 1;
            // 
            // downloadStrip
            // 
            this.downloadStrip.AutoSize = false;
            this.downloadStrip.BackColor = System.Drawing.Color.Transparent;
            this.downloadStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.downloadStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.downloadStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBtn,
            this.pauseBtn,
            this.stopBtn,
            this.toolStripSeparator2,
            this.openBrowserBtn,
            this.openExplorerBtn});
            this.downloadStrip.Location = new System.Drawing.Point(0, 40);
            this.downloadStrip.Name = "downloadStrip";
            this.downloadStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.downloadStrip.Size = new System.Drawing.Size(1176, 40);
            this.downloadStrip.TabIndex = 2;
            // 
            // startBtn
            // 
            this.startBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_control_play;
            this.startBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(114, 37);
            this.startBtn.Text = "Start/Resume";
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_control_pause;
            this.pauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(74, 37);
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_control_stop;
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(67, 37);
            this.stopBtn.Text = "Stop";
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // openBrowserBtn
            // 
            this.openBrowserBtn.Enabled = false;
            this.openBrowserBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_browser_wire;
            this.openBrowserBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBrowserBtn.Name = "openBrowserBtn";
            this.openBrowserBtn.Size = new System.Drawing.Size(130, 37);
            this.openBrowserBtn.Text = "Open in Browser";
            this.openBrowserBtn.Click += new System.EventHandler(this.OpenBrowserBtn_Click);
            // 
            // openExplorerBtn
            // 
            this.openExplorerBtn.Enabled = false;
            this.openExplorerBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_cabinet_variant;
            this.openExplorerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openExplorerBtn.Name = "openExplorerBtn";
            this.openExplorerBtn.Size = new System.Drawing.Size(121, 37);
            this.openExplorerBtn.Text = "Open Location";
            this.openExplorerBtn.Click += new System.EventHandler(this.OpenExplorerBtn_Click);
            // 
            // offlineLocationField
            // 
            this.offlineLocationField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offlineLocationField.Location = new System.Drawing.Point(35, 3);
            this.offlineLocationField.Name = "offlineLocationField";
            this.offlineLocationField.Size = new System.Drawing.Size(829, 20);
            this.offlineLocationField.TabIndex = 0;
            this.offlineLocationField.Text = "C:\\DLTest";
            // 
            // offlineLocationBtn
            // 
            this.offlineLocationBtn.BackgroundImage = global::WebsiteDownloader.Properties.Resources.appbar_folder_open;
            this.offlineLocationBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.offlineLocationBtn.Location = new System.Drawing.Point(3, 3);
            this.offlineLocationBtn.Name = "offlineLocationBtn";
            this.offlineLocationBtn.Size = new System.Drawing.Size(26, 20);
            this.offlineLocationBtn.TabIndex = 1;
            this.offlineLocationBtn.UseVisualStyleBackColor = true;
            this.offlineLocationBtn.Click += new System.EventHandler(this.OfflineLocationBtn_Click);
            // 
            // offlineLocationTable
            // 
            this.offlineLocationTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offlineLocationTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.offlineLocationTable.ColumnCount = 2;
            this.offlineLocationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.offlineLocationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.offlineLocationTable.Controls.Add(this.offlineLocationBtn, 0, 0);
            this.offlineLocationTable.Controls.Add(this.offlineLocationField, 1, 0);
            this.offlineLocationTable.Location = new System.Drawing.Point(153, 177);
            this.offlineLocationTable.Margin = new System.Windows.Forms.Padding(0);
            this.offlineLocationTable.Name = "offlineLocationTable";
            this.offlineLocationTable.RowCount = 1;
            this.offlineLocationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.offlineLocationTable.Size = new System.Drawing.Size(867, 77);
            this.offlineLocationTable.TabIndex = 11;
            // 
            // offlineLocationLbl
            // 
            this.offlineLocationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.offlineLocationLbl.Location = new System.Drawing.Point(3, 174);
            this.offlineLocationLbl.Name = "offlineLocationLbl";
            this.offlineLocationLbl.Size = new System.Drawing.Size(81, 13);
            this.offlineLocationLbl.TabIndex = 10;
            this.offlineLocationLbl.Text = "Offline Location";
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1176, 446);
            this.Controls.Add(this.downloadStrip);
            this.Controls.Add(this.fileStrip);
            this.Controls.Add(this.tabControl);
            this.Name = "MainUi";
            this.Text = "WebsiteDL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUi_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUi_FormClosed);
            this.Load += new System.EventHandler(this.MainUi_Load);
            this.tabControl.ResumeLayout(false);
            this.settingsPage.ResumeLayout(false);
            this.settingsTable.ResumeLayout(false);
            this.settingsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadDepthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelEditsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parallelDownloadsNum)).EndInit();
            this.progressPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.fileStrip.ResumeLayout(false);
            this.fileStrip.PerformLayout();
            this.downloadStrip.ResumeLayout(false);
            this.downloadStrip.PerformLayout();
            this.offlineLocationTable.ResumeLayout(false);
            this.offlineLocationTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label offlineLocationLbl;
        private System.Windows.Forms.TableLayoutPanel offlineLocationTable;
        private System.Windows.Forms.Button offlineLocationBtn;
        private System.Windows.Forms.TextBox offlineLocationField;
    }
}