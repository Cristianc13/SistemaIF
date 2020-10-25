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

        public DataTable MostrarProductoVenta()
        {
            return CProducto.MostrarProductoVenta();
        }

        public string ObtenerPrecio(int idProducto)
        {
            return CProducto.ObtenerPrecio(idProducto);
        }

        public void InsertarProducto(ENTProducto EProducto)
        {
            CProducto.InsertarProducto(EProducto);
        }

        public void EliminarProduto(ENTProducto EProducto)
        {
            CProducto.EliminarProduto(EProducto);
        }

        public void UpdateProducto(ENTProducto EProducto)
        {
            CProducto.UpdateProducto(EProducto);
        }

        public DataTable BuscarProducto(ENTProducto EProducto)
        {
            return CProducto.BuscarProducto(EProducto);
        }

        public DataTable BusarProdMarcaModelo(ENTProducto EProducto)
        {
            return CProducto.BusarProdMarcaModelo(EProducto);
        }

        public DataTable BuscarProdCodigoNombre(ENTProducto EProducto)
        {
            return CProducto.BuscarProdCodigoNombre(EProducto);
        }

        public int CantidadProducto()
        {
            return CProducto.CantidadProducto();
        }
    }
}