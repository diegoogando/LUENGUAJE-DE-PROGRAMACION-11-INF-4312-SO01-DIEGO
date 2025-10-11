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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "rojo": this.BackColor = Color.Red; break;
                case "verde": this.BackColor = Color.Green; break;
                case "azul": this.BackColor = Color.Blue; break;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
