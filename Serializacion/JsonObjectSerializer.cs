
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace Serializacion
{
    public class JsonObjectSerializer : ISerializer
    {
        public List<T> Deserializer<T>(string fileName)
        {
            string json = File.ReadAllText(fileName);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public void Serializer<T>(List<T> list, string fileName)
        {
            string json = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(fileName, json);
        }
    }
}
