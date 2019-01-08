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
            this.flowLayoutPanelPrograms = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timerCheckProcesses = new System.Windows.Forms.Timer(this.components);
            this.panelActions = new System.Windows.Forms.Panel();
            this.materialFlatButtonStopAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButtonStartAll = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControlMain
            // 
            this.materialTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControlMain.Controls.Add(this.tabPageMain);
            this.materialTabControlMain.Controls.Add(this.tabPage2);
            this.materialTabControlMain.Depth = 0;
            this.materialTabControlMain.Location = new System.Drawing.Point(5, 125);
            this.materialTabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlMain.Name = "materialTabControlMain";
            this.materialTabControlMain.SelectedIndex = 0;
            this.materialTabControlMain.Size = new System.Drawing.Size(790, 321);
            this.materialTabControlMain.TabIndex = 0;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.Controls.Add(this.flowLayoutPanelPrograms);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(782, 295);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Start";
            // 
            // flowLayoutPanelPrograms
            // 
            this.flowLayoutPanelPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPrograms.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelPrograms.Name = "flowLayoutPanelPrograms";
            this.flowLayoutPanelPrograms.Size = new System.Drawing.Size(776, 289);
            this.flowLayoutPanelPrograms.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(782, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // panelActions
            // 
            this.panelActions.Controls.Add(this.materialFlatButtonStopAll);
            this.panelActions.Controls.Add(this.materialFlatButtonStartAll);
            this.panelActions.Location = new System.Drawing.Point(15, 100);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(776, 46);
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
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControlMain);
            this.MinimumSize = new System.Drawing.Size(355, 300);
            this.Name = "ManagerForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "iRacing Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.materialTabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPrograms;
        private System.Windows.Forms.Timer timerCheckProcesses;
        private System.Windows.Forms.Panel panelActions;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonStartAll;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonStopAll;
    }
}

