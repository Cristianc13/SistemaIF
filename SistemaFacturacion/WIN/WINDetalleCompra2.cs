using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using ENT;
using System.Runtime.InteropServices;

namespace WIN
{
    public partial class WINDetalleCompra2 : Form
    {
        public WINDetalleCompra2()
        {
            InitializeComponent();
        }
        public string nombrep;
      


        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam,
        [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        public string codigo, marca, modelo, estado, descripciom;


        private int IdCategoria, IdMarca, IdModelo, IdEstado, IdProducto;
        private BLMarca BMarca = new BLMarca();
        private BLModelo BModelo = new BLModelo();
        public BLCategoria BCategoria = new BLCategoria();
        private BLEstado BEstado = new BLEstado();
        private BLProducto BProducto = new BLProducto();
        private ENTProducto EProducto = new ENTProducto();

        public void Limpiar()
        {
            txtnombre.Text = string.Empty;

            txtpreciosalida.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtobservacion.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbMarca.SelectedIndex = -1;
            cmbMarca.Text = string.Empty;
            cmbModelo.SelectedIndex = -1;
            cmbModelo.Text = string.Empty;
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = string.Empty;
            cmbEstado.SelectedIndex = -1;
            cmbEstado.Text = string.Empty;
            //BuscartextBox.Text = string.Empty;
            //LlenarGrid();
            //NombretextBox.Focus();
            //errorProvider1.Clear();
        }

        public void FormatoGrid()
        {
            DetalleCompra2GridView1.Columns[0].Visible = false;//idProducto
            DetalleCompra2GridView1.Columns[1].HeaderText = "Codigo";
            DetalleCompra2GridView1.Columns[2].HeaderText = "Producto";
            DetalleCompra2GridView1.Columns[3].HeaderText = "Descripcion";
            DetalleCompra2GridView1.Columns[4].HeaderText = "Fecha";
            //DetalleCompra2GridView1.Columns[5].HeaderText = "Costo";
            DetalleCompra2GridView1.Columns[5].HeaderText = "Precio Salida";
            //DetalleCompra2GridView1.Columns[7].HeaderText = "Stock";
            DetalleCompra2GridView1.Columns[6].HeaderText = "Observacion";
            DetalleCompra2GridView1.Columns[7].HeaderText = "Marca";
            DetalleCompra2GridView1.Columns[8].HeaderText = "Modelo";
            DetalleCompra2GridView1.Columns[9].HeaderText = "Estado";
            DetalleCompra2GridView1.Columns[10].HeaderText = "Categoria";
            DetalleCompra2GridView1.AllowUserToResizeColumns = false;
            DetalleCompra2GridView1.AllowUserToResizeRows = false;

            DetalleCompra2GridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            DetalleCompra2GridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            Recursos.DatagridviewDiseño.DiseñoDGV(ref DetalleCompra2GridView1);
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnEditar.Enabled = p2;
            if (btnEditar.Enabled == true)
            {
                btnEditar.BackColor = Color.FromArgb(21, 30, 41);
                btnEditar.IconColor = Color.White;
            }
            else
            {
                btnEditar.BackColor = Color.FromArgb(177, 180, 183);
                btnEditar.IconColor = Color.Black;
            }

            //btneliminar.Enabled = p2;
            //if (btneliminar.Enabled == true)
            //{
            //    btneliminar.BackColor = Color.FromArgb(21, 30, 41);
            //    btneliminar.IconColor = Color.White;
            //}
            //else
            //{
            //    btneliminar.BackColor = Color.FromArgb(177, 180, 183);
            //    btneliminar.IconColor = Color.Black;
            //}

            btnguardar.Enabled = p1;
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
        }

        private void LlenarMarca()
        {
            cmbMarca.DataSource = BMarca.MostrarMarca();
            cmbMarca.DisplayMember = "nombreMarca";
            cmbMarca.ValueMember = "idMarca";
            cmbMarca.SelectedIndex = -1;
        }

        private void LlenarModelo()
        {
            cmbModelo.DataSource = BModelo.MostrarModelo();
            cmbModelo.DisplayMember = "nombreModelo";
            cmbModelo.ValueMember = "idModelo";
            cmbModelo.SelectedIndex = -1;
        }

        private void LlenarCategoria()
        {
            cmbCategoria.DataSource = BCategoria.MostrarCategoria();
            cmbCategoria.DisplayMember = "nombreCategoria";
            cmbCategoria.ValueMember = "idCategoria";
            cmbCategoria.SelectedIndex = -1;
        }

        private void LlenarEstado()
        {
            cmbEstado.DataSource = BEstado.MostrarEstado();
            cmbEstado.DisplayMember = "estado";
            cmbEstado.ValueMember = "idEstado";
            cmbEstado.SelectedIndex = -1;
        }

        public void LlenarGrid()
        {
            DetalleCompra2GridView1.DataSource = BProducto.MostrarDetallesProd();
        }

        public void IniciarTextbox()
        {
            txtnombre.Visible = true;
            txtcodigo.Visible = true;
            txtpreciosalida.Visible = true;
            txtdescripcion.Visible = true;
            txtobservacion.Visible = true;
            txtfiltrar.Visible = true;
            btnEditar.Visible = true;
            iconPictureBox1.Visible = true;
        }


        private void WINDetalleCompra2_Load(object sender, EventArgs e)
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MinimumSize = this.Size;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            HabilitarBotones(true, false);
            LlenarEstado();
            LlenarGrid();
            FormatoGrid();
            LlenarMarca();
            LlenarCategoria();
            LlenarModelo();
            Limpiar();
            IniciarTextbox();
            SendMessage(txtfiltrar.Handle, EM_SETCUEBANNER, 0, "Codigo o Nombre");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EProducto.nombreProducto = txtnombre.Text;
            EProducto.codigopro = txtcodigo.Text;
            EProducto.FK_idMarca = IdMarca;
            EProducto.precioSalida = Convert.ToDecimal(txtpreciosalida.Text);
            EProducto.costo = 0;
            EProducto.stockProducto = 0;
            EProducto.FK_idModelo = IdModelo;
            EProducto.FK_idCategoria = IdCategoria;
            EProducto.FK_idEstado = IdEstado;
            EProducto.descripcion = txtdescripcion.Text;
            EProducto.observacion = txtobservacion.Text;
            BProducto.InsertarProducto(EProducto);
            Limpiar();
            LlenarGrid();
            HabilitarBotones(false, true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string ID = DetalleCompra2GridView1.CurrentRow.Cells[0].Value.ToString();
            IdProducto = Convert.ToInt32(ID);
            EProducto.idProducto = IdProducto;
            EProducto.nombreProducto = txtnombre.Text;
            EProducto.codigopro = txtcodigo.Text;
            EProducto.FK_idMarca = IdMarca;
            EProducto.precioSalida = Convert.ToDecimal(txtpreciosalida.Text);
            EProducto.costo = 0;
            EProducto.stockProducto = 0;
            EProducto.FK_idModelo = IdModelo;
            EProducto.FK_idCategoria = IdCategoria;
            EProducto.FK_idEstado = IdEstado;
            EProducto.descripcion = txtdescripcion.Text;
            EProducto.observacion = txtobservacion.Text;
            BProducto.UpdateProducto(EProducto);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;
            EProducto.idProducto = IdProducto;
            BProducto.EliminarProduto(EProducto);
            HabilitarBotones(false, true);
            Limpiar();
            LlenarGrid();
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMarca.SelectedValue != null)
                {
                    IdMarca = (int)cmbMarca.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbModelo.SelectedValue != null)
                {
                    IdModelo = (int)cmbModelo.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtpreciosalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            WINCategoria WCat = new WINCategoria();
            WCat.ShowDialog();
            LlenarCategoria();
            
        }

        private void btnModelo_Click(object sender, EventArgs e)
        {
            WINModelo WMod = new WINModelo();
            WMod.ShowDialog();
            LlenarModelo();
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            WINMarca WMar = new WINMarca();
            WMar.ShowDialog();
            LlenarMarca();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            WINEstado we = new WINEstado();
            we.ShowDialog();
            LlenarModelo();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = txtfiltrar.Text;
            EProducto.codigopro = filtro;
            //  ProductodataGridView.Columns.Clear();
            DetalleCompra2GridView1.DataSource = BProducto.BuscarProducto(EProducto);
        }

        private void txtfiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            string filtro;
            filtro = txtfiltrar.Text;
            EProducto.codigopro = filtro;
            //  ProductodataGridView.Columns.Clear();
            DetalleCompra2GridView1.DataSource = BProducto.BuscarProducto(EProducto);
        }

