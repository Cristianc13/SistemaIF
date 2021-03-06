﻿using System;
using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADCompra : CADConexion
    {
        private DataTable tabla = new DataTable();

        public DataTable MostrarCompra()
        {
            tabla.Clear();
            SqlCommand cmd = new SqlCommand("SelectCompra", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            CerrarConexion();
            return tabla;
        }

        public void DeleteCompra(ENTCompra Ecompra)
        {
            SqlCommand cmd = new SqlCommand("DeleteCompra", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCompra", Ecompra.idCompra);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void UpdateCompra(ENTCompra Ecompra)
        {
            SqlCommand cmd = new SqlCommand("UpdateCompra", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCompra", Ecompra.idCompra);
            cmd.Parameters.AddWithValue("@numeroFactura", Ecompra.numeroFactura);
            cmd.Parameters.AddWithValue("@descripcion", Ecompra.descripcion);
            cmd.Parameters.AddWithValue("@IVA", Ecompra.IVA);
            cmd.Parameters.AddWithValue("@FK_idProveedor", Ecompra.FK_idProveedor);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        //Nuevo codigo
        public int InsertarCompra(ENTCompra Ecompra)
        {
            SqlCommand cmd = new SqlCommand("InsertarCompra", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@numeroFactura", Ecompra.numeroFactura);
            cmd.Parameters.AddWithValue("@descripcion", Ecompra.descripcion);
            cmd.Parameters.AddWithValue("@IVA", Ecompra.IVA);
            cmd.Parameters.AddWithValue("@fecha", Ecompra.fechaCompra);
            cmd.Parameters.AddWithValue("@FK_idProveedor", Ecompra.FK_idProveedor);
            int g = (int)cmd.ExecuteScalar();
            int a = Convert.ToInt32(g);
            CerrarConexion();
            return a;
        }
    }
}