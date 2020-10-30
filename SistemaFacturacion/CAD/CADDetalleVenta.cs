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

        public int InsertarVenta(int idCliente)
        {
            SqlCommand cmd = new SqlCommand("InsertarVenta", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fkCliente", idCliente);
            int g = (int)cmd.ExecuteScalar();
            int a = Convert.ToInt32(g);
            CerrarConexion();
            return a;
        }

        public void InsertDetalleVenta(int idventa, ENTDetalleVenta Edetalle)
        {
            SqlCommand cmd = new SqlCommand("InsertDetalleVenta", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cantidadProducto", Edetalle.cantidadProducto);
            cmd.Parameters.AddWithValue("@precioSalida", Edetalle.precioSalida);
            cmd.Parameters.AddWithValue("@IVA", Edetalle.IVA);
            cmd.Parameters.AddWithValue("@importe", Edetalle.importe);
            cmd.Parameters.AddWithValue("@FK_idProducto", Edetalle.Fk_idProducto);
            cmd.Parameters.AddWithValue("@FK_idVenta", idventa);
            cmd.ExecuteNonQuery();
            CerrarConexion();

        }
    }
}