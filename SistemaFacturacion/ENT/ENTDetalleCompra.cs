namespace ENT
{
    public class ENTDetalleCompra
    {
        public int FK_idCompra { get; set; }
        public int FK_idProducto { get; set; }
        public string Producto { get; set; }
        public int idDetallecompra { get; set; }
        public decimal cantidadProducto { get; set; }
        public decimal costo { get; set; }
        public decimal importe { get; set; }
    }
}