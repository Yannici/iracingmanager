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

            this.initializeInstalledPrograms();
        }

        #endregion

        #region Methods

        private void checkProgramControls()
        {
            foreach(Control control in this.flowLayoutPanelPrograms.Controls)
            {
                if (control.GetType() == typeof(NewProgramControl)) continue;
                ((ProgramControl)control).updateState();
            }
        }

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

        private void initializeInstalledPrograms()
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
            foreach(Model.Program program in this._Programs)
            {
                this.createProgramControl(program);
            }
        }

        private void createProgramControl(Model.Program program)
        {
            ProgramControl control = new ProgramControl(program, this._FontCollection);
            program.Control = control;
            this.flowLayoutPanelPrograms.Controls.Add(control);
        }

        private void addAddControl()
        {
            this.flowLayoutPanelPrograms.Controls.Add(new NewProgramControl());
        }

        #endregion


        #region Eventhandler

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.initCustomMaterialDesignFont();
                this._Settings = Model.Settings.Settings.LoadSettings();
                this.initializePrograms();
                this.initializeProgramControls();
                this.addAddControl();
                this._Settings.Save();
            } catch(Exception ex)
            {
                MessageBox.Show(this, $"Error on loading iRacing Manager: {ex.Message}", "Error on loading.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._Settings.Save();
        }

        private void timerCheckProcesses_Tick(object sender, EventArgs e)
        {
            this.checkProgramControls();
        }

        #endregion

    }
}
