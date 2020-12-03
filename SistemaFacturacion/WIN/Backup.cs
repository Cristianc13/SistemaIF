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
using CAD;

namespace WIN
{
    public partial class Backup : Form
    {
        private CADBackup CB = new CADBackup();

        public Backup()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var archivoBackup = new SaveFileDialog();
                string x = DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + "_" + "TiendaInventario";
                archivoBackup.Title = "Guardar Como";
                archivoBackup.FileName = x;
                archivoBackup.Filter = "SQL Backup (*.bak)| *.bak";

                if (archivoBackup.ShowDialog() == DialogResult.OK)
                {
                    txtruta.Text = archivoBackup.FileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            CB.BackupBD(txtruta.Text);

            MessageBox.Show("Bakcup realizado satisfactoriamente");
        }

        //Mover formulario

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}