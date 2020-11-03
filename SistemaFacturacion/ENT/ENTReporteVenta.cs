﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTReporteVenta
    {
        public DateTime FechaReporte { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinal { get; set; }
        public List<ENTReporteListaVentas> ListaVentas { get; set; }
        public List<ENTReporteVentasPorPeriodo> PorPeriodo { get; set; }
        public decimal ventasTotales { get; set; }
    }

    
}
