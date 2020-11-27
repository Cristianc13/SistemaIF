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
        string producto;
        string stock;


        public WINProVent()
        {
            InitializeComponent();
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
          
        private void WINProVent_Load(object sender, EventArgs e)
        {           
            llenarGrid();
            FormatoGrid();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            BuscartextBox.Text = "";
            MarcModeltextBox.Text = "";
            llenarGrid();
        }

        private void ProductodataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ProductodataGridView.CurrentRow == null) return;

            producto = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            stock = ProductodataGridView.CurrentRow.Cells[6].Value.ToString();

            decimal x = Convert.ToDecimal(stock);
            if (x <= 0)
            {
                MessageBox.Show("Stock del producto en su minimo valor");
            }
            else
            {
                WINDetalleVenta dx = Owner as WINDetalleVenta;
                dx.ProductocomboBox.Text = producto;
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
