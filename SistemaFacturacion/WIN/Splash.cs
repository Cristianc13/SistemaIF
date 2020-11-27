using System;
using System.Windows.Forms;

namespace WIN
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 7;
            if (panel2.Width >= 682)
            {
                timer1.Stop();
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }
    }
}