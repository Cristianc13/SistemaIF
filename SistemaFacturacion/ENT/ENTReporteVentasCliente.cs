using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
