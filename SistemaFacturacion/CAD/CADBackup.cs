using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class CADBackup : CADConexion
    {
        public void BackupBD(string ruta)
        {
            SqlCommand cmd = new SqlCommand("BackupBD", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ruta", ruta);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}