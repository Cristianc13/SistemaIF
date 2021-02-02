using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using CAD;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace WIN
{
    public partial class WINUser : Form
    {
        public WINUser()
        {
            InitializeComponent();
        }

        private int id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string usuario;
        private string clave;

        private CADAdministrador cad = new CADAdministrador();
        public ENTAdministrador ead = new ENTAdministrador();

        private void WINUser_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
        }

        private void FormatoGrid()
        {
            dataGridView.Columns[0].Visible = false;
            Recursos.DatagridviewDiseño.DiseñoDGV(ref dataGridView);
        }

        private void LlenarDataGrid()
        {
            dataGridView.DataSource = cad.MostrarAdmin();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = dataGridView.CurrentRow.Cells[0].Value.ToString();
                id = Convert.ToInt32(ID);
                string Cliente = dataGridView.CurrentRow.Cells[1].Value.ToString();
                string Apellido = dataGridView.CurrentRow.Cells[2].Value.ToString();

                DialogResult rpt = MessageBox.Show("Desea eliminar el Usuario: " + Cliente + " " + Apellido, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (rpt == DialogResult.No) return;
                ead.idAdmin = id;
                cad.DeleteAdministrador(ead);
                HabilitarBotones(true, false);
                Limpiar();
                LlenarDataGrid();
                Limpiar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LlenarDataGrid();
            HabilitarBotones(true, false);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text == string.Empty)
            {
                errorProvider1.SetError(nombretxt, "Debe ingresar un Nombre");
                nombretxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (apellidotxt.Text == string.Empty)
            {
                errorProvider1.SetError(apellidotxt, "Debe ingresar un Apellido");
                apellidotxt.Focus();
                return;
            }
            errorProvider1.Clear();

            if (telefonotxt.Text == string.Empty)
            {
                errorProvider1.SetError(telefonotxt, "Debe ingresar un Telefono");
                telefonotxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (usuariotxt.Text == string.Empty)
            {
                errorProvider1.SetError(usuariotxt, "Debe ingresar un Usuario");
                usuariotxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (clavetxt.Text == string.Empty)
            {
                errorProvider1.SetError(nombretxt, "Debe ingresar una Clave");
                clavetxt.Focus();
                return;
            }
            errorProvider1.Clear();

            string ID = dataGridView.CurrentRow.Cells[0].Value.ToString();
            id = Convert.ToInt32(ID);
            ead.idAdmin = id;
            ead.nombreAdmin = nombretxt.Text;
            ead.apellidoAdmin = apellidotxt.Text;
            ead.telefonoAdmin = telefonotxt.Text;
            ead.usuario = usuariotxt.Text;
            ead.clave = clavetxt.Text;

            cad.UpdateAdministrador(ead);

            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (nombretxt.Text == string.Empty)
            {
                errorProvider1.SetError(nombretxt, "Debe ingresar un Nombre");
                nombretxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (apellidotxt.Text == string.Empty)
            {
                errorProvider1.SetError(apellidotxt, "Debe ingresar un Apellido");
                apellidotxt.Focus();
                return;
            }
            errorProvider1.Clear();

            if (telefonotxt.Text == string.Empty)
            {
                errorProvider1.SetError(telefonotxt, "Debe ingresar un Telefono");
                telefonotxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (usuariotxt.Text == string.Empty)
            {
                errorProvider1.SetError(usuariotxt, "Debe ingresar un Usuario");
                usuariotxt.Focus();
                return;
            }
            errorProvider1.Clear();
            if (clavetxt.Text == string.Empty)
            {
                errorProvider1.SetError(nombretxt, "Debe ingresar una Clave");
                clavetxt.Focus();
                return;
            }
            errorProvider1.Clear();

            ead.nombreAdmin = nombretxt.Text;
            ead.apellidoAdmin = apellidotxt.Text;
            ead.telefonoAdmin = telefonotxt.Text;
            ead.usuario = usuariotxt.Text;
            ead.clave = clavetxt.Text;

            cad.InsertAdministrador(ead);
            LlenarDataGrid();
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnguardar.Enabled = p1;
            if (btnguardar.Enabled == true)
            {
                btnguardar.BackColor = Color.FromArgb(21, 30, 41);
                btnguardar.IconColor = Color.White;
            }
            else
            {
                btnguardar.BackColor = Color.FromArgb(177, 180, 183);
                btnguardar.IconColor = Color.Black;
            }

            btneliminar.Enabled = p2;
            if (btneliminar.Enabled == true)
            {
                btneliminar.BackColor = Color.FromArgb(21, 30, 41);
                btneliminar.IconColor = Color.White;
            }
            else
            {
                btneliminar.BackColor = Color.FromArgb(177, 180, 183);
                btneliminar.IconColor = Color.Black;
            }

            btneditar.Enabled = p2;
            if (btneditar.Enabled == true)
            {
                btneditar.BackColor = Color.FromArgb(21, 30, 41);
                btneditar.IconColor = Color.White;
            }
            else
            {
                btneditar.BackColor = Color.FromArgb(177, 180, 183);
                btneditar.IconColor = Color.Black;
            }
        }

        private void Limpiar()
        {
            nombretxt.Text = string.Empty;
            apellidotxt.Text = string.Empty;
            telefonotxt.Text = string.Empty;
            usuariotxt.Text = string.Empty;
            clavetxt.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            try
            {
                nombretxt.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                apellidotxt.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                telefonotxt.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                usuariotxt.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
                clavetxt.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
                HabilitarBotones(false, true);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
        }

        private void nombretxt_KeyUp(object sender, KeyEventArgs e)
        {
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

        private void nombretxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void apellidotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void telefonotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void usuariotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void clavetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
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
    }
}