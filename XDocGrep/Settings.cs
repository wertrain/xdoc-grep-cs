using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XDocGrep
{
    public class Settings
    {
        /// <summary>
        /// 
        /// </summary>
        public Size FormSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> TargetHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> ExtensionsHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<string> SearchTextHistory { get; set; }

        public Settings()
        {
            FormSize = new Size(580, 210);
            TargetHistory = new List<string>();
            ExtensionsHistory = new List<string>();
            SearchTextHistory = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Settings Load()
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));

            try
            {
                var assembly = Assembly.GetEntryAssembly();
                var filePath = Path.GetDirectoryName(assembly.Location) + Path.DirectorySeparatorChar + "settings.xml";

                using (var sr = new System.IO.StreamReader(filePath, new UTF8Encoding(false)))
                {
                    return (Settings)serializer.Deserialize(sr);
                }
            }
            catch (Exception)
            {

            }
            return new Settings();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        public static bool Save(Settings settings)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));

            try
            {
                var assembly = Assembly.GetEntryAssembly();
                var filePath = Path.GetDirectoryName(assembly.Location) + Path.DirectorySeparatorChar + "settings.xml";

                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false, new System.Text.UTF8Encoding(false)))
                {
                    serializer.Serialize(sw, settings);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
