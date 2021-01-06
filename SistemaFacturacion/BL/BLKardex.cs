using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLKardex
    {
        public CADKardex CADkardex = new CADKardex();

        public void InsertKardex(ENTKardex kardex)
        {
            CADkardex.InsertKardex(kardex);
        }

        public DataTable BuscarProductoID(ENTKardex EKardex)
        {
            return CADkardex.BuscarProductoID(EKardex);
        }
    }
}