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
    public partial class WINProveedor : Form
    {
        public ENTProveedor EProveedor = new ENTProveedor();
        public BLProveedor BProveedor = new BLProveedor();

        public WINProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EProveedor.nombreProv=textBox1.Text;
            EProveedor.telefonoProv=textBox2.Text;
            BProveedor.InsertProveedor(EProveedor);
        }

        private void WINProveedor_Load(object sender, EventArgs e)
        {
        }
    }
}