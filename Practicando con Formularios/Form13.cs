﻿using System;
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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius = Convert.ToDouble(textBox1.Text);
            double fahrenheit = (celsius * 9 / 5) + 32;
            label1.Text = $"{celsius}°C = {fahrenheit}°F";
        }
    }
}
