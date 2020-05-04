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
using Microsoft.Win32;
using iRacingManager.Gui.Controls;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace iRacingManager
{
    public partial class ManagerForm : MaterialForm
    {

        #region Members

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        private List<(string DisplayName, string Path)> _InstalledPrograms = new List<(string DisplayName, string Path)>();
        private Model.Settings.Settings _Settings = null;
        private List<Model.Program> _Programs = new List<Model.Program>();
        private System.Drawing.Text.PrivateFontCollection _FontCollection = new System.Drawing.Text.PrivateFontCollection();
        private iRacingSdkWrapper.SdkWrapper _iRacingSdkWrapper = null;
        private bool _TrayClosing = false;
        private bool _UpdateClosing = false;

        private const string URL = "https://irm.yannici.de/";
        private const string UPDATE_CHECK_NAME = "version.txt";

        #endregion

        #region Construction

        public ManagerForm(bool StartMinimized)
        {
            InitializeComponent();

            System.IO.Directory.SetCurrentDirectory(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "iRacingManager"));
            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Red800, MaterialSkin.Primary.Blue800,
                MaterialSkin.Primary.Indigo400, MaterialSkin.Accent.Indigo400,
                MaterialSkin.TextShade.WHITE);

            this._iRacingSdkWrapper = new iRacingSdkWrapper.SdkWrapper();
            this._iRacingSdkWrapper.Connected += iRacingConnected;
            this._iRacingSdkWrapper.Disconnected += iRacingDisconnected;

            this.labelInfoTitle.Font = new Font("Roboto Medium", 18);
            this.linkLabelMembersite.Font = new Font("Roboto Medium", 11);
            this.labelThanks.Font = new Font("Roboto Medium", 9);

            this._Settings = Model.Settings.Settings.LoadSettings();

            if (StartMinimized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        #endregion

        #region Methods

        private void checkProgramControls()
        {
            try
            {
                foreach (Control control in this.flowLayoutPanelPrograms.Controls)
                {
                    if (control.GetType() == typeof(NewProgramControl)) continue;
                    ((ProgramControl)control).updateState();
                }
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Found at https://stackoverflow.com/questions/28315510/how-to-get-installed-software-path-from-registry/28315920
        /// </summary>
        private void initializeInstalledPrograms()
        {
            try
            {
                string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                        {
                            this._InstalledPrograms.Add((subkey.GetValue("DisplayName")?.ToString(), subkey.GetValue("InstallLocation")?.ToString()));
                        }
                    }
                }

                registry_key = @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
                {
                    foreach (string subkey_name in key.GetSubKeyNames())
                    {
                        using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                        {
                            this._InstalledPrograms.Add((subkey.GetValue("DisplayName")?.ToString(), subkey.GetValue("InstallLocation")?.ToString()));
                        }
                    }
                }

                this._InstalledPrograms = this._InstalledPrograms.Distinct().ToList();
                this._InstalledPrograms.RemoveAll((p) => p.DisplayName == null || p.Path == null);
            } catch(Exception ex)
            {
                throw new Exception("Error on initializing installed programs", ex);
            }
        }

        internal void removeProgram(Model.Program program)
        {
            try
            {
                ProgramControl control = this.ProgramControls.Find((c) => c.Program == program);
                if (control != null)
                {
                    this.flowLayoutPanelPrograms.Controls.Remove(control);
                    this._Programs.Remove(program);
                }
            } catch (Exception ex)
            {
                throw new Exception("Error on removing program control", ex);
            }
        }

        /// <summary>
        /// Found at https://stackoverflow.com/questions/556147/how-to-quickly-and-easily-embed-fonts-in-winforms-app-in-c-sharp
        /// </summary>
        private void initCustomMaterialDesignFont()
        {
            System.IO.Stream fontStream = new System.IO.MemoryStream(Properties.Resources.Roboto_Medium);

            //create an unsafe memory block for the data
            System.IntPtr data = System.Runtime.InteropServices.Marshal.AllocCoTaskMem((int)fontStream.Length);
            //create a buffer to read in to
            Byte[] fontData = new Byte[fontStream.Length];
            //fetch the font program from the resource
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            //copy the bytes to the unsafe memory block
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, data, (int)fontStream.Length);

            // We HAVE to do this to register the font to the system (Weird .NET bug !)
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

            //pass the font to the font collection
            this._FontCollection.AddMemoryFont(data, (int)fontStream.Length);
            //close the resource stream
            fontStream.Close();
            //free the unsafe memory
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(data);
        }

        private void initializePrograms()
        {
            // Custom Programs
            foreach(Model.Program program in this._Settings.Programs)
            {
                this._Programs.Add(program);
            }
        }

        private void initializeProgramControls()
        {
            try
            {
                foreach (Model.Program program in this._Programs)
                {
                    this.createProgramControl(program);
                }

                this.flowLayoutPanelPrograms.Refresh();
            } catch(Exception ex)
            {
                throw new Exception("Error on initializing program controls", ex);
            }
        }

        /// <summary>
        /// Creates a program control for a program and adds it to the control list as last child.
        /// </summary>
        /// <param name="program"></param>
        private void createProgramControl(Model.Program program)
        {
            try
            {
                ProgramControl control = new ProgramControl(program, this._FontCollection);
                program.Control = control;
                this.flowLayoutPanelPrograms.Controls.Add(control);
                this.flowLayoutPanelPrograms.Controls.SetChildIndex(control, this.flowLayoutPanelPrograms.Controls.Count - 1);
            } catch (Exception ex)
            {
                throw new Exception($"Error on initializing program control for '{program.Name}'", ex);
            }
        }

        /// <summary>
        /// Adds the "add program" control
        /// </summary>
        private void addAddControl()
        {
            NewProgramControl newProgramControl = new NewProgramControl();
            newProgramControl.ProgramAdded += NewProgramControl_ProgramAdded;
            this.flowLayoutPanelPrograms.Controls.Add(newProgramControl);
        }

        /// <summary>
        /// Start all stopped programs.
        /// </summary>
        private void startAll()
        {
            try
            {
                foreach (Control control in this.flowLayoutPanelPrograms.Controls)
                {
                    if (control.GetType() == typeof(NewProgramControl)) continue;

                    if (((ProgramControl)control).State != Model.Program.ProcessState.RUNNING)
                    {
                        ((ProgramControl)control).start();
                    }
                }
            } catch(Exception ex)
            {
                throw new Exception("Error on starting all programs", ex);
            }
        }

        /// <summary>
        /// Stop all running programs.
        /// </summary>
        private void stopAll()
        {
            try
            {
                foreach (Control control in this.flowLayoutPanelPrograms.Controls)
                {
                    if (control.GetType() == typeof(NewProgramControl)) continue;

                    if (((ProgramControl)control).State != Model.Program.ProcessState.STOPPED)
                    {
                        ((ProgramControl)control).stop();
                    }
                }
            } catch (Exception ex)
            {
                throw new Exception("Error on stopping all programs", ex);
            }
        }

        /// <summary>
        /// Check if the start all / stop all buttons should be visible
        /// </summary>
        private void checkStartStopButtons()
        {
            var startVisible = this.flowLayoutPanelPrograms.Controls.Cast<Control>().Any((c) =>
            {
                return c.GetType() == typeof(ProgramControl) && ((ProgramControl)c).State == Model.Program.ProcessState.STOPPED;
            });
            var stopVisible = this.flowLayoutPanelPrograms.Controls.Cast<Control>().Any((c) =>
            {
                return c.GetType() == typeof(ProgramControl) && ((ProgramControl)c).State == Model.Program.ProcessState.RUNNING;
            });

            this.materialFlatButtonStartAll.Visible = startVisible;
            this.startAllToolStripMenuItem.Visible = startVisible;

            this.materialFlatButtonStopAll.Visible = stopVisible;
            this.stopAllToolStripMenuItem.Visible = stopVisible;
        }

        /// <summary>
        /// Save the settings file.
        /// </summary>
        internal void saveSettings()
        {
            this._Settings.Programs = this._Programs;
            this._Settings.Save();
        }

        /// <summary>
        /// Will be executing if the program starts the first time (settings file does not exists).
        /// </summary>
        private void firstStart()
        {
            List<(string, string)> knownPrograms = new List<(string, string)> {
                ("CrewChiefV4", "CrewChiefV4.exe"),
                ("Trading Paints", "Trading Paints.exe"),
                ("iSpeed*", "iSpeed.exe"),
                ("Joel Real Timing*", "Timing.exe")};
            foreach ((string DisplayName, string Path) program in this._InstalledPrograms)
            {
                (string, string) knownProgram = knownPrograms.Find((p) =>
                {
                    if (p.Item1.EndsWith("*"))
                    {
                        return (program.DisplayName.StartsWith(p.Item1.Substring(0, p.Item1.Length - 1)));
                    } else
                    {
                        return program.DisplayName == p.Item1;
                    }
                });

                if (knownProgram.Item1 != null && knownProgram.Item2 != null)
                {
                    this._Programs.Add(new Model.Program(program.DisplayName, program.DisplayName, program.Path, knownProgram.Item2));
                }
            }
        }

        /// <summary>
        /// Executing when iRacing started (SDK was connected).
        /// </summary>
        private void iRacingConnected(object sender, EventArgs e)
        {
            foreach(ProgramControl control in this.ProgramControls)
            {
                if (control.Program.StartWithIRacing && control.State == Model.Program.ProcessState.STOPPED)
                {
                    control.start();
                }
            }
        }

        /// <summary>
        /// Executing when iRacing stopped (SDK was disconnected).
        /// </summary>
        private void iRacingDisconnected(object sender, EventArgs e)
        {
            foreach (ProgramControl control in this.ProgramControls)
            {
                if (control.Program.StopWithIRacing && control.State == Model.Program.ProcessState.RUNNING)
                {
                    control.stop();
                }
            }
        }

        private void openFromTray()
        {
            this.Show();
            this.notifyIconTray.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private bool newUpdateAvailable(string newVersionString)
        {
            Version currentVersion = Version.Parse(Application.ProductVersion);
            Version newVersion = Version.Parse(newVersionString);

            return (newVersion > currentVersion);
        }

        private async void checkForUpdates(bool manualCheck)
        {
            System.Net.WebRequest request = null;
            System.Net.WebResponse response = null;
            string currentVersion = string.Empty;
            string updateSetupName = string.Empty;

            try
                {
                this.materialLabelCurrentVersionValue.Text = Application.ProductVersion;

                request = System.Net.WebRequest.Create(ManagerForm.URL + ManagerForm.UPDATE_CHECK_NAME);
                response = await request.GetResponseAsync();

                using (System.IO.Stream responseStream = response.GetResponseStream())
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(responseStream))
                    {
                        currentVersion = await reader.ReadLineAsync();
                        updateSetupName = await reader.ReadLineAsync();
                    }
                }

                // Check if new update
                if (this.newUpdateAvailable(currentVersion))
                {
                    Gui.UpdateDialog updateDialog = new Gui.UpdateDialog(Application.ProductVersion, currentVersion, ManagerForm.URL, updateSetupName);
                    updateDialog.StartPosition = FormStartPosition.CenterParent;
                    updateDialog.Show();

                    updateDialog.UpdateDownloadCompleted += (object sender, EventArgs e) =>
                    {
                        this._UpdateClosing = true;
                        Process.Start(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "iRacingManager", updateSetupName));
                        this.Close();
                    };

                    updateDialog.BringToFront();
                } else if(manualCheck)
                {
                    MessageBox.Show(this, "There is no update available!", "No update", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            } catch
            {
                // No exceptions at update checking.
            } finally
            {
                response?.Close();
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Program.WM_SHOWIRMNG)
            {
                if (this.notifyIconTray.Visible)
                {
                    this.openFromTray();
                }

                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                }

                // get our current "TopMost" value (ours will always be false though)
                bool top = TopMost;
                // make our form jump to the top of everything
                TopMost = true;
                // set it back to whatever it was
                TopMost = top;
            }

            base.WndProc(ref m);
        }

        #endregion

        #region Eventhandler

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Minimized && this._Settings != null && this._Settings.MinimizeToSystemTray)
                {
                    this.Hide();
                    this.notifyIconTray.Visible = true;
                }

                this.initializeInstalledPrograms();
                this.initCustomMaterialDesignFont();
                this.settingsBindingSource.DataSource = this._Settings;

                if (this._Settings.IsNew)
                {
                    this.firstStart();
                }

                this.initializePrograms();
                this.initializeProgramControls();
                this.addAddControl();
                this._Settings.Save();

                this._iRacingSdkWrapper.Start();

                this.checkForUpdates(false);
                this.timerCheckProcesses.Start();
            } catch(Exception ex)
            {
                MessageBox.Show(this, $"Error on loading iRacing Manager: {ex.Message}", "Error on loading.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                throw new Exception("Error on loading", ex);
            }
        }

        private void NewProgramControl_ProgramAdded(object sender, Model.ProgramAddedEventArgs e)
        {
            this._Programs.Add(e.AddedProgram);
            this.createProgramControl(e.AddedProgram);

            this.saveSettings();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.saveSettings();
            if (this._iRacingSdkWrapper.IsRunning)
            {
                this._iRacingSdkWrapper.Stop();
            }
        }

        private void timerCheckProcesses_Tick(object sender, EventArgs e)
        {
            this.checkProgramControls();
            this.checkStartStopButtons();
        }

        private void materialFlatButtonStartAll_Click(object sender, EventArgs e)
        {
            this.startAll();
        }

        private void materialFlatButtonStopAll_Click(object sender, EventArgs e)
        {
            this.stopAll();
        }

        private void startAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.startAll();
        }

        private void stopAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.stopAll();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._UpdateClosing || e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.ApplicationExitCall)
            {
                this.ProgramControls.ForEach((c) =>
                {
                    if (!c.Program.ExternStart)
                    {
                        c.kill();
                    }
                });
                e.Cancel = false;
                return;
            }

            if (this._Settings.CloseToSystemTray && !this._TrayClosing)
            {
                this.Hide();
                this.notifyIconTray.Visible = true;
                e.Cancel = true;
            }

            if (!e.Cancel && this.ProgramControls.Any((c) => !c.Program.ExternStart && (c.State == Model.Program.ProcessState.RUNNING || c.State == Model.Program.ProcessState.INACTION))) {
                if(MessageBox.Show(this, "There are still applications running. When you close this application, all started applications will be closed! Continue?", "Close applications?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.ProgramControls.ForEach((c) =>
                    {
                        if (!c.Program.ExternStart)
                        {
                            c.kill();
                        }
                    });
                } else
                {
                    e.Cancel = true;
                }
            }

            if (e.Cancel)
            {
                this._TrayClosing = false;
            }
        }

        private void linkLabelMembersite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://members.iracing.com/membersite/member/CareerStats.do?custid=302443");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._TrayClosing = true;
            this.Close();
        }
        
        private void notifyIconTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.openFromTray();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFromTray();
        }

        private void ManagerForm_Resize(object sender, EventArgs e)
        {
            if (this._Settings == null) return;
            if (this._Settings.MinimizeToSystemTray && this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIconTray.Visible = true;
            }
        }

        private void materialFlatButtonCheckUpdates_Click(object sender, EventArgs e)
        {
            this.checkForUpdates(true);
        }

        #region Settings

        private void materialCheckBoxStartWithWindows_CheckStateChanged(object sender, EventArgs e)
        {
            this._Settings.ToggleProgramAutorun();
        }


        #endregion

        #endregion

        #region Properties

        private List<ProgramControl> ProgramControls
        {
            get
            {
                return this.flowLayoutPanelPrograms.Controls.Cast<Control>().Where((c) =>
                {
                    return c.GetType() == typeof(ProgramControl);
                }).Cast<ProgramControl>().ToList();
            }
        }




        #endregion

    }
}
