using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CAD;
using ENT;

namespace BL
{
    public class BLCategoria
    {


        public CADCategoria Cat = new CADCategoria();

        public DataTable MostrarCategoria()
        {
            return Cat.MostrarCategoria();
        }

        public void InsertCategoria(ENTCategoria categ)
        {
            Cat.InsertCategoria(categ);
        }

        public void DeleteCategoria(ENTCategoria categ)
        {
            Cat.DeleteCategoria(categ);
        }

        public void UpdateCategoria(ENTCategoria categ)
        {
            Cat.UpdateCategoria(categ);
        }

    }
}
