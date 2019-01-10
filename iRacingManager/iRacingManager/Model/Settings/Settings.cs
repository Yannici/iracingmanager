﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace iRacingManager.Model.Settings
{

    /// <summary>
    /// Settings for the iRacingManager (settings.xml)
    /// </summary>
    [Serializable()]
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

        /// <summary>
        /// Saves/Serializes the setting file (settings.xml).
        /// </summary>
        internal void Save()
        {
            try
            {
                using (var inputWriter = new StreamWriter(Settings.FILENAME))
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
                if (!File.Exists(Settings.FILENAME))
                {
                    return new Settings();
                }

                using (var inputReader = new StreamReader(Settings.FILENAME))
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

        #endregion

    }
}
