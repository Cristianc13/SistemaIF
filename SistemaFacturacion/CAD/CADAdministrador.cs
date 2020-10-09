using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    public class CADAdministrador:CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarAdministrador()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectAdministrador", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
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
