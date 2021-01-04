using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINEstado : Form
    {
        public WINEstado()
        {
            InitializeComponent();
        }

        private int id;
        public ENTEstado EEstado = new ENTEstado();
        public BLEstado BLEstado = new BLEstado();

        private void LlenarDataGrid()
        {
            EstadodataGridView1.DataSource = BLEstado.MostrarEstado();
            Limpiar();
            txtestados.Focus();
        }

        //Clases Diseño

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnguardar.Enabled = p2;

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

            btneditar.Enabled = p1;
            if (btneditar.Enabled == false)
            {
                btneditar.BackColor = Color.FromArgb(177, 180, 183);
                btneditar.IconColor = Color.Black;
            }
            else
            {
                btneditar.BackColor = Color.FromArgb(21, 30, 41);
                btneditar.IconColor = Color.White;
            }
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            EstadodataGridView1.Columns[0].Visible = false;
            EstadodataGridView1.Columns[1].HeaderText = "Estado";
            Recursos.DatagridviewDiseño.DiseñoDGV(ref EstadodataGridView1);
        }

        private void Limpiar()
        {
            txtestados.Text = string.Empty;

            errorProvider1.Clear();
        }

        private void WINEstado_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            LlenarDataGrid();
            FormatoGrid(); ;
        }

        private void EstadodataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (EstadodataGridView1.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            id = (int)EstadodataGridView1.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            txtestados.Text = EstadodataGridView1.CurrentRow.Cells[1].Value.ToString();
            errorProvider1.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string valor = EstadodataGridView1.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Estado " + valor, "estado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            EEstado.idEstado = id;

            BLEstado.DeleteEstado(EEstado);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            Limpiar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            Limpiar();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EEstado.idEstado = id;
            EEstado.estado = txtestados.Text;
            BLEstado.UpdateEstado(EEstado);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(false, true);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (txtestados.Text == string.Empty)
            {
                errorProvider1.SetError(txtestados, "Debe ingresar un Estado");
                txtestados.Focus();
                return;
            }

            errorProvider1.Clear();

            EEstado.estado = txtestados.Text;

            BLEstado.InsertEstado(EEstado);
            LlenarDataGrid();
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}