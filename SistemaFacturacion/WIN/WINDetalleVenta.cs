using System;
using System.Collections.Generic;
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
        private int idCl = 0;
        //private int idcliente = 2;
        public int idventa;

        private List<ENTVenta> Eventa = new List<ENTVenta>();
        private List<ENTDetalleVenta> EDventa = new List<ENTDetalleVenta>();

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleVenta BLDetalle = new BLDetalleVenta();
        private BLCliente BCliente = new BLCliente();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void WINDetalleVenta_Load(object sender, EventArgs e)
        {
            ImportetextBox.Text = "0";
            HabilitarBotones(false, true);
            LlenarComboCliente();
            LlenaComboProducto();
            Limpiar();
        }

        private void FormatoGrid()
        {
            DVentadataGridView.Columns[0].Visible = false;
            DVentadataGridView.Columns[1].Visible = false;
            DVentadataGridView.Columns[2].HeaderText = "Producto";
            DVentadataGridView.Columns[3].HeaderText = "Cantidad";
            DVentadataGridView.Columns[4].HeaderText = "Costo";
            DVentadataGridView.Columns[5].HeaderText = "IVA";
            DVentadataGridView.Columns[6].HeaderText = "Importe";
            DVentadataGridView.Columns[7].Visible = false;
            DVentadataGridView.AllowUserToResizeColumns = false;
            DVentadataGridView.AllowUserToResizeRows = false;
            //DVentadataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //DVentadataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void LlenaComboProducto()
        {
            ProductocomboBox.DataSource = BProducto.MostrarProducto();
            ProductocomboBox.DisplayMember = "nombreProducto";
            ProductocomboBox.ValueMember = "idProducto";
            ProductocomboBox.SelectedIndex = -1;
        }

        private void LlenarComboCliente()
        {
            ClientecomboBox.DataSource = BCliente.MostrarCliente();
            ClientecomboBox.DisplayMember = "nombreCliente";
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

        private void Agregarbutton_Click(object sender, EventArgs e)
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

            ENTDetalleVenta miDetalle = new ENTDetalleVenta();
            miDetalle.Fk_idProducto = idProducto;
            miDetalle.producto = ProductocomboBox.Text;
            miDetalle.cantidadProducto = Convert.ToDecimal(CantidadtextBox.Text);
            miDetalle.precioSalida = Convert.ToDecimal(PreciotextBox.Text);
            miDetalle.IVA = 15;
            miDetalle.importe = miDetalle.cantidadProducto * miDetalle.precioSalida;
            EDventa.Add(miDetalle);
            DVentadataGridView.DataSource = null;
            DVentadataGridView.DataSource = EDventa;
            FormatoGrid();
            CalcularTotal();
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void ProductocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProductocomboBox.SelectedValue != null)
                {
                    idProducto = (int)ProductocomboBox.SelectedValue;
                    PreciotextBox.Text = Convert.ToString(BProducto.ObtenerPrecio(idProducto));
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

        private void DVentadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex != DVentadataGridView.Columns["cOpciones"].Index) return;

            //DVentadataGridView.Rows.RemoveAt(e.RowIndex);

            //HabilitarBotones(false, true);

            //CalcularTotal();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (ClientecomboBox.Text == string.Empty)
            {
                errorProvider1.SetError(ClientecomboBox, "Debe ingresar un Cliente para realizar su venta");
                return;
            }
            errorProvider1.Clear();

            object idcliente = ClientecomboBox.SelectedValue;
            int xd = Convert.ToInt32(idcliente);
            idventa = BLDetalle.InsertarVenta(xd);

            foreach (ENTDetalleVenta miDetalle in EDventa)
            {
                BLDetalle.InsertDetalleVenta(idventa, miDetalle);               
            }
            MessageBox.Show("Venta realizada con exito");
            DVentadataGridView.DataSource = null;
            ImportetextBox.Text = "0";
            ClientecomboBox.SelectedIndex = -1;
            TelefonotextBox.Text = "";
            HabilitarBotones(false, true);
            Limpiar();
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p1;
            //Cancelarbutton.Enabled = p1;
        }

        public void HabilitarGuardar()
        {
            if (DVentadataGridView.Rows.Count == 0)
            {
                HabilitarBotones(false, true);
            }
            else
            {
                HabilitarBotones(true, false);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            
            WINProVent pv = new WINProVent();
            AddOwnedForm(pv);
            pv.ShowDialog();
        }

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Clientebutton_Click(object sender, EventArgs e)
        {
            WINCliente cl = new WINCliente();
            AddOwnedForm(cl);
            cl.ShowDialog();
        }

        private void DVentadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}