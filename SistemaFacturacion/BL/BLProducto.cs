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

        public DataTable MostrarProductoByForanea()
        {
            return CProducto.MostrarProductoByForanea();
        }

        public string ObtenerPrecio(int idProducto)
        {
            return CProducto.ObtenerPrecio(idProducto);
        }
    }
}