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
    public partial class Form17 : Form
    {
        double valor1 = 0, valor2 = 0, resultado = 0;
        string operacion = "";
        bool operacionEnCurso = false;
        public Form17()
        {
            InitializeComponent();
        }
        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (textBox1.Text == "0" || operacionEnCurso)
            {
                textBox1.Clear();
                operacionEnCurso = false;
            }

            textBox1.Text += boton.Text;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            valor1 = Convert.ToDouble(textBox1.Text);
            operacion = boton.Text;
            operacionEnCurso = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(textBox1.Text);

            switch (operacion)
            {
                case "+": resultado = valor1 + valor2; break;
                case "-": resultado = valor1 - valor2; break;
                case "*": resultado = valor1 * valor2; break;
                case "/":
                    if (valor2 != 0)
                        resultado = valor1 / valor2;
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                        return;
                    }
                    break;
            }

            textBox1.Text = resultado.ToString();
            valor1 = resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            valor1 = valor2 = resultado = 0;
            operacion = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text += ".";
        }
    }
}


