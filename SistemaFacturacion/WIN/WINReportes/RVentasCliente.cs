using System;
using System.Windows.Forms;
using BL;

namespace WIN.WINReportes
{
    public partial class RVentasCliente : Form
    {
        public RVentasCliente()
        {
            InitializeComponent();
        }

        private void RVentasCliente_Load(object sender, EventArgs e)
        {
            GenerarF(2);
            this.reportViewer1.RefreshReport();
        }

        public void GenerarF(int NFactura)
        {
            RBLVentasCliente FC = new RBLVentasCliente();
            FC.GenerarReporte(NFactura);
            RBLVentasClienteBindingSource.DataSource = FC;
        }
    }
}