using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT;
using CAD;

namespace BL
{
    public class BLKardex
    {
        public CADKardex CADkardex = new CADKardex();

        public void InsertKardex(ENTKardex kardex)
        {
            CADkardex.InsertKardex(kardex);
        }
    }
}