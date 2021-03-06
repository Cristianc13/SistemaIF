﻿using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADProveedor : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarProveedor()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public DataTable SelectProveedorCombo()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProveedorCombo", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void InsertProveedor(ENTProveedor EProveedor)
        {
            SqlCommand cmd = new SqlCommand("InsertProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombreProv", EProveedor.nombreProv);
            cmd.Parameters.AddWithValue("@telefonoProv", EProveedor.telefonoProv);
            cmd.Parameters.AddWithValue("@nombreCompañia", EProveedor.nombreCompañia);
            cmd.Parameters.AddWithValue("@numeroCompañia", EProveedor.numeroCompañia);
            cmd.Parameters.AddWithValue("@ruc", EProveedor.ruc);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void DeleteProveedor(ENTProveedor EProvedor)
        {
            SqlCommand cmd = new SqlCommand("DeleteProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProveedor", EProvedor.idProveedor);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateProveedor(ENTProveedor EProveedor)
        {
            SqlCommand cmd = new SqlCommand("UpdateProveedor", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProveedor", EProveedor.idProveedor);
            cmd.Parameters.AddWithValue("@nombreProv", EProveedor.nombreProv);
            cmd.Parameters.AddWithValue("@telefonoProv", EProveedor.telefonoProv);
            cmd.Parameters.AddWithValue("@nombreCompañia", EProveedor.nombreCompañia);
            cmd.Parameters.AddWithValue("@numeroCompañia", EProveedor.numeroCompañia);
            cmd.Parameters.AddWithValue("@ruc", EProveedor.ruc);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
        public DataTable BuscarProveedor(ENTProveedor Eproveedor)
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectProveedorNombre", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ruc", Eproveedor.filtro);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public string SelectProveedorNombreCom(int idProveedor)
        {
            string a;
            string i;
            SqlCommand cmd = new SqlCommand("SelectProveedorNombreCom", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
            a = (string)cmd.ExecuteScalar();
           
            CerrarConexion();
            return a;
        }

    }
}