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

        private decimal IVA = 0;
        private int idCompra = 0;
        

        private ENTCompra Ecompra = new ENTCompra();
        private BLCompra BCompra = new BLCompra();

        private int idProducto = 0;

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleCompra Bldetallec = new BLDetalleCompra();
        private List<ENTDetalleCompra> EDetalleC = new List<ENTDetalleCompra>();


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
            cmbNFactura.DisplayMember = "numeroFactura";
            cmbNFactura.ValueMember = "idCompra";
            cmbNFactura.SelectedIndex = -1;
        }

        public void CalcularTotal()
        {
            decimal subtotal = 0;
            decimal total = 0;
            decimal iva2 = 0;
            
            foreach (DataGridViewRow dr in DetalleCompraGridView1.Rows)
            {
                
                decimal importe = decimal.Parse(dr.Cells[6].Value.ToString());
                subtotal += importe;
                iva2 = IVA / 100;
               
                iva2 = subtotal * iva2;
                
                txtIVA.Text = iva2.ToString();
                total = subtotal + iva2;
                

            }

            txtsubtotal.Text = subtotal.ToString();
            txtTotal.Text = total.ToString();
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

        private void limpiar2()
        {
           
            bmbproducto.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtcosto.Text = string.Empty;
            errorProvider1.Clear();
            
            bmbproducto.SelectedIndex = -1;
            bmbproducto.Focus();
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

        private void FormatoGrid()
        {
            DetalleCompraGridView1.Columns["FK_idCompra"].Visible = false;
            DetalleCompraGridView1.Columns["FK_idProducto"].Visible = false;
            DetalleCompraGridView1.Columns["idDetallecompra"].Visible = false;
            DetalleCompraGridView1.Columns["cantidadProducto"].HeaderText = "Cantidad";
            DetalleCompraGridView1.Columns["costo"].HeaderText = "Costo";
            DetalleCompraGridView1.Columns["importe"].HeaderText = "Importe";

            DetalleCompraGridView1.AllowUserToResizeColumns = false;
            DetalleCompraGridView1.AllowUserToResizeRows = false;
            DetalleCompraGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            DetalleCompraGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnguardar.Enabled = p1;
            btnactualizar.Enabled = p1;
           
            //Cancelarbutton.Enabled = p1;
        }

        private void WINDetalleCompra_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            LlenaComboFractura();
            LlenaComboProducto();
        }

        private void cmbNFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbNFactura.SelectedValue != null)
                {
                    idCompra = (int)cmbNFactura.SelectedValue;
                    IVA =decimal.Parse(Bldetallec.ObtenerIVA(idCompra));
                    //txtIVA.Text = Bldetallec.ObtenerIVA(idCompra);
                }
            }
            catch (Exception)
            {
            }

            //try
            //{
            //    if (cmbNFactura.SelectedValue != null)
            //    {
            //        idCompra = (int)cmbNFactura.SelectedValue;
            //    }
            //}
            //catch (Exception)
            //{
            //}
        }

        private void bmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (bmbproducto.SelectedValue != null)
                {
                    idProducto = (int)bmbproducto.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
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

            ENTDetalleCompra miDetalle = new ENTDetalleCompra();
            miDetalle.FK_idCompra = idCompra;
            miDetalle.FK_idProducto = idProducto;
            miDetalle.Producto = bmbproducto.Text;
            miDetalle.cantidadProducto = Convert.ToDecimal(txtcantidad.Text);
            miDetalle.costo = Convert.ToDecimal(txtcosto.Text);

            miDetalle.importe = miDetalle.cantidadProducto * miDetalle.costo;
            EDetalleC.Add(miDetalle);
            DetalleCompraGridView1.DataSource = null;
            DetalleCompraGridView1.DataSource = EDetalleC;
            FormatoGrid();
            CalcularTotal();
            HabilitarBotones(true, false);
            limpiar2();

       

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            

            foreach (ENTDetalleCompra miDetalle in EDetalleC)
            {
                Bldetallec.InsertDetalleCompra(idCompra, miDetalle);
            }
            MessageBox.Show("Venta realizada con exito");
            DetalleCompraGridView1.DataSource = null;
            //ImportetextBox.Text = "0";
            //TelefonotextBox.Text = "";
            HabilitarBotones(false, true);
            Limpiar();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void DetalleCompraGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex != DetalleCompraGridView1.Columns["cOpciones"].Index) return;

            //DetalleCompraGridView1.Rows.RemoveAt(e.RowIndex);

            //HabilitarBotones(false, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DetalleCompraGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalleCompraGridView1.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            
            cmbNFactura.Text = DetalleCompraGridView1.CurrentRow.Cells[0].Value.ToString();
            bmbproducto.Text = DetalleCompraGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcantidad.Text = DetalleCompraGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcosto.Text = DetalleCompraGridView1.CurrentRow.Cells[5].Value.ToString();


            HabilitarBotones(true, false);
        }
    }
}
