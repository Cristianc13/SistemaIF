using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADProveedor : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarProveedor()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertProveedor(ENTProveedor EProveedor)
        {
            SqlCommand cmd = new SqlCommand("InsertProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreProv", EProveedor.nombreProv);
            cmd.Parameters.AddWithValue("@telefonoProv", EProveedor.telefonoProv);
            cmd.Parameters.AddWithValue("@nombreCompañia", EProveedor.nombreCompañia);
            cmd.Parameters.AddWithValue("@numeroCompañia", EProveedor.numeroCompañia);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}