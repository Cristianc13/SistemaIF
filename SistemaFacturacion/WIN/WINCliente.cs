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
        int id;

        public WINCliente()
        {
            InitializeComponent();
        }

        private void WINCliente_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
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
            if (ClienteDataGridView.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            id = (int)ClienteDataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            NombreTextBox.Text = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            ApellidoTextBox.Text = ClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            TelefonoTextBox.Text = ClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            errorProvider1.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            string valor = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Nombre " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            cliente.DeleteCliente(id);
            LlenarDataGrid();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            cliente.UpdateCliente(id, NombreTextBox.Text, ApellidoTextBox.Text, TelefonoTextBox.Text);
            LlenarDataGrid();
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Agregarbutton.Enabled = p2;
            Actualizarbutton.Enabled = p1;
            Eliminarbutton.Enabled = p1;
            Cancelarbutton.Enabled = p1;
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            errorProvider1.Clear();
        }
    }
}