using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINProducto : Form
    {
        public WINProducto()
        {
            InitializeComponent();
        }

        private int IdCategoria, IdMarca, IdModelo, IdEstado;
        private BLMarca BMarca = new BLMarca();
        private BLProducto BProducto = new BLProducto();
        private ENTProducto EProducto = new ENTProducto();

        private void WINProducto_Load(object sender, EventArgs e)
        {
            Limpiar();
            LlenarGrid();
            FormatoGrid();
            LlenarMarca();
        }

        public void Limpiar()
        {
            NombretextBox.Text = string.Empty;
            StocktextBox.Text = string.Empty;
            CostotextBox.Text = string.Empty;
            PrecioSalidatextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            ObservacionestextBox.Text = string.Empty;
            MarcacomboBox.SelectedIndex = -1;
            ModelocomboBox.SelectedIndex = -1;
            CategoriacomboBox.SelectedIndex = -1;
            EstadocomboBox.SelectedIndex = -1;
            NombretextBox.Focus();
        }

        public void LlenarGrid()
        {
            ProductodataGridView.DataSource = BProducto.MostrarProductoByForanea();
        }

        public void FormatoGrid()
        {
            ProductodataGridView.Columns[0].Visible = false;//idProducto
            ProductodataGridView.Columns[1].HeaderText = "Producto";
            ProductodataGridView.Columns[2].HeaderText = "Descripcion";
            ProductodataGridView.Columns[3].HeaderText = "Fecha";
            ProductodataGridView.Columns[4].HeaderText = "Costo";
            ProductodataGridView.Columns[5].HeaderText = "Precio Salida";
            ProductodataGridView.Columns[6].HeaderText = "Stock";
            ProductodataGridView.Columns[7].HeaderText = "Observarcion";
            ProductodataGridView.Columns[8].HeaderText = "Marca";
            ProductodataGridView.Columns[9].HeaderText = "Modelo";
            ProductodataGridView.Columns[10].HeaderText = "Categoria";
            ProductodataGridView.Columns[11].HeaderText = "Estado";
            ProductodataGridView.AllowUserToResizeColumns = false;
            ProductodataGridView.AllowUserToResizeRows = false;
            ProductodataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            ProductodataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p2;
            Actualizarbutton.Enabled = p1;
            Eliminarbutton.Enabled = p1;
            Cancelarbutton.Enabled = p1;
        }

        private void LlenarMarca()
        {
            MarcacomboBox.DataSource = BMarca.MostrarMarca();
            MarcacomboBox.DisplayMember = "nombreMarca";
            MarcacomboBox.ValueMember = "idMarca";
            MarcacomboBox.SelectedIndex = -1;
        }

        public bool Validar()
        {
            //Marca
            if (MarcacomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcacomboBox, "Debe seleccionar una Marca");
                MarcacomboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Modelo
            if (ModelocomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(ModelocomboBox, "Debe seleccionar un Modelo");
                ModelocomboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Categoria
            if (CategoriacomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(CategoriacomboBox, "Debe seleccionar un Categoria");
                CategoriacomboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Estado
            if (EstadocomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(EstadocomboBox, "Debe seleccionar un Estado");
                MarcacomboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Nombre
            if (NombretextBox.Text == string.Empty)
            {
                errorProvider1.SetError(NombretextBox, "Debe ingresar un Nombre");
                NombretextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Stock
            if (StocktextBox.Text == string.Empty)
            {
                errorProvider1.SetError(StocktextBox, "Debe ingresar un Numero de Stok");
                StocktextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Costo
            if (CostotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CostotextBox, "Debe ingresar un Numero de Costo");
                CostotextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Precio Salida
            if (PrecioSalidatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioSalidatextBox, "Debe ingresar un Precio Salida");
                PrecioSalidatextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }
    }
}