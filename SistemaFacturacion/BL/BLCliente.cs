using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENT;
using CAD;

namespace BL
{
    public class BLCliente
    {
        private CADCliente cliente = new CADCliente();

        public DataTable MostrarCliente()
        {
            return cliente.MostrarCliente();
        }

        public void InsertCliente(ENTCliente ECliente)
        {
            cliente.InsertCliente(ECliente);
        }

        public void DeleteCliente(ENTCliente ECliente)
        {
            cliente.DeleteCliente(ECliente);
        }

        public void UpdateCliente(ENTCliente ECliente)
        {
            cliente.UpdateCliente(ECliente);
        }
    }
}