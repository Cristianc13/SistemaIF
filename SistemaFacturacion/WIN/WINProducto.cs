﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
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
        private ENTKardex kardex = new ENTKardex();
        private BLMarca BMarca = new BLMarca();
        private BLModelo BModelo = new BLModelo();
        public BLCategoria BCategoria = new BLCategoria();
        private BLEstado BEstado = new BLEstado();
        private BLProducto BProducto = new BLProducto();
        private ENTProducto EProducto = new ENTProducto();
        private BLKardex BKardex = new BLKardex();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        private void WINProducto_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            LlenarEstado();
            LlenarGrid();
            FormatoGrid();
            LlenarMarca();
            LlenarCategoria();
            LlenarModelo();
            Limpiar();
            Tarjetas();
            IniciarTextbox();
            SendMessage(BuscartextBox.Handle, EM_SETCUEBANNER, 0, "Codigo, Producto o Descripción");

            ContextMenu _blankContextMenu = new ContextMenu();
            NombretextBox.ContextMenu = _blankContextMenu;
            CodigotextBox.ContextMenu = _blankContextMenu;
            StocktextBox.ContextMenu = _blankContextMenu;
            CostotextBox.ContextMenu = _blankContextMenu;
            PrecioSalidatextBox.ContextMenu = _blankContextMenu;
            DescripciontextBox.ContextMenu = _blankContextMenu;
            ObservacionestextBox.ContextMenu = _blankContextMenu;
            BuscartextBox.ContextMenu = _blankContextMenu;
            EstadocomboBox.ContextMenu = _blankContextMenu;
            ModelocomboBox.ContextMenu = _blankContextMenu;
            MarcacomboBox.ContextMenu = _blankContextMenu;
            CategoriacomboBox.ContextMenu = _blankContextMenu;
        }

        private const Keys CopyKeys = Keys.Control | Keys.C;
        private const Keys PasteKeys = Keys.Control | Keys.V;
        private const Keys CutKeys = Keys.Control | Keys.X;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == CopyKeys) || (keyData == PasteKeys) || (keyData == CutKeys))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        public void IniciarTextbox()
        {
            NombretextBox.Visible = true;
            CodigotextBox.Visible = true;
            StocktextBox.Visible = true;
            CostotextBox.Visible = true;
            PrecioSalidatextBox.Visible = true;
            DescripciontextBox.Visible = true;
            ObservacionestextBox.Visible = true;
            BuscartextBox.Visible = true;
            btneditar.Visible = true;
        }

        public void Limpiar()
        {
            NombretextBox.Text = string.Empty;
            StocktextBox.Text = string.Empty;
            CostotextBox.Text = string.Empty;
            PrecioSalidatextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            ObservacionestextBox.Text = string.Empty;
            CodigotextBox.Text = string.Empty;
            MarcacomboBox.SelectedIndex = -1;
            MarcacomboBox.Text = string.Empty;
            ModelocomboBox.SelectedIndex = -1;
            ModelocomboBox.Text = string.Empty;
            CategoriacomboBox.SelectedIndex = -1;
            CategoriacomboBox.Text = string.Empty;
            EstadocomboBox.SelectedIndex = -1;
            EstadocomboBox.Text = string.Empty;
            BuscartextBox.Text = string.Empty;
            LlenarGrid();
            NombretextBox.Focus();
            errorProvider1.Clear();
        }

        public void LlenarGrid()
        {
            ProductodataGridView.DataSource = BProducto.MostrarProductoByForanea();
        }

        public void FormatoGrid()
        {
            ProductodataGridView.Columns[0].Visible = false;
            ProductodataGridView.Columns[1].HeaderText = "Codigo";
            ProductodataGridView.Columns[2].HeaderText = "Producto";
            ProductodataGridView.Columns[3].HeaderText = "Descripción";
            ProductodataGridView.Columns[4].HeaderText = "Fecha";
            ProductodataGridView.Columns[5].HeaderText = "Costo";
            ProductodataGridView.Columns[6].HeaderText = "Precio Salida";
            ProductodataGridView.Columns[7].HeaderText = "Stock";
            ProductodataGridView.Columns[8].HeaderText = "Observación";
            ProductodataGridView.Columns[9].HeaderText = "Marca";
            ProductodataGridView.Columns[10].HeaderText = "Modelo";
            ProductodataGridView.Columns[11].HeaderText = "Categoria";
            ProductodataGridView.Columns[12].HeaderText = "Estado";

            //Alinear texto a la derecha
            ProductodataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            ProductodataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            ProductodataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            ProductodataGridView.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Recursos.DatagridviewDiseño.DiseñoDGV(ref ProductodataGridView);
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
                    CodigotextBox.Text = BCategoria.ObtenercodCat(IdCategoria) + "-";
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

        private void ProductodataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductodataGridView.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            IdProducto = (int)ProductodataGridView.CurrentRow.Cells[0].Value;

            NombretextBox.Text = ProductodataGridView.CurrentRow.Cells[2].Value.ToString();
            DescripciontextBox.Text = ProductodataGridView.CurrentRow.Cells[3].Value.ToString();
            CostotextBox.Text = ProductodataGridView.CurrentRow.Cells[5].Value.ToString();
            PrecioSalidatextBox.Text = ProductodataGridView.CurrentRow.Cells[6].Value.ToString();
            StocktextBox.Text = ProductodataGridView.CurrentRow.Cells[7].Value.ToString();
            ObservacionestextBox.Text = ProductodataGridView.CurrentRow.Cells[8].Value.ToString();
            MarcacomboBox.Text = ProductodataGridView.CurrentRow.Cells[9].Value.ToString();
            ModelocomboBox.Text = ProductodataGridView.CurrentRow.Cells[10].Value.ToString();
            CategoriacomboBox.Text = ProductodataGridView.CurrentRow.Cells[11].Value.ToString();
            CodigotextBox.Text = ProductodataGridView.CurrentRow.Cells[1].Value.ToString();
            EstadocomboBox.Text = ProductodataGridView.CurrentRow.Cells[12].Value.ToString();

            HabilitarBotones(true, false);
        }

        private void StocktextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CostotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PrecioSalidatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BuscartextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = BuscartextBox.Text;
            EProducto.codigopro = filtro;
            //  ProductodataGridView.Columns.Clear();
            ProductodataGridView.DataSource = BProducto.BuscarProducto(EProducto);
        }

        private void BuscarModbutton_Click(object sender, EventArgs e)
        {
            WINModelo WMod = new WINModelo();
            WMod.ShowDialog();
            LlenarModelo();
            Tarjetas();
        }

        public void LlenarCategoria()
        {
            CategoriacomboBox.DataSource = BCategoria.MostrarCategoria();
            CategoriacomboBox.DisplayMember = "nombreCategoria";
            CategoriacomboBox.ValueMember = "idCategoria";
            CategoriacomboBox.SelectedIndex = -1;
        }

        private void ProductodataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Fprmato condicional de la grid
            if (this.ProductodataGridView.Columns[e.ColumnIndex].Name == "stockProducto")
            {
                if (Convert.ToInt32(e.Value) <= 3)
                {
                    e.CellStyle.ForeColor = Color.FromArgb(156, 0, 6);
                    e.CellStyle.BackColor = Color.FromArgb(255, 199, 206);
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                EProducto.nombreProducto = NombretextBox.Text;
                EProducto.codigopro = CodigotextBox.Text;
                EProducto.stockProducto = Conversion(StocktextBox.Text);
                EProducto.costo = Conversion(CostotextBox.Text);
                EProducto.FK_idMarca = IdMarca;
                EProducto.precioSalida = Conversion(PrecioSalidatextBox.Text);
                EProducto.FK_idModelo = IdModelo;
                EProducto.FK_idCategoria = IdCategoria;
                EProducto.FK_idEstado = IdEstado;
                EProducto.descripcion = DescripciontextBox.Text;
                EProducto.observacion = ObservacionestextBox.Text;

                int idP = BProducto.InsertarProducto(EProducto);
                Limpiar();
                LlenarGrid();
                HabilitarBotones(false, true);
                Tarjetas();

                kardex.fecha = DateTime.Now;
                kardex.concepto = "Inventario Inicial";
                kardex.entrada = EProducto.stockProducto;
                kardex.salida = 0;
                kardex.existencia = EProducto.stockProducto;
                kardex.costeunitario = EProducto.costo;
                kardex.FK_idProducto = idP;
                BKardex.InsertKardex(kardex);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("IX_CodigoProducto"))
                {
                    MessageBox.Show("Codigo de Producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CodigotextBox.Focus();
                }
            }
        }

        public decimal Conversion(string numero)
        {
            CultureInfo invariant = CultureInfo.InvariantCulture;
            string texto = numero;
            decimal conversion1 = decimal.Parse(texto, invariant);
            string conversion2 = conversion1.ToString("0.00", invariant);
            decimal final = decimal.Parse(conversion2, invariant);
            //.5=0.50  .47
            return final;
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;
            try
            {
                EProducto.idProducto = IdProducto;
                EProducto.codigopro = CodigotextBox.Text;
                EProducto.nombreProducto = NombretextBox.Text;
                EProducto.stockProducto = Conversion(StocktextBox.Text);
                EProducto.costo = Conversion(CostotextBox.Text);
                EProducto.FK_idMarca = IdMarca;
                EProducto.precioSalida = Conversion(PrecioSalidatextBox.Text); ;
                EProducto.FK_idModelo = IdModelo;
                EProducto.FK_idCategoria = IdCategoria;
                EProducto.FK_idEstado = IdEstado;
                EProducto.descripcion = DescripciontextBox.Text;
                EProducto.observacion = ObservacionestextBox.Text;
                BProducto.UpdateProducto(EProducto);
                Limpiar();
                LlenarGrid();
                HabilitarBotones(false, true);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("IX_CodigoProducto"))
                {
                    MessageBox.Show("Codigo de Producto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CodigotextBox.Focus();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //    DialogResult rpt = MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            //    if (rpt == DialogResult.No) return;
            //    EProducto.idProducto = IdProducto;
            //    BProducto.EliminarProduto(EProducto);
            //    HabilitarBotones(false, true);
            //    Limpiar();
            //    LlenarGrid();
            //    Tarjetas();
            //    if (ex.Message.Contains("FK_detalleCompra_producto"))
            //    {
            //    MessageBox.Show("Este Producto Esta sujeto a Transacciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(false, true);
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            ExportarDatos();
        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            WINCategoria WCat = new WINCategoria();
            WCat.ShowDialog();
            LlenarCategoria();
            Tarjetas();
            LlenarGrid();
        }

        private void btnmodelo_Click(object sender, EventArgs e)
        {
            WINModelo WMod = new WINModelo();
            WMod.ShowDialog();
            LlenarModelo();
            Tarjetas();
            LlenarGrid();
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
            WINMarca WMar = new WINMarca();
            WMar.ShowDialog();
            LlenarMarca();
            Tarjetas();
            LlenarGrid();
        }

        private void btnestado_Click(object sender, EventArgs e)
        {
            WINEstado we = new WINEstado();
            we.ShowDialog();
            LlenarEstado();
            Tarjetas();
            LlenarGrid();
        }

        private void LlenarEstado()
        {
            EstadocomboBox.DataSource = BEstado.MostrarEstado();
            EstadocomboBox.DisplayMember = "estado";
            EstadocomboBox.ValueMember = "idEstado";
            EstadocomboBox.SelectedIndex = -1;
        }

        private void NombretextBox_KeyUp(object sender, KeyEventArgs e)
        {
            NombretextBox.Text = ReducirEspaciado(NombretextBox.Text);
            NombretextBox.SelectionStart = NombretextBox.Text.Length;
        }

        private void DescripciontextBox_KeyUp(object sender, KeyEventArgs e)
        {
            DescripciontextBox.Text = ReducirEspaciado(DescripciontextBox.Text);
            DescripciontextBox.SelectionStart = DescripciontextBox.Text.Length;
        }

        private void ObservacionestextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ObservacionestextBox.Text = ReducirEspaciado(ObservacionestextBox.Text);
            ObservacionestextBox.SelectionStart = ObservacionestextBox.Text.Length;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Kardex
            WINKardex wk = new WINKardex();
            wk.ShowDialog();
        }

        private void CodigotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ProductodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //Evitar espacios en blanco
        public static string ReducirEspaciado(string Cadena)
        {
            while (Cadena.Contains("  "))
            {
                Cadena = Cadena.Replace("  ", " ");
            }

            return Cadena.TrimStart();
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

            //Categoria
            if (CategoriacomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(CategoriacomboBox, "Debe seleccionar un Categoria");
                CategoriacomboBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Codigo
            if (CodigotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigotextBox, "Debe ingresar un Codigo");
                CodigotextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Stock
            if (StocktextBox.Text == string.Empty)
            {
                errorProvider1.SetError(StocktextBox, "Debe ingresar un Numero de Stock");
                StocktextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (StocktextBox.Text == ".")
            {
                errorProvider1.SetError(StocktextBox, "Debe ingresar un Numero de Stock");
                StocktextBox.Focus();
                return false;
            }

            errorProvider1.Clear();
            if (StocktextBox.Text == Convert.ToString(0))
            {
                errorProvider1.SetError(StocktextBox, "Debe ingresar un Numero de Stock Mayor a 0");
                StocktextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            //Costo
            if (CostotextBox.Text == Convert.ToString(0))
            {
                errorProvider1.SetError(CostotextBox, "Debe ingresar un Numero de Costo mayor a 0");
                CostotextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (CostotextBox.Text == ".")
            {
                errorProvider1.SetError(CostotextBox, "Debe ingresar un Numero de Stock");
                CostotextBox.Focus();
                return false;
            }

            //Precio Salida
            if (PrecioSalidatextBox.Text == ".")
            {
                errorProvider1.SetError(PrecioSalidatextBox, "Debe ingresar un Numero de Stock");
                PrecioSalidatextBox.Focus();
                return false;
            }
            if (PrecioSalidatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrecioSalidatextBox, "Debe ingresar un Precio Salida");
                PrecioSalidatextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            decimal a = Convert.ToDecimal(PrecioSalidatextBox.Text);
            decimal b = Convert.ToDecimal(CostotextBox.Text);
            if (a <= b)
            {
                errorProvider1.SetError(CostotextBox, "El precio de salida debe ser mayor al costo");
                PrecioSalidatextBox.Focus();
                return false;
            }
            errorProvider1.Clear();

            if (PrecioSalidatextBox.Text == Convert.ToString(0))
            {
                errorProvider1.SetError(PrecioSalidatextBox, "Debe ingresar un Numero de Precio salida mayor a 0");
                CostotextBox.Focus();
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
            //Marca

            if (MarcacomboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(MarcacomboBox, "Debe seleccionar una Marca");
                MarcacomboBox.Focus();
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

        public void Tarjetas()
        {
            CantidadProduLabel.Text = BProducto.CantidadProducto().ToString();
            lbcantcate.Text = BProducto.CantidadCategorias().ToString();
            lbcantmarca.Text = BProducto.CantidadMarca().ToString();
            lbcantmodelo.Text = BProducto.CantidadModelo().ToString();
            lbcantestado.Text = BProducto.CantidadEstado().ToString();
        }

        public void ExportarDatos()
        {
            WINReportes.RProducto rProducto = new WINReportes.RProducto();
            rProducto.ShowDialog();
        }
    }
}