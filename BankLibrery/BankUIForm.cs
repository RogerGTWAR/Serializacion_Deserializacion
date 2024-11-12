using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLibrery
{
    public partial class BankUIForm : Form
    {
        protected int TextBoxCount { get; set; } = 4;

        public enum TextBoxIndices { Cuenta, Nombre, Apellido, Saldo }
        public BankUIForm()
        {
            InitializeComponent();
        }
        public void ClearTextBox()
        {
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();
            }
        }

        public TextBox GetAccountTextBox()
        {
            return TxtCuenta;
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw (new ArgumentException($"There must be {TextBoxCount} string in the array", nameof(values)));
            }
            else
            {
                TxtCuenta.Text = values[(int)TextBoxIndices.Cuenta];
                TxtNombre.Text = values[(int)TextBoxIndices.Nombre];
                TxtApellido.Text = values[(int)TextBoxIndices.Apellido];
                TxtSaldo.Text = values[(int)TextBoxIndices.Saldo];
            }
        }

        public string[] GetTextBoxValues()
        {
            return new string[] {

                TxtCuenta.Text, TxtNombre.Text,
                TxtApellido.Text, TxtSaldo.Text
            };
        }

        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSaldo_TextChanged(object sender, EventArgs e)
        {

        }
        private void BankUIForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
