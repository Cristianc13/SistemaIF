using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADAdministrador : CADConexion
    {
        private DataTable tabla = new DataTable();

        public int Login(ENTAdministrador admin)
        {
            int c;

            SqlCommand cmd = new SqlCommand("LoginValidacion", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", admin.usuario);
            cmd.Parameters.AddWithValue("@clave", admin.clave);
            c = (int)cmd.ExecuteScalar();
            return c;
        }

        public void InsertAdministrador(ENTAdministrador admin)
        {
            SqlCommand cmd = new SqlCommand("InsertAdministrador", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreAdmin", admin.nombreAdmin);
            cmd.Parameters.AddWithValue("@apellidoAdmin", admin.apellidoAdmin);
            cmd.Parameters.AddWithValue("@telefonoAdmin", admin.telefonoAdmin);
            cmd.Parameters.AddWithValue("@usuario", admin.usuario);
            cmd.Parameters.AddWithValue("@clave", admin.clave);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteAdministrador(ENTAdministrador admin)
        {
            SqlCommand cmd = new SqlCommand("DeleteAdministrador", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idAdmin", admin.idAdmin);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateAdministrador(ENTAdministrador admin)
        {
            SqlCommand cmd = new SqlCommand("UpdateAdministrador", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idAdmin", admin.idAdmin);
            cmd.Parameters.AddWithValue("@nombreAdmin", admin.nombreAdmin);
            cmd.Parameters.AddWithValue("@apellidoAdmin", admin.apellidoAdmin);
            cmd.Parameters.AddWithValue("@telefonoAdmin", admin.telefonoAdmin);
            cmd.Parameters.AddWithValue("@usuario", admin.usuario);
            cmd.Parameters.AddWithValue("@clave", admin.clave);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}