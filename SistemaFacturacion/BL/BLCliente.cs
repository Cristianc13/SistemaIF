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

        public void InsertCliente(int idCLiente, string nombreCliente, string apellidoCliente, string telefono)
        {
            ENTCliente ccliente = new ENTCliente(idCLiente, nombreCliente, apellidoCliente, telefono);
            cliente.InsertCliente(ccliente);
        }

        public void DeleteCliente (int idc)
        {
            ENTCliente ccliente = new ENTCliente(idc);
            cliente.DeleteCliente(ccliente);
        }

        public void UpdateCliente (int idCliente, string nombreCliente, string apellidoCliente, String telefono)
        {
            ENTCliente ccliente = new ENTCliente(idCliente, nombreCliente, apellidoCliente, telefono);
            cliente.UpdateCliente(ccliente);

        }

       
    }
}