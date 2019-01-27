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
using System.Runtime.InteropServices;

namespace iRacingManager.Gui.Controls
{

    /// <summary>
    /// Control which displays the program information and to starting/stopping the program.
    /// </summary>
    public partial class ProgramControl : UserControl
    {

        #region Members

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindowVisible(IntPtr hWnd);

        private Model.Program _Program = null;
        private Process _Process = null;
        private bool _StartStopAction = false;
        private Model.Program.ProcessState _CurrentState = Model.Program.ProcessState.NOTEXISTING;

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

        /// <summary>
        /// Stops the program and updates the control.
        /// </summary>
        internal async void stop()
        {
            try
            {
                this._StartStopAction = true;
                this.buttonStart.BackColor = Color.DarkRed;
                this.buttonStart.Text = "STOPPING ...";
                this.buttonStart.Enabled = false;       
                if (await Task.Run(() => this.stopAsync()))
                {
                    this.setStopped();
                } else 
                {
                    this.setRunning();
                }
            } catch(Exception ex)
            {
                throw ex;
            } finally
            {
                this.buttonStart.Enabled = true;
                this._StartStopAction = false;
            }
        }

        /// <summary>
        /// Starts the program and updates the control.
        /// </summary>
        internal async void start()
        {
            try
            {
                this.buttonStart.BackColor = Color.LightBlue;
                this.buttonStart.Text = "STARTING ...";
                this.buttonStart.Enabled = false;

                this._StartStopAction = true;
                this.buttonStart.Enabled = false;
                if (await Task.Run(() => this.startAsync()))
                {
                    this.setRunning();
                } else
                {
                    this.setStopped();
                }
            } catch(Exception ex)
            {
                throw ex;
            } finally
            {
                this._StartStopAction = false;
                this.buttonStart.Enabled = true;
            }
        }

        /// <summary>
        /// Set start button to stopped (Text: START)
        /// </summary>
        internal void setStopped()
        {
            this._Process = null;
            this.buttonStart.Text = "START";
            this.buttonStart.BackColor = Color.WhiteSmoke;
            this.buttonStart.Enabled = true;
            this.materialFlatButtonModify.Enabled = true;
            this._CurrentState = Model.Program.ProcessState.STOPPED;
        }

        /// <summary>
        /// Updates the control by state.
        /// </summary>
        internal void updateState()
        {
            try
            {
                if (this.State == Model.Program.ProcessState.STOPPED)
                {
                    this.checkProgramRunning();
                }

                if (this.State != this._CurrentState)
                {
                    switch(this.State)
                    {
                        case Model.Program.ProcessState.STOPPED:
                            this.Invoke(new Action(() => this.setStopped()));
                            break;
                        case Model.Program.ProcessState.RUNNING:
                            this.Invoke(new Action(() => this.setRunning()));
                            break;
                        default:
                            break;
                    }
                }
            } catch(Exception ex)
            {
                throw new Exception("Error on updating program control state", ex);
            }
        }

