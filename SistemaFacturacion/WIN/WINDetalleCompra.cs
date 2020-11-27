using System;
using System.Collections.Generic;
using System.Drawing;
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

        public bool bloqueo;
        public int fila = 0;

        private decimal IVA = 0;
        private int idCompra = 0;

        private ENTCompra Ecompra = new ENTCompra();
        private BLCompra BCompra = new BLCompra();

        private int idProducto = 0;

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleCompra Bldetallec = new BLDetalleCompra();

        //   private int idetalleCompra = 0;

        private List<ENTDetalleCompra> EDetalleC = new List<ENTDetalleCompra>();
        private ENTDetalleCompra EdetalleCompra = new ENTDetalleCompra();

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

        #region Limpiar

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

        private void limpiar4()
        {
            bmbproducto.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtcosto.Text = string.Empty;
            errorProvider1.Clear();
            txtsubtotal.Text = string.Empty;
            txtIVA.Text = string.Empty;
            txtTotal.Text = string.Empty;
            cmbNFactura.Text = string.Empty;

            bmbproducto.SelectedIndex = -1;

            cmbNFactura.SelectedIndex = -1;

            cmbNFactura.Focus();
        }

        private void limpiar3()
        {
            bmbproducto.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtcosto.Text = string.Empty;
            errorProvider1.Clear();

            bmbproducto.Focus();
        }

        #endregion Limpiar

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

            Recursos.DatagridviewDiseño.DiseñoDGV(ref DetalleCompraGridView1);
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnguardar.Enabled = p1;
            btnactualizar.Enabled = p1;
            btnEliminar.Enabled = p1;

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
                    IVA = decimal.Parse(Bldetallec.ObtenerIVA(idCompra));
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
            bloqueo = false;
            if (bloqueo == false)
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
                cmbNFactura.Enabled = false;
            }
            else
            {
                cmbNFactura.Enabled = true;
                bloqueo = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            foreach (ENTDetalleCompra miDetalle in EDetalleC)
            {
                Bldetallec.InsertDetalleCompra(idCompra, miDetalle);
            }

            Ecompra.idCompra = idCompra;
            Ecompra.realizada = false;
            Bldetallec.UpdateDetalleCompra(Ecompra);
            MessageBox.Show("Compra realizada con exito");
            DetalleCompraGridView1.DataSource = null;
            EDetalleC.Clear();
            HabilitarBotones(false, true);
            LlenaComboFractura();
            limpiar4();
            cmbNFactura.Enabled = true;
            //btnguardar.Enabled = true;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            cmbNFactura.Enabled = true;
        }

        private void DetalleCompraGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //NUMERO DE FILA EN EL DATAGRIDVIEW
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WINDetalleCompra2 WCd2 = new WINDetalleCompra2();
            WCd2.ShowDialog();
            LlenaComboProducto();
        }

        private void DetalleCompraGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = DetalleCompraGridView1.CurrentRow.Index;

            if (DetalleCompraGridView1.Rows.Count == 0) return;
            HabilitarBotones(true, false);

            //cmbNFactura.Text = DetalleCompraGridView1.CurrentRow.Cells[0].Value.ToString();
            bmbproducto.Text = DetalleCompraGridView1.CurrentRow.Cells[2].Value.ToString();
            txtcantidad.Text = DetalleCompraGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcosto.Text = DetalleCompraGridView1.CurrentRow.Cells[5].Value.ToString();
            HabilitarBotones(true, false);
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Comprabutton_Click(object sender, EventArgs e)
        {
            WINCompra compra = new WINCompra();
            compra.ShowDialog();
            LlenaComboFractura();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //RECORREMOS LOS ELEMENTOS GUARDADOS EN LA LISTA
            for (int i = 0; i < EDetalleC.Count; i++)
            {
                //COMPROBAMOS QUE LA FILA SELECCIONADA ES IGUAL AL DE LA LISTA
                if (i == fila)
                {
                    EDetalleC.RemoveAt(fila);
                }

                //ACTUALIZAMOS LA LISTA Y EL DATAGRIDVIEW
                DetalleCompraGridView1.DataSource = null;
                DetalleCompraGridView1.DataSource = EDetalleC;
                FormatoGrid();
                CalcularTotal();
                limpiar3();
            }
        }

        private void DetalleCompraGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbNFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void bmbproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}