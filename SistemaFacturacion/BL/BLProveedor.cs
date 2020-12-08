using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLProveedor
    {
        private CADProveedor CProveedor = new CADProveedor();

        public DataTable MostrarProveedor()
        {
            return CProveedor.MostrarProveedor();
        }

        public void InsertProveedor(ENTProveedor EProveedor)
        {
            CProveedor.InsertProveedor(EProveedor);
        }

        public void DeleteProveedor(ENTProveedor EProveedor)
        {
            CProveedor.DeleteProveedor(EProveedor);
        }

        public void UpdateProveedor(ENTProveedor EProveedor)
        {
            CProveedor.UpdateProveedor(EProveedor);
        }

        public DataTable SelectProveedorNombre(ENTProveedor Eproveedor)
        {
          return CProveedor.BuscarProveedor(Eproveedor);
        }

        public string SelectProveedorNombreCom(int idProveedor)
        {
            return CProveedor.SelectProveedorNombreCom(idProveedor);
        }
    }
}