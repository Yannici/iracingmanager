namespace iRacingManager.Gui
{
    partial class UpdateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDialog));
            this.materialLabelNewUpdate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCurrentLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelCurrentVersion = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelNewVersionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelNewVersion = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButtonUpdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButtonCancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialProgressBarDownload = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialLabelDownload = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabelNewUpdate
            // 
            this.materialLabelNewUpdate.AutoSize = true;
            this.materialLabelNewUpdate.BackColor = System.Drawing.Color.White;
            this.materialLabelNewUpdate.Depth = 0;
            this.materialLabelNewUpdate.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNewUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelNewUpdate.Location = new System.Drawing.Point(57, 73);
            this.materialLabelNewUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNewUpdate.Name = "materialLabelNewUpdate";
            this.materialLabelNewUpdate.Size = new System.Drawing.Size(182, 19);
            this.materialLabelNewUpdate.TabIndex = 0;
            this.materialLabelNewUpdate.Text = "A new update is available!";
            // 
            // materialLabelCurrentLabel
            // 
            this.materialLabelCurrentLabel.AutoSize = true;
            this.materialLabelCurrentLabel.BackColor = System.Drawing.Color.White;
            this.materialLabelCurrentLabel.Depth = 0;
            this.materialLabelCurrentLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCurrentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCurrentLabel.Location = new System.Drawing.Point(12, 101);
            this.materialLabelCurrentLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCurrentLabel.Name = "materialLabelCurrentLabel";
            this.materialLabelCurrentLabel.Size = new System.Drawing.Size(115, 19);
            this.materialLabelCurrentLabel.TabIndex = 1;
            this.materialLabelCurrentLabel.Text = "Current version:";
            // 
            // materialLabelCurrentVersion
            // 
            this.materialLabelCurrentVersion.AutoSize = true;
            this.materialLabelCurrentVersion.BackColor = System.Drawing.Color.White;
            this.materialLabelCurrentVersion.Depth = 0;
            this.materialLabelCurrentVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelCurrentVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelCurrentVersion.Location = new System.Drawing.Point(133, 101);
            this.materialLabelCurrentVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCurrentVersion.Name = "materialLabelCurrentVersion";
            this.materialLabelCurrentVersion.Size = new System.Drawing.Size(41, 19);
            this.materialLabelCurrentVersion.TabIndex = 2;
            this.materialLabelCurrentVersion.Text = "0.0.0";
            // 
            // materialLabelNewVersionLabel
            // 
            this.materialLabelNewVersionLabel.AutoSize = true;
            this.materialLabelNewVersionLabel.BackColor = System.Drawing.Color.White;
            this.materialLabelNewVersionLabel.Depth = 0;
            this.materialLabelNewVersionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNewVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelNewVersionLabel.Location = new System.Drawing.Point(31, 129);
            this.materialLabelNewVersionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNewVersionLabel.Name = "materialLabelNewVersionLabel";
            this.materialLabelNewVersionLabel.Size = new System.Drawing.Size(96, 19);
            this.materialLabelNewVersionLabel.TabIndex = 3;
            this.materialLabelNewVersionLabel.Text = "New version:";
            // 
            // materialLabelNewVersion
            // 
            this.materialLabelNewVersion.AutoSize = true;
            this.materialLabelNewVersion.BackColor = System.Drawing.Color.White;
            this.materialLabelNewVersion.Depth = 0;
            this.materialLabelNewVersion.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelNewVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelNewVersion.Location = new System.Drawing.Point(133, 129);
            this.materialLabelNewVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelNewVersion.Name = "materialLabelNewVersion";
            this.materialLabelNewVersion.Size = new System.Drawing.Size(41, 19);
            this.materialLabelNewVersion.TabIndex = 4;
            this.materialLabelNewVersion.Text = "0.0.0";
            // 
            // materialRaisedButtonUpdate
            // 
            this.materialRaisedButtonUpdate.AutoSize = true;
            this.materialRaisedButtonUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButtonUpdate.Depth = 0;
            this.materialRaisedButtonUpdate.Icon = null;
            this.materialRaisedButtonUpdate.Location = new System.Drawing.Point(12, 162);
            this.materialRaisedButtonUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButtonUpdate.Name = "materialRaisedButtonUpdate";
            this.materialRaisedButtonUpdate.Primary = true;
            this.materialRaisedButtonUpdate.Size = new System.Drawing.Size(77, 36);
            this.materialRaisedButtonUpdate.TabIndex = 5;
            this.materialRaisedButtonUpdate.Text = "Update!";
            this.materialRaisedButtonUpdate.UseVisualStyleBackColor = true;
            this.materialRaisedButtonUpdate.Click += new System.EventHandler(this.materialRaisedButtonUpdate_Click);
            // 
            // materialFlatButtonCancel
            // 
            this.materialFlatButtonCancel.AutoSize = true;
            this.materialFlatButtonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButtonCancel.Depth = 0;
            this.materialFlatButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.materialFlatButtonCancel.Icon = null;
            this.materialFlatButtonCancel.Location = new System.Drawing.Point(208, 162);
            this.materialFlatButtonCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButtonCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButtonCancel.Name = "materialFlatButtonCancel";
            this.materialFlatButtonCancel.Primary = false;
            this.materialFlatButtonCancel.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButtonCancel.TabIndex = 6;
            this.materialFlatButtonCancel.Text = "Cancel";
            this.materialFlatButtonCancel.UseVisualStyleBackColor = true;
            this.materialFlatButtonCancel.Click += new System.EventHandler(this.materialFlatButtonCancel_Click);
            // 
            // materialProgressBarDownload
            // 
            this.materialProgressBarDownload.Depth = 0;
            this.materialProgressBarDownload.Location = new System.Drawing.Point(12, 193);
            this.materialProgressBarDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBarDownload.Name = "materialProgressBarDownload";
            this.materialProgressBarDownload.Size = new System.Drawing.Size(269, 5);
            this.materialProgressBarDownload.TabIndex = 7;
            this.materialProgressBarDownload.Visible = false;
            // 
            // materialLabelDownload
            // 
            this.materialLabelDownload.AutoSize = true;
            this.materialLabelDownload.BackColor = System.Drawing.Color.White;
            this.materialLabelDownload.Depth = 0;
            this.materialLabelDownload.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabelDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabelDownload.Location = new System.Drawing.Point(88, 170);
            this.materialLabelDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDownload.Name = "materialLabelDownload";
            this.materialLabelDownload.Size = new System.Drawing.Size(112, 19);
            this.materialLabelDownload.TabIndex = 8;
            this.materialLabelDownload.Text = "Downloading ...";
            this.materialLabelDownload.Visible = false;
            // 
            // UpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.materialFlatButtonCancel;
            this.ClientSize = new System.Drawing.Size(294, 210);
            this.Controls.Add(this.materialLabelDownload);
            this.Controls.Add(this.materialProgressBarDownload);
            this.Controls.Add(this.materialFlatButtonCancel);
            this.Controls.Add(this.materialRaisedButtonUpdate);
            this.Controls.Add(this.materialLabelNewVersion);
            this.Controls.Add(this.materialLabelNewVersionLabel);
            this.Controls.Add(this.materialLabelCurrentVersion);
            this.Controls.Add(this.materialLabelCurrentLabel);
            this.Controls.Add(this.materialLabelNewUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.Text = "Update available";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelNewUpdate;
        private MaterialSkin.Controls.MaterialLabel materialLabelCurrentLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabelCurrentVersion;
        private MaterialSkin.Controls.MaterialLabel materialLabelNewVersionLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabelNewVersion;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButtonUpdate;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButtonCancel;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBarDownload;
        private MaterialSkin.Controls.MaterialLabel materialLabelDownload;
    }
}