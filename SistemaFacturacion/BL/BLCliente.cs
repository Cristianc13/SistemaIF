using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLCliente
    {
        private CADCliente cliente = new CADCliente();

        public DataTable MostrarCliente()
        {
            return cliente.MostrarCliente();
        }

        public DataTable MostrarClientes()
        {
            return cliente.SeleccionarCliente();
        }

        public string ObtenerNumeroCliente(int idCliente)
        {
            return cliente.ObtenerNumeroCliente(idCliente);
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

        public DataTable FiltarClientes (ENTCliente ECliente)
        {
            return cliente.FiltrarCliente(ECliente);
        }

    }
}