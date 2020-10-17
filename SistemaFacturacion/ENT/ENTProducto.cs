using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ENTProducto
    {
        public int idProducto { get; set; }
        public string codigopro { get; set; }
        public string nombreProducto { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaEntrada { get; set; }
        public decimal costo { get; set; }
        public decimal precioSalida { get; set; }
        public decimal stockProducto { get; set; }
        public string observacion { get; set; }
        public int FK_idMarca { get; set; }
        public int FK_idModelo { get; set; }
        public int FK_idCategoria { get; set; }
        public int FK_idEstado { get; set; }
    }
}