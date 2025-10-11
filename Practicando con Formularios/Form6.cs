using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicando_con_Formularios
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) label1.Text = "Seleccionaste: " + radioButton1.Text;
            else if (radioButton2.Checked) label1.Text = "Seleccionaste: " + radioButton2.Text;
            else if (radioButton3.Checked) label1.Text = "Seleccionaste: " + radioButton3.Text;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
