using System;

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
        public string categoria { get; set; }
        public string estado { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
    }
}