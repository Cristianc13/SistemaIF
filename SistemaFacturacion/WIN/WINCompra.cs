using System;
using System.Drawing;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINCompra : Form
    {
        public WINCompra()
        {
            InitializeComponent();
        }

        private int idCompra;
        private int idProveedor = 0;
        private ENTProveedor Eproveedor = new ENTProveedor();
        private BLProveedor Bproveedor = new BLProveedor();

        private ENTCompra Ecompra = new ENTCompra();
        private BLCompra Bcompra = new BLCompra();

        private void LlenaComboProveedor()
        {
            ProveedorcomboBox.DataSource = Bproveedor.MostrarProveedor();
            ProveedorcomboBox.DisplayMember = "nombreProv";
            ProveedorcomboBox.ValueMember = "idProveedor";
            ProveedorcomboBox.SelectedIndex = -1;
        }

        public void Limpiar()
        {
            txtNFactura.Text = string.Empty;
            txtdescrip.Text = string.Empty;
            ProveedorcomboBox.Text = string.Empty;
            txtIVA.Text = string.Empty;

            txtNFactura.Focus();
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p2;
            Actualizarbutton.Enabled = p1;
            Eliminarbutton.Enabled = p1;

            //Cancelarbutton.Enabled = p1;
        }

        public void LlenarGrid()
        {
            CompraGridView1.DataSource = Bcompra.MostrarCompra();
            txtNFactura.Focus();
        }

        private void CompraGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CompraGridView1.Rows.Count == 0) return;
            HabilitarBotones(true, false);
            idCompra = (int)CompraGridView1.CurrentRow.Cells[0].Value;

            txtNFactura.Text = CompraGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdescrip.Text = CompraGridView1.CurrentRow.Cells[3].Value.ToString();
            txtIVA.Text = CompraGridView1.CurrentRow.Cells[4].Value.ToString();
            ProveedorcomboBox.Text = CompraGridView1.CurrentRow.Cells[5].Value.ToString();

            HabilitarBotones(true, false);
        }

        public void validaciones()
        {
        }

        private void WINCompra_Load(object sender, EventArgs e)
        {
            HabilitarBotones(false, true);
            LlenarGrid();
            FormatoGrid();
            Limpiar();
            LlenaComboProveedor();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (txtNFactura.Text == string.Empty)
            {
                errorProvider1.SetError(txtNFactura, "Debe ingresar un Nº de Factura");
                return;
            }
            errorProvider1.Clear();

            if (ProveedorcomboBox.Text == string.Empty)
            {
                errorProvider1.SetError(ProveedorcomboBox, "Debe ingresar un Proveedor");
                return;
            }
            errorProvider1.Clear();

            if (txtdescrip.Text == string.Empty)
            {
                errorProvider1.SetError(txtdescrip, "Debe ingresar una descripcion");
                return;
            }
            errorProvider1.Clear();

            if (txtIVA.Text == string.Empty)
            {
                errorProvider1.SetError(txtIVA, "Debe ingresar el IVA");
                return;
            }
            errorProvider1.Clear();

            Ecompra.numeroFactura = txtNFactura.Text;
            Ecompra.descripcion = txtdescrip.Text;
            Ecompra.IVA = decimal.Parse(txtIVA.Text);
            Ecompra.FK_idProveedor = idProveedor;
            // Bcompra.InsertCompra(Ecompra);
            Limpiar();
            LlenarGrid();
            HabilitarBotones(false, true);
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            if (txtNFactura.Text == string.Empty)
            {
                errorProvider1.SetError(txtNFactura, "Debe ingresar un Nº de Factura");
                return;
            }
            errorProvider1.Clear();

            if (ProveedorcomboBox.Text == string.Empty)
            {
                errorProvider1.SetError(ProveedorcomboBox, "Debe ingresar un Proveedor");
                return;
            }
            errorProvider1.Clear();

            if (txtdescrip.Text == string.Empty)
            {
                errorProvider1.SetError(txtdescrip, "Debe ingresar una descripcion");
                return;
            }
            errorProvider1.Clear();

            if (txtIVA.Text == string.Empty)
            {
                errorProvider1.SetError(txtIVA, "Debe ingresar el IVA");
                return;
            }
            errorProvider1.Clear();

            Ecompra.idCompra = idCompra;
            Ecompra.numeroFactura = txtNFactura.Text;
            Ecompra.descripcion = txtdescrip.Text;
            Ecompra.IVA = decimal.Parse(txtIVA.Text);
            Ecompra.FK_idProveedor = idProveedor;

            Bcompra.UpdateCompra(Ecompra);
            Limpiar();
            LlenarGrid();
            HabilitarBotones(false, true);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            DialogResult rpt = MessageBox.Show("Desea eliminar el registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;
            Ecompra.idCompra = idCompra;
            Bcompra.DeleteCompra(Ecompra);
            HabilitarBotones(false, true);
            Limpiar();
            LlenarGrid();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(false, true);
        }

        public void FormatoGrid()
        {
            CompraGridView1.Columns[0].Visible = false;//idCompra
            CompraGridView1.Columns[1].HeaderText = "N° Factura";
            CompraGridView1.Columns[2].HeaderText = "Fecha de Compra";
            CompraGridView1.Columns[3].HeaderText = "Descripcion";
            CompraGridView1.Columns[4].HeaderText = "IVA";
            CompraGridView1.Columns[5].HeaderText = "Proveedor";

            CompraGridView1.AllowUserToResizeColumns = false;
            CompraGridView1.AllowUserToResizeRows = false;
            CompraGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            CompraGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void ProveedorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ProveedorcomboBox.SelectedValue != null)
                {
                    idProveedor = (int)ProveedorcomboBox.SelectedValue;
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            WINProveedor cl = new WINProveedor();
            cl.ShowDialog();
            LlenaComboProveedor();
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ProveedorcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}