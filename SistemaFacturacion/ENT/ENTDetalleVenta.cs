namespace ENT
{
    public class ENTDetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public int Fk_idProducto { get; set; }
        public string producto { get; set; }
        public decimal cantidadProducto { get; set; }
        public decimal precioSalida { get; set; }
        public decimal descuento { get; set; }
        public decimal importe { get; set; }
        public int Fk_idCliente { get; set; }
    }
}