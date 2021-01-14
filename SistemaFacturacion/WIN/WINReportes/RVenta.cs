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
using BL;

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

        private BLCliente BCliente = new BLCliente();
        DetalleVenta DV = new DetalleVenta();
        FacturaVenta FV = new FacturaVenta();
        FacturaCliente FC = new FacturaCliente();

        DateTime date = DateTime.Now;

        private void RVenta_Load(object sender, EventArgs e)
        {
            RVentasHoy();
            dtdate.Value = DateTime.Now;
            dtfrom.Value = DateTime.Now;
            LlenarComboCliente();
            this.WindowState = FormWindowState.Maximized;
            ContextMenu _blankContextMenu = new ContextMenu();
            comboBoxCliente.ContextMenu = _blankContextMenu;
            textBoxFactura.ContextMenu = _blankContextMenu;
        }

        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        private const Keys CutKeys = Keys.Control | Keys.X;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys) || (keyData == CutKeys))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void LlenarComboCliente()
        {
            comboBoxCliente.DataSource = BCliente.MostrarCliente();
            comboBoxCliente.DisplayMember = "cliente";
            comboBoxCliente.ValueMember = "idCliente";
            comboBoxCliente.SelectedIndex = -1;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (textBoxFactura.Text == string.Empty)
            {
                errorProvider1.SetError(textBoxFactura, "Debe ingresar una Factura");
                return;
            }
            errorProvider1.Clear();

            int F = Convert.ToInt32(textBoxFactura.Text);
            FV.SetParameterValue("@idFactura", F);
            crystalReportViewer1.ReportSource = FV;

            textBoxFactura.Text = "";
        }

        private void textBoxFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (comboBoxCliente.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxCliente, "Debe ingresar un Cliente");
                return;
            }
            errorProvider1.Clear();

            string F = comboBoxCliente.Text;
            FC.SetParameterValue("@idCliente", F);
            crystalReportViewer1.ReportSource = FC;

            comboBoxCliente.SelectedIndex = -1;
        }

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }

        private void comboBoxCliente_KeyUp(object sender, KeyEventArgs e)
        {
            comboBoxCliente.Text = ReducirEspaciado(comboBoxCliente.Text);
            comboBoxCliente.SelectionStart = comboBoxCliente.Text.Length;
        }

        private void comboBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
