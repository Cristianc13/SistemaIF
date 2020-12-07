using System.Data;
using System.Data.SqlClient;
using ENT;

namespace CAD
{
    public class CADDashboard : CADConexion
    {
        private DataTable tabla = new DataTable();
        private SqlDataReader dr;

        public void ProdPorCategoria(ENTDashboard obj)
        {
            SqlCommand cmd = new SqlCommand("ProductoCategoria", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Categoria1.Add(dr.GetString(0));
                obj.CantProd1.Add(dr.GetInt32(1));
            }
            dr.Close();
            CerrarConexion();
        }

        public void VentaMes(ENTDashboard obj)
        {
            SqlCommand cmd = new SqlCommand("VentasMes", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Meses1.Add(dr.GetString(0));
                obj.Cantvent1.Add(dr.GetDecimal(1));
            }
            dr.Close();
            CerrarConexion();
        }

        public void ProdPreferidos(ENTDashboard obj)
        {
            SqlCommand cmd = new SqlCommand("ProductosPreferidos", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                obj.Producto1.Add(dr.GetString(0));
                obj.Cant1.Add(dr.GetInt32(1));
            }
            dr.Close();
            CerrarConexion();
        }

        public void SumarioDatos(ENTDashboard obj)
        {
            SqlCommand cmd = new SqlCommand("DashboardDatos", AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter total = new SqlParameter("@totVenta", 0); total.Direction = ParameterDirection.Output;
            SqlParameter nventa = new SqlParameter("@nventa", 0); nventa.Direction = ParameterDirection.Output;
            SqlParameter ncompra = new SqlParameter("@ncompra", 0); ncompra.Direction = ParameterDirection.Output;
            SqlParameter nprod = new SqlParameter("@nproducto", 0); nprod.Direction = ParameterDirection.Output;
            SqlParameter ncliente = new SqlParameter("@ncliente", 0); ncliente.Direction = ParameterDirection.Output;
            SqlParameter nproveedores = new SqlParameter("@nproveedor", 0); nproveedores.Direction = ParameterDirection.Output;
            SqlParameter nmarca = new SqlParameter("@nmarca", 0); nmarca.Direction = ParameterDirection.Output;
            SqlParameter nmodelo = new SqlParameter("@nmodelo", 0); nmodelo.Direction = ParameterDirection.Output;
            SqlParameter ncate = new SqlParameter("@ncate", 0); ncate.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(total);
            cmd.Parameters.Add(nventa);
            cmd.Parameters.Add(ncompra);
            cmd.Parameters.Add(nprod);
            cmd.Parameters.Add(nmarca);
            cmd.Parameters.Add(nmodelo);
            cmd.Parameters.Add(ncliente);
            cmd.Parameters.Add(nproveedores);
            cmd.Parameters.Add(ncate);
            cmd.ExecuteNonQuery();

            obj.totalVentas = cmd.Parameters["@totVenta"].Value.ToString();
            obj.CantVenta = cmd.Parameters["@nventa"].Value.ToString();
            obj.CantCompra = cmd.Parameters["@ncompra"].Value.ToString();
            obj.CantProductos = cmd.Parameters["@nproducto"].Value.ToString();
            obj.CantClientes = cmd.Parameters["@ncliente"].Value.ToString();
            obj.CantProveedores = cmd.Parameters["@nproveedor"].Value.ToString();
            obj.CantMarcas = cmd.Parameters["@nmarca"].Value.ToString();
            obj.CantModelo = cmd.Parameters["@nmodelo"].Value.ToString();
            obj.CantCat = cmd.Parameters["@ncate"].Value.ToString();

            CerrarConexion();
        }
    }
}