        private void DetalleCompra2GridView1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            EProducto.nombreProducto = txtnombre.Text;
            EProducto.codigopro = txtcodigo.Text;
            EProducto.FK_idMarca = IdMarca;
            EProducto.precioSalida = Convert.ToDecimal(txtpreciosalida.Text);
            EProducto.costo = 0;
            EProducto.stockProducto = 0;
            EProducto.FK_idModelo = IdModelo;
            EProducto.FK_idCategoria = IdCategoria;
            EProducto.FK_idEstado = IdEstado;
            EProducto.descripcion = txtdescripcion.Text;
            EProducto.observacion = txtobservacion.Text;
            BProducto.InsertarProducto(EProducto);
            Limpiar();
            LlenarGrid();
            HabilitarBotones(false, true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string ID = DetalleCompra2GridView1.CurrentRow.Cells[0].Value.ToString();
            IdProducto = Convert.ToInt32(ID);
            EProducto.idProducto = IdProducto;
            EProducto.nombreProducto = txtnombre.Text;
            EProducto.codigopro = txtcodigo.Text;
            EProducto.FK_idMarca = IdMarca;
            EProducto.precioSalida = Convert.ToDecimal(txtpreciosalida.Text);
            EProducto.costo = 0;
            EProducto.stockProducto = 0;
            EProducto.FK_idModelo = IdModelo;
            EProducto.FK_idCategoria = IdCategoria;
            EProducto.FK_idEstado = IdEstado;
            EProducto.descripcion = txtdescripcion.Text;
            EProducto.observacion = txtobservacion.Text;
            BProducto.UpdateProducto(EProducto);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = string.Empty;
            txtpreciosalida.Text = string.Empty;
            txtdescripcion.Text = string.Empty;
            txtobservacion.Text = string.Empty;
            txtcodigo.Text = string.Empty;
            cmbMarca.SelectedIndex = -1;
            cmbMarca.Text = string.Empty;
            cmbModelo.SelectedIndex = -1;
            cmbModelo.Text = string.Empty;
            cmbCategoria.SelectedIndex = -1;
            cmbCategoria.Text = string.Empty;
            cmbEstado.SelectedIndex = -1;
            cmbEstado.Text = string.Empty;
            txtfiltrar.Text = string.Empty;
            LlenarGrid();
            txtnombre.Focus();
            errorProvider1.Clear();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void WINDetalleCompra2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstado_CursorChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedValue != null)
                {
                    IdCategoria = (int)cmbCategoria.SelectedValue;
                    txtcodigo.Text = BCategoria.ObtenercodCat(IdCategoria) + "-";
                }
            }
            catch (Exception)
            {
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstado.SelectedValue != null)
                {
                    IdEstado = (int)cmbEstado.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void DetalleCompra2GridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalleCompra2GridView1.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            IdProducto = (int)DetalleCompra2GridView1.CurrentRow.Cells[0].Value;

            txtnombre.Text = DetalleCompra2GridView1.CurrentRow.Cells[2].Value.ToString();
            txtdescripcion.Text = DetalleCompra2GridView1.CurrentRow.Cells[3].Value.ToString();
            //4 fecha
            txtpreciosalida.Text = DetalleCompra2GridView1.CurrentRow.Cells[5].Value.ToString();
            txtobservacion.Text = DetalleCompra2GridView1.CurrentRow.Cells[6].Value.ToString();
            cmbMarca.Text = DetalleCompra2GridView1.CurrentRow.Cells[7].Value.ToString();
            cmbModelo.Text = DetalleCompra2GridView1.CurrentRow.Cells[8].Value.ToString();
            cmbEstado.Text = DetalleCompra2GridView1.CurrentRow.Cells[9].Value.ToString();
            cmbCategoria.Text = DetalleCompra2GridView1.CurrentRow.Cells[10].Value.ToString(); 
            txtcodigo.Text = DetalleCompra2GridView1.CurrentRow.Cells[1].Value.ToString();

        }

        private void DetalleCompra2GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalleCompra2GridView1.CurrentRow == null) return;

                IdProducto = (int)DetalleCompra2GridView1.CurrentRow.Cells[0].Value;
            codigo = DetalleCompra2GridView1.CurrentRow.Cells[1].Value.ToString();
            nombrep = DetalleCompra2GridView1.CurrentRow.Cells[2].Value.ToString();
            descripciom = DetalleCompra2GridView1.CurrentRow.Cells[3].Value.ToString();
            marca = DetalleCompra2GridView1.CurrentRow.Cells[7].Value.ToString();
            modelo = DetalleCompra2GridView1.CurrentRow.Cells[8].Value.ToString();
            estado = DetalleCompra2GridView1.CurrentRow.Cells[9].Value.ToString();

            WINDCompracs dv = Owner as WINDCompracs;
            dv.bmbproducto.Text = codigo + " " + nombrep + " " + marca + " " + descripciom + " " + modelo + " - " + estado;
            this.Close();
              
        }
    }
}