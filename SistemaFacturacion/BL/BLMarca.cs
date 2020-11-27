using System.Data;
using CAD;
using ENT;

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