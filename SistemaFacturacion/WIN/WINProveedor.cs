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
    public partial class WINProveedor : Form
    {
        public ENTProveedor EProveedor = new ENTProveedor();
        private BLProveedor BProveedor = new BLProveedor();
        public int n = 0;
        private int id;
        public WINProveedor()
        {
            InitializeComponent();
        }

        private void WINProveedor_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            LlenarDataGrid();
            FormatoGrid();
        }

        private void GuardarProv_Click(object sender, EventArgs e)
        {
            if (txtnombreProv.Text == string.Empty)
            {
                errorProvider1.SetError(txtnombreProv, "Debe ingresar un Nombre");
                txtnombreProv.Focus();
                return;
            }

            errorProvider1.Clear();

            if (txttelefonoProv.Text == string.Empty)
            {
                errorProvider1.SetError(txttelefonoProv, "Debe ingresar un Numero Telefonico");
                txttelefonoProv.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnombreCompañia.Text == string.Empty)
            {
                errorProvider1.SetError(txtnombreCompañia, "Debe ingresar un Nombre de la Empresa");
                txtnombreCompañia.Focus();
                return;
            }
            errorProvider1.Clear();

            if (txtnumeroCompañia.Text == string.Empty)
            {
                errorProvider1.SetError(txtnumeroCompañia, "Debe ingresar un Numero de la Empresa");
                txtnumeroCompañia.Focus();
                return;
            }
            errorProvider1.Clear();


            EProveedor.nombreProv = txtnombreProv.Text;
            EProveedor.telefonoProv = txttelefonoProv.Text;
            EProveedor.nombreCompañia = txtnombreCompañia.Text;
            EProveedor.numeroCompañia = txtnumeroCompañia.Text;
            BProveedor.InsertProveedor(EProveedor);
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            dataGridProovedor.DataSource = BProveedor.MostrarProveedor();
            Limpiar();
            txtnombreProv.Focus();
        }



        //Clases Diseño

        private void HabilitarBotones(bool p1, bool p2)
        {
            GuardarProv.Enabled = p1;
            ActualizarProv.Enabled = p2;
            EliminarProv.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
        }

        //Formato a la grid
        private void FormatoGrid()
        {
            dataGridProovedor.Columns[0].Visible = false;
            dataGridProovedor.Columns[1].HeaderText = "Nombre";
            dataGridProovedor.Columns[2].HeaderText = "Telefono";
            dataGridProovedor.Columns[3].HeaderText = "Nombre de la Empresa";
            dataGridProovedor.Columns[4].HeaderText = "Numero de la Empresa";
        }

        //Limpiar Cajas
        private void Limpiar()
        {
            txtnombreProv.Text = string.Empty;
            txttelefonoProv.Text = string.Empty;
            txtnombreCompañia.Text = string.Empty;
            txtnumeroCompañia.Text = string.Empty;
            errorProvider1.Clear();
        }

        private void dataGridProovedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridProovedor_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridProovedor.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)dataGridProovedor.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            txtnombreProv.Text = dataGridProovedor.CurrentRow.Cells[1].Value.ToString();
            txttelefonoProv.Text = dataGridProovedor.CurrentRow.Cells[2].Value.ToString();
            txtnombreCompañia.Text = dataGridProovedor.CurrentRow.Cells[3].Value.ToString();
            txtnumeroCompañia.Text = dataGridProovedor.CurrentRow.Cells[4].Value.ToString();
            errorProvider1.Clear();
        }

        private void EliminarProv_Click(object sender, EventArgs e)
        {
            string valor = dataGridProovedor.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Nombre " + valor, "Ubicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            EProveedor.idProveedor = id;
            BProveedor.DeleteProveedor(EProveedor);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void ActualizarProv_Click(object sender, EventArgs e)
        {
            EProveedor.idProveedor = id;
            EProveedor.nombreProv = txtnombreProv.Text;
            EProveedor.telefonoProv = txttelefonoProv.Text;
            EProveedor.nombreCompañia = txtnombreCompañia.Text;
            EProveedor.numeroCompañia = txtnumeroCompañia.Text;
            BProveedor.UpdateProveedor(EProveedor);
            LlenarDataGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void CancelarProv_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }
    }
}
