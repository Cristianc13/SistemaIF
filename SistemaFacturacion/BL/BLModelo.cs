using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLModelo
    {
        public CADModelo Mol = new CADModelo();

        public DataTable MostrarModelo()
        {
            return Mol.MostrarModelo();
        }

        public void InsertModelo(ENTModelo mod)
        {
            Mol.InsertModelo(mod);
        }

        public void DeleteModelo(ENTModelo mod)
        {
            Mol.DeleteModelo(mod);
        }

        public void UpdateModelo(ENTModelo mod)
        {
            Mol.UpdateModelo(mod);
        }
    }
}