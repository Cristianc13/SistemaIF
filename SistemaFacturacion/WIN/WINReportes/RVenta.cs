using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using WIN.WINReportes.ReporteCristal;

namespace WIN.WINReportes
{
    public partial class RVenta : Form
    {
        public RVenta()
        {
            InitializeComponent();
        }

        DetalleVenta DV = new DetalleVenta();
        DateTime date = DateTime.Now;

        private void RVenta_Load(object sender, EventArgs e)
        {
            RVentasHoy();
        }

        private void Semanabtn_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);//10/11/2020
            DatosInforme(fromDate, date);
        }

        private void DatosInforme(DateTime fromDate, DateTime date)
        {
            DV.SetParameterValue("@fechaInicial", fromDate);
            DV.SetParameterValue("@fechaFinal", date);
            crystalReportViewer1.ReportSource = DV;
        }

        private void mesbtn_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);//10/11/2020           
            DatosInforme(fromDate, date);
        }

        private void aniobtn_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            DatosInforme(fromDate, date);
        }

        private void totalbtn_Click(object sender, EventArgs e)
        {
            DateTime fechaI = Convert.ToDateTime("2019-10-01");
            DatosInforme(fechaI, date);
        }

        public void RVentasHoy()
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            DatosInforme(fromDate, date);
        }

        private void btnpersonalizado_Click(object sender, EventArgs e)
        {
            DatosInforme(dtdate.Value, dtfrom.Value);
        }
    }
}
