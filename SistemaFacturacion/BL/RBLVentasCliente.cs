using System;
using System.Collections.Generic;
using CAD;
using ENT;

namespace BL
{
    public class RBLVentasCliente
    {
        public List<ENTReporteVentasCliente> ERVC { get; set; }

        public void GenerarReporte(int i)
        {
            var reporte = new CADCliente();
            var resultado = reporte.GenerarVentasCliente(i);
            ERVC = new List<ENTReporteVentasCliente>();

            foreach (System.Data.DataRow fila in resultado.Rows)
            {
                var DetalleFactura = new ENTReporteVentasCliente()
                {
                    idFactura = Convert.ToInt32(fila[0]),
                    nombreCliente = fila[1].ToString(),
                    fecha = Convert.ToDateTime(fila[2].ToString()),
                    descripcion = fila[3].ToString(),
                    importe = Convert.ToDecimal(fila[4].ToString()),
                };
                ERVC.Add(DetalleFactura);
            }
        }
    }
}