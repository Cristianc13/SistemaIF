using System;

namespace ENT
{
    public class ENTReporteVentasCliente
    {
        public int idFactura { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public decimal importe { get; set; }
    }
}