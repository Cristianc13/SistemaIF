using System;
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
    public partial class RFacturaVenta : Form
    {
        public RFacturaVenta()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MinimumSize = this.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public int Factura;
        
        FacturaVenta DV = new FacturaVenta();
        private void RFacturaVenta_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            GF();
        }

        public void GenerarF(int ID)
        {
            DV.SetParameterValue("@idFactura", ID);
            crystalReportViewer1.ReportSource = DV;
        }

        private void GF()
        {
            GenerarF(Factura);
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                btnmaximizar.Text = "Restaurar";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnmaximizar.Text = "Maximizar";
            }
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
