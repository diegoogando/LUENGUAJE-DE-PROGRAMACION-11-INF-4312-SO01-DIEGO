namespace proyecto_final_Sistema_de_Agencia_de_Tours
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaíses = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnTours = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 100);
            this.pnlHeader.TabIndex = 5;
            this.pnlHeader.Controls.Add(this.label1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Agencia de Tours";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(800, 350);
            this.pnlButtons.TabIndex = 6;
            this.pnlButtons.Controls.Add(this.btnPaíses);
            this.pnlButtons.Controls.Add(this.btnDestinos);
            this.pnlButtons.Controls.Add(this.btnTours);
            this.pnlButtons.Controls.Add(this.btnSalir);
            // 
            // btnPaíses
            // 
            this.btnPaíses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPaíses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaíses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPaíses.ForeColor = System.Drawing.Color.White;
            this.btnPaíses.Location = new System.Drawing.Point(150, 80);
            this.btnPaíses.Name = "btnPaíses";
            this.btnPaíses.Size = new System.Drawing.Size(150, 50);
            this.btnPaíses.TabIndex = 1;
            this.btnPaíses.Text = "🌍 Países";
            this.btnPaíses.UseVisualStyleBackColor = false;
            this.btnPaíses.Click += new System.EventHandler(this.btnPaíses_Click);
            this.btnPaíses.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnPaíses.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnDestinos
            // 
            this.btnDestinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDestinos.ForeColor = System.Drawing.Color.White;
            this.btnDestinos.Location = new System.Drawing.Point(500, 80);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(150, 50);
            this.btnDestinos.TabIndex = 2;
            this.btnDestinos.Text = "📍 Destinos";
            this.btnDestinos.UseVisualStyleBackColor = false;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            this.btnDestinos.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnDestinos.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnTours
            // 
            this.btnTours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnTours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTours.ForeColor = System.Drawing.Color.White;
            this.btnTours.Location = new System.Drawing.Point(150, 180);
            this.btnTours.Name = "btnTours";
            this.btnTours.Size = new System.Drawing.Size(150, 50);
            this.btnTours.TabIndex = 3;
            this.btnTours.Text = "✈️ Tours";
            this.btnTours.UseVisualStyleBackColor = false;
            this.btnTours.Click += new System.EventHandler(this.btnTours_Click);
            this.btnTours.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnTours.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(500, 180);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 50);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "🚪 Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Sistema de Agencia de Tours";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaíses;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnTours;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlButtons;
    }
}

