using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    class ENTVenta
    {
        public int idVenta { get; set; }
        public DateTime fechaVenta { get; set; }
        public int FK_idCliente { get; set; }
    }
}
