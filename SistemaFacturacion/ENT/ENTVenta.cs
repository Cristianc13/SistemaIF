using System;

namespace ENT
{
    public class ENTVenta
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public int FK_idCliente { get; set; }
    }
}