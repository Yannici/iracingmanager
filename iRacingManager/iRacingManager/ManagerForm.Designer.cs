namespace iRacingManager
{
    partial class ManagerForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.materialTabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.panelActions = new System.Windows.Forms.Panel();
            this.materialFlatButtonStopAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButtonStartAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.flowLayoutPanelPrograms = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.materialCheckBoxMinimizedWindowsStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabelCurrentVersionValue = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCurrentVersion = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButtonCheckUpdates = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialCheckBoxMinimizeTray = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBoxSystemTray = new MaterialSkin.Controls.MaterialCheckBox();
            this.labelThanks = new System.Windows.Forms.Label();
            this.labelInfoTitle = new System.Windows.Forms.Label();
            this.linkLabelMembersite = new System.Windows.Forms.LinkLabel();
            this.materialLabelInfo1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckBoxStartWithWindows = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timerCheckProcesses = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.startAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialTabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.contextMenuStripTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControlMain
            // 
            this.materialTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControlMain.Controls.Add(this.tabPageMain);
            this.materialTabControlMain.Controls.Add(this.tabPageSettings);
            this.materialTabControlMain.Depth = 0;
            this.materialTabControlMain.Location = new System.Drawing.Point(5, 91);
            this.materialTabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlMain.Name = "materialTabControlMain";
            this.materialTabControlMain.SelectedIndex = 0;
            this.materialTabControlMain.Size = new System.Drawing.Size(790, 355);
            this.materialTabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.Controls.Add(this.panelActions);
            this.tabPageMain.Controls.Add(this.flowLayoutPanelPrograms);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(782, 329);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Start";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.materialFlatButtonStopAll);
            this.panelActions.Controls.Add(this.materialFlatButtonStartAll);
            this.panelActions.Location = new System.Drawing.Point(2, 3);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(777, 46);
            this.panelActions.TabIndex = 3;
            // 
            // materialFlatButtonStopAll
            // 
            this.materialFlatButtonStopAll.AutoSize = true;
            this.materialFlatButtonStopAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonStopAll.Depth = 0;
            this.materialFlatButtonStopAll.Icon = global::iRacingManager.Properties.Resources.stop;
            this.materialFlatButtonStopAll.Location = new System.Drawing.Point(131, 6);
            this.materialFlatButtonStopAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonStopAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonStopAll.Name = "materialFlatButtonStopAll";
            this.materialFlatButtonStopAll.Primary = false;
            this.materialFlatButtonStopAll.Size = new System.Drawing.Size(111, 36);
            this.materialFlatButtonStopAll.TabIndex = 1;
            this.materialFlatButtonStopAll.Text = "Stop all";
            this.materialFlatButtonStopAll.UseVisualStyleBackColor = true;
            this.materialFlatButtonStopAll.Click += new System.EventHandler(this.materialFlatButtonStopAll_Click);
            // 
            // materialFlatButtonStartAll
            // 
            this.materialFlatButtonStartAll.AutoSize = true;
            this.materialFlatButtonStartAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonStartAll.Depth = 0;
            this.materialFlatButtonStartAll.Icon = ((System.Drawing.Image)(resources.GetObject("materialFlatButtonStartAll.Icon")));
            this.materialFlatButtonStartAll.Location = new System.Drawing.Point(4, 6);
            this.materialFlatButtonStartAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonStartAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonStartAll.Name = "materialFlatButtonStartAll";
            this.materialFlatButtonStartAll.Primary = false;
            this.materialFlatButtonStartAll.Size = new System.Drawing.Size(119, 36);
            this.materialFlatButtonStartAll.TabIndex = 0;
            this.materialFlatButtonStartAll.Text = "Start all";
            this.materialFlatButtonStartAll.UseVisualStyleBackColor = true;
            this.materialFlatButtonStartAll.Click += new System.EventHandler(this.materialFlatButtonStartAll_Click);
            // 
            // flowLayoutPanelPrograms
            // 
            this.flowLayoutPanelPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelPrograms.AutoScroll = true;
            this.flowLayoutPanelPrograms.Location = new System.Drawing.Point(3, 48);
            this.flowLayoutPanelPrograms.Name = "flowLayoutPanelPrograms";
            this.flowLayoutPanelPrograms.Size = new System.Drawing.Size(776, 292);
            this.flowLayoutPanelPrograms.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.materialCheckBoxMinimizedWindowsStart);
            this.tabPageSettings.Controls.Add(this.materialLabelCurrentVersionValue);
            this.tabPageSettings.Controls.Add(this.materialLabelCurrentVersion);
            this.tabPageSettings.Controls.Add(this.materialFlatButtonCheckUpdates);
            this.tabPageSettings.Controls.Add(this.materialCheckBoxMinimizeTray);
            this.tabPageSettings.Controls.Add(this.materialCheckBoxSystemTray);
            this.tabPageSettings.Controls.Add(this.labelThanks);
            this.tabPageSettings.Controls.Add(this.labelInfoTitle);
            this.tabPageSettings.Controls.Add(this.linkLabelMembersite);
            this.tabPageSettings.Controls.Add(this.materialLabelInfo1);
            this.tabPageSettings.Controls.Add(this.materialCheckBoxStartWithWindows);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(782, 329);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings & Info";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // materialCheckBoxMinimizedWindowsStart
            // 
            this.materialCheckBoxMinimizedWindowsStart.AutoSize = true;
            this.materialCheckBoxMinimizedWindowsStart.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "StartWithWindowsMinimized", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxMinimizedWindowsStart.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", this.settingsBindingSource, "StartWithWindows", true));
            this.materialCheckBoxMinimizedWindowsStart.Depth = 0;
            this.materialCheckBoxMinimizedWindowsStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxMinimizedWindowsStart.Location = new System.Drawing.Point(29, 45);
            this.materialCheckBoxMinimizedWindowsStart.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxMinimizedWindowsStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxMinimizedWindowsStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxMinimizedWindowsStart.Name = "materialCheckBoxMinimizedWindowsStart";
            this.materialCheckBoxMinimizedWindowsStart.Ripple = true;
            this.materialCheckBoxMinimizedWindowsStart.Size = new System.Drawing.Size(94, 30);
            this.materialCheckBoxMinimizedWindowsStart.TabIndex = 12;
            this.materialCheckBoxMinimizedWindowsStart.Text = "minimized";
            this.materialCheckBoxMinimizedWindowsStart.UseVisualStyleBackColor = true;
            this.materialCheckBoxMinimizedWindowsStart.CheckStateChanged += new System.EventHandler(this.materialCheckBoxStartWithWindows_CheckStateChanged);
            // 
            // materialLabelCurrentVersionValue
            // 
            this.materialLabelCurrentVersionValue.AutoSize = true;
            this.materialLabelCurrentVersionValue.Depth = 0;
            this.materialLabelCurrentVersionValue.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCurrentVersionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCurrentVersionValue.Location = new System.Drawing.Point(129, 217);
            this.materialLabelCurrentVersionValue.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCurrentVersionValue.Name = "materialLabelCurrentVersionValue";
            this.materialLabelCurrentVersionValue.Size = new System.Drawing.Size(41, 19);
            this.materialLabelCurrentVersionValue.TabIndex = 11;
            this.materialLabelCurrentVersionValue.Text = "0.0.0";
            // 
            // materialLabelCurrentVersion
            // 
            this.materialLabelCurrentVersion.AutoSize = true;
            this.materialLabelCurrentVersion.Depth = 0;
            this.materialLabelCurrentVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCurrentVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCurrentVersion.Location = new System.Drawing.Point(8, 217);
            this.materialLabelCurrentVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCurrentVersion.Name = "materialLabelCurrentVersion";
            this.materialLabelCurrentVersion.Size = new System.Drawing.Size(115, 19);
            this.materialLabelCurrentVersion.TabIndex = 10;
            this.materialLabelCurrentVersion.Text = "Current version:";
            // 
            // materialFlatButtonCheckUpdates
            // 
            this.materialFlatButtonCheckUpdates.AutoSize = true;
            this.materialFlatButtonCheckUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonCheckUpdates.Depth = 0;
            this.materialFlatButtonCheckUpdates.Icon = null;
            this.materialFlatButtonCheckUpdates.Location = new System.Drawing.Point(12, 175);
            this.materialFlatButtonCheckUpdates.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonCheckUpdates.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonCheckUpdates.Name = "materialFlatButtonCheckUpdates";
            this.materialFlatButtonCheckUpdates.Primary = false;
            this.materialFlatButtonCheckUpdates.Size = new System.Drawing.Size(158, 36);
            this.materialFlatButtonCheckUpdates.TabIndex = 9;
            this.materialFlatButtonCheckUpdates.Text = "Check for updates";
            this.materialFlatButtonCheckUpdates.UseVisualStyleBackColor = true;
            this.materialFlatButtonCheckUpdates.Click += new System.EventHandler(this.materialFlatButtonCheckUpdates_Click);
            // 
            // materialCheckBoxMinimizeTray
            // 
            this.materialCheckBoxMinimizeTray.AutoSize = true;
            this.materialCheckBoxMinimizeTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "MinimizeToSystemTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxMinimizeTray.Depth = 0;
            this.materialCheckBoxMinimizeTray.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxMinimizeTray.Location = new System.Drawing.Point(347, 15);
            this.materialCheckBoxMinimizeTray.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxMinimizeTray.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxMinimizeTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxMinimizeTray.Name = "materialCheckBoxMinimizeTray";
            this.materialCheckBoxMinimizeTray.Ripple = true;
            this.materialCheckBoxMinimizeTray.Size = new System.Drawing.Size(177, 30);
            this.materialCheckBoxMinimizeTray.TabIndex = 8;
            this.materialCheckBoxMinimizeTray.Text = "Minimize to system tray";
            this.materialCheckBoxMinimizeTray.UseVisualStyleBackColor = true;
            // 
            // materialCheckBoxSystemTray
            // 
            this.materialCheckBoxSystemTray.AutoSize = true;
            this.materialCheckBoxSystemTray.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "CloseToSystemTray", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxSystemTray.Depth = 0;
            this.materialCheckBoxSystemTray.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxSystemTray.Location = new System.Drawing.Point(177, 15);
            this.materialCheckBoxSystemTray.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxSystemTray.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxSystemTray.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxSystemTray.Name = "materialCheckBoxSystemTray";
            this.materialCheckBoxSystemTray.Ripple = true;
            this.materialCheckBoxSystemTray.Size = new System.Drawing.Size(156, 30);
            this.materialCheckBoxSystemTray.TabIndex = 7;
            this.materialCheckBoxSystemTray.Text = "Close to system tray";
            this.materialCheckBoxSystemTray.UseVisualStyleBackColor = true;
            // 
            // labelThanks
            // 
            this.labelThanks.AutoSize = true;
            this.labelThanks.Location = new System.Drawing.Point(9, 156);
            this.labelThanks.Name = "labelThanks";
            this.labelThanks.Size = new System.Drawing.Size(255, 13);
            this.labelThanks.TabIndex = 6;
            this.labelThanks.Text = "Thanks to Nick Thissen for the iRacingSDKWrapper";
            // 
            // labelInfoTitle
            // 
            this.labelInfoTitle.AutoSize = true;
            this.labelInfoTitle.Location = new System.Drawing.Point(6, 100);
            this.labelInfoTitle.Name = "labelInfoTitle";
            this.labelInfoTitle.Size = new System.Drawing.Size(59, 13);
            this.labelInfoTitle.TabIndex = 5;
            this.labelInfoTitle.Text = "Information";
            // 
            // linkLabelMembersite
            // 
            this.linkLabelMembersite.AutoSize = true;
            this.linkLabelMembersite.Location = new System.Drawing.Point(194, 135);
            this.linkLabelMembersite.Name = "linkLabelMembersite";
            this.linkLabelMembersite.Size = new System.Drawing.Size(82, 13);
            this.linkLabelMembersite.TabIndex = 3;
            this.linkLabelMembersite.TabStop = true;
            this.linkLabelMembersite.Text = "Yannic Schnetz";
            this.linkLabelMembersite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMembersite_LinkClicked);
            // 
            // materialLabelInfo1
            // 
            this.materialLabelInfo1.AutoSize = true;
            this.materialLabelInfo1.Depth = 0;
            this.materialLabelInfo1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelInfo1.Location = new System.Drawing.Point(8, 135);
            this.materialLabelInfo1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo1.Name = "materialLabelInfo1";
            this.materialLabelInfo1.Size = new System.Drawing.Size(189, 19);
            this.materialLabelInfo1.TabIndex = 2;
            this.materialLabelInfo1.Text = "iRacingManager created by";
            // 
            // materialCheckBoxStartWithWindows
            // 
            this.materialCheckBoxStartWithWindows.AutoSize = true;
            this.materialCheckBoxStartWithWindows.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "StartWithWindows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxStartWithWindows.Depth = 0;
            this.materialCheckBoxStartWithWindows.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxStartWithWindows.Location = new System.Drawing.Point(14, 15);
            this.materialCheckBoxStartWithWindows.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxStartWithWindows.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxStartWithWindows.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxStartWithWindows.Name = "materialCheckBoxStartWithWindows";
            this.materialCheckBoxStartWithWindows.Ripple = true;
            this.materialCheckBoxStartWithWindows.Size = new System.Drawing.Size(147, 30);
            this.materialCheckBoxStartWithWindows.TabIndex = 0;
            this.materialCheckBoxStartWithWindows.Text = "Start with windows";
            this.materialCheckBoxStartWithWindows.UseVisualStyleBackColor = true;
            this.materialCheckBoxStartWithWindows.CheckStateChanged += new System.EventHandler(this.materialCheckBoxStartWithWindows_CheckStateChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControlMain;
            this.materialTabSelector1.Cursor = System.Windows.Forms.Cursors.Default;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(800, 30);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // timerCheckProcesses
            // 
            this.timerCheckProcesses.Interval = 500;
            this.timerCheckProcesses.Tick += new System.EventHandler(this.timerCheckProcesses_Tick);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::iRacingManager.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(734, 31);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(54, 54);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.ContextMenuStrip = this.contextMenuStripTray;
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "iRacingManager";
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconTray_MouseDoubleClick);
            // 
            // contextMenuStripTray
            // 
            this.contextMenuStripTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.startAllToolStripMenuItem,
            this.stopAllToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStripTray.Name = "contextMenuStripTray";
            this.contextMenuStripTray.Size = new System.Drawing.Size(114, 104);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(110, 6);
            // 
            // startAllToolStripMenuItem
            // 
            this.startAllToolStripMenuItem.Image = global::iRacingManager.Properties.Resources.start;
            this.startAllToolStripMenuItem.Name = "startAllToolStripMenuItem";
            this.startAllToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.startAllToolStripMenuItem.Text = "Start all";
            this.startAllToolStripMenuItem.Click += new System.EventHandler(this.startAllToolStripMenuItem_Click);
            // 
            // stopAllToolStripMenuItem
            // 
            this.stopAllToolStripMenuItem.Image = global::iRacingManager.Properties.Resources.stop;
            this.stopAllToolStripMenuItem.Name = "stopAllToolStripMenuItem";
            this.stopAllToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.stopAllToolStripMenuItem.Text = "Stop all";
            this.stopAllToolStripMenuItem.Click += new System.EventHandler(this.stopAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(110, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(372, 300);
            this.Name = "ManagerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "iRacing Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.Resize += new System.EventHandler(this.ManagerForm_Resize);
            this.materialTabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.contextMenuStripTray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSettings;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPrograms;
        private System.Windows.Forms.Timer timerCheckProcesses;
        private System.Windows.Forms.Panel panelActions;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonStartAll;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonStopAll;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxStartWithWindows;
        private MaterialSkin.Controls.MaterialLabel materialLabelInfo1;
        private System.Windows.Forms.LinkLabel linkLabelMembersite;
        private System.Windows.Forms.Label labelInfoTitle;
        private System.Windows.Forms.Label labelThanks;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxSystemTray;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTray;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxMinimizeTray;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonCheckUpdates;
        private MaterialSkin.Controls.MaterialLabel materialLabelCurrentVersionValue;
        private MaterialSkin.Controls.MaterialLabel materialLabelCurrentVersion;
        private System.Windows.Forms.ToolStripMenuItem startAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxMinimizedWindowsStart;
    }
}

