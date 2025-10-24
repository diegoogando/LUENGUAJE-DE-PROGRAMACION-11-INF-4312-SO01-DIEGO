namespace ManipulacionDeDatosApp
{
    partial class FrmCategorias
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
            label1 = new Label();
            txtNombre1 = new TextBox();
            button2 = new Button();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtId3 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtNombre2 = new TextBox();
            txtId2 = new TextBox();
            label9 = new Label();
            label5 = new Label();
            btnActualizar = new Button();
            dgCategorias = new DataGridView();
            btnCargar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre1);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 141);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre  de la categorias ";
            // 
            // txtNombre1
            // 
            txtNombre1.Location = new Point(15, 39);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(142, 23);
            txtNombre1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(132, 97);
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
            groupBox2.Location = new Point(257, 21);
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
            label2.Size = new Size(153, 15);
            label2.TabIndex = 3;
            label2.Text = "ID de la categoria a eliminar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNombre2);
            groupBox3.Controls.Add(txtId2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Location = new Point(530, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 160);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(26, 68);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(130, 23);
            txtNombre2.TabIndex = 14;
            // 
            // txtId2
            // 
            txtId2.Location = new Point(26, 121);
            txtId2.Name = "txtId2";
            txtId2.Size = new Size(130, 23);
            txtId2.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 103);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 12;
            label9.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 39);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Nombre ";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(196, 103);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 38);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgCategorias
            // 
            dgCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategorias.Location = new Point(-3, 303);
            dgCategorias.Name = "dgCategorias";
            dgCategorias.Size = new Size(969, 298);
            dgCategorias.TabIndex = 6;
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
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 600);
            Controls.Add(btnCargar);
            Controls.Add(dgCategorias);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmCategorias";
            Text = "Form2";
            Load += FrmCategorias_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgCategorias;
        private Button btnCargar;
        private TextBox txtNombre1;
        private Button button2;
        private Label label1;
        private TextBox txtId3;
        private Label label2;
        private Button btnEliminar;
        private Button btnActualizar;
        private Label label5;
        private Label label9;
        private TextBox txtId2;
        private TextBox txtNombre2;
    }
}