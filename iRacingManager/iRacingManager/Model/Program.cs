using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace iRacingManager.Model
{
    /// <summary>
    /// Class represents a startable program in the manager form.
    /// </summary>
    [Serializable()]
    public class Program : INotifyPropertyChanged
    {

        #region Members

        private bool _stopWithIRacing = true;
        private bool _startWithIRacing = true;
        private bool _startOnDisconnect = false;
        private bool _delayStop = false;
        private bool _delayStart = false;

        internal enum ProcessState
        {
            NOTEXISTING,
            STOPPED,
            INACTION,
            RUNNING
        }

        #endregion

        #region Construction

        /// <summary>
        /// Default constructor for serialization
        /// </summary>
        public Program() : base() {}

        /// <summary>
        /// Initializes a new instance of the iRacingManager.Model.Program class.
        /// </summary>
        /// <param name="Name">Name of the program</param>
        /// <param name="DisplayName">Dispay-Name of the program</param>
        /// <param name="InstallLocation">Directory where the program is located at.</param>
        /// <param name="FileName">Filename of the program</param>
        public Program(string Name, string DisplayName, string InstallLocation, string FileName) : base()
        {
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.InstallLocation = InstallLocation;
            this.FileName = FileName;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the program. Eg. checks if the program still exists.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="installedPrograms"></param>
        internal void initialize(Settings.Settings settings, List<(string DisplayName, string Path)> installedPrograms)
        {
            if (string.IsNullOrEmpty(this.InstallLocation) || !System.IO.File.Exists(System.IO.Path.Combine(this.InstallLocation, this.FileName)))
            {
                var program = installedPrograms.Find(prog => !string.IsNullOrEmpty(this.Name) && !string.IsNullOrEmpty(prog.DisplayName) && prog.DisplayName.Contains(this.Name));

                if (program.Path != null)
                {
                    this.InstallLocation = program.Path;
                }
            }
        }

        internal Image getClonedImage()
        {
            using (Image sourceImage = this.Icon)
            {
                if (sourceImage == null) return null;
                Image clonedImg = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);
                using (var copy = Graphics.FromImage(clonedImg))
                {
                    copy.DrawImage(sourceImage, 0, 0);
                }

                return clonedImg;
            }
        }

        internal void runSpecialLogic(ref ProcessStartInfo psi)
        {
            switch(this.FileName.ToLower())
            {
                case "kapps.exe":
                case "racelabapps.exe":
                    var fileInfo = new FileInfo(Path.Combine(this.InstallLocation, this.FileName));
                    // The kapps launcher only has less than 1MB size
                    if (fileInfo.Length < 1000000)
                    {
                        // Use the application in the subdirectory instead by getting the version number
                        var version = FileVersionInfo.GetVersionInfo(fileInfo.FullName);
                        var versionDir = Path.Combine(this.InstallLocation, "app-" + (version.FileVersion.EndsWith(".0") && version.FileVersion.Count(c => c.Equals('.')) > 3 ? version.FileVersion.Substring(0, version.FileVersion.LastIndexOf('.') + 2) : version.FileVersion));

                        if (Directory.Exists(versionDir)) {
                            psi.FileName = Path.Combine(versionDir, this.FileName);
                            psi.WorkingDirectory = versionDir;
                        }
                    }
                    break;
            }
        }

        internal bool exists()
        {
            if (string.IsNullOrEmpty(this.InstallLocation) || string.IsNullOrEmpty(this.FileName))
            {
                return false;
            }

            return System.IO.File.Exists(System.IO.Path.Combine(this.InstallLocation, this.FileName));
        }

        #endregion

        #region Properties

        public string PicturePath
        {
            get; set;
        } = string.Empty;

        public bool UseIconFromApplication => string.IsNullOrEmpty(this.PicturePath);

        [System.Xml.Serialization.XmlIgnore]
        public Image Icon
        {
            get
            {
                if (!this.UseIconFromApplication)
                {
                    return Image.FromFile(this.PicturePath);
                } else
                {
                    if (!this.exists())
                    {
                        return null;
                    }

                    return System.Drawing.Icon.ExtractAssociatedIcon(System.IO.Path.Combine(this.InstallLocation, this.FileName)).ToBitmap();
                }
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public Gui.Controls.ProgramControl Control
        {
            get; set;
        } = null;

        [System.Xml.Serialization.XmlIgnore]
        public bool ExternStart
        {
            get; set;
        } = false;

        public bool StartWithIRacing
        {
            get => this._startWithIRacing;
            set
            {
                this._startWithIRacing = value;
                if (value)
                    this.StartOnDisconnect = false;

                this.OnPropertyChanged();
            }
        }

        public bool StopWithIRacing
        {
            get => this._stopWithIRacing;
            set
            {
                this._stopWithIRacing = value;
                if (!value)
                    this.DelayStop = false;

                this.OnPropertyChanged();
            }
        }

        public string Name
        {
            get; set;
        } = string.Empty;

        public string DisplayName
        {
            get; set;
        } = string.Empty;

        public string InstallLocation
        {
            get; set;
        } = string.Empty;

        public string FileName
        {
            get; set;
        } = string.Empty;

        public string Arguments
        {
            get; set;
        } = string.Empty;

        public bool StartHidden
        {
            get; set;
        } = false;

        public bool DelayStart
        {
            get => this._delayStart;
            set
            {
                this._delayStart = value;
                this.OnPropertyChanged();
            }
        }

        public int DelayStartSeconds
        {
            get; set;
        } = 0;

        public bool DelayStop
        {
            get => this._delayStop;
            set
            {
                this._delayStop = value;
                this.OnPropertyChanged();
            }
        }

        public int DelayStopSeconds
        {
            get; set;
        } = 0;

        public bool StartOnDisconnect
        {
            get => this._startOnDisconnect;
            set
            {
                this._startOnDisconnect = value;
                if (value)
                {
                    this.StartWithIRacing = false;
                    this.StopWithIRacing = false;
                }
                    

                this.OnPropertyChanged();
            }
        }

        #endregion

        #region Event

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (string.IsNullOrEmpty(propertyName))
                return;

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

    }
}
