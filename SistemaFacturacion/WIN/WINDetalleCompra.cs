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
    public partial class WINDetalleCompra : Form
    {
        public WINDetalleCompra()
        {
            InitializeComponent();
        }

        private int idCompra = 0;

        private ENTCompra Ecompra = new ENTCompra();
        private BLCompra BCompra = new BLCompra();

        private int idProducto = 0;

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleCompra Bldetallec = new BLDetalleCompra();

        private void LlenaComboProducto()
        {
            bmbproducto.DataSource = BProducto.MostrarProducto();
            bmbproducto.DisplayMember = "nombreProducto";
            bmbproducto.ValueMember = "idProducto";
            bmbproducto.SelectedIndex = -1;
        }

        private void LlenaComboFractura()
        {
            cmbNFactura.DataSource = BCompra.MostrarCompra();
            cmbNFactura.DisplayMember = "nombreFactura";
            cmbNFactura.ValueMember = "idCompra";
            cmbNFactura.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            cmbNFactura.Text = string.Empty;
            bmbproducto.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtcosto.Text = string.Empty;
            errorProvider1.Clear();
            cmbNFactura.SelectedIndex = -1;
            bmbproducto.SelectedIndex = -1;
            cmbNFactura.Focus();
        }

        public void HabilitarGuardar()
        {
            if (DetalleCompraGridView1.Rows.Count == 0)
            {
                HabilitarBotones(false, true);
            }
            else
            {
                HabilitarBotones(true, false);
            }
        }

        public void validaciones()
        {
           
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnguardar.Enabled = p1;
            //Cancelarbutton.Enabled = p1;
        }

        private void WINDetalleCompra_Load(object sender, EventArgs e)
        {
            LlenaComboFractura();
            LlenaComboProducto();
        }

        private void cmbNFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (bmbproducto.SelectedIndex == -1)
            {
                errorProvider1.SetError(bmbproducto, "Debe ingresar un Producto");
                return;
            }
            errorProvider1.Clear();

            if (cmbNFactura.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbNFactura, "Debe ingresar un N° de Factura");
                return;
            }
            errorProvider1.Clear();

            if (txtcantidad.Text == string.Empty)
            {
                errorProvider1.SetError(txtcantidad, "Debe ingresar una Cantidad");
                return;
            }
            errorProvider1.Clear();

            if (txtcosto.Text == string.Empty)
            {
                errorProvider1.SetError(txtcosto, "Debe ingresar un Costo");
                return;
            }
            errorProvider1.Clear();

            string Nombre = bmbproducto.Text;// ProductocomboBox.SelectedItem;
            string factura = cmbNFactura.Text; //Factura.selectedItem;
            string Cantidad = txtcantidad.Text;
            string Costo = txtcosto.Text;
            string Importe = (decimal.Parse(Cantidad) * decimal.Parse(Costo)).ToString();
            string idP = idProducto.ToString();
            string idF = idCompra.ToString();
            DetalleCompraGridView1.Rows.Add(new object[] { Nombre, factura ,Cantidad, Costo, Importe, "Eliminar", idP , idF});
            //CalcularTotal();
            Limpiar();
            HabilitarGuardar();
            errorProvider1.Clear();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void DetalleCompraGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != DetalleCompraGridView1.Columns["cOpciones"].Index) return;

            DetalleCompraGridView1.Rows.RemoveAt(e.RowIndex);

            HabilitarBotones(false, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
