using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    class CADCliente
    {

        CADConexion conexion = new CADConexion();
        DataTable tabla = new DataTable();

        public DataTable MostrarCliente()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectCliente", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

     
    }
}
