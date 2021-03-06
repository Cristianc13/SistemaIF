﻿using System;
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
            chartproductosCat.Legends[0].Docking = Docking.Bottom;
            chartventasmes.Series[0].Points.DataBindXY(obj.Meses1, obj.Cantvent1);
            chartcompras.Series[0].Points.DataBindXY(obj.MesesCompras1, obj.CantCompras1);

            lbproduc.Text = obj.CantProductos;
            lbmarca.Text = obj.CantMarcas;
            lbmodel.Text = obj.CantModelo;
            lbcat.Text = obj.CantCat;
            lbclient.Text = obj.CantClientes;
            lbprovee.Text = obj.CantProveedores;
            lbvent.Text = obj.CantVenta;
            lbcompr.Text = obj.CantCompra;

            #region ChartVentasMes

            chartventasmes.Legends[0].Docking = Docking.Bottom;
            chartventasmes.Legends[0].Alignment = StringAlignment.Center;

            Axis XA = chartventasmes.ChartAreas[0].AxisX;
            Axis YA = chartventasmes.ChartAreas[0].AxisY;
            Series S1 = chartventasmes.Series[0];

            DateTime fechaActual = DateTime.Today;
            S1.LegendText = "Año: " + fechaActual.Year;

            XA.Interval = 1;
            YA.LabelStyle.Format = "C$##0";

            #endregion ChartVentasMes

               #region ChartComprasMes

            chartcompras.Legends[0].Docking = Docking.Bottom;
            chartcompras.Legends[0].Alignment = StringAlignment.Center;

            Axis XB = chartcompras.ChartAreas[0].AxisX;
            Axis YB = chartcompras.ChartAreas[0].AxisY;
            Series S2 = chartcompras.Series[0];

            S2.LegendText = "Año: " + fechaActual.Year;

            XB.Interval = 1;
            YB.LabelStyle.Format = "C$##0";

            #endregion ChartComprasMes
        }
    }
}