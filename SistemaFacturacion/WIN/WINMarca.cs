using System;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINMarca : Form
    {
        public WINMarca()
        {
            InitializeComponent();
        }

        private int id;
        public ENTMarca EMarca = new ENTMarca();
        public BLMarca BLMarca = new BLMarca();

        private void WINMarca_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
        }

        private void LlenarDataGrid()
        {
            MarcadataGridView.DataSource = BLMarca.MostrarMarca();
            Limpiar();
            MarcatextBox.Focus();
        }

        //Clases Diseño

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
            Eliminarbutton.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            MarcadataGridView.Columns[0].Visible = false;
            MarcadataGridView.Columns[1].HeaderText = "Marca";
        }

        //Limpiar Cajas
        private void Limpiar()
        {
            MarcatextBox.Text = string.Empty;

            errorProvider1.Clear();
        }

        private void MarcadataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (MarcadataGridView.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)MarcadataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            MarcatextBox.Text = MarcadataGridView.CurrentRow.Cells[1].Value.ToString();
            errorProvider1.Clear();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            EMarca.idMarca = id;
            EMarca.nombreMarca = MarcatextBox.Text;
            BLMarca.UpdateMarca(EMarca);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            string valor = MarcadataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Marca " + valor, "Marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            EMarca.idMarca = id;

            BLMarca.DeleteMarca(EMarca);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (MarcatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(MarcatextBox, "Debe ingresar un Nombre");
                MarcatextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            EMarca.nombreMarca = MarcatextBox.Text;

            BLMarca.InsertMarca(EMarca);
            LlenarDataGrid();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}