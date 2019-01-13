using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace iRacingManager.Gui
{
    public partial class UpdateDialog : MaterialForm
    {

        #region Members


        private string _DownloadUri = string.Empty;
        private string _DownloadFileName = string.Empty;
        private string _CurrentVersion = string.Empty;
        private string _NewVersion = string.Empty;
        private bool _Downloading = false;
        private System.Net.WebClient _DownloadClient = null;

        #endregion

        #region Construction

        public UpdateDialog(string CurrentVersion, string NewVersion, string downloadUri, string downloadFileName)
        {
            InitializeComponent();

            this.materialLabelCurrentVersion.Text = CurrentVersion;
            this.materialLabelNewVersion.Text = NewVersion;
            this._DownloadUri = downloadUri;
            this._DownloadFileName = downloadFileName;
        }

        #endregion

        #region Methods

        protected virtual void OnUpdateDownloadCompleted()
        {
            if (UpdateDownloadCompleted != null)
            {
                UpdateDownloadCompleted(this, EventArgs.Empty);
            }
        }

        private void setDownloadMode()
        {
            this.materialProgressBarDownload.Visible = true;
            this.materialLabelDownload.Visible = true;

            this.materialRaisedButtonUpdate.Visible = false;
            this.materialFlatButtonCancel.Visible = false;

            this._Downloading = true;
        }

        private void startUpdateDownload()
        {
            try
            {
                this.setDownloadMode();

                string downloadFolder = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "iRacingManager", this._DownloadFileName);

                if (System.IO.File.Exists(downloadFolder))
                {
                    System.IO.File.Delete(downloadFolder);
                }

                this._DownloadClient = new System.Net.WebClient();
                this._DownloadClient.DownloadProgressChanged += Client_DownloadProgressChanged;
                this._DownloadClient.DownloadFileCompleted += Client_DownloadFileCompleted;
                this._DownloadClient.DownloadFileAsync(new Uri(this._DownloadUri + this._DownloadFileName), downloadFolder);
            } catch(Exception ex)
            {
                MessageBox.Show(this, "Error on downloading the update.", "Error on update",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Program.Logger.Error(ex, "Error on dowloading the update.");
            }
        }

        #endregion

        #region Eventhandler

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.OnUpdateDownloadCompleted();
        }

        private void Client_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            this.materialProgressBarDownload.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void materialRaisedButtonUpdate_Click(object sender, EventArgs e)
        {
            this.startUpdateDownload();
        }

        private void materialFlatButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        internal event EventHandler UpdateDownloadCompleted;

        #endregion

        private void UpdateDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._Downloading)
            {
                if (MessageBox.Show(this, "Do you want to cancel the download?", "Cancel download?", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this._DownloadClient?.CancelAsync();
                } else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
