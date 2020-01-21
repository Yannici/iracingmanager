using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace iRacingManager.Model.Settings
{
    /// <summary>
    /// Settings class to migrate old settings data to new one
    /// </summary>
    class Migration
    {

        [Migration("1.0.0")]
        private static void DivideStopAndStart(XmlDocument xmlDoc)
        {
            foreach(XmlNode node in xmlDoc.SelectNodes("//Programs/Program"))
            {
                var startStopNode = node.SelectSingleNode("StartStopWithIRacing");
                var startStop = bool.Parse(startStopNode.InnerText);
                var startNew = xmlDoc.CreateElement("StartWithIRacing");
                var stopNew = xmlDoc.CreateElement("StopWithIRacing");

                startNew.InnerText = startStop.ToString().ToLower();
                stopNew.InnerText = startStop.ToString().ToLower();

                node.AppendChild(startNew);
                node.AppendChild(stopNew);
                node.RemoveChild(startStopNode);
            }
        }

    }
}
