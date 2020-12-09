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
    public partial class WINDCompracs : Form
    {
        public WINDCompracs()
        {
            InitializeComponent();
        }

        public string comboprov;

        public bool bloqueo;
        public int fila = 0;

        private decimal IVA = 0;
        private int idCompra = 0;

        private ENTCompra Ecompra = new ENTCompra();
        private BLCompra BCompra = new BLCompra();

        private int idProducto = 0;
        private int idProveedor = 0;

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleCompra Bldetallec = new BLDetalleCompra();

        private List<ENTDetalleCompra> EDetalleC = new List<ENTDetalleCompra>();
        private ENTDetalleCompra EdetalleCompra = new ENTDetalleCompra();

        public ENTProveedor EProveedor = new ENTProveedor();
        private BLProveedor BProveedor = new BLProveedor();

        private void LlenaComboProducto()
        {
            bmbproducto.DataSource = BProducto.MostrarProducto();
            bmbproducto.DisplayMember = "Producto";
            bmbproducto.ValueMember = "idProducto";
            bmbproducto.SelectedIndex = -1;
        }
        private void Botones()
        {
            iconButton3.Visible = true;
            iconButton4.Visible = true;
        }

        private void LlenaComboProveedor()
        {
            CmbProveedor.DataSource = BProveedor.MostrarProveedor();
            CmbProveedor.DisplayMember = "nombreProv";
            CmbProveedor.ValueMember = "idProveedor";
            CmbProveedor.SelectedIndex = -1;
        }

        public void CalcularTotal()
        {
            decimal subtotal = 0;
            decimal total = 0;
            decimal iva2 = Convert.ToDecimal(txtIVAdetalleC.Text);

            foreach (DataGridViewRow dr in DetalleCompraGridView1.Rows)
            {
                decimal importe = decimal.Parse(dr.Cells[6].Value.ToString());
                subtotal += importe;
                iva2 = iva2 / 100;

                iva2 = subtotal * iva2;

                txtIVA.Text = iva2.ToString();
                total = subtotal + iva2;
            }

            txtsubtotal.Text = subtotal.ToString();
            txtTotal.Text = total.ToString();
        }

        private void HabilitarEliminar(bool p1)
        {
            iconButton4.Enabled = p1;
            if (iconButton4.Enabled == true)
            {
                iconButton4.BackColor = Color.FromArgb(21, 30, 41);
                iconButton4.IconColor = Color.White;
            }
            else
            {
                iconButton4.BackColor = Color.FromArgb(177, 180, 183);
                iconButton4.IconColor = Color.Black;
                iconButton2.Enabled = true;
                iconButton2.BackColor = Color.FromArgb(21, 30, 41);
                iconButton2.IconColor = Color.White;
            }

        }

        #region Limpiar

        private void Limpiar()
        {
            //CmbProveedor.Text = string.Empty;
            //CmbProveedor.SelectedIndex = -1;
            //txtnombreCompañia.Text = string.Empty;
            //txtIVAdetalleC.Text = "0";
            //txtnfactura.Text = string.Empty;
            //txtdescr.Text = string.Empty;
            
            bmbproducto.Text = string.Empty;
            txtcantidad.Text = string.Empty;
            txtcosto.Text = string.Empty;
            errorProvider1.Clear();
            
            bmbproducto.SelectedIndex = -1;
            bmbproducto.Focus();
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
            CmbProveedor.Text = string.Empty;
            txtnombreCompañia.Text = string.Empty;
            errorProvider1.Clear();
            txtnfactura.Text = string.Empty;
            txtdescr.Text = string.Empty;
            txtIVAdetalleC.Text = string.Empty;



            bmbproducto.SelectedIndex = -1;
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

        

        private void HabilitarBotones(bool p1, bool p2)
        {
            iconButton4.Enabled = p1;
            if (iconButton4.Enabled == true)
            {
                iconButton4.BackColor = Color.FromArgb(21, 30, 41);
                iconButton4.IconColor = Color.White;
            }
            else
            {
                iconButton4.BackColor = Color.FromArgb(177, 180, 183);
                iconButton4.IconColor = Color.Black;
            }

            //iconButton3.Enabled = p1;
            //if (iconButton3.Enabled == true)
            //{
            //    iconButton3.BackColor = Color.FromArgb(21, 30, 41);
            //    iconButton3.IconColor = Color.White;
            //}
            //else
            //{
            //    iconButton3.BackColor = Color.FromArgb(177, 180, 183);
            //    iconButton3.IconColor = Color.Black;
            //}

            iconButton2.Enabled = p2;
            if (iconButton2.Enabled == true)
            {
                iconButton2.BackColor = Color.FromArgb(21, 30, 41);
                iconButton2.IconColor = Color.White;
            }
            else
            {
                iconButton2.BackColor = Color.FromArgb(177, 180, 183);
                iconButton2.IconColor = Color.Black;
            }



            //Cancelarbutton.Enabled = p1;
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

        private void WINDCompracs_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);

            LlenaComboProducto();
            LlenaComboProveedor();
            txtIVAdetalleC.Text = "0";
            Botones();
            cajasdetextotrue();
        }

        public void cajasdetextotrue()
        {
            txtnfactura.Visible = true;
            txtdescr.Visible = true;
            txtnombreCompañia.Visible = true;
            txtIVAdetalleC.Visible = true;
            txtcantidad.Visible = true;
            txtcosto.Visible = true;
            dtfecha.Visible = true;
            txtsubtotal.Visible = true;
            txtTotal.Visible = true;
            txtIVA.Visible = true;

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
                if (CmbProveedor.SelectedIndex == -1)
                {
                    errorProvider1.SetError(CmbProveedor, "Debe Asignar un Proveedor a la compra");
                    return;
                }
                errorProvider1.Clear();

                if (bmbproducto.SelectedIndex == -1)
                {
                    errorProvider1.SetError(bmbproducto, "Debe ingresar un Producto");
                    return;
                }
                errorProvider1.Clear();

                if (txtnfactura.Text == string.Empty)
                {
                    errorProvider1.SetError(txtnfactura, "Debe ingresar un N° de Factura");
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
            else
            {
                bloqueo = true;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Ecompra.FK_idProveedor = idProveedor;
            Ecompra.numeroFactura = txtnfactura.Text;
            Ecompra.descripcion = txtdescr.Text;
            Ecompra.fechaCompra = dtfecha.Value;
            Ecompra.IVA = Convert.ToDecimal(txtIVAdetalleC.Text);
            //id
            idCompra = BCompra.InsertarCompra(Ecompra);

            foreach (ENTDetalleCompra miDetalle in EDetalleC)
            {
                Bldetallec.InsertDetalleCompra(idCompra, miDetalle);
            }
            //Ecompra.idCompra = idCompra;
            //Ecompra.realizada = false;
            //Bldetallec.UpdateDetalleCompra(Ecompra);
            MessageBox.Show("Compra realizada con exito");
            DetalleCompraGridView1.DataSource = null;
            EDetalleC.Clear();
            HabilitarBotones(false, true);

            limpiar4();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WINDetalleCompra2 WCd2 = new WINDetalleCompra2();
            AddOwnedForm(WCd2);
            WCd2.ShowDialog();
            //LlenaComboProducto();
            
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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

        private void bmbproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }

        private void ProveedorButoon_Click(object sender, EventArgs e)
        {
            WINProveedor cl = new WINProveedor();
            AddOwnedForm(cl);
            cl.ShowDialog();
        }

        private void CmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CmbProveedor.SelectedValue != null)
                {
                    idProveedor = (int)CmbProveedor.SelectedValue;
                    txtnombreCompañia.Text = Convert.ToString(BProveedor.SelectProveedorNombreCom(idProveedor));
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtnfactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtIVAdetalleC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DetalleCompraGridView1_Click(object sender, EventArgs e)
        {
            fila = DetalleCompraGridView1.CurrentRow.Index;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            WINProveedor cl = new WINProveedor();
            AddOwnedForm(cl);
            cl.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            WINDetalleCompra2 WCd2 = new WINDetalleCompra2();
            AddOwnedForm(WCd2);
            WCd2.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            bloqueo = false;
            if (bloqueo == false)
            {
                if (CmbProveedor.SelectedIndex == -1)
                {
                    errorProvider1.SetError(CmbProveedor, "Debe ingresar un Proveedor a la compra");
                    return;
                }
                errorProvider1.Clear();

                if (bmbproducto.SelectedIndex == -1)
                {
                    errorProvider1.SetError(bmbproducto, "Debe ingresar un Producto");
                    return;
                }
                errorProvider1.Clear();

                if (txtnfactura.Text == string.Empty)
                {
                    errorProvider1.SetError(txtnfactura, "Debe ingresar un N° de Factura");
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
                HabilitarBotones(false, true);
                limpiar2();
            }
            else
            {
                bloqueo = true;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
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
                HabilitarBotones(false, true);
            }
            
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Ecompra.FK_idProveedor = idProveedor;
            Ecompra.numeroFactura = txtnfactura.Text;
            Ecompra.descripcion = txtdescr.Text;
            Ecompra.fechaCompra = dtfecha.Value;
            Ecompra.IVA = Convert.ToDecimal(txtIVAdetalleC.Text);
            //id
            idCompra = BCompra.InsertarCompra(Ecompra);

            foreach (ENTDetalleCompra miDetalle in EDetalleC)
            {
                Bldetallec.InsertDetalleCompra(idCompra, miDetalle);
            }
            //Ecompra.idCompra = idCompra;
            //Ecompra.realizada = false;
            //Bldetallec.UpdateDetalleCompra(Ecompra);
            MessageBox.Show("Compra realizada con exito");
            DetalleCompraGridView1.DataSource = null;
            EDetalleC.Clear();
            HabilitarBotones(false, true);

            limpiar4();
            txtIVAdetalleC.Text = "0";
            dtfecha.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Limpiar();
            dtfecha.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            HabilitarEliminar(false);
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void DetalleCompraGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotones(true, false);
            fila = DetalleCompraGridView1.CurrentRow.Index;
        }

        private void CmbProveedor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcantidad_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtcosto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }
    }
}