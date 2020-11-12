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

        public DataTable MostrarDetallesProd()
        {
            return CProducto.MostrarSelectDetallePro();
        }

        public DataTable MostrarProductoVenta()
        {
            return CProducto.MostrarProductoVenta();
        }

        public string ObtenerStock(int idProducto)
        {
            return CProducto.SelectProductoStock(idProducto);
        }

        public string ObtenerPrecio(int idProducto)
        {
            return CProducto.ObtenerPrecio(idProducto);
        }

        public string SelectProductocosto(int idProducto)
        {
            return CProducto.ObtenerCosto(idProducto);
        }

        public int InsertarProducto(ENTProducto EProducto)
        {
            return CProducto.InsertarProducto(EProducto);
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

        public int CantidadCategorias()
        {
            return CProducto.CantidadCategorias();
        }

        public int CantidadMarca()
        {
            return CProducto.CantidadMarca();
        }

        public int CantidadModelo()
        {
            return CProducto.CantidadModelo();
        }

        public int CantidadEstado()
        {
            return CProducto.CantidadEstado();
        }
    }
}