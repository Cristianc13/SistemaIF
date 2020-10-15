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
    public partial class WINModelo : Form
    {

        BLModelo BModelo = new BLModelo();
        ENTModelo EMod = new ENTModelo();
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
            ModelodataGridView.AllowUserToResizeColumns = false;
            ModelodataGridView.AllowUserToResizeRows = false;
            ModelodataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            ModelodataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
            Eliminar.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            string valor = ModelodataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Modelo " + valor, "Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            EMod.idModelo = id;
            EMod.nombreModelo = ModelotextBox.Text;
            BModelo.DeleteModelo(EMod);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void ModelodataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ModelodataGridView.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)ModelodataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            ModelotextBox.Text = ModelodataGridView.CurrentRow.Cells[1].Value.ToString();
            errorProvider1.Clear();
        }

        private void WINModelo_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            FormatoGrid();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
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

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            EMod.idModelo = id;
            EMod.nombreModelo = ModelotextBox.Text;
            BModelo.UpdateModelo(EMod);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }
    }
}
