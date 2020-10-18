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

        private ENTProducto Eproducto = new ENTProducto();
        private BLProducto BProducto = new BLProducto();
        private BLDetalleVenta BLDetalle = new BLDetalleVenta();

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void WINDetalleVenta_Load(object sender, EventArgs e)
        {
            ImportetextBox.Text = "0";
            HabilitarBotones(false, true);
            LlenaComboProducto();
            Limpiar();
        }

        private void LlenaComboProducto()
        {
            ProductocomboBox.DataSource = BProducto.MostrarProducto();
            ProductocomboBox.DisplayMember = "nombreProducto";
            ProductocomboBox.ValueMember = "idProducto";
            ProductocomboBox.SelectedIndex = -1;
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

            string Nombre = ProductocomboBox.Text;// ProductocomboBox.SelectedItem;
            string Cantidad = CantidadtextBox.Text;
            string Precio = PreciotextBox.Text;
            string Importe = (decimal.Parse(Cantidad) * decimal.Parse(Precio)).ToString();
            string idP = idProducto.ToString();
            DVentadataGridView.Rows.Add(new object[] { Nombre, Cantidad, Precio, 15, Importe, "Eliminar", idP });
            CalcularTotal();
            Limpiar();
            HabilitarGuardar();
            errorProvider1.Clear();
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

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow dr in DVentadataGridView.Rows)
            {
                decimal importe = decimal.Parse(dr.Cells[4].Value.ToString());
                total += importe;
            }
            ImportetextBox.Text = total.ToString();
        }

        private void DVentadataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != DVentadataGridView.Columns["cOpciones"].Index) return;

            DVentadataGridView.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            

            try
            {
                List<ENTDetalleVenta> lst = new List<ENTDetalleVenta>();

                //llenado de elementos detalles
                foreach (DataGridViewRow dr in DVentadataGridView.Rows)
                {
                    ENTDetalleVenta oConcepto = new ENTDetalleVenta();
                    oConcepto.cantidadProducto = decimal.Parse(dr.Cells[1].Value.ToString());
                    oConcepto.precioSalida = decimal.Parse(dr.Cells[2].Value.ToString());
                    oConcepto.IVA = decimal.Parse(dr.Cells[3].Value.ToString());
                    oConcepto.importe = decimal.Parse(dr.Cells[4].Value.ToString());
                    oConcepto.Fk_idProducto = int.Parse(dr.Cells[6].Value.ToString());
                    lst.Add(oConcepto);
                    DVentadataGridView.Rows.Clear();
                    ImportetextBox.Text = "0";
                    ProductocomboBox.Focus();
                    HabilitarBotones(false, true);
                }

                BLDetalle.InsertDetalleVenta(2, lst);

                MessageBox.Show("Venta realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}