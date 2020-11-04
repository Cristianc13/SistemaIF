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
    public class CADDetalleCompra : CADConexion
    {
        //private ENTDetalleCompra EdetalleC = new ENTDetalleCompra();
        private DataTable tabla = new DataTable();

        public DataTable MostrarDetalleCompra()
        {
            return null;
        }

        public void InsertDetalleCompra(int idCompra, ENTDetalleCompra EdetalleC)
        {
            SqlCommand cmd = new SqlCommand("InsertDetalleCompra", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.AddWithValue("@cantidadProducto", EdetalleC.cantidadProducto);
            cmd.Parameters.AddWithValue("@costo", EdetalleC.costo);
            cmd.Parameters.AddWithValue("@importe", EdetalleC.importe);
            cmd.Parameters.AddWithValue("@FK_idCompra", idCompra);
            cmd.Parameters.AddWithValue("@FK_idProducto", EdetalleC.FK_idProducto);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }
        
        public void DeleteDetalleCompra()
        {

        }

        public void UpdateDetalleCompra()
        {

        }

        public string ObtenerIVA(int idCompra)
        {
            decimal a;
            string i;
            SqlCommand cmd = new SqlCommand("ObtenerIVA", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCompra", idCompra);
            a = (decimal)cmd.ExecuteScalar();//castear
            i = Convert.ToString(a);
            CerrarConexion();
            return i;
        }
    }
}
