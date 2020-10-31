using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using CAD;
using System.Data;

namespace BL
{
    public class RBLProducto
    {
        public List<ENTProducto> EReportePro { get; private set; }

        public void GenerarReporte(int i)
        {
            var reporte = new RCADProducto();
            var resultado = reporte.GenerarInformeProducto();
            EReportePro = new List<ENTProducto>();

            foreach (DataRow fila in resultado.Rows)
            {
                var detallescomprobante = new ENTProducto()
                {
                    codigopro = fila[1].ToString(),
                    nombreProducto = fila[2].ToString(),
                    descripcion = fila[3].ToString(),
                    fechaEntrada = Convert.ToDateTime(fila[4].ToString()),
                    costo = Convert.ToDecimal(fila[5].ToString()),
                    precioSalida = Convert.ToDecimal(fila[6].ToString()),
                    stockProducto = Convert.ToDecimal(fila[7].ToString()),
                    categoria = fila[8].ToString(),
                    marca = fila[9].ToString(),
                    modelo = fila[10].ToString(),
                    estado = fila[11].ToString(),
                    observacion = fila[12].ToString()
                };
                EReportePro.Add(detallescomprobante);
            }
        }
    }
}