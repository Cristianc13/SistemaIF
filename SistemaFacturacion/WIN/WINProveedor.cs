using System;
using System.Windows.Forms;
using BL;
using ENT;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Data.SqlClient;

namespace WIN
{
    public partial class WINProveedor : Form
    {
        public ENTProveedor EProveedor = new ENTProveedor();
        private BLProveedor BProveedor = new BLProveedor();
        public int n = 0;
        private int id;
        public string nombre;
        public string telefono;

        public WINProveedor()
        {
            InitializeComponent();
        }

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
[MarshalAs(UnmanagedType.LPWStr)] string lParam);

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

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }



        private void WINProveedor_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
            Limpiar();
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Nombre o RUC");
            Botones();

            ContextMenu _blankContextMenu = new ContextMenu();
            txtnombreProv.ContextMenu = _blankContextMenu;
            txtnombreCompañia.ContextMenu = _blankContextMenu;
            txttelefonoProv.ContextMenu = _blankContextMenu;
            txtnumeroCompañia.ContextMenu = _blankContextMenu;
            txtruc.ContextMenu = _blankContextMenu;
            textBox1.ContextMenu = _blankContextMenu;


        }

        private void GuardarProv_Click(object sender, EventArgs e)
        {
            if (txtnombreProv.Text == string.Empty)
            {
                errorProvider1.SetError(txtnombreProv, "Debe ingresar un Nombre");
                txtnombreProv.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txttelefonoProv.Text == string.Empty)
            {
                errorProvider1.SetError(txttelefonoProv, "Debe ingresar un Numero Telefonico");
                txttelefonoProv.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnombreCompañia.Text == string.Empty)
            {
                errorProvider1.SetError(txtnombreCompañia, "Debe ingresar un Nombre de la Empresa");
                txtnombreCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnumeroCompañia.Text == string.Empty)
            {
                errorProvider1.SetError(txtnumeroCompañia, "Debe ingresar un Numero de la Empresa");
                txtnumeroCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            EProveedor.nombreProv = txtnombreProv.Text;
            EProveedor.telefonoProv = txttelefonoProv.Text;
            EProveedor.nombreCompañia = txtnombreCompañia.Text;
            EProveedor.numeroCompañia = txtnumeroCompañia.Text;
            EProveedor.ruc = txtruc.Text;
            BProveedor.InsertProveedor(EProveedor);
            //LlenarDataGrid();

            WINDCompracs dc = Owner as WINDCompracs;
            dc.CmbProveedor.DataSource = BProveedor.MostrarProveedor();
            dc.CmbProveedor.DisplayMember = "nombreProv";
            dc.CmbProveedor.ValueMember = "idProveedor";
            dc.CmbProveedor.SelectedIndex = -1;

            dc.CmbProveedor.Text = txtnombreProv.Text;
            dc.txtnombreCompañia.Text = txtnombreCompañia.Text;

            this.Close();

        }

        private void LlenarDataGrid()
        {
            dataGridProovedor.DataSource = BProveedor.MostrarProveedor();
            Limpiar();
            txtnombreProv.Focus();
        }

        //Clases Diseño

        private void HabilitarBotones(bool p1, bool p2)
        {
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

            //btneliminar.Enabled = p2;
            //if (btneliminar.Enabled == true)
            //{
            //    btneliminar.BackColor = Color.FromArgb(21, 30, 41);
            //    btneliminar.IconColor = Color.White;
            //}
            //else
            //{
            //    btneliminar.BackColor = Color.FromArgb(177, 180, 183);
            //    btneliminar.IconColor = Color.Black;
            //}

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

        }

        //Formato a la grid
        private void FormatoGrid()
        {
            dataGridProovedor.Columns[0].Visible = false;
            dataGridProovedor.Columns[1].HeaderText = "Nombre";
            dataGridProovedor.Columns[2].HeaderText = "Telefono";
            dataGridProovedor.Columns[3].HeaderText = "Nombre de la Empresa";
            dataGridProovedor.Columns[4].HeaderText = "Numero de la Empresa";
            dataGridProovedor.Columns[5].HeaderText = "RUC";

            dataGridProovedor.AllowUserToResizeColumns = false;
            dataGridProovedor.AllowUserToResizeRows = false;
            Recursos.DatagridviewDiseño.DiseñoDGV(ref dataGridProovedor);
        }

        //Limpiar Cajas

        private void Limpiar()
        {
            txtnombreProv.Text = string.Empty;
            txttelefonoProv.Text = string.Empty;
            txtnombreCompañia.Text = string.Empty;
            txtnumeroCompañia.Text = string.Empty;
            txtruc.Text = string.Empty;
            textBox1.Text = string.Empty;
            
            errorProvider1.Clear();
        }

        private void dataGridProovedor_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridProovedor.CurrentRow == null) return;

            try
            {
                id = (int)dataGridProovedor.CurrentRow.Cells[0].Value;
                nombre = dataGridProovedor.CurrentRow.Cells[1].Value.ToString();

                telefono = dataGridProovedor.CurrentRow.Cells[3].Value.ToString();
                errorProvider1.Clear();

                WINDCompracs dc = Owner as WINDCompracs;
                dc.CmbProveedor.DataSource = BProveedor.MostrarProveedorCombo();
                dc.CmbProveedor.DisplayMember = "proveedor";
                dc.CmbProveedor.ValueMember = "idProveedor";
                dc.CmbProveedor.SelectedIndex = -1;

                dc.CmbProveedor.Text = txtnombreProv.Text + " - " + txttelefonoProv.Text;
                dc.txtnombreCompañia.Text = txtnombreCompañia.Text;
                //dc.CmbProveedor.Enabled = false;
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void EliminarProv_Click(object sender, EventArgs e)
        {
            string ID = dataGridProovedor.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(ID);
            string valor = dataGridProovedor.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Nombre " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            EProveedor.idProveedor = id;
            BProveedor.DeleteProveedor(EProveedor);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void ActualizarProv_Click(object sender, EventArgs e)
        {
            string ID = dataGridProovedor.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(ID);
            EProveedor.idProveedor = id;
            EProveedor.nombreProv = txtnombreProv.Text;
            EProveedor.telefonoProv = txttelefonoProv.Text;
            EProveedor.nombreCompañia = txtnombreCompañia.Text;
            EProveedor.numeroCompañia = txtnumeroCompañia.Text;
            EProveedor.ruc = txtruc.Text;
            BProveedor.UpdateProveedor(EProveedor);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void CancelarProv_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = textBox1.Text;
            EProveedor.filtro = filtro;
            dataGridProovedor.DataSource = BProveedor.SelectProveedorNombre(EProveedor);
        }

        private void dataGridProovedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombreProv.Text = dataGridProovedor.CurrentRow.Cells[1].Value.ToString();
            txttelefonoProv.Text = dataGridProovedor.CurrentRow.Cells[2].Value.ToString();
            txtnombreCompañia.Text = dataGridProovedor.CurrentRow.Cells[3].Value.ToString();
            txtnumeroCompañia.Text = dataGridProovedor.CurrentRow.Cells[4].Value.ToString();
            txtruc.Text = dataGridProovedor.CurrentRow.Cells[5].Value.ToString();

            HabilitarBotones(false, true);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtnombreProv.Text == string.Empty)
            {
                errorProvider1.SetError(txtnombreProv, "Debe ingresar un Nombre");
                txtnombreProv.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txttelefonoProv.Text == string.Empty)
            {
                errorProvider1.SetError(txttelefonoProv, "Debe ingresar un Numero Telefonico");
                txttelefonoProv.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnombreCompañia.Text == string.Empty)
            {
                errorProvider1.SetError(txtnombreCompañia, "Debe ingresar un Nombre de la Empresa");
                txtnombreCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnumeroCompañia.Text == string.Empty)
            {
                errorProvider1.SetError(txtnumeroCompañia, "Debe ingresar un Numero de la Empresa");
                txtnumeroCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            EProveedor.nombreProv = txtnombreProv.Text;
            EProveedor.telefonoProv = txttelefonoProv.Text;
            EProveedor.nombreCompañia = txtnombreCompañia.Text;
            EProveedor.numeroCompañia = txtnumeroCompañia.Text;
            EProveedor.ruc = txtruc.Text;
            BProveedor.InsertProveedor(EProveedor);
            //LlenarDataGrid();

            WINDCompracs dc = Owner as WINDCompracs;
            dc.CmbProveedor.DataSource = BProveedor.MostrarProveedorCombo();
            dc.CmbProveedor.DisplayMember = "nombreProv";
            dc.CmbProveedor.ValueMember = "idProveedor";
            dc.CmbProveedor.SelectedIndex = -1;

            dc.CmbProveedor.Text = txtnombreProv.Text + " - " + txttelefonoProv.Text;
            dc.txtnombreCompañia.Text = txtnombreCompañia.Text;
            //dc.CmbProveedor.Enabled = false;

            this.Close();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombreProv.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtnombreProv, "Debe ingresar un Nombre");
                txtnombreProv.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txttelefonoProv.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txttelefonoProv, "Debe ingresar un Numero Telefonico");
                txttelefonoProv.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnombreCompañia.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtnombreCompañia, "Debe ingresar un Nombre de la Empresa");
                txtnombreCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnumeroCompañia.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtnumeroCompañia, "Debe ingresar un Numero de la Empresa");
                txtnumeroCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            string ID = dataGridProovedor.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(ID);
            EProveedor.idProveedor = id;
            EProveedor.nombreProv = txtnombreProv.Text;
            EProveedor.telefonoProv = txttelefonoProv.Text;
            EProveedor.nombreCompañia = txtnombreCompañia.Text;
            EProveedor.numeroCompañia = txtnumeroCompañia.Text;
            EProveedor.ruc = txtruc.Text;
            BProveedor.UpdateProveedor(EProveedor);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }
        private void Botones()
        {
            btnguardar.Visible = true;
           
        }

        private void txtnombreProv_KeyUp(object sender, KeyEventArgs e)
        {
            txtnombreProv.Text = ReducirEspaciado(txtnombreProv.Text);
            txtnombreProv.SelectionStart = txtnombreProv.Text.Length;
        }

        private void txttelefonoProv_KeyUp(object sender, KeyEventArgs e)
        {
            txttelefonoProv.Text = ReducirEspaciado(txttelefonoProv.Text);
            txttelefonoProv.SelectionStart = txttelefonoProv.Text.Length;
        }

        private void txtnombreCompañia_KeyUp(object sender, KeyEventArgs e)
        {
            txtnombreCompañia.Text = ReducirEspaciado(txtnombreCompañia.Text);
            txtnombreCompañia.SelectionStart = txtnombreCompañia.Text.Length;
        }

        private void txtnumeroCompañia_KeyUp(object sender, KeyEventArgs e)
        {
            txtnumeroCompañia.Text = ReducirEspaciado(txtnumeroCompañia.Text);
            txtnumeroCompañia.SelectionStart = txtnumeroCompañia.Text.Length;
        }

        private void txtruc_KeyUp(object sender, KeyEventArgs e)
        {
            txtruc.Text = ReducirEspaciado(txtruc.Text);
            txtruc.SelectionStart = txtruc.Text.Length;
        }

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ID = dataGridProovedor.CurrentRow.Cells[0].Value.ToString();
                id = Convert.ToInt32(ID);
                string valor = dataGridProovedor.CurrentRow.Cells[1].Value.ToString();
                DialogResult rpt = MessageBox.Show("Eliminar Nombre " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (rpt == DialogResult.No) return;

                //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
                EProveedor.idProveedor = id;
                BProveedor.DeleteProveedor(EProveedor);
                LlenarDataGrid();
                Limpiar();
                HabilitarBotones(true, false);
        }

            catch (SqlException ex)
            {
                if (ex.Message.Contains("FK_compra_proveedor"))
                {
                    MessageBox.Show("Este Proveedor Esta sujeto a Transacciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
}
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}