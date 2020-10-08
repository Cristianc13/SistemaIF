using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace WIN
{
    public partial class WINCliente : Form
    {
        private BLCliente cliente = new BLCliente();
        public int n = 0;

        public WINCliente()
        {
            InitializeComponent();
        }

        private void WINCliente_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            ClienteDataGridView.DataSource = cliente.MostrarCliente();
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            NombreTextBox.Focus();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar un Nombre");
                NombreTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            if (ApellidoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ApellidoTextBox, "Debe ingresar un Apellido");
                ApellidoTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            if (TelefonoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(TelefonoTextBox, "Debe ingresar un Telefono");
                TelefonoTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            cliente.InsertCliente(0, NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text);
            LlenarDataGrid();
        }

        private void ClienteDataGridView_Click(object sender, EventArgs e)
        {
        }
    }
}