using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    public class RCADProducto : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable GenerarInformeProducto()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectRProducto", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            var reader = cmd.ExecuteReader();
            tabla.Load(reader);
            CerrarConexion();
            return tabla;
        }
    }
}