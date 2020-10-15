using System;
using System.Data.SqlClient;
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

        private int IdCategoria, IdMarca, IdModelo, IdEstado, IdProducto;
        private BLMarca BMarca = new BLMarca();
        private BLModelo BModelo = new BLModelo();
        public BLCategoria BCategoria = new BLCategoria();
        private BLEstado BEstado = new BLEstado();
        private BLProducto BProducto = new BLProducto();
        private ENTProducto EProducto = new ENTProducto();

        private void WINProducto_Load(object sender, EventArgs e)
        {
            LlenarEstado();
            LlenarGrid();
            FormatoGrid();
            LlenarMarca();
            LlenarCategoria();
            LlenarModelo();
            Limpiar();
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
            ProductodataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
            ProductodataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8);
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

        private void LlenarModelo()
        {
            ModelocomboBox.DataSource = BModelo.MostrarModelo();
            ModelocomboBox.DisplayMember = "nombreModelo";
            ModelocomboBox.ValueMember = "idModelo";
            ModelocomboBox.SelectedIndex = -1;
        }

        private void MarcacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MarcacomboBox.SelectedValue != null)
                {
                    IdMarca = (int)MarcacomboBox.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void ModelocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ModelocomboBox.SelectedValue != null)
                {
                    IdModelo = (int)ModelocomboBox.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void CategoriacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CategoriacomboBox.SelectedValue != null)
                {
                    IdCategoria = (int)CategoriacomboBox.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void EstadocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (EstadocomboBox.SelectedValue != null)
                {
                    IdEstado = (int)EstadocomboBox.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                EProducto.nombreProducto = NombretextBox.Text;
                EProducto.stockProducto = Convert.ToDecimal(StocktextBox.Text);
                EProducto.costo = Convert.ToDecimal(CostotextBox.Text);
                EProducto.FK_idMarca = IdMarca;
                EProducto.precioSalida = int.Parse(PrecioSalidatextBox.Text);
                EProducto.FK_idModelo = IdModelo;
                EProducto.FK_idCategoria = IdCategoria;
                EProducto.FK_idEstado = IdEstado;
                EProducto.descripcion = DescripciontextBox.Text;
                EProducto.observacion = ObservacionestextBox.Text;
                BProducto.InsertarProducto(EProducto);
                Limpiar();
                LlenarGrid();
            }
            catch (SqlException ex)
            {
            }
        }

        private void ProductodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductodataGridView.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            IdProducto = (int)ProductodataGridView.CurrentRow.Cells[0].Value;
            NombretextBox.Text = ProductodataGridView.CurrentRow.Cells[1].Value.ToString();
            DescripciontextBox.Text = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            CostotextBox.Text = ProductodataGridView.CurrentRow.Cells[4].Value.ToString();
            PrecioSalidatextBox.Text = ProductodataGridView.CurrentRow.Cells[5].Value.ToString();
            StocktextBox.Text = ProductodataGridView.CurrentRow.Cells[6].Value.ToString();
            ObservacionestextBox.Text = ProductodataGridView.CurrentRow.Cells[7].Value.ToString();
            MarcacomboBox.Text = ProductodataGridView.CurrentRow.Cells[8].Value.ToString();
            ModelocomboBox.Text = ProductodataGridView.CurrentRow.Cells[9].Value.ToString();
            CategoriacomboBox.Text = ProductodataGridView.CurrentRow.Cells[10].Value.ToString();
            EstadocomboBox.Text = ProductodataGridView.CurrentRow.Cells[11].Value.ToString();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                EProducto.idProducto = IdProducto;
                EProducto.nombreProducto = NombretextBox.Text;
                EProducto.stockProducto = Convert.ToDecimal(StocktextBox.Text);
                EProducto.costo = Convert.ToDecimal(CostotextBox.Text);
                EProducto.FK_idMarca = IdMarca;
                EProducto.precioSalida = Convert.ToDecimal(PrecioSalidatextBox.Text);
                EProducto.FK_idModelo = IdModelo;
                EProducto.FK_idCategoria = IdCategoria;
                EProducto.FK_idEstado = IdEstado;
                EProducto.descripcion = DescripciontextBox.Text;
                EProducto.observacion = ObservacionestextBox.Text;
                BProducto.UpdateProducto(EProducto);
                Limpiar();
                LlenarGrid();
            }
            catch (SqlException ex)
            {
            }
        }

        public void LlenarCategoria()
        {
            CategoriacomboBox.DataSource = BCategoria.MostrarCategoria();
            CategoriacomboBox.DisplayMember = "nombreCategoria";
            CategoriacomboBox.ValueMember = "idCategoria";
            CategoriacomboBox.SelectedIndex = -1;
        }

        private void LlenarEstado()
        {
            EstadocomboBox.DataSource = BEstado.MostrarEstado();
            EstadocomboBox.DisplayMember = "estado";
            EstadocomboBox.ValueMember = "idEstado";
            EstadocomboBox.SelectedIndex = -1;
        }

        public bool Validar()
        {
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

            //Marca
            if (MarcacomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcacomboBox, "Debe seleccionar una Marca");
                MarcacomboBox.Focus();
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

            return true;
        }
    }
}