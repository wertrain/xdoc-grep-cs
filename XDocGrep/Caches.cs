using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XDocGrep
{
    class Caches
    {
        /// <summary>
        /// 
        /// </summary>
        public List<DirectoryCache> DirectoryCaches;

        /// <summary>
        /// 
        /// </summary>
        public class DirectoryCache
        {
            /// <summary>
            /// 
            /// </summary>
            public string Path { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public DateTime UpdateTime { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public List<string> Files { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Caches Default()
        {
            return new Caches();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Caches Load()
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(Caches));

            try
            {
                var assembly = Assembly.GetEntryAssembly();
                var filePath = Path.GetDirectoryName(assembly.Location) + Path.DirectorySeparatorChar + "caches.xml";

                using (var sr = new StreamReader(filePath, new UTF8Encoding(false)))
                {
                    return (Caches)serializer.Deserialize(sr);
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
        public static bool Save(Caches cache)
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Caches));

            try
            {
                var assembly = Assembly.GetEntryAssembly();
                var filePath = Path.GetDirectoryName(assembly.Location) + Path.DirectorySeparatorChar + "caches.xml";

                using (var sw = new StreamWriter(filePath, false, new UTF8Encoding(false)))
                {
                    serializer.Serialize(sw, cache);
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
