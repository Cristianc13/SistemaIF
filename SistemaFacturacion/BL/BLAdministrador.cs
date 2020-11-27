using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLAdministrador
    {
        private CADAdministrador ADMIN = new CADAdministrador();

        public DataTable MostrarAdmin()
        {
            return ADMIN.MostrarAdministrador();
        }

        public void InsertAdmin(ENTAdministrador ECliente)
        {
            ADMIN.InsertAdministrador(ECliente);
        }

        public void DeleteAdmin(ENTAdministrador ECliente)
        {
            ADMIN.DeleteAdministrador(ECliente);
        }

        public void UpdateAdmin(ENTAdministrador ECliente)
        {
            ADMIN.UpdateAdministrador(ECliente);
        }
    }
}