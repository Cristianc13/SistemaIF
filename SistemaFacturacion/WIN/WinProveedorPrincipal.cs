using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using BL;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace WIN
{
    public partial class WinProveedorPrincipal : Form
    {
        public ENTProveedor EProveedor = new ENTProveedor();
        private BLProveedor BProveedor = new BLProveedor();
        public int n = 0;
        private int id;
        public string nombre;
        public string telefono;

        public WinProveedorPrincipal()
        {
            InitializeComponent();
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

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }


        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private void WinProveedorPrincipal_Load(object sender, EventArgs e)
        {           
            LlenarDataGrid();
            HabilitarBotones(true, false);
            FormatoGrid();
            Limpiar();
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Nombre o RUC");
            Botones();

            ContextMenu _blankContextMenu = new ContextMenu();
            textBox1.ContextMenu = _blankContextMenu;
            txtnombreProv.ContextMenu = _blankContextMenu;
            txttelefonoProv.ContextMenu = _blankContextMenu;
            txtnombreCompañia.ContextMenu = _blankContextMenu;
            txtnumeroCompañia.ContextMenu = _blankContextMenu;


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
        }

        private void LlenarDataGrid()
        {
            ProveedorGridView.DataSource = BProveedor.MostrarProveedor();
            Limpiar();
            txtnombreProv.Focus();
        }

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

        private void FormatoGrid()
        {
            ProveedorGridView.Columns[0].Visible = false;
            ProveedorGridView.Columns[1].HeaderText = "Nombre";
            ProveedorGridView.Columns[2].HeaderText = "Telefono";
            ProveedorGridView.Columns[3].HeaderText = "Nombre de la Empresa";
            ProveedorGridView.Columns[4].HeaderText = "Numero de la Empresa";
            ProveedorGridView.Columns[5].HeaderText = "RUC";

            ProveedorGridView.AllowUserToResizeColumns = false;
            ProveedorGridView.AllowUserToResizeRows = false;
            Recursos.DatagridviewDiseño.DiseñoDGV(ref ProveedorGridView);
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
            LlenarDataGrid();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID = ProveedorGridView.CurrentRow.Cells[0].Value.ToString();
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
            try
            {
                string ID = ProveedorGridView.CurrentRow.Cells[0].Value.ToString();
                id = Convert.ToInt32(ID);
                string valor = ProveedorGridView.CurrentRow.Cells[1].Value.ToString();
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = textBox1.Text;
            EProveedor.filtro = filtro;
            ProveedorGridView.DataSource = BProveedor.SelectProveedorNombre(EProveedor);
        }

        private void ProveedorGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombreProv.Text = ProveedorGridView.CurrentRow.Cells[1].Value.ToString();
            txttelefonoProv.Text = ProveedorGridView.CurrentRow.Cells[2].Value.ToString();
            txtnombreCompañia.Text = ProveedorGridView.CurrentRow.Cells[3].Value.ToString();
            txtnumeroCompañia.Text = ProveedorGridView.CurrentRow.Cells[4].Value.ToString();
            txtruc.Text = ProveedorGridView.CurrentRow.Cells[5].Value.ToString();

            HabilitarBotones(false, true);
        }

        private void Botones()
        {
            btnEditar.Visible = true;
            btneliminar.Visible = true;
        }

        private void txtnombreProv_KeyUp(object sender, KeyEventArgs e)
        {
            txtnombreProv.Text = ReducirEspaciado(txtnombreProv.Text);
            txtnombreProv.SelectionStart = txtnombreProv.Text.Length;
        }

        private void txtnombreCompañia_KeyUp(object sender, KeyEventArgs e)
        {
            txtnombreCompañia.Text = ReducirEspaciado(txtnombreCompañia.Text);
            txtnombreCompañia.SelectionStart = txtnombreCompañia.Text.Length;
        }

        private void txtruc_KeyUp(object sender, KeyEventArgs e)
        {
            txtruc.Text = ReducirEspaciado(txtruc.Text);
            txtruc.SelectionStart = txtruc.Text.Length;
        }

        private void txttelefonoProv_KeyUp(object sender, KeyEventArgs e)
        {
            txttelefonoProv.Text = ReducirEspaciado(txttelefonoProv.Text);
            txttelefonoProv.SelectionStart = txttelefonoProv.Text.Length;
        }

        private void txtnumeroCompañia_KeyUp(object sender, KeyEventArgs e)
        {
            txtnumeroCompañia.Text = ReducirEspaciado(txtnumeroCompañia.Text);
            txtnumeroCompañia.SelectionStart = txtnumeroCompañia.Text.Length;
        }
    }
}
