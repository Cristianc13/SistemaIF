using System;
using System.Drawing;
using System.Runtime.InteropServices;
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
            HabilitarBotones(false, true);
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
            MarcadataGridView.Columns[0].Visible = false;
            MarcadataGridView.Columns[1].HeaderText = "Marca";
            Recursos.DatagridviewDiseño.DiseñoDGV(ref MarcadataGridView);
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
            HabilitarBotones(true, false);
            id = (int)MarcadataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            MarcatextBox.Text = MarcadataGridView.CurrentRow.Cells[1].Value.ToString();
            errorProvider1.Clear();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            EMarca.idMarca = id;
            EMarca.nombreMarca = MarcatextBox.Text;
            BLMarca.UpdateMarca(EMarca);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btnguardar_Click(object sender, EventArgs e)
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}