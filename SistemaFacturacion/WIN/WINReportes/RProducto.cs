using System;
using System.Windows.Forms;
using BL;

namespace WIN.WINReportes
{
    public partial class RProducto : Form
    {
        public RProducto()
        {
            InitializeComponent();
        }

        private void RProducto_Load(object sender, EventArgs e)
        {
            GenerarInforme();
        }

        private void GenerarInforme()
        {
            RBLProducto informeProducto = new RBLProducto();
            informeProducto.GenerarReporte(0);

            RBLProductoBindingSource.DataSource = informeProducto.EReportePro;
            this.reportViewer1.RefreshReport();
        }
    }
}