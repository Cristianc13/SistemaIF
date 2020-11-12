using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAD;
using ENT;
using System.Data;

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


    }
}
