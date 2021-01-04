using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINDetalleVenta : Form
    {
        public WINDetalleVenta()
        {
            InitializeComponent();
        }

        private int idProducto = 0;
        private decimal stock;
        private decimal costo;
        private int idCl = 0;
        public int idventa;
        private int fila;

        private List<ENTVenta> Eventa = new List<ENTVenta>();
        private List<ENTDetalleVenta> EDventa = new List<ENTDetalleVenta>();
        private ENTDetalleVenta miDetalle = new ENTDetalleVenta();

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleVenta BLDetalle = new BLDetalleVenta();
        private BLCliente BCliente = new BLCliente();

        private void WINDetalleVenta_Load(object sender, EventArgs e)
        {
            ImportetextBox.Text = "0";
            HabilitarBotones(false, false);
            LlenarComboCliente();
            LlenaComboProducto();
            Limpiar();
            DescuentotextBox.Text = "0";
            ClientecomboBox.Focus();
            Botones();

            ContextMenu _blankContextMenu = new ContextMenu();
            ProductocomboBox.ContextMenu = _blankContextMenu;
            ClientecomboBox.ContextMenu = _blankContextMenu;
            TelefonotextBox.ContextMenu = _blankContextMenu;
            DescuentotextBox.ContextMenu = _blankContextMenu;
            PreciotextBox.ContextMenu = _blankContextMenu;
            CantidadtextBox.ContextMenu = _blankContextMenu;
            ImportetextBox.ContextMenu = _blankContextMenu;
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

        private void Botones()
        {
            btneliminar.Visible = true;
            btnguardar.Visible = true;
        }
        private void FormatoGrid()
        {
            DVentadataGridView.Columns[0].Visible = false;
            DVentadataGridView.Columns[1].Visible = false;
            DVentadataGridView.Columns[2].HeaderText = "Producto";
            DVentadataGridView.Columns[3].HeaderText = "Cantidad";
            DVentadataGridView.Columns[4].HeaderText = "Costo";
            DVentadataGridView.Columns[5].HeaderText = "Importe";
            DVentadataGridView.Columns[6].Visible = false;
            DVentadataGridView.AllowUserToResizeColumns = false;
            DVentadataGridView.AllowUserToResizeRows = false;

            DVentadataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            DVentadataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            Recursos.DatagridviewDiseño.DiseñoDGV(ref DVentadataGridView);
        }

        private void LlenaComboProducto()
        {
            ProductocomboBox.DataSource = BProducto.MostrarProducto();
            ProductocomboBox.DisplayMember = "Producto";
            ProductocomboBox.ValueMember = "idProducto";
            ProductocomboBox.SelectedIndex = -1;
        }

        private void LlenarComboCliente()
        {
            ClientecomboBox.DataSource = BCliente.MostrarCliente();
            ClientecomboBox.DisplayMember = "cliente";
            ClientecomboBox.ValueMember = "idCliente";
            ClientecomboBox.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            ProductocomboBox.Text = string.Empty;
            CantidadtextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            errorProvider1.Clear();
            ProductocomboBox.SelectedIndex = -1;
            ProductocomboBox.Focus();
        }

        private void ProductocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProductocomboBox.SelectedValue != null)
                {
                    idProducto = (int)ProductocomboBox.SelectedValue;
                    PreciotextBox.Text = Convert.ToString(BProducto.ObtenerPrecio(idProducto));
                    stock = Convert.ToDecimal(BProducto.ObtenerStock(idProducto));
                    costo = Convert.ToDecimal(BProducto.SelectProductocosto(idProducto));
                }
            }
            catch (Exception)
            {
            }
        }

        private void ClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ClientecomboBox.SelectedValue != null)
                {
                    idCl = (int)ClientecomboBox.SelectedValue;
                    TelefonotextBox.Text = Convert.ToString(BCliente.ObtenerNumeroCliente(idCl));
                }
            }
            catch (Exception)
            {
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow dr in DVentadataGridView.Rows)
            {
                decimal importe = decimal.Parse(dr.Cells[5].Value.ToString());
                total += importe;
            }
            ImportetextBox.Text = total.ToString();
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
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ClientecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void DescuentotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void EnviarID()
        {
            WINReportes.RReporteVenta GenerarFactura = new WINReportes.RReporteVenta();
            GenerarFactura.Factura = idventa;
            GenerarFactura.ShowDialog();
        }

        private void Eliminar()
        {
            if (DVentadataGridView.Rows.Count == 0)
            {
                HabilitarBotones(false, false);
            }
            else
            {
                HabilitarBotones(true, false);
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (ProductocomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ProductocomboBox, "Debe ingresar un Producto");
                return;
            }
            errorProvider1.Clear();

            if (CantidadtextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CantidadtextBox, "Debe ingresar una Cantidad");
                return;
            }
            errorProvider1.Clear();

            Cero();
            decimal cantidad = Convert.ToDecimal(CantidadtextBox.Text);
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            decimal descuento = Convert.ToDecimal(DescuentotextBox.Text);
            decimal NuevoPrecio = precio - descuento;
            int N = 1;

            if (NuevoPrecio <= costo)
            {
                MessageBox.Show("No puedes Vender este porducto por menos de: " + "C$" + (Convert.ToDecimal(N) + costo), "Advertencia");
            }
            else if (stock == 0)
            {
                MessageBox.Show("No Hay existencia de este producto");
                CantidadtextBox.Text = "";
                PreciotextBox.Text = "";
                ProductocomboBox.SelectedIndex = -1;
                ProductocomboBox.Focus();
            }
            else if (cantidad == 0)
            {
                MessageBox.Show("Para realizar la venta debes agregar la cantidad a vender");
            }
            else if (cantidad > stock)
            {
                MessageBox.Show("No puedes venter mas de:" + " " + stock + " " + "Productos");
                CantidadtextBox.Focus();
            }
            else
            {               
                ENTDetalleVenta miDetalle = new ENTDetalleVenta();
                miDetalle.Fk_idProducto = idProducto;
                miDetalle.producto = ProductocomboBox.Text;
                miDetalle.cantidadProducto = Convert.ToDecimal(CantidadtextBox.Text);

                miDetalle.precioSalida = NuevoPrecio;
                miDetalle.importe = miDetalle.cantidadProducto * miDetalle.precioSalida;
                EDventa.Add(miDetalle);
                DVentadataGridView.DataSource = null;
                DVentadataGridView.DataSource = EDventa;
                FormatoGrid();
                CalcularTotal();
                HabilitarBotones(true, false);
                Limpiar();
                DescuentotextBox.Text = "0";
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < EDventa.Count; i++)
            {
                if (i == fila)
                {
                    EDventa.RemoveAt(fila);
                }
                DVentadataGridView.DataSource = null;
                DVentadataGridView.DataSource = EDventa;
                FormatoGrid();
                CalcularTotal();
                Limpiar();
                HabilitarBotones(true, false);
                habilitarAgregar(true);
                Eliminar();
            }
        }
        private void habilitarAgregar(bool p1)
        {
            btnagregar.Enabled = p1;
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
            

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (ClientecomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ClientecomboBox, "Debe ingresar un Cliente para realizar su venta");
                return;
            }
            errorProvider1.Clear();

            object idcliente = ClientecomboBox.SelectedValue;
            int cliente = Convert.ToInt32(idcliente);
            idventa = BLDetalle.InsertarVenta(cliente);

            foreach (ENTDetalleVenta miDetalle in EDventa)
            {
                BLDetalle.InsertDetalleVenta(idventa, miDetalle);
            }

            MessageBox.Show("Venta realizada con exito");
            DVentadataGridView.DataSource = null;
            ImportetextBox.Text = "0";
            ClientecomboBox.SelectedIndex = -1;
            TelefonotextBox.Text = "";
            HabilitarBotones(false, false);
            Limpiar();
            EnviarID();
            EDventa.Clear();
            ClientecomboBox.Enabled = true;
        }

        private void HabilitarEliminar(bool p1)
        {
            btneliminar.Enabled = p1;
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

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarEliminar(false);
            Guardar(true);
            Limpiar();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            WINCliente cl = new WINCliente();
            AddOwnedForm(cl);
            cl.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            WINProVent pv = new WINProVent();
            AddOwnedForm(pv);
            pv.ShowDialog();
        }

        private void Cero()
        {
            if (DescuentotextBox.Text == "")
            {
                DescuentotextBox.Text = "0";
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("¿Cancelar Venta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.Yes)
            {
                ClientecomboBox.Enabled = true;
                Limpiar();
                TelefonotextBox.Text = "";
                ClientecomboBox.SelectedIndex = -1;
                DescuentotextBox.Text = "";
                DescuentotextBox.Text = "0";
                EDventa.Clear();
                DVentadataGridView.DataSource = null;
            }
            if (rpt == DialogResult.No) return;
        }

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }

        private void ClientecomboBox_KeyUp(object sender, KeyEventArgs e)
        {
            ClientecomboBox.Text = ReducirEspaciado(ClientecomboBox.Text);
            ClientecomboBox.SelectionStart = ClientecomboBox.Text.Length;
        }

        private void ProductocomboBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProductocomboBox.Text = ReducirEspaciado(ProductocomboBox.Text);
            ProductocomboBox.SelectionStart = ProductocomboBox.Text.Length;
        }

        private void Guardar(bool p1)
        {
            btnagregar.Enabled = p1;
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

        private void DVentadataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotones(true, true);
            Guardar(false);
            fila = DVentadataGridView.CurrentRow.Index;
        }
    }
}