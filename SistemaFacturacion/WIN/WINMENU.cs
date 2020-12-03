using System;
using System.Windows.Forms;

namespace WIN
{
    public partial class WINMENU : Form
    {
        public WINMENU()
        {
            InitializeComponent();
            personalizarDiseño();
        }

        private void personalizarDiseño()
        {
            PanelSubMenuCatalogos.Visible = false;
            PanelSubMenuMaestro.Visible = false;
            PanelSubMenuProductos.Visible = false;
        }

        private void ocultarSubMenu()
        {
            if (PanelSubMenuCatalogos.Visible == true)
                PanelSubMenuCatalogos.Visible = false;
            if (PanelSubMenuMaestro.Visible == true)
                PanelSubMenuMaestro.Visible = false;
            if (PanelSubMenuProductos.Visible == true)
                PanelSubMenuProductos.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PanelSubMenuCatalogos);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            openChildForm(new WINCategoria());
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new WINCliente());
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            openChildForm(new WINEstado());
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            openChildForm(new WINMarca());
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            openChildForm(new WINModelo());
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            openChildForm(new WINProveedor());
            //codigo aqui
            ocultarSubMenu();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panelchild.Controls.Add(childForm);
            Panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PanelSubMenuProductos);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new WINProducto());
            //codigo aqui
            ocultarSubMenu();
        }

        private void btnMaestro_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(PanelSubMenuMaestro);
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openChildForm(new WINDetalleVenta());
            //codigo aqui
            ocultarSubMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        }

        private void WINMENU_Load(object sender, EventArgs e)
        {
        }
    }
}