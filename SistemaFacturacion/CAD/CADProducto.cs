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

        public DataTable MostrarProductoVenta()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProdVent", AbrirConexion());
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

        public void InsertarProducto(ENTProducto EProducto)
        {
            SqlCommand cmd = new SqlCommand("InsertProducto", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", EProducto.codigopro);
            cmd.Parameters.AddWithValue("@nombreProducto", EProducto.nombreProducto);
            cmd.Parameters.AddWithValue("@descripcion", EProducto.descripcion);
            cmd.Parameters.AddWithValue("@costo", EProducto.costo);
            cmd.Parameters.AddWithValue("@precioSalida", EProducto.precioSalida);
            cmd.Parameters.AddWithValue("@stockProducto", EProducto.stockProducto);
            cmd.Parameters.AddWithValue("@observacion", EProducto.observacion);
            cmd.Parameters.AddWithValue("@FK_idMarca", EProducto.FK_idMarca);
            cmd.Parameters.AddWithValue("@FK_idModelo", EProducto.FK_idModelo);
            cmd.Parameters.AddWithValue("@FK_idCategoria", EProducto.FK_idCategoria);
            cmd.Parameters.AddWithValue("@FK_idEstado", EProducto.FK_idEstado);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void EliminarProduto(ENTProducto EProducto)
        {
            SqlCommand cmd = new SqlCommand("DeleteProducto", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", EProducto.idProducto);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateProducto(ENTProducto EProducto)
        {
            SqlCommand cmd = new SqlCommand("UpdateProducto", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", EProducto.idProducto);
            cmd.Parameters.AddWithValue("@codigo", EProducto.codigopro);
            cmd.Parameters.AddWithValue("@nombreProducto", EProducto.nombreProducto);
            cmd.Parameters.AddWithValue("@descripcion", EProducto.descripcion);
            cmd.Parameters.AddWithValue("@costo", EProducto.costo);
            cmd.Parameters.AddWithValue("@precioSalida", EProducto.precioSalida);
            cmd.Parameters.AddWithValue("@stockProducto", EProducto.stockProducto);
            cmd.Parameters.AddWithValue("@observacion", EProducto.observacion);
            cmd.Parameters.AddWithValue("@FK_idMarca", EProducto.FK_idMarca);
            cmd.Parameters.AddWithValue("@FK_idModelo", EProducto.FK_idModelo);
            cmd.Parameters.AddWithValue("@FK_idCategoria", EProducto.FK_idCategoria);
            cmd.Parameters.AddWithValue("@FK_idEstado", EProducto.FK_idEstado);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public DataTable BuscarProducto(ENTProducto EProducto)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("BuscarProductoCod", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", EProducto.codigopro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public DataTable BusarProdMarcaModelo(ENTProducto EProducto)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("BusarProdMarcaModelo", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", EProducto.codigopro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public DataTable BuscarProdCodigoNombre(ENTProducto EProducto)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("BuscarProdCodigoNombre", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", EProducto.codigopro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public int CantidadProducto()
        {
            int i;
            SqlCommand cmd = new SqlCommand("ContarProductos", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            i = (int)cmd.ExecuteScalar();
            CerrarConexion();
            return i;
        }
    }
}