using System;
using System.Windows.Forms;


namespace ManipulacionDeDatosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FrmCategorias().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FrmProveedores().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new FrmProductos().ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
