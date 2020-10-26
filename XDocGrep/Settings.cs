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

        public static Settings Default()
        {
            var settings = new Settings();
            var defaultExtensions = new List<string>()
            {
                "*.pdf",                   // Adobe PDF
                "*.xls .xlsx",             // Microsoft Excel 
                "*.doc .docx",             // Microsoft Word 
                "*.ppt .pptx",             // Microsoft PowerPoint
                "*.eml",                   // OutlookExpressのエクスポート形式 
                "*.sxw *.sxc *.sxi *.sxd", // OpenOffice.org
                "*.odt *.ods *.odp *.odg", // Open Document
                "*.jtd *.jtt",             // 一太郎 ver8/9/10/11/12
                "*.jfw *.jvw",             // 一太郎 ver7
                "*.jbw *.juw",             // 一太郎 ver6
                "*.jaw *.jtw",             // 一太郎 ver5
            };
            settings.ExtensionsHistory.AddRange(defaultExtensions);
            return settings;
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

                using (var sr = new StreamReader(filePath, new UTF8Encoding(false)))
                {
                    return (Settings)serializer.Deserialize(sr);
                }
            }
            catch (Exception)
            {

            }
            return Default();
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

                using (var sw = new StreamWriter(filePath, false, new UTF8Encoding(false)))
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
