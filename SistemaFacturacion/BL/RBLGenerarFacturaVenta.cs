using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class RBLGenerarFacturaVenta
    {
        public List<ENTFacturaVenta> EDV { get;  set; }
        public decimal TotalFactura;
        public void GenerarReporte(int i)
        {
            var reporte = new CADDetalleVenta();
            var resultado = reporte.GenerarFacturaVenta(i);
            EDV = new List<ENTFacturaVenta>();

            foreach (DataRow fila in resultado.Rows)
            {
                var DetalleFactura = new ENTFacturaVenta()
                {
                    descripcion = fila[1].ToString(),
                    cantidad = Convert.ToDecimal(fila[2].ToString()),
                    precioUnitario = Convert.ToDecimal(fila[3].ToString()),
                    importe = Convert.ToDecimal(fila[4].ToString()),
                };
                TotalFactura += Convert.ToDecimal(fila[4]);

                EDV.Add(DetalleFactura);
            }
        }

    }
}
