using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void WINClientePrincipal_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
            Botones();
            SendMessage(textBoxBuscar.Handle, EM_SETCUEBANNER, 0, "Nombre, Apellido o Telefono");
            ContextMenu _blankContextMenu = new ContextMenu();
            textBoxnombre.ContextMenu = _blankContextMenu;
            TextBoxApellido.ContextMenu = _blankContextMenu;
            textboxTelefono.ContextMenu = _blankContextMenu;
            textBoxBuscar.ContextMenu = _blankContextMenu;
        }

        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        private const Keys CutKeys = Keys.Control | Keys.X;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys) || (keyData == CutKeys))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
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

            btneliminar.Enabled = p2;
            if (btneliminar.Enabled == true)
            {
                btneliminar.BackColor = Color.FromArgb(21, 30, 41);
                btneliminar.IconColor = Color.White;
            }
            else
            {
                btneliminar.BackColor = Color.FromArgb(177, 180, 183);
                btneliminar.IconColor = Color.Black;
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
            textBoxBuscar.Text = "";
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
            HabilitarBotones(true, false);
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
            LlenarDataGrid();
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
            textBoxBuscar.Text = ReducirEspaciado(textBoxBuscar.Text);
            textBoxBuscar.SelectionStart = textBoxBuscar.Text.Length;

            string filtro;
            filtro = textBoxBuscar.Text;
            ECliente.Filtro = filtro;
            ClientedataGridView.DataSource = BCliente.FiltarClientes(ECliente);
        }

        private void textboxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }

        private void textBoxnombre_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxnombre.Text = ReducirEspaciado(textBoxnombre.Text);
            textBoxnombre.SelectionStart = textBoxnombre.Text.Length;
        }

        private void TextBoxApellido_KeyUp(object sender, KeyEventArgs e)
        {
            TextBoxApellido.Text = ReducirEspaciado(TextBoxApellido.Text);
            TextBoxApellido.SelectionStart = TextBoxApellido.Text.Length;
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ID = ClientedataGridView.CurrentRow.Cells[0].Value.ToString();
                id = Convert.ToInt32(ID);
                string Cliente = ClientedataGridView.CurrentRow.Cells[1].Value.ToString();
                string Apellido = ClientedataGridView.CurrentRow.Cells[2].Value.ToString();

                DialogResult rpt = MessageBox.Show("Desea eliminar el Cliente: " + Cliente + " " + Apellido, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (rpt == DialogResult.No) return;
                ECliente.idCLiente = id;
                BCliente.DeleteCliente(ECliente);
                HabilitarBotones(true, false);
                Limpiar();
                LlenarDataGrid();
                textBoxnombre.Text = "";
                textboxTelefono.Text = "";
                TextBoxApellido.Text = "";
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("FK_venta_cliente"))
                {
                    MessageBox.Show("Este ClienteEsta sujeto a Transacciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HabilitarBotones(true, false);
                    textBoxnombre.Text = "";
                    textboxTelefono.Text = "";
                    TextBoxApellido.Text = "";
                }
            }
        }
    }
}