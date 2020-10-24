using BL;
using ENT;
using System;
using System.Windows.Forms;

namespace WIN
{
    public partial class WINCliente : Form
    {
        public ENTCliente ECliente = new ENTCliente();
        private BLCliente cliente = new BLCliente();
        public int n = 0;
        private int id;

        public WINCliente()
        {
            InitializeComponent();
        }

        private void WINCliente_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
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

            ECliente.nombreCliente = NombreTextBox.Text;
            ECliente.apellidoCliente = ApellidoTextBox.Text;
            ECliente.telefono = TelefonoTextBox.Text;
            cliente.InsertCliente(ECliente);
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            ClienteDataGridView.DataSource = cliente.MostrarCliente();
            Limpiar();
            NombreTextBox.Focus();
        }

        private void ClienteDataGridView_Click(object sender, EventArgs e)
        {
            //Anterior Metodo de seleccion.
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            string valor = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Nombre " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            ECliente.idCLiente = id;
            cliente.DeleteCliente(ECliente);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            ECliente.idCLiente = id;
            ECliente.nombreCliente = NombreTextBox.Text;
            ECliente.apellidoCliente = ApellidoTextBox.Text;
            ECliente.telefono = TelefonoTextBox.Text;
            cliente.UpdateCliente(ECliente);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void ClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ClienteDataGridView.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)ClienteDataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            NombreTextBox.Text = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            ApellidoTextBox.Text = ClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            TelefonoTextBox.Text = ClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            errorProvider1.Clear();
        }

        //Clases Diseño

        private void HabilitarBotones(bool p1, bool p2)
        {
            Agregarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
            Eliminarbutton.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            ClienteDataGridView.Columns[0].Visible = false;
            ClienteDataGridView.Columns[1].HeaderText = "Nombre";
            ClienteDataGridView.Columns[2].HeaderText = "Apellido";
            ClienteDataGridView.Columns[3].HeaderText = "Telefono";
        }

        //Limpiar Cajas
        private void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void Enviarbutton_Click(object sender, EventArgs e)
        {
            WINDetalleVenta dv = Owner as WINDetalleVenta;
            dv.ClientetextBox.Text = NombreTextBox.Text + " " + ApellidoTextBox.Text;
            dv.TelefonotextBox.Text = TelefonoTextBox.Text;
        }
    }
}