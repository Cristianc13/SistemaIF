using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTCompra
    {
        public int idCompra { get; set; }
        public string numeroFactura { get; set; }
        public DateTime fechaCompra { get; set; }
        public string descripcion { get; set; }
        public int FK_idProveedor { get; set; }
    }
}
