using System;
using System.Windows.Forms;
using BL;
using WIN.WINReportes.ReporteCristal;
using CrystalDecisions.CrystalReports.Engine;
using System.Runtime.InteropServices;

namespace WIN.WINReportes
{
    public partial class RProducto : Form
    {
        public RProducto()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MinimumSize = this.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private Producto informe = new Producto();

        private void RProducto_Load(object sender, EventArgs e)
        {
            GenerarInforme(99999);
        }

        private void GenerarInforme(int existencia)
        {
            informe.SetParameterValue("@existecia", existencia);
            crystalReportViewer1.ReportSource = informe;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void btproducto_Click(object sender, EventArgs e)
        {
            GenerarInforme(3);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            GenerarInforme(99999);
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}