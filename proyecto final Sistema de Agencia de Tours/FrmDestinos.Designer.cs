namespace proyecto_final_Sistema_de_Agencia_de_Tours
{
    partial class FrmDestinos
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblDuracionDias = new System.Windows.Forms.Label();
            this.nudDuracionDias = new System.Windows.Forms.NumericUpDown();
            this.lblDuracionHoras = new System.Windows.Forms.Label();
            this.nudDuracionHoras = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dgvDestinos = new System.Windows.Forms.DataGridView();
            this.lblDestinoId = new System.Windows.Forms.Label();
            this.txtDestinoId = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracionDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracionHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinos)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.Location = new System.Drawing.Point(15, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.Location = new System.Drawing.Point(90, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPais.Location = new System.Drawing.Point(15, 130);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(31, 15);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "País:";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(90, 127);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(250, 23);
            this.cmbPais.TabIndex = 3;
            // 
            // lblDuracionDias
            // 
            this.lblDuracionDias.AutoSize = true;
            this.lblDuracionDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDuracionDias.Location = new System.Drawing.Point(15, 160);
            this.lblDuracionDias.Name = "lblDuracionDias";
            this.lblDuracionDias.Size = new System.Drawing.Size(77, 15);
            this.lblDuracionDias.TabIndex = 4;
            this.lblDuracionDias.Text = "Duración (D):";
            // 
            // nudDuracionDias
            // 
            this.nudDuracionDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDuracionDias.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDuracionDias.Location = new System.Drawing.Point(90, 157);
            this.nudDuracionDias.Name = "nudDuracionDias";
            this.nudDuracionDias.Size = new System.Drawing.Size(70, 23);
            this.nudDuracionDias.TabIndex = 5;
            // 
            // lblDuracionHoras
            // 
            this.lblDuracionHoras.AutoSize = true;
            this.lblDuracionHoras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDuracionHoras.Location = new System.Drawing.Point(180, 160);
            this.lblDuracionHoras.Name = "lblDuracionHoras";
            this.lblDuracionHoras.Size = new System.Drawing.Size(78, 15);
            this.lblDuracionHoras.TabIndex = 6;
            this.lblDuracionHoras.Text = "Duración (H):";
            // 
            // nudDuracionHoras
            // 
            this.nudDuracionHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudDuracionHoras.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDuracionHoras.Location = new System.Drawing.Point(270, 157);
            this.nudDuracionHoras.Name = "nudDuracionHoras";
            this.nudDuracionHoras.Size = new System.Drawing.Size(70, 23);
            this.nudDuracionHoras.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(15, 195);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 32);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "✚ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(106, 195);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 32);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "✎ Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(241, 195);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 32);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "🗑️ Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(356, 195);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(120, 32);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "📊 Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dgvDestinos
            // 
            this.dgvDestinos.AllowUserToAddRows = false;
            this.dgvDestinos.AllowUserToDeleteRows = false;
            this.dgvDestinos.AllowUserToResizeRows = false;
            this.dgvDestinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDestinos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDestinos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDestinos.Location = new System.Drawing.Point(15, 240);
            this.dgvDestinos.Name = "dgvDestinos";
            this.dgvDestinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinos.Size = new System.Drawing.Size(620, 200);
            this.dgvDestinos.TabIndex = 12;
            this.dgvDestinos.SelectionChanged += new System.EventHandler(this.dgvDestinos_SelectionChanged);
            this.dgvDestinos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDestinos_DataError);
            // 
            // lblDestinoId
            // 
            this.lblDestinoId.AutoSize = true;
            this.lblDestinoId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDestinoId.Location = new System.Drawing.Point(15, 70);
            this.lblDestinoId.Name = "lblDestinoId";
            this.lblDestinoId.Size = new System.Drawing.Size(64, 15);
            this.lblDestinoId.TabIndex = 13;
            this.lblDestinoId.Text = "Destino ID:";
            // 
            // txtDestinoId
            // 
            this.txtDestinoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDestinoId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDestinoId.Location = new System.Drawing.Point(90, 67);
            this.txtDestinoId.Name = "txtDestinoId";
            this.txtDestinoId.ReadOnly = true;
            this.txtDestinoId.Size = new System.Drawing.Size(100, 23);
            this.txtDestinoId.TabIndex = 14;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(650, 50);
            this.pnlHeader.TabIndex = 21;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📍 Gestión de Destinos";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDestinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(650, 460);
            this.Controls.Add(this.dgvDestinos);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.nudDuracionHoras);
            this.Controls.Add(this.lblDuracionHoras);
            this.Controls.Add(this.nudDuracionDias);
            this.Controls.Add(this.lblDuracionDias);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDestinoId);
            this.Controls.Add(this.lblDestinoId);
            this.Controls.Add(this.pnlHeader);
            this.Name = "FrmDestinos";
            this.Text = "Mantenimiento de Destinos";
            this.Load += new System.EventHandler(this.FrmDestinos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracionDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracionHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinos)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblDuracionDias;
        private System.Windows.Forms.NumericUpDown nudDuracionDias;
        private System.Windows.Forms.Label lblDuracionHoras;
        private System.Windows.Forms.NumericUpDown nudDuracionHoras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dgvDestinos;
        private System.Windows.Forms.Label lblDestinoId;
        private System.Windows.Forms.TextBox txtDestinoId;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
    }
}