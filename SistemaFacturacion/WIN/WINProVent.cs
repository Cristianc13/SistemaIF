using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using System.Xml.Linq;
using ENT;

namespace WIN
{
    public partial class WINProVent : Form
    {
        BLProducto BProducto = new BLProducto();
        ENTProducto Eproducto = new ENTProducto();


        public WINProVent()
        {
            InitializeComponent();
        }


        public void FormatoGrid()
        {
            ProductodataGridView.Columns[0].Visible = false;
            ProductodataGridView.Columns[1].HeaderText = "Codigo";
            ProductodataGridView.Columns[2].HeaderText = "Producto";
            ProductodataGridView.Columns[3].HeaderText = "Descripcion";
            ProductodataGridView.Columns[4].HeaderText = "Costo";
            ProductodataGridView.Columns[5].HeaderText = "Venta";
            ProductodataGridView.Columns[6].HeaderText = "Stock";
            ProductodataGridView.Columns[7].HeaderText = "Marca";
            ProductodataGridView.Columns[8].HeaderText = "Modelo";
            ProductodataGridView.Columns[9].HeaderText = "Categoria";
            ProductodataGridView.Columns[10].HeaderText = "Estado";
            ProductodataGridView.AllowUserToResizeColumns = false;
            ProductodataGridView.AllowUserToResizeRows = false;
            //ProductodataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            //ProductodataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        public void limpiar()
        {
            MarcModeltextBox.Text = "";
            BuscartextBox.Text = "";
            ProductotextBox.Text = "";
            CostotextBox.Text = "";
            PreciotextBox.Text = "";
            StocktextBox.Text = "";
        }

        public void HabilitarBotones(bool p1, bool p2)
        {
            Enviarbutton.Enabled = p1;
            
        }

        public void llenarGrid()
        {
            ProductodataGridView.DataSource = BProducto.MostrarProductoVenta();
        }
          
        private void WINProVent_Load(object sender, EventArgs e)
        {           
            HabilitarBotones(false, true);
            llenarGrid();
            FormatoGrid();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            limpiar();          
        }

        private void ProductodataGridView_DoubleClick(object sender, EventArgs e)
        {
            //NombretextBox.Text = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            ProductotextBox.Text = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            CostotextBox.Text = ProductodataGridView.CurrentRow.Cells[4].Value.ToString();
            PreciotextBox.Text = ProductodataGridView.CurrentRow.Cells[5].Value.ToString();
            StocktextBox.Text = ProductodataGridView.CurrentRow.Cells[6].Value.ToString();
            DescripciontextBox.Text = ProductodataGridView.CurrentRow.Cells[3].Value.ToString();

            BuscartextBox.Text = "";
            MarcModeltextBox.Text = "";

            HabilitarBotones(true, false);
        }

        private void Enviarbutton_Click(object sender, EventArgs e)
        {
            decimal x = Convert.ToDecimal(StocktextBox.Text);
            if (x <= 0)
            {
                MessageBox.Show("Stock del producto en su minimo valor");
            }
            else
            {
                WINDetalleVenta dx = Owner as WINDetalleVenta;
                dx.ProductocomboBox.Text = ProductotextBox.Text;
                this.Close();
            }
        }

        private void BuscartextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = BuscartextBox.Text;
            Eproducto.codigopro = filtro;
            ProductodataGridView.DataSource = BProducto.BuscarProdCodigoNombre(Eproducto);

        }

        private void MarcModeltextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = MarcModeltextBox.Text;
            Eproducto.codigopro = filtro;
            ProductodataGridView.DataSource = BProducto.BusarProdMarcaModelo(Eproducto);
        }
    }
}
