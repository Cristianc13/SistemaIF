using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADKardex : CADConexion
    {
        private DataTable tabla = new DataTable();

        public void InsertKardex(ENTKardex kardex)
        {
            SqlCommand cmd = new SqlCommand("InsertKardex", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha", kardex.fecha);
            cmd.Parameters.AddWithValue("@concepto", kardex.concepto);
            cmd.Parameters.AddWithValue("@entrada", kardex.entrada);
            cmd.Parameters.AddWithValue("@salida", kardex.salida);
            cmd.Parameters.AddWithValue("@existencia", kardex.existencia);
            cmd.Parameters.AddWithValue("@FK_idProducto", kardex.FK_idProducto);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public DataTable BuscarProductoID(ENTKardex EKardex)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectKardexId", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", EKardex.FK_idProducto);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }
    }
}