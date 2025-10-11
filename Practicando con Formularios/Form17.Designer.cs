namespace Practicando_con_Formularios
{
    partial class Form17
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Form

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Botones numéricos
            // 
            int ancho = 60, alto = 50, margenX = 12, margenY = 70, espaciado = 65;

            // Fila 1: 7, 8, 9, /
            this.btn7.Location = new System.Drawing.Point(margenX, margenY);
            this.btn8.Location = new System.Drawing.Point(margenX + espaciado, margenY);
            this.btn9.Location = new System.Drawing.Point(margenX + espaciado * 2, margenY);
            this.btnDivide.Location = new System.Drawing.Point(margenX + espaciado * 3, margenY);

            // Fila 2: 4, 5, 6, *
            this.btn4.Location = new System.Drawing.Point(margenX, margenY + espaciado);
            this.btn5.Location = new System.Drawing.Point(margenX + espaciado, margenY + espaciado);
            this.btn6.Location = new System.Drawing.Point(margenX + espaciado * 2, margenY + espaciado);
            this.btnMultiplica.Location = new System.Drawing.Point(margenX + espaciado * 3, margenY + espaciado);

            // Fila 3: 1, 2, 3, -
            this.btn1.Location = new System.Drawing.Point(margenX, margenY + espaciado * 2);
            this.btn2.Location = new System.Drawing.Point(margenX + espaciado, margenY + espaciado * 2);
            this.btn3.Location = new System.Drawing.Point(margenX + espaciado * 2, margenY + espaciado * 2);
            this.btnResta.Location = new System.Drawing.Point(margenX + espaciado * 3, margenY + espaciado * 2);

            // Fila 4: 0, ., C, +
            this.btn0.Location = new System.Drawing.Point(margenX, margenY + espaciado * 3);
            this.btnPunto.Location = new System.Drawing.Point(margenX + espaciado, margenY + espaciado * 3);
            this.btnLimpiar.Location = new System.Drawing.Point(margenX + espaciado * 2, margenY + espaciado * 3);
            this.btnSuma.Location = new System.Drawing.Point(margenX + espaciado * 3, margenY + espaciado * 3);

            // Botón igual (=)
            this.btnIgual.Location = new System.Drawing.Point(margenX, margenY + espaciado * 4);
            this.btnIgual.Size = new System.Drawing.Size(258, 50);

            // 
            // Propiedades comunes
            // 
            Button[] botones = {
                btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,
                btnSuma, btnResta, btnMultiplica, btnDivide, btnIgual, btnLimpiar, btnPunto
            };

            foreach (Button b in botones)
            {
                b.Size = new System.Drawing.Size(ancho, alto);
                b.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                this.Controls.Add(b);
            }

            // 
            // Textos de los botones
            // 
            btn0.Text = "0"; btn1.Text = "1"; btn2.Text = "2"; btn3.Text = "3"; btn4.Text = "4";
            btn5.Text = "5"; btn6.Text = "6"; btn7.Text = "7"; btn8.Text = "8"; btn9.Text = "9";
            btnSuma.Text = "+"; btnResta.Text = "-"; btnMultiplica.Text = "*"; btnDivide.Text = "/";
            btnIgual.Text = "="; btnLimpiar.Text = "C"; btnPunto.Text = ".";

            // 
            // Asignar eventos
            // 
            btn0.Click += btnNumero_Click;
            btn1.Click += btnNumero_Click;
            btn2.Click += btnNumero_Click;
            btn3.Click += btnNumero_Click;
            btn4.Click += btnNumero_Click;
            btn5.Click += btnNumero_Click;
            btn6.Click += btnNumero_Click;
            btn7.Click += btnNumero_Click;
            btn8.Click += btnNumero_Click;
            btn9.Click += btnNumero_Click;

            btnSuma.Click += btnOperacion_Click;
            btnResta.Click += btnOperacion_Click;
            btnMultiplica.Click += btnOperacion_Click;
            btnDivide.Click += btnOperacion_Click;

            btnIgual.Click += btnIgual_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnPunto.Click += btnPunto_Click;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 400);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora - Diego Ogando Montero";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplica;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPunto;
    }
}
