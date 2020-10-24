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

namespace WIN
{
    public partial class WINProVent : Form
    {
        BLProducto bp = new BLProducto();

        public WINProVent()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
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
            ProductodataGridView.DataSource = bp.MostrarProductoVenta();
        }
          
        private void WINProVent_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            llenarGrid();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void ProductodataGridView_DoubleClick(object sender, EventArgs e)
        {
            //NombretextBox.Text = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            ProductotextBox.Text = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            CostotextBox.Text = ProductodataGridView.CurrentRow.Cells[3].Value.ToString();
            PreciotextBox.Text = ProductodataGridView.CurrentRow.Cells[4].Value.ToString();
            StocktextBox.Text = ProductodataGridView.CurrentRow.Cells[5].Value.ToString();

            HabilitarBotones(true, false);
        }

        private void Enviarbutton_Click(object sender, EventArgs e)
        {
            WINDetalleVenta dx = Owner as WINDetalleVenta;
            dx.ProductocomboBox.Text = ProductotextBox.Text;
            this.Close();
        }
    }
}
