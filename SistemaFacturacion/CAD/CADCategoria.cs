using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ENT;

namespace CAD
{
    public class CADCategoria : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarCategoria()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectCategoria", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertCategoria(ENTCategoria categoria)
        {
            SqlCommand cmd = new SqlCommand("InsertCategoria", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreCategoria", categoria.nombreCategoria);
            cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);
            cmd.Parameters.AddWithValue("@codigo", categoria.codigocategoria);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteCategoria(ENTCategoria categoria)
        {
            SqlCommand cmd = new SqlCommand("DeleteCategoria", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCategoria", categoria.idCategoria);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateCategoria(ENTCategoria categoria)
        {
            SqlCommand cmd = new SqlCommand("UpdateCategoria", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCategoria", categoria.idCategoria);
            cmd.Parameters.AddWithValue("@nombreCategoria", categoria.nombreCategoria);
            cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);
            cmd.Parameters.AddWithValue("@codigo", categoria.codigocategoria);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public string ObtenercodCat(int idCat)
        {
            string i;
            SqlCommand cmd = new SqlCommand("ObtenercodCat", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCategoria", idCat);
            i = (string)cmd.ExecuteScalar();//castear
            CerrarConexion();
            return i;
        }
    }
}