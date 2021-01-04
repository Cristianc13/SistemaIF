using System;
using System.Windows.Forms;
using BL;
using ENT;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Drawing;

namespace WIN
{
    public partial class WINProVent : Form
    {
        private BLProducto BProducto = new BLProducto();
        private ENTProducto Eproducto = new ENTProducto();
        private string codigo;
        private string marca;
        private string modelo;
        private string estado;
        string descripcion;
        private string stock;
        string producto;

        public WINProVent()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MinimumSize = this.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void WINProVent_Load(object sender, EventArgs e)
        {
            llenarGrid();
            FormatoGrid();
            SendMessage(BuscartextBox.Handle, EM_SETCUEBANNER, 0, "Codigo o Nombre");
            SendMessage(MarcModeltextBox.Handle, EM_SETCUEBANNER, 0, "Marca o Modelo");
            ContextMenu _blankContextMenu = new ContextMenu();
            BuscartextBox.ContextMenu = _blankContextMenu;
            MarcModeltextBox.ContextMenu = _blankContextMenu;
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

        public void FormatoGrid()
        {
            ProductodataGridView.Columns[0].Visible = false;
            ProductodataGridView.Columns[1].HeaderText = "Codigo";
            ProductodataGridView.Columns[2].HeaderText = "Producto";
            ProductodataGridView.Columns[3].HeaderText = "Marca";
            ProductodataGridView.Columns[4].HeaderText = "Modelo";
            ProductodataGridView.Columns[5].HeaderText = "Categoria";
            ProductodataGridView.Columns[6].HeaderText = "Stock";
            ProductodataGridView.Columns[7].HeaderText = "Importe";
            ProductodataGridView.Columns[8].HeaderText = "Descripcion";
            ProductodataGridView.Columns[9].HeaderText = "Estado";
            ProductodataGridView.AllowUserToResizeColumns = false;
            ProductodataGridView.AllowUserToResizeRows = false;
            Recursos.DatagridviewDiseño.DiseñoDGV(ref ProductodataGridView);
        }

        public void llenarGrid()
        {
            ProductodataGridView.DataSource = BProducto.MostrarProductoVenta();
        }

        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);


        private void ProductodataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ProductodataGridView.CurrentRow == null) return;

            codigo = ProductodataGridView.CurrentRow.Cells[1].Value.ToString(); /*1 3 4 9*/
            producto = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            marca = ProductodataGridView.CurrentRow.Cells[3].Value.ToString();
            descripcion = ProductodataGridView.CurrentRow.Cells[8].Value.ToString();
            modelo = ProductodataGridView.CurrentRow.Cells[4].Value.ToString();
            estado = ProductodataGridView.CurrentRow.Cells[9].Value.ToString();

            stock = ProductodataGridView.CurrentRow.Cells[6].Value.ToString();

            decimal x = Convert.ToDecimal(stock);
            if (x <= 0)
            {
                MessageBox.Show("Stock del producto en su minimo valor");
            }
            else
            {
                WINDetalleVenta dx = Owner as WINDetalleVenta;
                dx.ProductocomboBox.Text = codigo + " " + producto +" "+ marca +" "+ descripcion +" "+ modelo +" - "+ estado;
                this.Close();
            }
        }

        private void BuscartextBox_KeyUp(object sender, KeyEventArgs e)
        {
            BuscartextBox.Text = ReducirEspaciado(BuscartextBox.Text);
            BuscartextBox.SelectionStart = BuscartextBox.Text.Length;

            string filtro;
            filtro = BuscartextBox.Text;
            Eproducto.codigopro = filtro;
            ProductodataGridView.DataSource = BProducto.BuscarProdCodigoNombre(Eproducto);
        }

        private void MarcModeltextBox_KeyUp(object sender, KeyEventArgs e)
        {
            MarcModeltextBox.Text = ReducirEspaciado(MarcModeltextBox.Text);
            MarcModeltextBox.SelectionStart = MarcModeltextBox.Text.Length;

            string filtro;
            filtro = MarcModeltextBox.Text;
            Eproducto.codigopro = filtro;
            ProductodataGridView.DataSource = BProducto.BusarProdMarcaModelo(Eproducto);
        }

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            BuscartextBox.Text = "";
            MarcModeltextBox.Text = "";
            llenarGrid();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductodataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.ProductodataGridView.Columns[e.ColumnIndex].Name == "stockProducto")
            {
                if (Convert.ToInt32(e.Value) <= 3)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(156, 0, 6);
                    e.CellStyle.BackColor = Color.FromArgb(255, 199, 206);
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}