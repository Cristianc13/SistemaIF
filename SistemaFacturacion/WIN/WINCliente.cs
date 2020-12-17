using System;
using System.Windows.Forms;
using BL;
using ENT;
using BL;
using System.Drawing;
using System.Runtime.InteropServices;

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

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void WINCliente_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
            SendMessage(textBoxBuscar.Handle, EM_SETCUEBANNER, 0, "Nombre, Apellido o Telefono");
            ContextMenu _blankContextMenu = new ContextMenu();
            NombreTextBox.ContextMenu = _blankContextMenu;
            ApellidoTextBox.ContextMenu = _blankContextMenu;
            TelefonoTextBox.ContextMenu = _blankContextMenu;
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
            ClienteDataGridView.DataSource = cliente.MostrarClientes();
            Limpiar();
            NombreTextBox.Focus();
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
                dv.ClientecomboBox.Text = nombre +" "+ apellido;
                dv.TelefonotextBox.Text = telefono;
                dv.ClientecomboBox.Enabled = false;
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

            btnagregar.Enabled = p2;
            if (btnagregar.Enabled == true)
            {
                btnagregar.BackColor = Color.FromArgb(21, 30, 41);
                btnagregar.IconColor = Color.White;
            }
            else
            {
                btnagregar.BackColor = Color.FromArgb(177, 180, 183);
                btnagregar.IconColor = Color.Black;
            }

        }
        private void Habilitar(bool p1, bool p2)
        {
            btnagregar.Enabled = p2;
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
            HabilitarBotones(false, true);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar un Nombre");
                NombreTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            if (ApellidoTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(ApellidoTextBox, "Debe ingresar un Apellido");
                ApellidoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (TelefonoTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(TelefonoTextBox, "Debe ingresar un Telefono");
                TelefonoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

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

        private void btneliminar_Click(object sender, EventArgs e)
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (NombreTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(NombreTextBox, "Debe ingresar un Nombre");
                NombreTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            if (ApellidoTextBox.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(ApellidoTextBox, "Debe ingresar un Apellido");
                ApellidoTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (TelefonoTextBox.Text.Trim() == string.Empty)
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
            dv.ClientecomboBox.DisplayMember = "cliente";
            dv.ClientecomboBox.ValueMember = "idCliente";
            dv.ClientecomboBox.SelectedIndex = -1;

            dv.ClientecomboBox.Text = NombreTextBox.Text +" "+ ApellidoTextBox.Text;
            dv.TelefonotextBox.Text = TelefonoTextBox.Text;
            dv.ClientecomboBox.Enabled = false;

            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            textBoxBuscar.Text = ReducirEspaciado(textBoxBuscar.Text);
            textBoxBuscar.SelectionStart = textBoxBuscar.Text.Length;

            string filtro;
            filtro = textBoxBuscar.Text;
            ECliente.Filtro = filtro;
            ClienteDataGridView.DataSource = BCliente.FiltarClientes(ECliente);
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ApellidoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NombreTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            NombreTextBox.Text = ReducirEspaciado(NombreTextBox.Text);
            NombreTextBox.SelectionStart = NombreTextBox.Text.Length;
        }

        private void ApellidoTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ApellidoTextBox.Text = ReducirEspaciado(ApellidoTextBox.Text);
            ApellidoTextBox.SelectionStart = ApellidoTextBox.Text.Length;
        }


    }
}