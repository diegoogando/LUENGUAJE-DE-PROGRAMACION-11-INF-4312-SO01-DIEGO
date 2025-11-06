using System.Windows.Forms;
using System.Drawing;

namespace ManipulacionDeDatosApp
{
    partial class FrmProveedores
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
            txtCorreo1 = new TextBox();
            txtTelefono1 = new TextBox();
            txtDireccion1 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            groupBox2 = new GroupBox();
            btnEliminar = new Button();
            txtId3 = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtNombre2 = new TextBox();
            txtCorreo2 = new TextBox();
            txtTelefono2 = new TextBox();
            txtDireccion2 = new TextBox();
            txtId2 = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            btnActualizar = new Button();
            dgProveedores = new DataGridView();
            btnCargar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProveedores).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNombre1);
            groupBox1.Controls.Add(txtCorreo1);
            groupBox1.Controls.Add(txtTelefono1);
            groupBox1.Controls.Add(txtDireccion1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 256);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre del proveedor";
            // 
            // txtNombre1
            // 
            txtNombre1.Location = new Point(15, 39);
            txtNombre1.Name = "txtNombre1";
            txtNombre1.Size = new Size(142, 23);
            txtNombre1.TabIndex = 1;
            // 
            // txtCorreo1
            // 
            txtCorreo1.Location = new Point(15, 93);
            txtCorreo1.Name = "txtCorreo1";
            txtCorreo1.Size = new Size(142, 23);
            txtCorreo1.TabIndex = 2;
            // 
            // txtTelefono1
            // 
            txtTelefono1.Location = new Point(15, 137);
            txtTelefono1.Name = "txtTelefono1";
            txtTelefono1.Size = new Size(142, 23);
            txtTelefono1.TabIndex = 3;
            // 
            // txtDireccion1
            // 
            txtDireccion1.Location = new Point(15, 181);
            txtDireccion1.Name = "txtDireccion1";
            txtDireccion1.Size = new Size(142, 23);
            txtDireccion1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 75);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Correo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 119);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 6;
            label7.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 163);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 7;
            label8.Text = "Dirección";
            // 
            // button2
            // 
            button2.Location = new Point(145, 214);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGuardar_Click;
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
            label2.Size = new Size(149, 15);
            label2.TabIndex = 3;
            label2.Text = "ID del proveedor a eliminar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtNombre2);
            groupBox3.Controls.Add(txtCorreo2);
            groupBox3.Controls.Add(txtTelefono2);
            groupBox3.Controls.Add(txtDireccion2);
            groupBox3.Controls.Add(txtId2);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Location = new Point(530, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 256);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(26, 39);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(130, 23);
            txtNombre2.TabIndex = 14;
            // 
            // txtCorreo2
            // 
            txtCorreo2.Location = new Point(26, 83);
            txtCorreo2.Name = "txtCorreo2";
            txtCorreo2.Size = new Size(130, 23);
            txtCorreo2.TabIndex = 15;
            // 
            // txtTelefono2
            // 
            txtTelefono2.Location = new Point(26, 127);
            txtTelefono2.Name = "txtTelefono2";
            txtTelefono2.Size = new Size(130, 23);
            txtTelefono2.TabIndex = 16;
            // 
            // txtDireccion2
            // 
            txtDireccion2.Location = new Point(24, 215);
            txtDireccion2.Name = "txtDireccion2";
            txtDireccion2.Size = new Size(130, 23);
            txtDireccion2.TabIndex = 17;
            // 
            // txtId2
            // 
            txtId2.Location = new Point(24, 175);
            txtId2.Name = "txtId2";
            txtId2.Size = new Size(130, 23);
            txtId2.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 157);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 12;
            label9.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 21);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Nombre ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 65);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 18;
            label10.Text = "Correo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 109);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 19;
            label11.Text = "Teléfono";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 197);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 20;
            label12.Text = "Dirección";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(198, 206);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 38);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgProveedores
            // 
            dgProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProveedores.Location = new Point(-3, 303);
            dgProveedores.Name = "dgProveedores";
            dgProveedores.Size = new Size(969, 298);
            dgProveedores.TabIndex = 6;
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
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 600);
            Controls.Add(btnCargar);
            Controls.Add(dgProveedores);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmProveedores";
            Text = "Proveedores";
            Load += FrmProveedores_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgProveedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgProveedores;
        private Button btnCargar;
        private TextBox txtNombre1;
        private TextBox txtCorreo1;
        private TextBox txtTelefono1;
        private TextBox txtDireccion1;
        private Label label6;
        private Label label7;
        private Label label8;
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
        private TextBox txtCorreo2;
        private TextBox txtTelefono2;
        private TextBox txtDireccion2;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
