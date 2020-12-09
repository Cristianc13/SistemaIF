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
using ENT;

namespace WIN
{
    public partial class WINClientePrincipal : Form
    {
        public WINClientePrincipal()
        {
            InitializeComponent();
        }

        private BLCliente BCliente = new BLCliente();
        public ENTCliente ECliente = new ENTCliente();
        private BLCliente cliente = new BLCliente();
        private int id;

        private void WINClientePrincipal_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
            Botones();
        }

        private void LlenarDataGrid()
        {
            ClientedataGridView.DataSource = cliente.MostrarClientes();
            Limpiar();
            textBoxnombre.Focus();
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnguardar.Enabled = p1;
            if (btnguardar.Enabled == true)
            {
                btnguardar.BackColor = Color.FromArgb(21, 30, 41);
                btnguardar.IconColor = Color.White;
            }
            else
            {
                btnguardar.BackColor = Color.FromArgb(177, 180, 183);
                btnguardar.IconColor = Color.Black;
            }

            btnEditar.Enabled = p2;
            if (btnEditar.Enabled == true)
            {
                btnEditar.BackColor = Color.FromArgb(21, 30, 41);
                btnEditar.IconColor = Color.White;
            }
            else
            {
                btnEditar.BackColor = Color.FromArgb(177, 180, 183);
                btnEditar.IconColor = Color.Black;
            }

            //Cancelarbutton.Enabled = p1;
        }

        private void Habilitar(bool p1, bool p2)
        {
            btnEditar.Enabled = p2;
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            ClientedataGridView.Columns[0].Visible = false;
            ClientedataGridView.Columns[1].HeaderText = "Nombre";
            ClientedataGridView.Columns[2].HeaderText = "Apellido";
            ClientedataGridView.Columns[3].HeaderText = "Telefono";

            WIN.Recursos.DatagridviewDiseño.DiseñoDGV(ref ClientedataGridView);
        }

        //Limpiar Cajas
        private void Limpiar()
        {
            textBoxnombre.Text = string.Empty;
            TextBoxApellido.Text = string.Empty;
            textboxTelefono.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (textBoxnombre.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(textBoxnombre, "Debe ingresar un Nombre");
                textBoxnombre.Focus();
                return;
            }

            errorProvider1.Clear();

            if (TextBoxApellido.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(TextBoxApellido, "Debe ingresar un Apellido");
                TextBoxApellido.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textboxTelefono.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(textboxTelefono, "Debe ingresar un Telefono");
                textboxTelefono.Focus();
                return;
            }
            errorProvider1.Clear();

            ECliente.nombreCliente = textBoxnombre.Text;
            ECliente.apellidoCliente = TextBoxApellido.Text;
            ECliente.telefono = textboxTelefono.Text;
            cliente.InsertCliente(ECliente);
            MessageBox.Show("Cliente Registrado");
            LlenarDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (textBoxnombre.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(textBoxnombre, "Debe ingresar un Nombre");
                textBoxnombre.Focus();
                return;
            }

            errorProvider1.Clear();

            if (TextBoxApellido.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(TextBoxApellido, "Debe ingresar un Apellido");
                TextBoxApellido.Focus();
                return;
            }
            errorProvider1.Clear();

            if (textboxTelefono.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(textboxTelefono, "Debe ingresar un Telefono");
                textboxTelefono.Focus();
                return;
            }
            errorProvider1.Clear();

            string ID = ClientedataGridView.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(ID);
            ECliente.idCLiente = id;
            ECliente.nombreCliente = textBoxnombre.Text;
            ECliente.apellidoCliente = TextBoxApellido.Text;
            ECliente.telefono = textboxTelefono.Text;
            cliente.UpdateCliente(ECliente);
            LlenarDataGrid();
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string ID = ClientedataGridView.CurrentRow.Cells[0].Value.ToString();
            string valor = ClientedataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Cliente: " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;
            id = Convert.ToInt32(ID);
            ECliente.idCLiente = id;
            cliente.DeleteCliente(ECliente);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void ClientedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClientedataGridView.CurrentRow == null) return;

            try
            {
                id = (int)ClientedataGridView.CurrentRow.Cells[0].Value;
                textBoxnombre.Text = ClientedataGridView.CurrentRow.Cells[1].Value.ToString();
                TextBoxApellido.Text = ClientedataGridView.CurrentRow.Cells[2].Value.ToString();
                textboxTelefono.Text = ClientedataGridView.CurrentRow.Cells[3].Value.ToString();
                errorProvider1.Clear();
                Habilitar(true, true);
                HabilitarBotones(false, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Botones()
        {
            btnEditar.Visible = true;
        }

        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = textBoxBuscar.Text;
            ECliente.Filtro = filtro;
            ClientedataGridView.DataSource = BCliente.FiltarClientes(ECliente);
        }

        private void textboxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void textBoxnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }
    }
}