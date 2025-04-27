using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSCodeGen.DataAccess.Helper
{
    public class XMLHelper
    {
        #region Serialize & Deserialize
        public static T DeserializeFromXml<T>(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Deserialisieren: {ex.Message}");
                return default;
            }
        }

        public static void SerializeToXml<T>(T obj, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(writer, obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler beim Serialisieren: {ex.Message}");
            }
        }

        #endregion
    }
}
