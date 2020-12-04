using System;
using System.Windows.Forms;
using BL;
using ENT;
using BL;

namespace WIN
{
    public partial class WINCliente : Form
    {
        private BLCliente BCliente = new BLCliente();
        public ENTCliente ECliente = new ENTCliente();
        private BLCliente cliente = new BLCliente();
        public int n = 0;
        private int id;
        string nombre;
        string apellido;
        string telefono;

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
            //LlenarDataGrid();

            WINDetalleVenta dv = Owner as WINDetalleVenta;
            dv.ClientecomboBox.DataSource = BCliente.MostrarCliente();
            dv.ClientecomboBox.DisplayMember = "nombreCliente";
            dv.ClientecomboBox.ValueMember = "idCliente";
            dv.ClientecomboBox.SelectedIndex = -1;

            dv.ClientecomboBox.Text = NombreTextBox.Text;
            dv.TelefonotextBox.Text = TelefonoTextBox.Text;

            this.Close();
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
            string ID = ClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            string valor = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();           
            DialogResult rpt = MessageBox.Show("Eliminar Cliente: " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            id = Convert.ToInt32(ID);
            ECliente.idCLiente = id;
            cliente.DeleteCliente(ECliente);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            string ID = ClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(ID);
            ECliente.idCLiente = id;
            ECliente.nombreCliente = NombreTextBox.Text;
            ECliente.apellidoCliente = ApellidoTextBox.Text;
            ECliente.telefono = TelefonoTextBox.Text;
            cliente.UpdateCliente(ECliente);
            LlenarDataGrid();
            Limpiar();
            //HabilitarBotones(true, false);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            //HabilitarBotones(true, false);
            Limpiar();
        }

        private void ClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            //if (ClienteDataGridView.Rows.Count == 0) return;
            if (ClienteDataGridView.CurrentRow == null) return;

            try
            {
                id = (int)ClienteDataGridView.CurrentRow.Cells[0].Value;
                nombre = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
                apellido = ClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
                telefono = ClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
                errorProvider1.Clear();

                WINDetalleVenta dv = Owner as WINDetalleVenta;
                dv.ClientecomboBox.Text = nombre;
                dv.TelefonotextBox.Text = telefono;
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Clases Diseño

        private void HabilitarBotones(bool p1, bool p2)
        {
            Agregarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
            Eliminarbutton.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
        }
        private void Habilitar(bool p1, bool p2)
        {
            Eliminarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            ClienteDataGridView.Columns[0].Visible = false;
            ClienteDataGridView.Columns[1].HeaderText = "Nombre";
            ClienteDataGridView.Columns[2].HeaderText = "Apellido";
            ClienteDataGridView.Columns[3].HeaderText = "Telefono";

            WIN.Recursos.DatagridviewDiseño.DiseñoDGV(ref ClienteDataGridView);
        }

        //Limpiar Cajas
        private void Limpiar()
        {
            NombreTextBox.Text = string.Empty;
            ApellidoTextBox.Text = string.Empty;
            TelefonoTextBox.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void ClienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NombreTextBox.Text = ClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            ApellidoTextBox.Text = ClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            TelefonoTextBox.Text = ClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            Habilitar(true, true);
        }

    }
}