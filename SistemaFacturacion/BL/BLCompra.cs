using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLCompra
    {
        public CADCompra compras = new CADCompra();

        public DataTable MostrarCompra()
        {
            return compras.MostrarCompra();
        }

        //Nuevo codigo
        public int InsertarCompra(ENTCompra Ecompra)
        {
            return compras.InsertarCompra(Ecompra);
        }

        //public void DeleteCompra(ENTCompra compra)
        //{
        //    compras.DeleteCompra(compra);
        //}

        public void UpdateCompra(ENTCompra Ecompra)
        {
            compras.UpdateCompra(Ecompra);
        }

        public void DeleteCompra(ENTCompra Ecompra)
        {
            compras.DeleteCompra(Ecompra);
        }
    }
}