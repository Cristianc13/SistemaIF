using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using CAD;

namespace BL
{
    public class RBLReporteVentas
    {
        private ReporteVenta ENTDV = new ReporteVenta();
        public decimal totalNetSales { get; private set; }

        public List<ENTReporteListaVentas> listaVentas { get; set; }
        //public List<ENTReporteVentasPorPeriodo> listaVentasPeriodo { get; set; }

        //Metodo
        public void CrearReporteVenta(DateTime finicio, DateTime ffinal)
        {
            ENTDV.FechaReporte = DateTime.Now;
            ENTDV.fechaInicio = finicio;
            ENTDV.fechaFinal = ffinal;

            var RVenta = new CADDetalleVenta();
            var resultado = RVenta.GenerarReporteVenta(finicio, ffinal);

            listaVentas = new List<ENTReporteListaVentas>();

            foreach (System.Data.DataRow rows in resultado.Rows)
            {
                var salesModel = new ENTReporteListaVentas()
                {
                    idVenta = Convert.ToInt32(rows[0]),
                    fechaVenta = Convert.ToDateTime(rows[1]),
                    cliente = Convert.ToString(rows[2]),
                    nombreProducto = Convert.ToString(rows[3]),
                    ventasTotales = Convert.ToDecimal(rows[4])
                };
                listaVentas.Add(salesModel);
            }
        }
    }
}