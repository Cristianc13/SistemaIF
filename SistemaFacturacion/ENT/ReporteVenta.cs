using System;
using System.Collections.Generic;

namespace ENT
{
    public class ReporteVenta
    {
        public DateTime FechaReporte { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<ENTReporteListaVentas> ListaVentas { get; set; }

        //public List<ENTReporteVentasPorPeriodo> PorPeriodo { get; set; }
        public decimal ventasTotales { get; set; }
    }
}