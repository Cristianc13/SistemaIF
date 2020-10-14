using System;
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

        public DataTable MostrarProductoByForanea()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProductoByForanea", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public string ObtenerPrecio(int idProducto)
        {
            decimal a;
            string i;
            SqlCommand cmd = new SqlCommand("SelectProductoPrecio", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", idProducto);
            a = (decimal)cmd.ExecuteScalar();
            i = Convert.ToString(a);
            CerrarConexion();
            return i;
        }
    }
}