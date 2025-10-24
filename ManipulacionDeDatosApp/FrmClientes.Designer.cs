namespace ManipulacionDeDatosApp
{
    partial class FrmClientes
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
            dgClientes = new DataGridView();
            txtNombre = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            Correo = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtId = new TextBox();
            btnEliminar = new Button();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            txtId2 = new TextBox();
            txtNombre2 = new TextBox();
            btnActualizar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtDireccion2 = new TextBox();
            label8 = new Label();
            txtCorreo2 = new TextBox();
            txtTelefono2 = new TextBox();
            btnCargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgClientes).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgClientes
            // 
            dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClientes.Location = new Point(11, 295);
            dgClientes.Name = "dgClientes";
            dgClientes.Size = new Size(922, 198);
            dgClientes.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre ";
            label1.Click += label1_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(6, 78);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(130, 23);
            txtCorreo.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(6, 122);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(130, 23);
            txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(6, 166);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(130, 23);
            txtDireccion.TabIndex = 5;
            // 
            // Correo
            // 
            Correo.AutoSize = true;
            Correo.Location = new Point(6, 60);
            Correo.Name = "Correo";
            Correo.Size = new Size(43, 15);
            Correo.TabIndex = 6;
            Correo.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 104);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 7;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 148);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Direccion";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(192, 136);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(97, 38);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Agregar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Correo);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 192);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insertar";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(364, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 147);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Eliminar";
            // 
            // txtId
            // 
            txtId.Location = new Point(6, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(130, 23);
            txtId.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(110, 91);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 38);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 21);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtId2);
            groupBox3.Controls.Add(txtNombre2);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtDireccion2);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtCorreo2);
            groupBox3.Controls.Add(txtTelefono2);
            groupBox3.Location = new Point(606, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(319, 192);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actualizar";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(169, 16);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 11;
            label9.Text = "ID";
            // 
            // txtId2
            // 
            txtId2.Location = new Point(169, 34);
            txtId2.Name = "txtId2";
            txtId2.Size = new Size(130, 23);
            txtId2.TabIndex = 10;
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(6, 34);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(130, 23);
            txtNombre2.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(192, 136);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 38);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 16);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 2;
            label5.Text = "Nombre ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 148);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 8;
            label6.Text = "Direccion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 6;
            label7.Text = "Correo";
            // 
            // txtDireccion2
            // 
            txtDireccion2.Location = new Point(6, 166);
            txtDireccion2.Name = "txtDireccion2";
            txtDireccion2.Size = new Size(130, 23);
            txtDireccion2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 104);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 7;
            label8.Text = "Telefono";
            // 
            // txtCorreo2
            // 
            txtCorreo2.Location = new Point(6, 78);
            txtCorreo2.Name = "txtCorreo2";
            txtCorreo2.Size = new Size(130, 23);
            txtCorreo2.TabIndex = 3;
            // 
            // txtTelefono2
            // 
            txtTelefono2.Location = new Point(6, 122);
            txtTelefono2.Name = "txtTelefono2";
            txtTelefono2.Size = new Size(130, 23);
            txtTelefono2.TabIndex = 4;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(12, 251);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(921, 38);
            btnCargar.TabIndex = 13;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 498);
            Controls.Add(btnCargar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgClientes);
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgClientes;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label Correo;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtId;
        private Button btnEliminar;
        private Label label2;
        private GroupBox groupBox3;
        private TextBox txtNombre2;
        private Button btnActualizar;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtDireccion2;
        private Label label8;
        private TextBox txtCorreo2;
        private TextBox txtTelefono2;
        private Label label9;
        private TextBox txtId2;
        private Button btnCargar;
    }
}