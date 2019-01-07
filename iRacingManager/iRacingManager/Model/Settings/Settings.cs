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
    [Serializable()]
    public class Settings
    {

        #region Members

        private const string FILENAME = "settings.xml";

        #endregion

        #region Construction

        public Settings() : base()
        {
            this.Programs = new List<Model.Program>();
        }

        #endregion

        #region Methods

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

                    return (Settings) xmlDeserializer.Deserialize(xmlReader);
                }                
            } catch
            {
                return new Settings();
            }
        }

        #endregion

        #region Properties

        public List<Program> Programs
        {
            get; set;
        }

        #endregion

    }
}
