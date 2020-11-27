using System;
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
            btnGuardar.Enabled = p1;
            btnActualizar.Enabled = p2;
            btnEliminar.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            EstadodataGridView1.Columns[0].Visible = false;
            EstadodataGridView1.Columns[1].HeaderText = "estado";
        }

        private void Limpiar()
        {
            txtestados.Text = string.Empty;

            errorProvider1.Clear();
        }

        private void WINEstado_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
        }

        private void EstadodataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (EstadodataGridView1.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)EstadodataGridView1.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            txtestados.Text = EstadodataGridView1.CurrentRow.Cells[1].Value.ToString();
            errorProvider1.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EEstado.idEstado = id;
            EEstado.estado = txtestados.Text;
            BLEstado.UpdateEstado(EEstado);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
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
            HabilitarBotones(true, false);
            Limpiar();
        }
    }
}