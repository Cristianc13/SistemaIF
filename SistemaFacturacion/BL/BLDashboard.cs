using CAD;
using ENT;

namespace BL
{
    public class BLDashboard
    {
        public void Dashboard(ENTDashboard obj)
        {
            CADDashboard CADDashboard = new CADDashboard();
            CADDashboard.ProdPorCategoria(obj);
            CADDashboard.ProdPreferidos(obj);
            CADDashboard.SumarioDatos(obj);
        }
    }
}