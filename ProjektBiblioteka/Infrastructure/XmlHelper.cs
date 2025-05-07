using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjektBiblioteka.Infrastructure
{
    public class XmlHelper
    {

        public static void SerializeToXml<T>(T obj, string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));

            using(var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, obj);
            }
        }


        public static T DeserializeFromXml<T>(string filePath)
        {
            var serializer = new XmlSerializer(typeof(T));
            
            using (var reader = new StreamReader(filePath))
            {
                return (T)serializer.Deserialize(reader);
            }

            
        }
    }
}
