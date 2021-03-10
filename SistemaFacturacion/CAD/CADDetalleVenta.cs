using System;
using System.Data;
using System.Data.SqlClient;
using ENT;

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
            cmd.Parameters.AddWithValue("@descuento", Edetalle.descuento);
            cmd.Parameters.AddWithValue("@importe", Edetalle.importe);
            cmd.Parameters.AddWithValue("@FK_idProducto", Edetalle.Fk_idProducto);
            cmd.Parameters.AddWithValue("@FK_idVenta", idventa);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        /*=====================================================================================================*/

        public DataTable GenerarReporteVenta(DateTime fechaInicial, DateTime fechaFinal)
        {
            SqlCommand cmd = new SqlCommand("GenerarReporteVenta", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fechaInicial", fechaInicial);
            cmd.Parameters.AddWithValue("@fechaFinal", fechaFinal);
            var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            reader.Dispose();
            CerrarConexion();
            return table;
        }

        public DataTable GenerarFacturaVenta(int idFactura)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("GenerarFactura", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idFactura", idFactura);
            var reader = cmd.ExecuteReader();
            tabla.Load(reader);
            CerrarConexion();
            return tabla;
        }
    }
}