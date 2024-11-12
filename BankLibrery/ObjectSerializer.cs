using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public class ObjectSerializer
    {
        private readonly ISerializerFactory _factory;

        public ObjectSerializer(ISerializerFactory factory)
        {
            _factory = factory;
        }

        public void Serialize<T>(List<T> list, string fileName)
        {
            ISerializer serializer = _factory.CreateSerializer();
            serializer.Serializer(list, fileName);
        }

        public List<T> Deserialize<T>(string fileName)
        {
            ISerializer serializer = _factory.CreateSerializer();
            return serializer.Deserializer<T>(fileName);
        }
    }
}
