using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // PantallaOk();
        }

        public void PantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SeleccionarBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btncategoria.Textcolor = Color.White;
            btncliente.Textcolor = Color.White;
            btncompra.Textcolor = Color.White;
            btnestado.Textcolor = Color.White;
            btnmarca.Textcolor = Color.White;
            btnmodelo.Textcolor = Color.White;
            btnprincipal.Textcolor = Color.White;
            btnproducto.Textcolor = Color.White;
            btnproveedor.Textcolor = Color.White;
            btnventa.Textcolor = Color.White;
            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(95, 195, 140);
            }
        }

        public void SeguirBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            flecha.Top = sender.Top;
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnmodelo_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulario(new WINCliente());
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Panel de Producto";
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            AbrirFormulario(new WINProducto());
        }

        private void btnprincipal_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender); SeguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private Form formActivado = null;

        private void AbrirFormulario(Form formHijo)
        {
            if (formActivado != null) formActivado.Close();
            formActivado = formHijo;
            formHijo.TopLevel = false;
            // formHijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(formHijo);
            wrapper.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}