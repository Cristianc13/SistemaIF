using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BL;
using ENT;

namespace WIN
{
    public partial class WINAdministrador : Form
    {
        public ENTAdministrador EAdmin = new ENTAdministrador();
        public BLAdministrador BAdmin = new BLAdministrador();

        public WINAdministrador()
        {
            InitializeComponent();
        }

        private void WINAdministrador_Load(object sender, EventArgs e)
        {
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnojo_Click(object sender, EventArgs e)
        {
            if (ClavetextBox.PasswordChar == '*')
            {
                ClavetextBox.PasswordChar = '\0'; ;
                btnojo.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                ClavetextBox.PasswordChar = '*';
                btnojo.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            ClavetextBox.Focus();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            EAdmin.usuario = UsuariotextBox.Text;

            EAdmin.clave = ClavetextBox.Text;
            int resultado = BAdmin.Login(EAdmin);
            if (resultado == 1)
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else if (resultado == 0)
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }
        }
    }
}