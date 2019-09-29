namespace taller1_Ejercicios_9_
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgbcargaInicial = new System.Windows.Forms.ProgressBar();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pgbcargaInicial
            // 
            this.pgbcargaInicial.Location = new System.Drawing.Point(28, 73);
            this.pgbcargaInicial.Maximum = 103;
            this.pgbcargaInicial.Name = "pgbcargaInicial";
            this.pgbcargaInicial.Size = new System.Drawing.Size(124, 23);
            this.pgbcargaInicial.TabIndex = 0;
            this.pgbcargaInicial.Click += new System.EventHandler(this.PgbcargaInicial_Click);
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.Location = new System.Drawing.Point(52, 55);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(65, 15);
            this.lblporcentaje.TabIndex = 1;
            this.lblporcentaje.Text = "porcentaje";
            this.lblporcentaje.Visible = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(26, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(149, 16);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "Taller 1 Introduccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 164);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.pgbcargaInicial);
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgbcargaInicial;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label lbltitulo;
    }
}

