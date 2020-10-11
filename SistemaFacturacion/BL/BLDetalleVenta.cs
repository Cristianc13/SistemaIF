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

        public void InsertDetalleVenta(int idCliente, List<ENTDetalleVenta> Edetalle)
        {
            CdetalleVenta.InsertDetalleVenta(idCliente, Edetalle);
        }
    }
}