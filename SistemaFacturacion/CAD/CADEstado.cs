using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADEstado : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarEstado()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectEstado", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertEstado(ENTEstado estado)
        {
            SqlCommand cmd = new SqlCommand("InsertEstado", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@estado", estado.estado);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteEstado(ENTEstado estado)
        {
            SqlCommand cmd = new SqlCommand("DeleteEstado", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEstado", estado.idEstado);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateEstado(ENTEstado estado)
        {
            SqlCommand cmd = new SqlCommand("UpdateEstado", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idEstado", estado.idEstado);
            cmd.Parameters.AddWithValue("@estado", estado.estado);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}