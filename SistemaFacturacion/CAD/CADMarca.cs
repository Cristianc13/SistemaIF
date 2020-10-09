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
    public class CADMarca : CADConexion
    {
        // private CADConexion conexion = new CADConexion();
        private DataTable tabla = new DataTable();

        public DataTable MostrarMarca()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectMarca", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertMarca(ENTMarca marca)
        {
            SqlCommand cmd = new SqlCommand("InsertMarca", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreMarca", marca.nombreMarca);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteMarca(ENTMarca marca)
        {
            SqlCommand cmd = new SqlCommand("DeleteMarca", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMarca", marca.idMarca);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateMarca(ENTMarca marca)
        {
            SqlCommand cmd = new SqlCommand("UpdateMarca", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idMarca", marca.idMarca);
            cmd.Parameters.AddWithValue("@nombreMarca", marca.nombreMarca);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}