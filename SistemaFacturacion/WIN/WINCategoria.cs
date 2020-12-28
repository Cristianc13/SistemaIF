using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINCategoria : Form
    {
        private BLCategoria BCat = new BLCategoria();
        private ENTCategoria ECat = new ENTCategoria();
        public int id;

        public WINCategoria()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            CategoriatextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            CodigotextBox.Text = string.Empty;

            CategoriatextBox.Focus();
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

        public void LlenarGrid()
        {
            CategoriadataGridView.DataSource = BCat.MostrarCategoria();
            CategoriatextBox.Focus();
        }

        public void Guardar()
        {
            ECat.nombreCategoria = CategoriatextBox.Text;
            ECat.descripcion = DescripciontextBox.Text;
            ECat.codigocategoria = CodigotextBox.Text;
            BCat.InsertCategoria(ECat);
        }

        public void FormatoGrid()
        {
            CategoriadataGridView.Columns[0].Visible = false;//idProducto
            CategoriadataGridView.Columns[1].HeaderText = "Modelo";
            CategoriadataGridView.Columns[2].HeaderText = "Descripcion";
            CategoriadataGridView.Columns[3].HeaderText = "Codigo";
            CategoriadataGridView.AllowUserToResizeColumns = false;
            CategoriadataGridView.AllowUserToResizeRows = false;
            Recursos.DatagridviewDiseño.DiseñoDGV(ref CategoriadataGridView);
        }

        private void CategoriadataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (CategoriadataGridView.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            id = (int)CategoriadataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            CategoriatextBox.Text = CategoriadataGridView.CurrentRow.Cells[1].Value.ToString();
            DescripciontextBox.Text = CategoriadataGridView.CurrentRow.Cells[2].Value.ToString();
            CodigotextBox.Text = CategoriadataGridView.CurrentRow.Cells[3].Value.ToString();
            errorProvider1.Clear();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            LlenarGrid();
            FormatoGrid();
            btneditar.Visible = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string valor = CategoriadataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Categoria " + valor, "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;
            ECat.idCategoria = id;
            BCat.DeleteCategoria(ECat);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(false, true);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            ECat.idCategoria = id;
            ECat.nombreCategoria = CategoriatextBox.Text;
            ECat.descripcion = DescripciontextBox.Text;
            ECat.codigocategoria = CodigotextBox.Text;
            BCat.UpdateCategoria(ECat);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(false, true);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (CategoriatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CategoriatextBox, "Debe ingresar una Categoria");
                return;
            }
            errorProvider1.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripciontextBox, "Debe ingresar una Descripcion");
                return;
            }
            errorProvider1.Clear();

            if (CodigotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigotextBox, "Debe ingresar un Codigo");
                return;
            }
            errorProvider1.Clear();

            Guardar();
            LlenarGrid();
            Limpiar();
            HabilitarBotones(false, true);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
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