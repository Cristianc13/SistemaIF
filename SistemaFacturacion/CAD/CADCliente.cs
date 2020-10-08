using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    public class CADCliente
    {
        private CADConexion conexion = new CADConexion();
        private DataTable tabla = new DataTable();

        public DataTable MostrarCliente()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectCliente", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertCliente(ENTCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("InsertCliente", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
            cmd.Parameters.AddWithValue("@apellidoCliente", cliente.apellidoCliente);
            cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void DeleteCliente (ENTCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("DeleteCliente", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCLiente);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void UpdateCliente (ENTCliente cliente)
        {
            SqlCommand cmd = new SqlCommand("UpdateCliente", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCLiente);
            cmd.Parameters.AddWithValue("@nombreCliente", cliente.nombreCliente);
            cmd.Parameters.AddWithValue("@apellidoCliente", cliente.apellidoCliente);
            cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();

        }
            
    }
}