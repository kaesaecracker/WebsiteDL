namespace WebsiteDownloader.UI
{
    partial class MainUi
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.openBtn = new System.Windows.Forms.ToolStripButton();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.saveAsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBtn = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.form = new System.Windows.Forms.TableLayoutPanel();
            this.form_startUriLbl = new System.Windows.Forms.Label();
            this.form_startUriTxt = new System.Windows.Forms.TextBox();
            this.form_downloadDepthLbl = new System.Windows.Forms.Label();
            this.form_parallelEditsLbl = new System.Windows.Forms.Label();
            this.form_downloadDepthNum = new System.Windows.Forms.NumericUpDown();
            this.form_downloadTypesLbl = new System.Windows.Forms.Label();
            this.form_downloadTypesChkList = new System.Windows.Forms.CheckedListBox();
            this.form_parallelEditsNum = new System.Windows.Forms.NumericUpDown();
            this.form_parallelDownloadsLbl = new System.Windows.Forms.Label();
            this.form_parallelDownloadsNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fileStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.downloadStrip = new System.Windows.Forms.ToolStrip();
            this.startBtn = new System.Windows.Forms.ToolStripButton();
            this.pauseBtn = new System.Windows.Forms.ToolStripButton();
            this.stopBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripSeparator();
            this.openBrowserBtn = new System.Windows.Forms.ToolStripButton();
            this.openExplorerBtn = new System.Windows.Forms.ToolStripButton();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form_downloadDepthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_parallelEditsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_parallelDownloadsNum)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.fileStrip.SuspendLayout();
            this.downloadStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
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
            this.openBtn.Size = new System.Drawing.Size(93, 36);
            this.openBtn.Text = "Open File";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_save;
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(88, 36);
            this.saveBtn.Text = "Save File";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Enabled = false;
            this.saveAsBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_page_new;
            this.saveAsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(83, 36);
            this.saveAsBtn.Text = "Save As";
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_information_circle;
            this.aboutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(76, 36);
            this.aboutBtn.Text = "About";
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(583, 488);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 256);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.form);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // form
            // 
            this.form.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form.ColumnCount = 2;
            this.form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.form.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.form.Controls.Add(this.form_startUriLbl, 0, 0);
            this.form.Controls.Add(this.form_startUriTxt, 1, 0);
            this.form.Controls.Add(this.form_downloadDepthLbl, 0, 2);
            this.form.Controls.Add(this.form_parallelEditsLbl, 0, 4);
            this.form.Controls.Add(this.form_downloadDepthNum, 1, 2);
            this.form.Controls.Add(this.form_downloadTypesLbl, 0, 1);
            this.form.Controls.Add(this.form_downloadTypesChkList, 1, 1);
            this.form.Controls.Add(this.form_parallelEditsNum, 1, 4);
            this.form.Controls.Add(this.form_parallelDownloadsLbl, 0, 3);
            this.form.Controls.Add(this.form_parallelDownloadsNum, 1, 3);
            this.form.Controls.Add(this.label1, 0, 6);
            this.form.Controls.Add(this.tableLayoutPanel1, 1, 6);
            this.form.Location = new System.Drawing.Point(1, 6);
            this.form.Name = "form";
            this.form.RowCount = 7;
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.form.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.form.Size = new System.Drawing.Size(638, 218);
            this.form.TabIndex = 5;
            // 
            // form_startUriLbl
            // 
            this.form_startUriLbl.AutoSize = true;
            this.form_startUriLbl.Location = new System.Drawing.Point(3, 0);
            this.form_startUriLbl.Name = "form_startUriLbl";
            this.form_startUriLbl.Size = new System.Drawing.Size(51, 13);
            this.form_startUriLbl.TabIndex = 0;
            this.form_startUriLbl.Text = "Start-URI";
            // 
            // form_startUriTxt
            // 
            this.form_startUriTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_startUriTxt.Location = new System.Drawing.Point(153, 3);
            this.form_startUriTxt.Name = "form_startUriTxt";
            this.form_startUriTxt.Size = new System.Drawing.Size(482, 20);
            this.form_startUriTxt.TabIndex = 1;
            this.form_startUriTxt.Text = "https://wikipedia.org/";
            // 
            // form_downloadDepthLbl
            // 
            this.form_downloadDepthLbl.AutoSize = true;
            this.form_downloadDepthLbl.Location = new System.Drawing.Point(3, 96);
            this.form_downloadDepthLbl.Name = "form_downloadDepthLbl";
            this.form_downloadDepthLbl.Size = new System.Drawing.Size(87, 13);
            this.form_downloadDepthLbl.TabIndex = 4;
            this.form_downloadDepthLbl.Text = "Download Depth";
            // 
            // form_parallelEditsLbl
            // 
            this.form_parallelEditsLbl.AutoSize = true;
            this.form_parallelEditsLbl.Location = new System.Drawing.Point(3, 148);
            this.form_parallelEditsLbl.Name = "form_parallelEditsLbl";
            this.form_parallelEditsLbl.Size = new System.Drawing.Size(67, 13);
            this.form_parallelEditsLbl.TabIndex = 7;
            this.form_parallelEditsLbl.Text = "Parallel Edits";
            // 
            // form_downloadDepthNum
            // 
            this.form_downloadDepthNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_downloadDepthNum.Location = new System.Drawing.Point(153, 99);
            this.form_downloadDepthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.form_downloadDepthNum.Name = "form_downloadDepthNum";
            this.form_downloadDepthNum.Size = new System.Drawing.Size(482, 20);
            this.form_downloadDepthNum.TabIndex = 5;
            this.form_downloadDepthNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // form_downloadTypesLbl
            // 
            this.form_downloadTypesLbl.AutoSize = true;
            this.form_downloadTypesLbl.Location = new System.Drawing.Point(3, 26);
            this.form_downloadTypesLbl.Name = "form_downloadTypesLbl";
            this.form_downloadTypesLbl.Size = new System.Drawing.Size(99, 13);
            this.form_downloadTypesLbl.TabIndex = 2;
            this.form_downloadTypesLbl.Text = "Download file types";
            // 
            // form_downloadTypesChkList
            // 
            this.form_downloadTypesChkList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_downloadTypesChkList.FormattingEnabled = true;
            this.form_downloadTypesChkList.Items.AddRange(new object[] {
            "Images (<img src=* />)",
            "JavaScript (<script src=* ></script>)",
            "Stylesheets (<link rel=stylesheet href=* />)",
            "Objects (<object data=*>)"});
            this.form_downloadTypesChkList.Location = new System.Drawing.Point(153, 29);
            this.form_downloadTypesChkList.Name = "form_downloadTypesChkList";
            this.form_downloadTypesChkList.Size = new System.Drawing.Size(482, 64);
            this.form_downloadTypesChkList.TabIndex = 3;
            // 
            // form_parallelEditsNum
            // 
            this.form_parallelEditsNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_parallelEditsNum.Location = new System.Drawing.Point(153, 151);
            this.form_parallelEditsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.form_parallelEditsNum.Name = "form_parallelEditsNum";
            this.form_parallelEditsNum.Size = new System.Drawing.Size(482, 20);
            this.form_parallelEditsNum.TabIndex = 9;
            this.form_parallelEditsNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // form_parallelDownloadsLbl
            // 
            this.form_parallelDownloadsLbl.AutoSize = true;
            this.form_parallelDownloadsLbl.Location = new System.Drawing.Point(3, 122);
            this.form_parallelDownloadsLbl.Name = "form_parallelDownloadsLbl";
            this.form_parallelDownloadsLbl.Size = new System.Drawing.Size(97, 13);
            this.form_parallelDownloadsLbl.TabIndex = 6;
            this.form_parallelDownloadsLbl.Text = "Parallel Downloads";
            // 
            // form_parallelDownloadsNum
            // 
            this.form_parallelDownloadsNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.form_parallelDownloadsNum.Location = new System.Drawing.Point(153, 125);
            this.form_parallelDownloadsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.form_parallelDownloadsNum.Name = "form_parallelDownloadsNum";
            this.form_parallelDownloadsNum.Size = new System.Drawing.Size(482, 20);
            this.form_parallelDownloadsNum.TabIndex = 8;
            this.form_parallelDownloadsNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Offline Location";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(153, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 27);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(35, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WebsiteDownloader.Properties.Resources.appbar_folder_open;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Progress";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(569, 215);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Downloads in Queue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edits in Queue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Currently Downloading";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Currently Editing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Downloaded Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Edited Total";
            // 
            // fileStrip
            // 
            this.fileStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fileStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fileStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.saveAsBtn,
            this.toolStripSeparator1,
            this.aboutBtn,
            this.toolStripDropDownButton1});
            this.fileStrip.Location = new System.Drawing.Point(0, 0);
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fileStrip.Size = new System.Drawing.Size(371, 39);
            this.fileStrip.TabIndex = 1;
            this.fileStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 36);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // downloadStrip
            // 
            this.downloadStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.downloadStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.downloadStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startBtn,
            this.pauseBtn,
            this.stopBtn,
            this.toolStripButton7,
            this.openBrowserBtn,
            this.openExplorerBtn});
            this.downloadStrip.Location = new System.Drawing.Point(0, 39);
            this.downloadStrip.Name = "downloadStrip";
            this.downloadStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.downloadStrip.Size = new System.Drawing.Size(524, 39);
            this.downloadStrip.TabIndex = 2;
            this.downloadStrip.Text = "toolStrip2";
            // 
            // startBtn
            // 
            this.startBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_control_play;
            this.startBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(114, 36);
            this.startBtn.Text = "Start/Resume";
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_control_pause;
            this.pauseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(74, 36);
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_control_stop;
            this.stopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(67, 36);
            this.stopBtn.Text = "Stop";
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(6, 39);
            // 
            // openBrowserBtn
            // 
            this.openBrowserBtn.Enabled = false;
            this.openBrowserBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_browser_wire;
            this.openBrowserBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openBrowserBtn.Name = "openBrowserBtn";
            this.openBrowserBtn.Size = new System.Drawing.Size(130, 36);
            this.openBrowserBtn.Text = "Open in Browser";
            this.openBrowserBtn.Click += new System.EventHandler(this.openBrowserBtn_Click);
            // 
            // openExplorerBtn
            // 
            this.openExplorerBtn.Enabled = false;
            this.openExplorerBtn.Image = global::WebsiteDownloader.Properties.Resources.appbar_cabinet_variant;
            this.openExplorerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openExplorerBtn.Name = "openExplorerBtn";
            this.openExplorerBtn.Size = new System.Drawing.Size(121, 36);
            this.openExplorerBtn.Text = "Open Location";
            this.openExplorerBtn.Click += new System.EventHandler(this.openExplorerBtn_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            this.openFileDlg.Filter = "WebsiteDL Projects|*.wdlp,*.xml";
            this.openFileDlg.SupportMultiDottedExtensions = true;
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 336);
            this.Controls.Add(this.downloadStrip);
            this.Controls.Add(this.fileStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainUi";
            this.Text = "WebsiteDL";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form_downloadDepthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_parallelEditsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form_parallelDownloadsNum)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.fileStrip.ResumeLayout(false);
            this.fileStrip.PerformLayout();
            this.downloadStrip.ResumeLayout(false);
            this.downloadStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton openBtn;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.ToolStripButton saveAsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton aboutBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel form;
        private System.Windows.Forms.Label form_startUriLbl;
        private System.Windows.Forms.TextBox form_startUriTxt;
        private System.Windows.Forms.Label form_downloadDepthLbl;
        private System.Windows.Forms.Label form_parallelEditsLbl;
        private System.Windows.Forms.NumericUpDown form_downloadDepthNum;
        private System.Windows.Forms.Label form_downloadTypesLbl;
        private System.Windows.Forms.CheckedListBox form_downloadTypesChkList;
        private System.Windows.Forms.NumericUpDown form_parallelEditsNum;
        private System.Windows.Forms.Label form_parallelDownloadsLbl;
        private System.Windows.Forms.NumericUpDown form_parallelDownloadsNum;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip fileStrip;
        private System.Windows.Forms.ToolStrip downloadStrip;
        private System.Windows.Forms.ToolStripButton startBtn;
        private System.Windows.Forms.ToolStripButton stopBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripButton7;
        private System.Windows.Forms.ToolStripButton openBrowserBtn;
        private System.Windows.Forms.ToolStripButton openExplorerBtn;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton pauseBtn;
    }
}