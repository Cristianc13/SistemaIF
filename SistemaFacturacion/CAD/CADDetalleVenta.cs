using ENT;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CADDetalleVenta : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarDetalleVenta()
        {
            return null;
        }

        public void InsertDetalleVenta(int idCliente, List<ENTDetalleVenta> Edetalle)
        {
            List<ENTCliente> lst = new List<ENTCliente>();
            var dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("cantidadProducto");
            dt.Columns.Add("precioSalida");
            dt.Columns.Add("IVA");
            dt.Columns.Add("importe");
            dt.Columns.Add("Fk_idProducto");

            int i = 1;
            foreach (var item in Edetalle)
            {
                dt.Rows.Add(i, item.cantidadProducto, item.precioSalida, item.IVA, item.importe, item.Fk_idProducto);
                i++;
            }

            SqlCommand cmd = new SqlCommand("GuardarVenta", AbrirConexion());
            var listDetalle = new SqlParameter("@ListProducto", SqlDbType.Structured);
            listDetalle.TypeName = "dbo.DetalleV";
            listDetalle.Value = dt;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(listDetalle);
            cmd.Parameters.AddWithValue("@FK_idCliente", idCliente);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteDetalleVenta(ENTCliente cliente)
        {
        }

        public void UpdateDetalleVenta(ENTCliente cliente)
        {
        }
    }
}