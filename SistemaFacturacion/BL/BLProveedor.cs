﻿using CAD;
using ENT;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class BLProveedor
    {
        private CADProveedor CProveedor = new CADProveedor();

        public DataTable MostrarProveedor()
        {
            return CProveedor.MostrarProveedor();
        }

        public void InsertProveedor(ENTProveedor EProveedor)
        {
            CProveedor.InsertProveedor(EProveedor);
        }
        public void DeleteProveedor(ENTProveedor EProveedor)
        {
            CProveedor.DeleteProveedor(EProveedor);
        }

        public void UpdateProveedor(ENTProveedor EProveedor)
        {
            CProveedor.UpdateProveedor(EProveedor);
        }
    }
}