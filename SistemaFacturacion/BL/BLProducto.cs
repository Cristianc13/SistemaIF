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

        public void InsertarProducto(ENTProducto EProducto)
        {
            CProducto.InsertarProducto(EProducto);
        }

        public void UpdateProducto(ENTProducto EProducto)
        {
            CProducto.UpdateProducto(EProducto);
        }
    }
}