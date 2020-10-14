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
            ProductocomboBox.SelectedIndex = -1;
            CantidadtextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            ProductocomboBox.Focus();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            string Nombre = ProductocomboBox.Text;// ProductocomboBox.SelectedItem;
            string Cantidad = CantidadtextBox.Text;
            string Precio = PreciotextBox.Text;
            string Importe = (int.Parse(Cantidad) * int.Parse(Precio)).ToString();
            string idP = idProducto.ToString();
            DVentadataGridView.Rows.Add(new object[] { Nombre, Cantidad, Precio, 15, Importe, "Eliminar", idP });
            CalcularTotal();
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

            /// idProducto = Convert.ToInt32(ProductocomboBox.SelectedValue);
            //  PreciotextBox.Text = BProducto.ObtenerPrecio(idProducto);
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
                }

                BLDetalle.InsertDetalleVenta(2, lst);

                MessageBox.Show("Venta realizada");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}