        /// <summary>
        /// Stops the program async.
        /// </summary>
        /// <returns></returns>
        private bool stopAsync()
        {
            try
            {
                if (this._CurrentState != Model.Program.ProcessState.RUNNING || (this._Process == null || this._Process.HasExited))
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

        /// <summary>
        /// Starts the program async.
        /// </summary>
        /// <returns></returns>
        private bool startAsync()
        {
            ProcessStartInfo psi = new ProcessStartInfo(System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName));
            Process process = null;

            try
            {
                if (this._Program.StartHidden)
                {
                    psi.WindowStyle = ProcessWindowStyle.Hidden;
                    psi.CreateNoWindow = true;
                }

                psi.WorkingDirectory = this._Program.InstallLocation;
                psi.Arguments = this._Program.Arguments;

                process = Process.Start(psi);
            } catch(InvalidOperationException)
            {
                psi.UseShellExecute = false;
                process = Process.Start(psi);
            }

            if (process == null)
            {
                return false;
            }

            process.OutputDataReceived += Process_OutputDataReceived;
            try
            {
                process.WaitForInputIdle(10000); // 10 seconds wait for starting
            } catch (InvalidOperationException)
            {
                // Terminal application do not have an input to wait
            }
            

            if (process.HasExited || !process.Responding)
            {
                return false;
            }

            // If program is visible, wait for the window to set it in the foreground.
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

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        /// <summary>
        /// Sets the start button to running (Text: running)
        /// </summary>
        private void setRunning()
        {
            this.buttonStart.Text = "RUNNING";
            this.buttonStart.BackColor = Color.LightGreen;
            this.buttonStart.Enabled = true;
            this.materialFlatButtonModify.Enabled = false;
            this._CurrentState = Model.Program.ProcessState.RUNNING;
        }

        /// <summary>
        /// Sets the start button to not exists (Text: not found)
        /// </summary>
        private void setNotExist()
        {
            this.buttonStart.Text = "NOT FOUND";
            this.buttonStart.BackColor = Color.Gray;
            this.buttonStart.Enabled = false;
        }


        /// <summary>
        /// Checks if the program was started not by the iRacing Manager.
        /// </summary>
        private void checkProgramRunning()
        {
            if (this.State == Model.Program.ProcessState.STOPPED)
            {
                if (this._CurrentState == Model.Program.ProcessState.NOTEXISTING)
                {
                    this.setStopped();
                }

                Process[] processes = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(this._Program.FileName));
                if (processes.Any())
                {
                    IEnumerable<Process> correctProcesses = processes.Where((p) =>
                        System.IO.Path.GetFullPath(p.MainModule.FileName).Equals(
                            System.IO.Path.GetFullPath(System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName))));

                    if (!correctProcesses.Any())
                    {
                        return;
                    }

                    this._Process = correctProcesses.First();
                    this._Program.ExternStart = true;

                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(() => this.setRunning()));
                    }
                    else
                    {
                        this.setRunning();
                    }
                }
            }
        }

        /// <summary>
        /// Updates the control with program information
        /// </summary>
        private void updateProgram()
        {
            this.pictureBoxPicture.Image = this._Program.getClonedImage();
            this.materialSLTPath.Text = (!this._Program.exists()) ?
                "Program does not exist" :
                System.IO.Path.Combine(this._Program.InstallLocation, this._Program.FileName);
        }

        #endregion

        /// <summary>
        /// Kills the process.
        /// </summary>
        internal void kill()
        {
            if (this.State == Model.Program.ProcessState.RUNNING)
            {
                this._Process.Kill();
                this.setStopped();
            }
        }

        #region Eventhandler

        private void ProgramControl_Load(object sender, EventArgs e)
        {
            try
            {
                this.pictureBoxPicture.InitialImage = null;
                this.pictureBoxPicture.SizeMode = PictureBoxSizeMode.Zoom;

                this.updateProgram();
                if (this.Program.exists())
                {
                    this.buttonStart.Cursor = Cursors.Hand;
                    this.setStopped();
                    this.checkProgramRunning();
                } else
                {
                    this.setNotExist();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Error on loading an program control", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                iRacingManager.Program.Logger.Error(ex, "Error on loading an program control");
            }
        }

        private void materialFlatButtonSearch_Click(object sender, EventArgs e)
        {
            try
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
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Error on selecting an application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                iRacingManager.Program.Logger.Error(ex, "Error on selecting an application");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.State != Model.Program.ProcessState.RUNNING)
                {
                    this.start();
                }
                else
                {
                    this.stop();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Error on starting / stopping a program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                iRacingManager.Program.Logger.Error(ex, "Error on starting / stopping a program");
            }
        }

        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            if (this.State == Model.Program.ProcessState.RUNNING)
            {
                this.buttonStart.Text = "STOP";
                this.buttonStart.BackColor = Color.IndianRed;
            }
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            if (this.State == Model.Program.ProcessState.RUNNING)
            {
                this.buttonStart.Text = "RUNNING";
                this.buttonStart.BackColor = Color.LightGreen;
            }
        }

        private void materialFlatButtonModify_Click(object sender, EventArgs e)
        {
            try
            {
                using (ProgramDialog dialog = new ProgramDialog(this._Program))
                {
                    dialog.StartPosition = FormStartPosition.CenterParent;
                    switch (dialog.ShowDialog(this))
                    {
                        case DialogResult.Abort:
                            ((ManagerForm)this.ParentForm).removeProgram(this._Program);
                            break;
                        default:
                            ((ManagerForm)this.ParentForm).saveSettings();
                            break;
                    }
                }

                this.updateProgram();
            } catch (Exception ex)
            {
                MessageBox.Show(this, "Error on editing a program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                iRacingManager.Program.Logger.Error(ex, "Error on editing a program");
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the state of the process/program in this control
        /// </summary>
        internal Model.Program.ProcessState State
        {
            get
            {
                if (!this._Program.exists())
                {
                    return Model.Program.ProcessState.NOTEXISTING;
                }

                if (this._StartStopAction)
                {
                    return Model.Program.ProcessState.INACTION;
                }

                if (this._Process != null && !this._Process.HasExited)
                {
                    return Model.Program.ProcessState.RUNNING;
                }

                return Model.Program.ProcessState.STOPPED;
            }
        }

        /// <summary>
        /// Gets the program of this control
        /// </summary>
        internal Model.Program Program
        {
            get
            {
                return this._Program;
            }
        }

        #endregion
        
    }
}
