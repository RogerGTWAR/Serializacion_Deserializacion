using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializacion
{
    public class XmlObjectSerializer : ISerializer
    {

        public List<T> Deserializer<T>(string fileName)
        {
            List<T> list = new List<T>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(fileName))
                {
                    var serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("ArrayOfRecord"));
                    list = (List<T>)serializer.Deserialize(reader);
                }
            }
            return list;
        }

        public void Serializer<T>(List<T> list, string fileName)
        {
            using (var write = new StreamWriter(fileName))
            {
                var serializer = new XmlSerializer(typeof(List<T>), new XmlRootAttribute("ArrayOfRecord"));
                serializer.Serialize(write, list);
            }
        }
    }
}
