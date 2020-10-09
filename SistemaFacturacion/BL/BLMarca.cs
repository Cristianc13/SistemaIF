using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using System.Data;
using System.Data.SqlClient;
using CAD;

namespace BL
{
    public class BLMarca
    {
        private CADMarca CMarca = new CADMarca();

        public DataTable MostrarMarca()
        {
            return CMarca.MostrarMarca();
        }

        public void InsertCliente(ENTMarca marca)
        {
            CMarca.InsertMarca(marca);
        }

        public void DeleteCliente(ENTMarca marca)
        {
            CMarca.DeleteMarca(marca);
        }

        public void UpdateCliente(ENTMarca marca)
        {
            CMarca.UpdateMarca(marca);
        }
    }
}