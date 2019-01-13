using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace iRacingManager.Model.Settings {

    /// <summary>
    /// Settings for the iRacingManager (settings.xml)
    /// </summary>
    public class Settings
    {

        #region Members

        private const string FILENAME = "settings.xml";

        #endregion

        #region Construction

        public Settings() : base()
        {
            this.IsNew = true;
            this.Programs = new List<Program>();
        }

        #endregion

        #region Methods

        internal string getSavePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "iRacingManager", Settings.FILENAME);
        }

        /// <summary>
        /// Saves/Serializes the setting file (settings.xml).
        /// </summary>
        internal void Save()
        {
            try
            {
                string savePath = this.getSavePath();
                if (!Directory.Exists(Path.GetDirectoryName(savePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(savePath));
                }

                using (var inputWriter = new StreamWriter(savePath))
                {
                    var xmlSerializer = new XmlSerializer(typeof(Settings));
                    xmlSerializer.Serialize(inputWriter, this);
                }
            } catch(Exception ex)
            {
                throw new Exception("Error on saving the settings file.", ex);
            }
        }

        /// <summary>
        /// Adds/removes iRacingManager from Autorun, if checked or not.
        /// </summary>
        internal void ToggleProgramAutorun()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                if (this.StartWithWindows)
                {
                    if (key.GetValue("iRacingManager") == null)
                    {
                        key.SetValue("iRacingManager", "\"" + System.Windows.Forms.Application.ExecutablePath + "\"");
                    }
                }
                else
                {
                    if (key.GetValue("iRacingManager") != null)
                    {
                        key.DeleteValue("iRacingManager");
                    }
                }
            }
        }

        /// <summary>
        /// Loading settings from file (settings.xml). If there is no file, new settings will be created.
        /// </summary>
        /// <returns></returns>
        internal static Settings LoadSettings()
        {
            try
            {
                var setting = new Settings();
                if (!File.Exists(setting.getSavePath()))
                {
                    return setting;
                }

                using (var inputReader = new StreamReader(setting.getSavePath()))
                {
                    var xmlDeserializer = new XmlSerializer(typeof(Settings));
                    var xmlReader = XmlReader.Create(inputReader);
                    
                    if (!xmlDeserializer.CanDeserialize(xmlReader))
                    {
                        throw new Exception("Settings file could not be read.");
                    }

                    var settings = (Settings) xmlDeserializer.Deserialize(xmlReader);
                    settings.IsNew = false;
                    return settings;
                }                
            } catch
            {
                return new Settings();
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// The programs which will be saved to the settings file.
        /// </summary>
        public List<Program> Programs
        {
            get; set;
        }

        [XmlIgnore]
        public bool IsNew
        {
            get; set;
        } = false;

        /// <summary>
        /// Setting if iRacingManager should start with windows.
        /// </summary>
        public bool StartWithWindows
        {
            get; set;
        } = false;

        /// <summary>
        /// Setting if iRacingManager should minimize to system tray instead of closing.
        /// </summary>
        public bool CloseToSystemTray
        {
            get; set;
        } = false;

        /// <summary>
        /// Setting if iRacingManager should minimize to system tray instead of "normal" minimize.
        /// </summary>
        public bool MinimizeToSystemTray
        {
            get; set;
        } = false;

        #endregion

    }
}
