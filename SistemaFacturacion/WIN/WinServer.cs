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

namespace WIN
{
    public partial class WinServer : Form
    {
        public WinServer()
        {
            InitializeComponent();
        }

        private void WinServer_Load(object sender, EventArgs e)
        {
            ServerTextBox.Focus();
        }

        private void btnojo_Click(object sender, EventArgs e)
        {
            if (PasstextBox.PasswordChar == '*')
            {
                PasstextBox.PasswordChar = '\0'; ;
                btnojo.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                PasstextBox.PasswordChar = '*';
                btnojo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            PasstextBox.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (ServerTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ServerTextBox, "Debe ingresar su Servidor");
                return;
            }
            errorProvider1.Clear();

            if (BDtextBox.Text == string.Empty)
            {
                errorProvider1.SetError(BDtextBox, "Debe ingresar su Base de Datos");
                return;
            }
            errorProvider1.Clear();

            if (UsertextBox.Text == string.Empty)
            {
                errorProvider1.SetError(UsertextBox, "Debe ingresar su Usuario de Conexion");
                return;
            }
            errorProvider1.Clear();

            if (PasstextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PasstextBox, "Debe ingresar su Contraseña de Conexion");
                return;
            }
            errorProvider1.Clear();

            if (ServerTextBox.Text != "EquipoServidor" || BDtextBox.Text != "TiendaInventario" || UsertextBox.Text != "TEST" || PasstextBox.Text != "Admin")
            {
                MessageBox.Show("Revisa tus datos de ingreso");
            }

            else
            {
                MessageBox.Show("Datos Actualizados");
                this.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            ServerTextBox.Text = "";
            BDtextBox.Text = "";
            UsertextBox.Text = "";
            PasstextBox.Text = "";
            ServerTextBox.Focus();
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
    }
}
