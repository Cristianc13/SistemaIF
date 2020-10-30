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
    public class BLDetalleVenta
    {
        private CADDetalleVenta CdetalleVenta = new CADDetalleVenta();

        public DataTable MostrarDetalleVenta()
        {
            return CdetalleVenta.MostrarDetalleVenta();
        }

        public void InsertDetalleVenta(int idventa, ENTDetalleVenta Edetalle)
        {
            CdetalleVenta.InsertDetalleVenta(idventa, Edetalle);
        }

        public int InsertarVenta(int idCliente)
        {
            return CdetalleVenta.InsertarVenta(idCliente);
        }
    }
}