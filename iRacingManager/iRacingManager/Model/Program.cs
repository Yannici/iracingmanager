using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace iRacingManager.Model
{
    /// <summary>
    /// Class represents a startable program in the manager form.
    /// </summary>
    [Serializable()]
    public class Program
    {

        #region Members

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

        public bool UseIconFromApplication
        {
            get
            {
                return string.IsNullOrEmpty(this.PicturePath);
            }
        }

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
            get; set;
        } = true;

        public bool StopWithIRacing
        {
            get; set;
        } = true;

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
            get; set;
        } = false;

        public int DelayStartSeconds
        {
            get; set;
        } = 0;

        #endregion

    }
}
