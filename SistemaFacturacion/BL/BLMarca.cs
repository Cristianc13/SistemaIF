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

        public void InsertMarca(ENTMarca marca)
        {
            CMarca.InsertMarca(marca);
        }

        public void DeleteMarca(ENTMarca marca)
        {
            CMarca.DeleteMarca(marca);
        }

        public void UpdateMarca(ENTMarca marca)
        {
            CMarca.UpdateMarca(marca);
        }
    }
}