using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BL;
using ENT;

namespace WIN
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            Dashboard();
        }

        public void Dashboard()
        {
            BLDashboard BLDash = new BLDashboard();
            ENTDashboard obj = new ENTDashboard();
            BLDash.Dashboard(obj);
            //RECUPERAMOS DATOS DE LA ENTIDAD PARA CARGAR LOS DATOS DEL DASHBOARD
            chartopproductos.Series[0].Points.DataBindXY(obj.Producto1, obj.Cant1);
            chartproductosCat.Series[0].Points.DataBindXY(obj.Categoria1, obj.CantProd1);
            chartventasmes.Series[0].Points.DataBindXY(obj.Meses1, obj.Cantvent1);

            #region PrimerCodigo

            chartventasmes.Legends[0].Docking = Docking.Bottom;
            chartventasmes.Legends[0].Alignment = StringAlignment.Center;

            Axis XA = chartventasmes.ChartAreas[0].AxisX;
            Axis YA = chartventasmes.ChartAreas[0].AxisY;
            Series S1 = chartventasmes.Series[0];

            DateTime fechaActual = DateTime.Today;
            S1.LegendText = "Año: " + fechaActual.Year;

            XA.Interval = 1;
            YA.LabelStyle.Format = "C$##0";

            #endregion PrimerCodigo

            lbproduc.Text = obj.CantProductos;
            lbmarca.Text = obj.CantMarcas;
            lbmodel.Text = obj.CantModelo;
            lbcat.Text = obj.CantCat;
            lbclient.Text = obj.CantClientes;
            lbprovee.Text = obj.CantProveedores;
            lbvent.Text = obj.CantVenta;
            lbcompr.Text = obj.CantCompra;
        }
    }
}