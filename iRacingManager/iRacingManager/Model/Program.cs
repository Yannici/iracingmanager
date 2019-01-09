using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace iRacingManager.Model
{
    [Serializable()]
    public class Program
    {

        #region Members

        internal enum ProcessState
        {
            STOPPED,
            INACTION,
            RUNNING
        }

        #endregion

        #region Construction

        public Program() : base()
        {

        }

        public Program(string Name, string DisplayName, string InstallLocation, string FileName, string PicturePath, bool StartHidden) : base()
        {
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.InstallLocation = InstallLocation;
            this.FileName = FileName;
            this.StartHidden = StartHidden;
            this.PicturePath = PicturePath;
        }

        #endregion

        #region Methods

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

        #endregion

        #region Properties

        public string PicturePath
        {
            get; set;
        }

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
                    if (string.IsNullOrEmpty(this.InstallLocation) || string.IsNullOrEmpty(this.FileName))
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
        }

        [System.Xml.Serialization.XmlIgnore]
        public bool ExternStart
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string DisplayName
        {
            get; set;
        }

        public string InstallLocation
        {
            get; set;
        }

        public string FileName
        {
            get; set;
        }

        public bool StartHidden
        {
            get; set;
        }

        #endregion

    }
}
