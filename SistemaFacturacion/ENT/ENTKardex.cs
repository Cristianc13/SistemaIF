using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTKardex
    {
        public int idKardex { get; set; }
        public DateTime fecha { get; set; }
        public string concepto { get; set; }
        public decimal entrada { get; set; }
        public decimal salida { get; set; }
        public decimal existencia { get; set; }
        public decimal costeunitario { get; set; }
        public decimal costepromedio { get; set; }
        public int FK_idProducto { get; set; }
    }
}