using System.Data;
using System.Data.SqlClient;

namespace CAD

{
    public class CADConexion
    {
        private SqlConnection Conexion = new SqlConnection(
  "Data Source=localhost;Initial Catalog=TiendaInventario;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}