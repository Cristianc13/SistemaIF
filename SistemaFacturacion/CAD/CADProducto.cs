using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADProducto : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarProducto()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProducto", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public DataTable ObtenerPrecio(ENTProducto producto)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("ObtenerPrecio", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
            var x = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();
            CerrarConexion();
            return null;
        }
    }
}