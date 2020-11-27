using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADKardex : CADConexion
    {
        public void InsertKardex(ENTKardex kardex)
        {
            SqlCommand cmd = new SqlCommand("InsertKardex", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fecha", kardex.fecha);
            cmd.Parameters.AddWithValue("@concepto", kardex.concepto);
            cmd.Parameters.AddWithValue("@entrada", kardex.entrada);
            cmd.Parameters.AddWithValue("@salida", kardex.salida);
            cmd.Parameters.AddWithValue("@existencia", kardex.existencia);
            cmd.Parameters.AddWithValue("@costounitario", kardex.costeunitario);
            cmd.Parameters.AddWithValue("@costopromedio", kardex.costepromedio);
            cmd.Parameters.AddWithValue("@FK_idProducto", kardex.FK_idProducto);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}