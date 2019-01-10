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

namespace iRacingManager
{
    public partial class ManagerForm : MaterialForm
    {

        #region Members

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private List<(string DisplayName, string Path)> _InstalledPrograms = new List<(string DisplayName, string Path)>();
        private Model.Settings.Settings _Settings = null;
        private List<Model.Program> _Programs = new List<Model.Program>();
        private System.Drawing.Text.PrivateFontCollection _FontCollection = new System.Drawing.Text.PrivateFontCollection();
        private Process iRacingProcess = null;

        #endregion

        #region Construction

        public ManagerForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Red800, MaterialSkin.Primary.Blue800,
                MaterialSkin.Primary.Indigo400, MaterialSkin.Accent.Indigo400,
                MaterialSkin.TextShade.WHITE);
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
                this.flowLayoutPanelPrograms.Controls.SetChildIndex(control, this.flowLayoutPanelPrograms.Controls.Count - 2);
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
            this.materialFlatButtonStartAll.Visible = this.flowLayoutPanelPrograms.Controls.Cast<Control>().Any((c) =>
                {
                    return c.GetType() == typeof(ProgramControl) && ((ProgramControl)c).State == Model.Program.ProcessState.STOPPED;
                });
            this.materialFlatButtonStopAll.Visible = this.flowLayoutPanelPrograms.Controls.Cast<Control>().Any((c) =>
            {
                return c.GetType() == typeof(ProgramControl) && ((ProgramControl)c).State == Model.Program.ProcessState.RUNNING;
            });
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
                ("Trading Paints", "tradingpaints.exe") };
            foreach((string DisplayName, string Path) program in this._InstalledPrograms)
            {
                (string, string) knownProgram = knownPrograms.Find((p) => program.DisplayName != null && program.DisplayName.Equals(p.Item1));
                if (knownProgram.Item1 != null && knownProgram.Item2 != null)
                {
                    this._Programs.Add(new Model.Program(program.DisplayName, program.DisplayName, program.Path, knownProgram.Item2));
                }
            }
        }

        /// <summary>
        /// Checks if iracing is started/stopped and starts/stops programs if they are configured to start/stop.
        /// </summary>
        private void checkIRacingStarted()
        {
            // Check to start programs
            if (this.iRacingProcess == null)
            {
                // Check if iracing started
                Process[] iracingProcesses = Process.GetProcessesByName("iRacing");
                if (iracingProcesses.Any())
                {
                    this.iRacingProcess = iracingProcesses.First();
                    foreach(ProgramControl control in this.ProgramControls)
                    {
                        if (control.Program.StartStopWithIRacing && control.State == Model.Program.ProcessState.STOPPED)
                        {
                            control.start();
                        }
                    }
                }
            } else if (this.iRacingProcess.HasExited)
            {
                // Check to stop programs
                this.iRacingProcess = null;
                foreach (ProgramControl control in this.ProgramControls)
                {
                    if (control.Program.StartStopWithIRacing && control.State == Model.Program.ProcessState.RUNNING)
                    {
                        control.stop();
                    }
                }
            }
        }

        #endregion

        #region Eventhandler

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.initializeInstalledPrograms();
                this.initCustomMaterialDesignFont();
                this._Settings = Model.Settings.Settings.LoadSettings();
                this.settingsBindingSource.DataSource = this._Settings;

                if (this._Settings.IsNew)
                {
                    this.firstStart();
                }

                this.initializePrograms();
                this.initializeProgramControls();
                this.checkIRacingStarted();
                this.addAddControl();
                this._Settings.Save();

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
        }

        private void timerCheckProcesses_Tick(object sender, EventArgs e)
        {
            this.checkProgramControls();
            this.checkStartStopButtons();
            this.checkIRacingStarted();
        }

        private void materialFlatButtonStartAll_Click(object sender, EventArgs e)
        {
            this.startAll();
        }

        private void materialFlatButtonStopAll_Click(object sender, EventArgs e)
        {
            this.stopAll();
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ProgramControls.Any((c) => !c.Program.ExternStart && (c.State == Model.Program.ProcessState.RUNNING || c.State == Model.Program.ProcessState.INACTION))) {
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
