using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrery;

namespace Serializacion
{
    public partial class SerializacionForm : BankUIForm
    {
        private readonly ISerializerFactory xmlSerializerFactory = new XmlSerializerFactory();
        private List<Record> lista = new List<Record>();

        private readonly ISerializerFactory jsonSerializerFactory = new JsonSerializerFactory();
        private List<Record> lista2 = new List<Record>();
        public SerializacionForm()
        {
            InitializeComponent();
        }

        private void SerializacionForm_Load(object sender, EventArgs e)
        {
            lista = new List<Record>();
            lista2 = new List<Record>();
        }

        private void Serializacionbutton_Click(object sender, EventArgs e)
        {

            try
            {
                string[] values = GetTextBoxValues();

                int cuenta;
                decimal saldo;

                if (!int.TryParse(values[(int)TextBoxIndices.Cuenta], out cuenta))
                {
                    MessageBox.Show("El número de cuenta debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(values[(int)TextBoxIndices.Saldo], out saldo))
                {
                    MessageBox.Show("El saldo debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Record record = new Record(cuenta, values[(int)TextBoxIndices.Nombre], values[(int)TextBoxIndices.Apellido], saldo);

                SaveFileDialog saveXmlDialog = new SaveFileDialog();
                saveXmlDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveXmlDialog.Title = "Save XML File";
                if (saveXmlDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlObjectSerializer xmlObjectSerializer = new XmlObjectSerializer();
                    lista.Add(record);
                    xmlObjectSerializer.Serializer(lista, saveXmlDialog.FileName);
                }
                MessageBox.Show("Datos serializados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Serializacionjsonbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] values = GetTextBoxValues();

                int cuenta;
                decimal saldo;

                if (!int.TryParse(values[(int)TextBoxIndices.Cuenta], out cuenta))
                {
                    MessageBox.Show("El número de cuenta debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(values[(int)TextBoxIndices.Saldo], out saldo))
                {
                    MessageBox.Show("El saldo debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Record record = new Record(cuenta, values[(int)TextBoxIndices.Nombre], values[(int)TextBoxIndices.Apellido], saldo);

                SaveFileDialog saveJsonDialog = new SaveFileDialog();
                saveJsonDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveJsonDialog.Title = "Save JSON File";
                if (saveJsonDialog.ShowDialog() == DialogResult.OK)
                {
                    JsonObjectSerializer jsonObjectSerializer = new JsonObjectSerializer();
                    lista2.Add(record);
                    jsonObjectSerializer.Serializer(lista2, saveJsonDialog.FileName);
                }

                MessageBox.Show("Datos serializados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deserializacionbutton_Click(object sender, EventArgs e)
        {
            dgv.DataSource = null;

            OpenFileDialog openXmlDialog = new OpenFileDialog();
            openXmlDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            openXmlDialog.Title = "Open XML File";
            if (openXmlDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openXmlDialog.FileName;
                lista = LoadRecords(filePath);
                dgv.DataSource = lista;

                MessageBox.Show("Datos deserializados correctamente desde: " + filePath);
            }
        }

        private void jsonbutton_Click(object sender, EventArgs e)
        {
            dvgjson.DataSource = null;


            OpenFileDialog openJsonDialog = new OpenFileDialog();
            openJsonDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openJsonDialog.Title = "Open JSON File";
            if (openJsonDialog.ShowDialog() == DialogResult.OK)
            {
                JsonObjectSerializer jsonObjectSerializer = new JsonObjectSerializer();
                lista2 = jsonObjectSerializer.Deserializer<Record>(openJsonDialog.FileName);
                dvgjson.DataSource = lista2;

                MessageBox.Show("Datos deserializados correctamente desde: " + openJsonDialog.FileName);
            }
        }

        private List<Record> LoadRecords(string filePath)
        {
            ObjectSerializer xmlObjectSerializer = new ObjectSerializer(xmlSerializerFactory);
            return xmlObjectSerializer.Deserialize<Record>(filePath);
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

