namespace taller1_Ejercicios_9_
{
    partial class Ejercicio4_VolumenCaja
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lbllongitud = new System.Windows.Forms.Label();
            this.lblancho = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblvolumen = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(65, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(104, 16);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Volumen Caja";
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(85, 68);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(100, 20);
            this.txtlongitud.TabIndex = 1;
            this.txtlongitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtlongitud_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(191, 152);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lbllongitud
            // 
            this.lbllongitud.AutoSize = true;
            this.lbllongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllongitud.Location = new System.Drawing.Point(12, 69);
            this.lbllongitud.Name = "lbllongitud";
            this.lbllongitud.Size = new System.Drawing.Size(67, 15);
            this.lbllongitud.TabIndex = 3;
            this.lbllongitud.Text = "Longitud:";
            // 
            // lblancho
            // 
            this.lblancho.AutoSize = true;
            this.lblancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblancho.Location = new System.Drawing.Point(29, 114);
            this.lblancho.Name = "lblancho";
            this.lblancho.Size = new System.Drawing.Size(50, 15);
            this.lblancho.TabIndex = 4;
            this.lblancho.Text = "Ancho:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(27, 152);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 15);
            this.lblaltura.TabIndex = 5;
            this.lblaltura.Text = "Altura: ";
            // 
            // txtancho
            // 
            this.txtancho.Location = new System.Drawing.Point(85, 109);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(100, 20);
            this.txtancho.TabIndex = 6;
            this.txtancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtancho_KeyPress);
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(85, 151);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 7;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtaltura_KeyPress);
            // 
            // lblvolumen
            // 
            this.lblvolumen.AutoSize = true;
            this.lblvolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvolumen.Location = new System.Drawing.Point(12, 211);
            this.lblvolumen.Name = "lblvolumen";
            this.lblvolumen.Size = new System.Drawing.Size(67, 15);
            this.lblvolumen.TabIndex = 8;
            this.lblvolumen.Text = "Volumen:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(96, 213);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(60, 16);
            this.lblmensaje.TabIndex = 9;
            this.lblmensaje.Text = "Mensaje";
            this.lblmensaje.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(191, 257);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio4_VolumenCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 292);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblvolumen);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtancho);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblancho);
            this.Controls.Add(this.lbllongitud);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio4_VolumenCaja";
            this.Text = "Ejercicio4_VolumenCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbllongitud;
        private System.Windows.Forms.Label lblancho;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtancho;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblvolumen;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnsalir;
    }
}