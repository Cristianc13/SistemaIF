using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT;
using BL;

namespace WIN
{
    public partial class WINDetalleCompra2 : Form
    {
        public WINDetalleCompra2()
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
            DetalleCompra2GridView1.Columns[9].HeaderText = "Categoria";
            DetalleCompra2GridView1.Columns[10].HeaderText = "Estado";
           DetalleCompra2GridView1.AllowUserToResizeColumns = false;
            DetalleCompra2GridView1.AllowUserToResizeRows = false;
            DetalleCompra2GridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            DetalleCompra2GridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            btnAgregar.Enabled = p2;
            btnActualizar.Enabled = p1;
            btnEliminar.Enabled = p1;
            // Cancelarbutton.Enabled = p1;
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

        private void WINDetalleCompra2_Load(object sender, EventArgs e)
        {
            //HabilitarBotones(false, true);
            LlenarEstado();
            LlenarGrid();
            FormatoGrid();
            LlenarMarca();
            LlenarCategoria();
            LlenarModelo();
            Limpiar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                EProducto.nombreProducto = txtnombre.Text;
                EProducto.codigopro = txtcodigo.Text;
                EProducto.FK_idMarca = IdMarca;
                EProducto.precioSalida = int.Parse(txtpreciosalida.Text);
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategoria.SelectedValue != null)
                {
                    IdCategoria = (int)cmbCategoria.SelectedValue;
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
        }

        private void DetalleCompra2GridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DetalleCompra2GridView1.Rows.Count == 0) return;
            //HabilitarBotones(true, false);
            IdProducto = (int)DetalleCompra2GridView1.CurrentRow.Cells[0].Value;

            txtnombre.Text = DetalleCompra2GridView1.CurrentRow.Cells[2].Value.ToString();
            txtdescripcion.Text = DetalleCompra2GridView1.CurrentRow.Cells[3].Value.ToString();

            txtpreciosalida.Text = DetalleCompra2GridView1.CurrentRow.Cells[4].Value.ToString();

            txtobservacion.Text = DetalleCompra2GridView1.CurrentRow.Cells[5].Value.ToString();
            cmbMarca.Text = DetalleCompra2GridView1.CurrentRow.Cells[6].Value.ToString();
            cmbModelo.Text = DetalleCompra2GridView1.CurrentRow.Cells[7].Value.ToString();
            cmbCategoria.Text = DetalleCompra2GridView1.CurrentRow.Cells[8].Value.ToString();
            txtcodigo.Text = DetalleCompra2GridView1.CurrentRow.Cells[1].Value.ToString();
            cmbEstado.Text = DetalleCompra2GridView1.CurrentRow.Cells[9].Value.ToString();

            //HabilitarBotones(true, false);
        }
    }
}