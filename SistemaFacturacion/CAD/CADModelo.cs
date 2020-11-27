using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADModelo : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarModelo()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectModelo", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertModelo(ENTModelo modelo)
        {
            SqlCommand cmd = new SqlCommand("InsertModelo", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreModelo", modelo.nombreModelo);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteModelo(ENTModelo modelo)
        {
            SqlCommand cmd = new SqlCommand("DeleteModelo", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idModelo", modelo.idModelo);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateModelo(ENTModelo modelo)
        {
            SqlCommand cmd = new SqlCommand("UpdateModelo", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idModelo", modelo.idModelo);
            cmd.Parameters.AddWithValue("@nombreModelo", modelo.nombreModelo);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}