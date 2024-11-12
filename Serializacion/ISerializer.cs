using BankLibrery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacion
{
    public interface ISerializer
    {
        void Serializer<T>(List<T> list, string fileName);
        List<T> Deserializer<T>(string fileName);

    }
}
