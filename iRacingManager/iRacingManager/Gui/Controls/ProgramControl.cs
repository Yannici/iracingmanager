using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace iRacingManager.Gui.Controls
{
    public partial class ProgramControl : UserControl
    {

        #region Members

        [System.Runtime.InteropServices.DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        private Model.Program _Program = null;
        private Process _Process = null;
        private bool _StartStopAction = false;

        #endregion

        #region Construction

        public ProgramControl(Model.Program Program, System.Drawing.Text.PrivateFontCollection fontCollection)
        {
            InitializeComponent();

            this._Program = Program;
            this.programBindingSource.DataSource = this._Program;

            this.buttonStart.Font = new Font(fontCollection.Families[0], this.buttonStart.Font.Size);
        }

        #endregion

        #region Methods

        internal async void stop()
        {
            try
            {
                this._StartStopAction = true;
                if (await Task.Run(() => this.stopAsync()))
                {
                    this.setStopped();
                }
            } catch(Exception ex)
            {
                throw ex;
            } finally
            {
                this._StartStopAction = false;
            }
        }

        internal async void start()
        {
            try
            {
                this._StartStopAction = true;
                if (await Task.Run(() => this.startAsync()))
                {
                    this.setRunning();
                }
            } catch(Exception ex)
            {
                throw ex;
            } finally
            {
                this._StartStopAction = false;
            }
        }

        internal void setStopped()
        {
            this._Process = null;
            this.buttonStart.Text = "START";
            this.buttonStart.BackColor = Color.White;
            this.buttonStart.Enabled = true;
        }

        internal void updateState()
        {
            try
            {
                if (this._Process == null || this._Process.HasExited)
                {
                    this.setStopped();
                }
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        private bool stopAsync()
        {
            try
            {
                if (this._Process == null || this._Process.HasExited)
                {
                    this.setStopped();
                }

                this._Process.CloseMainWindow();
                this._Process.WaitForExit(5000);

                if (!this._Process.HasExited)
                {
                    this._Process.Kill();
                }

                return true;
            } catch
            {
                return false;
            }
        }

        private bool startAsync()
        {
            ProcessStartInfo psi = new ProcessStartInfo(System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName));

            if (this._Program.StartHidden)
            {
                psi.WindowStyle = ProcessWindowStyle.Hidden;
            }

            Process process = Process.Start(psi);
            process.WaitForInputIdle(10000); // 10 seconds wait for starting

            if (process.HasExited || !process.Responding)
            {
                return false;
            }

            if (!this._Program.StartHidden)
            {
                IntPtr h = process.MainWindowHandle;

                int timeoutCounter = 0;
                bool isVisible = false;
                while (!isVisible)
                {
                    h = process.MainWindowHandle;
                    isVisible = ProgramControl.IsWindowVisible(h);

                    if (!isVisible)
                    {
                        // Timeout 5 seconds
                        System.Threading.Thread.Sleep(100);
                        timeoutCounter += 1;
                    }

                    if (timeoutCounter >= 50)
                    {
                        break;
                    }
                }

                if (isVisible)
                {
                    ProgramControl.SetForegroundWindow(h);
                }
            }

            this._Process = process;
            return true;
        }

        private void setRunning()
        {
            this.buttonStart.Text = "RUNNING";
            this.buttonStart.BackColor = Color.LightGreen;
            this.buttonStart.Enabled = true;
        }

        private void checkProgramRunning()
        {
            Process[] processes = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(this._Program.FileName));
            if (processes.Any())
            {
                this._Process = processes.First();
                this.setRunning();
            }
        }

        #endregion

        #region Eventhandler

        private void ProgramControl_Load(object sender, EventArgs e)
        {
            this.pictureBoxPicture.Image = this._Program.Icon;
            this.pictureBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage;

            this.materialLabelName.Text = this._Program.DisplayName;
            this.materialSLTPath.Text = (string.IsNullOrEmpty(this._Program.InstallLocation)) ?
                this._Program.DisplayName + " not found" :
                System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName);

            this.buttonStart.Cursor = Cursors.Hand;
            this.checkProgramRunning();
        }

        private void materialFlatButtonSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.RestoreDirectory = true;
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                ofd.Multiselect = false;
                ofd.Title = "Select " + this._Program.DisplayName + " program ...";
                ofd.Filter = "Batch-File (*.bat;*.cmd)|*.bat;*.cmd|Executable-File (*.exe)|*.exe";
                ofd.FilterIndex = 2;

                if (ofd.ShowDialog(this.ParentForm) != DialogResult.OK)
                {
                    return;
                }

                this._Program.InstallLocation = System.IO.Path.GetDirectoryName(ofd.FileName);
                this._Program.FileName = System.IO.Path.GetFileName(ofd.FileName);
                this.materialSLTPath.Text = System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (this._Process == null || this._Process.HasExited)
            {
                this.buttonStart.BackColor = Color.LightBlue;
                this.buttonStart.Text = "STARTING ...";
                this.buttonStart.Enabled = false;
                this.start();
            } else
            {
                this.buttonStart.BackColor = Color.DarkRed;
                this.buttonStart.Text = "STOPPING ...";
                this.buttonStart.Enabled = false;
                this.buttonStart.Update();
                this.stop();
            }
        }

        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            if (this._Process != null && !this._Process.HasExited)
            {
                this.buttonStart.Text = "STOP";
                this.buttonStart.BackColor = Color.IndianRed;
            }
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            if (this._Process != null && !this._Process.HasExited && !this._StartStopAction)
            {
                this.buttonStart.Text = "RUNNING";
                this.buttonStart.BackColor = Color.LightGreen;
            }
        }

        #endregion
    }
}
