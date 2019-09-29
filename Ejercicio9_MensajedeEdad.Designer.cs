namespace taller1_Ejercicios_9_
{
    partial class Ejercicio9_MensajedeEdad
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
            this.lblingresar = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lblmensajedad = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(52, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(113, 19);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Muestra Edad";
            // 
            // lblingresar
            // 
            this.lblingresar.AutoSize = true;
            this.lblingresar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresar.Location = new System.Drawing.Point(13, 67);
            this.lblingresar.Name = "lblingresar";
            this.lblingresar.Size = new System.Drawing.Size(118, 19);
            this.lblingresar.TabIndex = 1;
            this.lblingresar.Text = "Ingrese su edad:";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(31, 89);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 2;
            this.txtedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtedad_KeyPress);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(157, 85);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 3;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.Btnmostrar_Click);
            // 
            // lblmensajedad
            // 
            this.lblmensajedad.AutoSize = true;
            this.lblmensajedad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajedad.Location = new System.Drawing.Point(28, 132);
            this.lblmensajedad.Name = "lblmensajedad";
            this.lblmensajedad.Size = new System.Drawing.Size(46, 19);
            this.lblmensajedad.TabIndex = 4;
            this.lblmensajedad.Text = "Edad:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(79, 132);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(39, 19);
            this.lbledad.TabIndex = 5;
            this.lbledad.Text = "Edad";
            this.lbledad.Visible = false;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(28, 186);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(60, 19);
            this.lblmensaje.TabIndex = 10;
            this.lblmensaje.Text = "Mensaje";
            this.lblmensaje.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(150, 215);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio9_MensajedeEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 250);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblmensajedad);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.lblingresar);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio9_MensajedeEdad";
            this.Text = "Ejercicio9_MensajedeEdad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblingresar;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Label lblmensajedad;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnsalir;
    }
}