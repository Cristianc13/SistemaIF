using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTFacturaVenta
    {
        public int factura{ get; set; }
        public string cliente { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public decimal  precioUnitario{ get; set; }
        public decimal importe { get; set; }
        public decimal TotalFactura { get; set; }

    }
}
