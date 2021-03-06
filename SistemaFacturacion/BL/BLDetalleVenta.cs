﻿using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLDetalleVenta
    {
        private CADDetalleVenta CdetalleVenta = new CADDetalleVenta();

        // private ReporteVenta ERV = new ReporteVenta();
        private ENTReporteListaVentas ELRV = new ENTReporteListaVentas();

        //private ENTReporteVentasPorPeriodo ERVPP = new ENTReporteVentasPorPeriodo();

        public DataTable MostrarDetalleVenta()
        {
            return CdetalleVenta.MostrarDetalleVenta();
        }

        public void InsertDetalleVenta(int idventa, ENTDetalleVenta Edetalle)
        {
            CdetalleVenta.InsertDetalleVenta(idventa, Edetalle);
        }

        public int InsertarVenta(int idCliente)
        {
            return CdetalleVenta.InsertarVenta(idCliente);
        }

        public void GenerarFacturaVenta(int idFactura)
        {
            CdetalleVenta.GenerarFacturaVenta(idFactura);
        }
    }
}