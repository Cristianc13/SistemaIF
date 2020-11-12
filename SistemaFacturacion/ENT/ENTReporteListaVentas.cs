using System;


namespace ENT
{
    public class ENTReporteListaVentas
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public string cliente { get; set; }
        public string nombreProducto { get; set; }
        public decimal ventasTotales { get; set; }
        public decimal importe { get; set; }
    }
}