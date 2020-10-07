using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ENT;

namespace BL
{
    public class BLCliente
    {
        private ENTCliente clientes = new ENTCliente();
        private CADCliente cliente = new CADCliente();

        public DataTable MostrarCliente()
        {
            return cliente.MostrarCliente();
        }
    }
}