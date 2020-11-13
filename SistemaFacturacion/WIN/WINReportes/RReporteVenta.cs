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

namespace WIN.WINReportes
{
    public partial class RReporteVenta : Form
    {
        public RReporteVenta()
        {
            InitializeComponent();
        }

        //RBLGenerarFacturaVenta GF = new RBLGenerarFacturaVenta();
        public int Factura;

        private void RReporteVenta_Load(object sender, EventArgs e)
        {
            GenerarF(Factura);
            this.reportViewer1.RefreshReport();
           
        }

        public void GenerarF(int NFactura )
        {
            RBLGenerarFacturaVenta GF = new RBLGenerarFacturaVenta();
            GF.GenerarReporte(NFactura);
            RBLGenerarFacturaVentaBindingSource.DataSource = GF;
        }


    }
}
