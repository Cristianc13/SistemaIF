using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ENT;
using CAD;

namespace BL
{
    public class BLEstado
    {


        private CADEstado est = new CADEstado();

        public DataTable MostrarEstado()
        {
            return est.MostrarEstado();
        }

        public void InsertEstado(ENTEstado edt)
        {
            est.InsertEstado(edt);
        }

        public void DeleteEstado(ENTEstado edt)
        {
            est.DeleteEstado(edt);
        }

        public void UpdateEstado(ENTEstado edt)
        {
            est.UpdateEstado(edt);
        }

    }
}
