using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WIN
{
    public partial class Form1 : Form
    {
        private IconButton BotonActual;
        public Panel panelizquierdo;
        private Form actualformhijo;

        public Form1()
        {
            InitializeComponent();
            panelizquierdo = new Panel();
            panelizquierdo.Size = new Size(7, 46);
            slidebar.Controls.Add(panelizquierdo);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MinimumSize = this.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirForm(new Prueba());
        }

        #region Controles basicos

        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion Controles basicos

        #region Segundo Codigo

        //Colores

        private void ActivarBoton(object sender, Color color)
        {
            if (sender != null)
            {
                //Activar boton
                DesactivarBoton();
                BotonActual = (IconButton)sender;
                BotonActual.BackColor = Color.FromArgb(38, 55, 75);
                BotonActual.ForeColor = color;
                BotonActual.TextAlign = ContentAlignment.MiddleCenter;
                BotonActual.IconColor = color;
                BotonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                BotonActual.ImageAlign = ContentAlignment.MiddleRight;

                //Panel izquiedo
                panelizquierdo.BackColor = color;
                panelizquierdo.Location = new Point(0, BotonActual.Location.Y);
                panelizquierdo.Visible = true;
                panelizquierdo.BringToFront();

                //Cambiar iconohome
                icohome.IconChar = BotonActual.IconChar;
                icohome.IconColor = Color.White;
                //Texto
                lbltitulo.Text = BotonActual.Text;
            }
        }

        private void DesactivarBoton()
        {
            if (BotonActual != null)
            {
                BotonActual.BackColor = Color.FromArgb(21, 30, 41);
                BotonActual.ForeColor = Color.White;
                BotonActual.TextAlign = ContentAlignment.MiddleLeft;
                BotonActual.IconColor = Color.White;
                BotonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                BotonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btventa_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(52, 152, 219));
            AbrirForm(new WINDetalleVenta());
        }

        private void btcompra_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(230, 126, 34));
            AbrirForm(new WINDCompracs());
        }

        private void btdashboard_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(39, 174, 96));
            AbrirForm(new Prueba());
        }

        private void btproducto_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(241, 196, 15));
            AbrirForm(new WINProducto());
        }

        private void pictreinicio_Click(object sender, EventArgs e)
        {
            DesactivarBoton();
            panelizquierdo.Visible = false;
            icohome.IconChar = IconChar.TachometerAlt;
            icohome.IconColor = Color.FromArgb(21, 30, 41);
            lbltitulo.Text = "Dashboard";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            //Proveedor
            ActivarBoton(sender, Color.FromArgb(196, 229, 56));
            AbrirForm(new WinProveedorPrincipal());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Cliente
            ActivarBoton(sender, Color.FromArgb(61, 193, 211));
            AbrirForm(new WINClientePrincipal());
        }

        #region MoverFormulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion MoverFormulario

        //Abrir formulario
        private void AbrirForm(Form hijoForm)
        {
            //open only form
            if (actualformhijo != null)
            {
                actualformhijo.Close();
            }
            actualformhijo = hijoForm;
            //End
            hijoForm.TopLevel = false;
            hijoForm.FormBorderStyle = FormBorderStyle.None;
            hijoForm.Dock = DockStyle.Fill;
            wrapper.Controls.Add(hijoForm);
            wrapper.Tag = hijoForm;
            hijoForm.BringToFront();
            hijoForm.Show();
        }

        #endregion Segundo Codigo

        private void btconfig_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(255, 94, 87));
        }

        private void btnrespaldo_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(0, 148, 50));
            Backup bc = new Backup();
            bc.ShowDialog();
            btdashboard_Click(sender, e);
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            WINReportes.RVenta RVenta = new WINReportes.RVenta();
            RVenta.ShowDialog();
        }
    }
}