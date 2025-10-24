namespace ManipulacionDeDatosApp
{
    partial class FrmProductos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label6 = new Label();
            cbProveedor1 = new ComboBox();
            cbCategoria1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtPrecio1 = new TextBox();
            txtNombre1 = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtId3 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            cbProveedor2 = new ComboBox();
            cbCategoria2 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtPrecio2 = new TextBox();
            txtNombre2 = new TextBox();
            txtId2 = new TextBox();
            label9 = new Label();
            label5 = new Label();
            btnActualizar = new Button();
            dgProductos = new DataGridView();
            btnCargar = new Button();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbProveedor1);
            groupBox1.Controls.Add(cbCategoria1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPrecio1);
            groupBox1.Controls.Add(txtNombre1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 235);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 68);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 8;
            label6.Text = "Precios";
            // 
            // cbProveedor1
            // 
            cbProveedor1.FormattingEnabled = true;
            cbProveedor1.Location = new Point(15, 197);
            cbProveedor1.Name = "cbProveedor1";
            cbProveedor1.Size = new Size(150, 23);
            cbProveedor1.TabIndex = 7;
            // 
            // cbCategoria1
            // 
            cbCategoria1.FormattingEnabled = true;
            cbCategoria1.Location = new Point(15, 144);
            cbCategoria1.Name = "cbCategoria1";
            cbCategoria1.Size = new Size(150, 23);
            cbCategoria1.TabIndex = 6;
            cbCategoria1.SelectedIndexChanged += cbCategoria1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 170);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 123);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // txtPrecio1
            // 
            txtPrecio1.Location = new Point(15, 86);
            txtPrecio1.Name = "txtPrecio1";
            txtPrecio1.Size = new Size(100, 23);
            txtPrecio1.TabIndex = 2;
            // 
            // txtNombre1
            // 
            txtNombre1.Location = new Point(15, 39);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(150, 23);
            txtNombre1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(200, 150);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(txtId3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(341, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(203, 120);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(99, 68);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 38);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtId3
            // 
            txtId3.Location = new Point(16, 39);
            txtId3.Name = "txtId3";
            txtId3.Size = new Size(110, 23);
            txtId3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 21);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 3;
            label2.Text = "ID del producto a eliminar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(cbProveedor2);
            groupBox3.Controls.Add(cbCategoria2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtPrecio2);
            groupBox3.Controls.Add(txtNombre2);
            groupBox3.Controls.Add(txtId2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Location = new Point(550, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 256);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // cbProveedor2
            // 
            cbProveedor2.FormattingEnabled = true;
            cbProveedor2.Location = new Point(26, 170);
            cbProveedor2.Name = "cbProveedor2";
            cbProveedor2.Size = new Size(150, 23);
            cbProveedor2.TabIndex = 16;
            cbProveedor2.SelectedIndexChanged += cbProveedor2_SelectedIndexChanged;
            // 
            // cbCategoria2
            // 
            cbCategoria2.FormattingEnabled = true;
            cbCategoria2.Location = new Point(26, 123);
            cbCategoria2.Name = "cbCategoria2";
            cbCategoria2.Size = new Size(150, 23);
            cbCategoria2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 152);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 14;
            label8.Text = "Proveedor";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 105);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 13;
            label7.Text = "Categoría";
            // 
            // txtPrecio2
            // 
            txtPrecio2.Location = new Point(26, 79);
            txtPrecio2.Name = "txtPrecio2";
            txtPrecio2.Size = new Size(100, 23);
            txtPrecio2.TabIndex = 12;
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(26, 39);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(150, 23);
            txtNombre2.TabIndex = 11;
            txtNombre2.TextChanged += txtNombre2_TextChanged;
            // 
            // txtId2
            // 
            txtId2.Location = new Point(26, 212);
            txtId2.Name = "txtId2";
            txtId2.Size = new Size(100, 23);
            txtId2.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 197);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 9;
            label9.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 19);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(220, 170);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 38);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgProductos
            // 
            dgProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProductos.Location = new Point(-3, 303);
            dgProductos.Name = "dgProductos";
            dgProductos.Size = new Size(969, 298);
            dgProductos.TabIndex = 6;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(-3, 274);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(969, 23);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 65);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 17;
            label10.Text = "Precios";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 600);
            Controls.Add(btnCargar);
            Controls.Add(dgProductos);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmProductos";
            Text = "Productos";
            Load += FrmProductos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbProveedor1;
        private ComboBox cbCategoria1;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox txtPrecio1;
        private TextBox txtNombre1;
        private Button button2;
        private GroupBox groupBox2;
        private Button btnEliminar;
        private TextBox txtId3;
        private Label label2;
        private GroupBox groupBox3;
        private ComboBox cbProveedor2;
        private ComboBox cbCategoria2;
        private Label label8;
        private Label label7;
        private TextBox txtPrecio2;
        private TextBox txtNombre2;
        private TextBox txtId2;
        private Label label9;
        private Label label5;
        private Button btnActualizar;
        private DataGridView dgProductos;
        private Button btnCargar;
        private Label label6;
        private Label label10;
    }
}
