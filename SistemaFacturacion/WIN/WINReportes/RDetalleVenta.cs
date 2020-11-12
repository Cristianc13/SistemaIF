﻿using System;
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
    public partial class RDetalleVenta : Form
    {
        public RDetalleVenta()
        {
            InitializeComponent();
        }

        private void RDetalleVenta_Load(object sender, EventArgs e)
        {
            RVentasHoy();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void Reporte(DateTime ffinicio, DateTime ffinal)
        {
            RBLReporteVentas ventas = new RBLReporteVentas();
            ventas.CrearReporteVenta(ffinicio, ffinal);
            RBLReporteVentasBindingSource.DataSource = ventas;
            //RBLVentasBindingSource.DataSource = ventas;
            this.reportViewer1.RefreshReport();
        }

        private void Semanabutton_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var date = DateTime.Now;
            Reporte(fromDate, date);
        }

        private void Mesbutton_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var date = DateTime.Now;
            Reporte(fromDate, date);
        }

        private void Aniobutton_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var date = DateTime.Now;
            Reporte(fromDate, date);
        }

        public void RVentasHoy()
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            Reporte(fromDate, toDate);
        }
    }
}
