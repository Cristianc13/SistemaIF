using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLDetalleCompra
    {
        private CADDetalleCompra CdetalleCompra = new CADDetalleCompra();

        public DataTable MostrarDetalleCompra()
        {
            return CdetalleCompra.MostrarDetalleCompra();
        }

        public void InsertDetalleCompra(int idCompra, ENTDetalleCompra EdetalleC)
        {
            CdetalleCompra.InsertDetalleCompra(idCompra, EdetalleC);
        }

        public string ObtenerIVA(int idCompra)
        {
            return CdetalleCompra.ObtenerIVA(idCompra);
        }

        public void DeleteDetalleCompra(ENTDetalleCompra EdetalleC)
        {
            CdetalleCompra.DeleteDetalleCompra(EdetalleC);
        }

        public void UpdateDetalleCompra(ENTCompra Ecompra)
        {
            CdetalleCompra.UpdateDetalleCompra(Ecompra);
        }
    }
}