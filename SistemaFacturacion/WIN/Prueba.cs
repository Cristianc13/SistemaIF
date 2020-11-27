using System;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class Prueba : Form
    {
        public Prueba()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            Dashboard();
        }

        public void Dashboard()
        {
            BLDashboard BLDash = new BLDashboard();
            ENTDashboard obj = new ENTDashboard();
            BLDash.Dashboard(obj);
            //RECUPERAMOS DATOS DE LA ENTIDAD PARA CARGAR LOS DATOS DEL DASHBOARD
            chartopproductos.Series[0].Points.DataBindXY(obj.Producto1, obj.Cant1);

            chartproductosCat.Series[0].Points.DataBindXY(obj.Categoria1, obj.CantProd1);
        }
    }
}