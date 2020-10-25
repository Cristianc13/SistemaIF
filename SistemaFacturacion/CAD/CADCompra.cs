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

        public void InsertCompra(ENTCompra Ecompra)
        {
            SqlCommand cmd = new SqlCommand("InsertCompra", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@idCompra", Ecompra.idCompra);
            cmd.Parameters.AddWithValue("@numeroFactura", Ecompra.numeroFactura);
            //cmd.Parameters.AddWithValue("@fechaCompra", Ecompra.fechaCompra);
            cmd.Parameters.AddWithValue("@descripcion", Ecompra.descripcion);
            cmd.Parameters.AddWithValue("@FK_idProveedor", Ecompra.FK_idProveedor);
            cmd.ExecuteNonQuery();
            CerrarConexion();
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
            cmd.Parameters.AddWithValue("@FK_idProveedor", Ecompra.FK_idProveedor);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }



    }
}
