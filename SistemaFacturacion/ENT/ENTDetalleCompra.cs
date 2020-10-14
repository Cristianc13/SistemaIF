using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTDetalleCompra
    {
        public int idDetallecompra { get; set; }
        public decimal cantidadProducto { get; set; }
        public decimal costo { get; set; }
        public decimal IVA { get; set; }
        public decimal importe { get; set; }
        public int FK_idCompra {get; set;}
        public int FK_idProducto { get; set; }

    }
}
