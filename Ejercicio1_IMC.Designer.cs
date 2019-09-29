namespace taller1_Ejercicios_9_
{
    partial class Ejercicio1_IMC
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
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblestatura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.lblmensaje1 = new System.Windows.Forms.Label();
            this.lblmensaje2 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(51, 22);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(192, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Indice de Masa Corporal";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(82, 130);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 1;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpeso_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(208, 125);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestatura.Location = new System.Drawing.Point(12, 94);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(64, 15);
            this.lblestatura.TabIndex = 3;
            this.lblestatura.Text = "Estatura:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(27, 135);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(43, 15);
            this.lblpeso.TabIndex = 4;
            this.lblpeso.Text = "Peso:";
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(82, 94);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 20);
            this.txtestatura.TabIndex = 5;
            this.txtestatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtestatura_KeyPress);
            // 
            // lblmensaje1
            // 
            this.lblmensaje1.AutoSize = true;
            this.lblmensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje1.Location = new System.Drawing.Point(65, 221);
            this.lblmensaje1.Name = "lblmensaje1";
            this.lblmensaje1.Size = new System.Drawing.Size(70, 16);
            this.lblmensaje1.TabIndex = 6;
            this.lblmensaje1.Text = "mensaje 1";
            this.lblmensaje1.Visible = false;
            // 
            // lblmensaje2
            // 
            this.lblmensaje2.AutoSize = true;
            this.lblmensaje2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje2.Location = new System.Drawing.Point(65, 253);
            this.lblmensaje2.Name = "lblmensaje2";
            this.lblmensaje2.Size = new System.Drawing.Size(70, 16);
            this.lblmensaje2.TabIndex = 7;
            this.lblmensaje2.Text = "mensaje 2";
            this.lblmensaje2.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(208, 288);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio1_IMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 323);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje2);
            this.Controls.Add(this.lblmensaje1);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio1_IMC";
            this.Text = "Ejercicio1_IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.Label lblmensaje1;
        private System.Windows.Forms.Label lblmensaje2;
        private System.Windows.Forms.Button btnsalir;
    }
}