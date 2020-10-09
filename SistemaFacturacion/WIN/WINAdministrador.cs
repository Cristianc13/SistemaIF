using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINAdministrador : Form
    {

        public ENTAdministrador EAdmin = new ENTAdministrador();
        public BLAdministrador BAdmin = new BLAdministrador();
        int id;

        public WINAdministrador()
        {
            InitializeComponent();
        }

        private void WINAdministrador_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (NombretextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombretextBox, "Debe ingresar un Nombre");
                NombretextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            if (ApellidotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ApellidotextBox, "Debe ingresar un Apellido");
                ApellidotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (TelefonotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(TelefonotextBox, "Debe ingresar un Telefono");
                TelefonotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (UsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsuariotextBox, "Debe ingresar un Usuario");
                UsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ClavetextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ClavetextBox, "Debe ingresar unA cLAVE");
                ClavetextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            EAdmin.nombreAdmin = NombretextBox.Text;
            EAdmin.apellidoAdmin = ApellidotextBox.Text;
            EAdmin.telefonoAdmin = TelefonotextBox.Text;
            EAdmin.usuario = UsuariotextBox.Text;
            EAdmin.clave = ClavetextBox.Text;
            BAdmin.InsertAdmin(EAdmin);
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            AdministradordataGridView.DataSource = BAdmin.MostrarAdmin();
            Limpiar();
            NombretextBox.Focus();
        }

        private void Limpiar()
        {
            NombretextBox.Text = string.Empty;
            ApellidotextBox.Text = string.Empty;
            TelefonotextBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void FormatoGrid()
        {
            AdministradordataGridView.Columns[0].Visible = false;
            AdministradordataGridView.Columns[1].HeaderText = "Nombre";
            AdministradordataGridView.Columns[2].HeaderText = "Apellido";
            AdministradordataGridView.Columns[3].HeaderText = "Telefono";
            AdministradordataGridView.Columns[4].HeaderText = "Usuario";
            AdministradordataGridView.Columns[5].HeaderText = "Clave";
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            string valor = AdministradordataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Nombre " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            EAdmin.idAdmin = id;
            BAdmin.DeleteAdmin(EAdmin);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            EAdmin.idAdmin = id;
            EAdmin.nombreAdmin = NombretextBox.Text;
            EAdmin.apellidoAdmin = ApellidotextBox.Text;
            EAdmin.telefonoAdmin = TelefonotextBox.Text;
            EAdmin.usuario = UsuariotextBox.Text;
            EAdmin.clave = ClavetextBox.Text;
            BAdmin.UpdateAdmin(EAdmin);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
            Eliminarbutton.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
        }

        private void AdministradordataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (AdministradordataGridView.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)AdministradordataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            NombretextBox.Text = AdministradordataGridView.CurrentRow.Cells[1].Value.ToString();
            ApellidotextBox.Text = AdministradordataGridView.CurrentRow.Cells[2].Value.ToString();
            TelefonotextBox.Text = AdministradordataGridView.CurrentRow.Cells[3].Value.ToString();
            UsuariotextBox.Text = AdministradordataGridView.CurrentRow.Cells[4].Value.ToString();
            ClavetextBox.Text = AdministradordataGridView.CurrentRow.Cells[5].Value.ToString();
            errorProvider1.Clear();
        }
    }
}
