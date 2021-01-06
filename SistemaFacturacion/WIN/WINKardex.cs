using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINKardex : Form
    {
        private int idProducto;
        private BLProducto BProducto = new BLProducto();
        private BLKardex bkardex = new BLKardex();
        private ENTKardex Ek = new ENTKardex();

        public WINKardex()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
    [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        private void WINKardex_Load(object sender, EventArgs e)
        {
            LlenarProducto();
            SendMessage(txtfiltrar.Handle, EM_SETCUEBANNER, 0, "Codigo, Producto o Descripción");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProducto.SelectedValue != null)
                {
                    idProducto = (int)comboBoxProducto.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        public void LlenarProducto()
        {
            comboBoxProducto.DataSource = BProducto.MostrarProducto();
            comboBoxProducto.DisplayMember = "Producto";
            comboBoxProducto.ValueMember = "idProducto";
            comboBoxProducto.SelectedIndex = -1;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            Ek.FK_idProducto = idProducto;
            dataGridViewKardex.DataSource = bkardex.BuscarProductoID(Ek);
            FormatoGrid();
        }

        public void FormatoGrid()
        {
            dataGridViewKardex.Columns[0].HeaderText = "Concepto";
            dataGridViewKardex.Columns[1].HeaderText = "Fecha";
            dataGridViewKardex.Columns[2].HeaderText = "Entrada";
            dataGridViewKardex.Columns[3].HeaderText = "Salida";
            dataGridViewKardex.Columns[4].HeaderText = "Existencia";
            dataGridViewKardex.Columns[5].HeaderText = "Codigo";
            dataGridViewKardex.Columns[6].HeaderText = "Producto";
            dataGridViewKardex.Columns[7].HeaderText = "Marca";
            dataGridViewKardex.Columns[8].HeaderText = "Modelo";
            dataGridViewKardex.Columns[9].HeaderText = "Descripcion";
            dataGridViewKardex.Columns[10].HeaderText = "Estado";
            dataGridViewKardex.Columns[11].HeaderText = "Categoria";

            //Alinear texto a la derecha
            dataGridViewKardex.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewKardex.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewKardex.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Recursos.DatagridviewDiseño.DiseñoDGV(ref dataGridViewKardex);
            dataGridViewKardex.Columns[0].Width = 150;
        }
    }
}