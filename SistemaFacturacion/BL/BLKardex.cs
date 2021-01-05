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

        //public void kardexVenta(ENTKardex kardex)
        //{
        //    CADkardex.KardexVenta(kardex);
        //}
    }
}