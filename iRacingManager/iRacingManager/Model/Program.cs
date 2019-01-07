using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRacingManager.Model
{
    [Serializable()]
    public class Program
    {

        #region Members

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
        public System.Drawing.Image Icon
        {
            get
            {
                if (!this.UseIconFromApplication)
                {
                    using(System.Drawing.Image img = System.Drawing.Image.FromFile(this.PicturePath))
                    {
                        return (System.Drawing.Image)img.Clone();
                    }
                } else
                {
                    using (System.Drawing.Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(System.IO.Path.Combine(this.InstallLocation, this.FileName)))
                    {
                        return ((System.Drawing.Icon)icon.Clone()).ToBitmap();
                    }
                }
            }
        }

        [System.Xml.Serialization.XmlIgnore]
        public Gui.Controls.ProgramControl Control
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
