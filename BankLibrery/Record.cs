using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankLibrery
{
    [Serializable]
    [XmlRoot("Record")]
    public class Record
    {
        public int Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Saldo { get; set; }

        public Record() : this(0, string.Empty, string.Empty, 0M) { }

        public Record(int cuenta, string nombre,
            string apellido, decimal saldo)
        {
            Cuenta = cuenta;
            Nombre = nombre;
            Apellido = apellido;
            Saldo = saldo;
        }
    }
}
