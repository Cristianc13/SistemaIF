using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIN.Recursos
{
    internal class DatagridviewDiseño
    {
        public static void DiseñoDGV(ref DataGridView List)
        {
            //Mi maldito Codigo

            //Ajustar Tamaño de columnas
            List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Alinear fuente al centro
            List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            //Desactivar estilos de datagridview por defecto
            List.EnableHeadersVisualStyles = false;

            //Estilo de Columna
            List.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(21, 30, 41);
            List.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 11);
            List.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            List.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(20, 39, 67);
            List.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            //Estilo Celda Alterna
            List.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            List.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.Teal;

            //Estilo Celda Default
            List.DefaultCellStyle.BackColor = Color.White;
            List.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            List.DefaultCellStyle.ForeColor = Color.Black;
            List.DefaultCellStyle.SelectionBackColor = Color.Teal;
            List.DefaultCellStyle.SelectionForeColor = Color.White;

            //Modo de Seleccion
            List.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            List.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //Diseño
            List.BackgroundColor = Color.White;
            List.BorderStyle = BorderStyle.Fixed3D;
            List.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;

            //Tamaño
            List.AllowUserToResizeRows = false;
        }
    }
}