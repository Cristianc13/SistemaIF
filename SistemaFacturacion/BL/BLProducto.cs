using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLProducto
    {
        private CADProducto CProducto = new CADProducto();

        public DataTable MostrarProducto()
        {
            return CProducto.MostrarProducto();
        }

        public DataTable ObtenerPrecio(ENTProducto producto)
        {
            return CProducto.ObtenerPrecio(producto);
        }
    }
}