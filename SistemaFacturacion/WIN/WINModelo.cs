using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINModelo : Form
    {
        private BLModelo BModelo = new BLModelo();
        private ENTModelo EMod = new ENTModelo();
        public int id;

        public WINModelo()
        {
            InitializeComponent();
        }

        public void LlenarGrid()
        {
            ModelodataGridView.DataSource = BModelo.MostrarModelo();
            ModelotextBox.Focus();
        }

        public void FormatoGrid()
        {
            ModelodataGridView.Columns[0].Visible = false;//idProducto
            ModelodataGridView.Columns[1].HeaderText = "Modelo";
            Recursos.DatagridviewDiseño.DiseñoDGV(ref ModelodataGridView);
        }

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

        public void Limpiar()
        {
            ModelotextBox.Text = "";
            ModelotextBox.Focus();
        }

        public void Guardar()
        {
            EMod.nombreModelo = ModelotextBox.Text;
            BModelo.InsertModelo(EMod);
        }

        private void ModelodataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ModelodataGridView.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            id = (int)ModelodataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            ModelotextBox.Text = ModelodataGridView.CurrentRow.Cells[1].Value.ToString();
            errorProvider1.Clear();
        }

        private void WINModelo_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            FormatoGrid();
            btneditar.Visible = true;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            EMod.idModelo = id;
            EMod.nombreModelo = ModelotextBox.Text;
            BModelo.UpdateModelo(EMod);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string valor = ModelodataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Modelo " + valor, "Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR
            EMod.idModelo = id;
            EMod.nombreModelo = ModelotextBox.Text;
            BModelo.DeleteModelo(EMod);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ModelotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ModelotextBox, "Debe ingresar un Modelo");
                return;
            }

            errorProvider1.Clear();

            Guardar();
            LlenarGrid();
            Limpiar();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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