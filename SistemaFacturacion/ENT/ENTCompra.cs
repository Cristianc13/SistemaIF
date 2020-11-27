using System;

namespace ENT
{
    public class ENTCompra
    {
        public int idCompra { get; set; }
        public string numeroFactura { get; set; }
        public DateTime fechaCompra { get; set; }
        public string descripcion { get; set; }
        public decimal IVA { get; set; }
        public int FK_idProveedor { get; set; }
        public bool realizada { get; set; }
    }
}