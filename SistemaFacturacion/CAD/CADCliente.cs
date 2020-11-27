using System;
using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADCliente : CADConexion
    {
        // private CADConexion conexion = new CADConexion();
        private DataTable tabla = new DataTable();

        public DataTable MostrarCliente()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertCliente(ENTCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("InsertCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
            cmd.Parameters.AddWithValue("@apellidoCliente", cliente.apellidoCliente);
            cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteCliente(ENTCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("DeleteCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCLiente);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateCliente(ENTCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("UpdateCliente", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCLiente);
            cmd.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
            cmd.Parameters.AddWithValue("@apellidoCliente", cliente.apellidoCliente);
            cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public string ObtenerNumeroCliente(int idCliente)
        {
            string a;
            string i;
            SqlCommand cmd = new SqlCommand("SelectClienteNumero", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            a = (string)cmd.ExecuteScalar();
            i = Convert.ToString(a);
            CerrarConexion();
            return i;
        }

        /*===============================Reporte=============================================*/

        public DataTable GenerarVentasCliente(int idCliente)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("GenerarReporteVentaClientes", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            var reader = cmd.ExecuteReader();
            tabla.Load(reader);
            CerrarConexion();
            return tabla;
        }
    }
}