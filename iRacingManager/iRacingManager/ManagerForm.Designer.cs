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
            this.materialCheckBoxStartWithWindows = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timerCheckProcesses = new System.Windows.Forms.Timer(this.components);
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
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
            this.tabPageSettings.Controls.Add(this.materialCheckBoxStartWithWindows);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(782, 329);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // materialCheckBoxStartWithWindows
            // 
            this.materialCheckBoxStartWithWindows.AutoSize = true;
            this.materialCheckBoxStartWithWindows.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "StartWithWindows", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.materialCheckBoxStartWithWindows.Depth = 0;
            this.materialCheckBoxStartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(iRacingManager.Model.Settings.Settings);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControlMain);
            this.MinimumSize = new System.Drawing.Size(372, 300);
            this.Name = "ManagerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "iRacing Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.materialTabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource settingsBindingSource;
    }
}

