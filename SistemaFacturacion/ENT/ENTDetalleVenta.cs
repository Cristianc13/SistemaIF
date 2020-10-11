using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTDetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public decimal cantidadProducto { get; set; }
        public decimal precioSalida { get; set; }
        public decimal IVA { get; set; }
        public decimal importe { get; set; }
        public int Fk_idProducto { get; set; }
        public int Fk_idCliente { get; set; }
    }
}