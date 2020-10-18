﻿using System;
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
    public partial class WINCategoria : Form
    {

        BLCategoria BCat = new BLCategoria();
        ENTCategoria ECat = new ENTCategoria();
        public int id;

        public WINCategoria()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            CategoriatextBox.Text = "";
            DescripciontextBox.Text = "";
            CategoriatextBox.Focus();
        }

        private void HabilitarBotones(bool p1, bool p2)
        {
            Guardarbutton.Enabled = p1;
            Actualizarbutton.Enabled = p2;
            Eliminarbutton.Enabled = p2;
            //Cancelarbutton.Enabled = p1;
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
            BCat.InsertCategoria(ECat);
        }

        public void FormatoGrid()
        {
            CategoriadataGridView.Columns[0].Visible = false;//idProducto
            CategoriadataGridView.Columns[1].HeaderText = "Modelo";
            CategoriadataGridView.Columns[2].HeaderText = "Descripcion";
            CategoriadataGridView.AllowUserToResizeColumns = false;
            CategoriadataGridView.AllowUserToResizeRows = false;
            CategoriadataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            CategoriadataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
        }

        private void CategoriadataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (CategoriadataGridView.Rows.Count == 0) return;
            HabilitarBotones(false, true);
            id = (int)CategoriadataGridView.CurrentRow.Cells[0].Value;
            //MessageBox.Show(vIDEquipo.ToString());
            CategoriatextBox.Text = CategoriadataGridView.CurrentRow.Cells[1].Value.ToString();
            DescripciontextBox.Text = CategoriadataGridView.CurrentRow.Cells[2].Value.ToString();
            errorProvider1.Clear();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            FormatoGrid();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (CategoriatextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CategoriatextBox, "Debe ingresar una categoria");
                return;
            }

            if (DescripciontextBox.Text == string.Empty)
            {
                errorProvider1.SetError(DescripciontextBox, "Debe ingresar una descripcion");
                return;
            }

            errorProvider1.Clear();

            Guardar();
            LlenarGrid();
            Limpiar();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false);
            Limpiar();
        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            ECat.idCategoria = id;
            ECat.nombreCategoria = CategoriatextBox.Text;
            ECat.descripcion = DescripciontextBox.Text;
            BCat.UpdateCategoria(ECat);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            string valor = CategoriadataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult rpt = MessageBox.Show("Eliminar Modelo " + valor, "Modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (rpt == DialogResult.No) return;

            //VERIFICAR SI NO HAY INFORMACIÓN EN EL Ubicacion A BORRAR ************************
            ECat.idCategoria = id;
            ECat.nombreCategoria = CategoriatextBox.Text;
            ECat.descripcion = DescripciontextBox.Text;
            BCat.DeleteCategoria(ECat);
            LlenarGrid();
            Limpiar();
            HabilitarBotones(true, false);
        }
    }
}