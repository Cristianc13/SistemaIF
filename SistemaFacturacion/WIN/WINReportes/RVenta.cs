﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MinimumSize = this.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }
    }
}