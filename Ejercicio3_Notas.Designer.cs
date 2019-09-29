namespace taller1_Ejercicios_9_
{
    partial class Ejercicio3_Notas
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
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnota1 = new System.Windows.Forms.Label();
            this.lblnota2 = new System.Windows.Forms.Label();
            this.lblnota3 = new System.Windows.Forms.Label();
            this.lblnota4 = new System.Windows.Forms.Label();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lblnotafinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(89, 20);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(81, 18);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Promedio";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(92, 89);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(100, 20);
            this.txtnota1.TabIndex = 1;
            this.txtnota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota1_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(219, 205);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblnota1
            // 
            this.lblnota1.AutoSize = true;
            this.lblnota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota1.Location = new System.Drawing.Point(25, 89);
            this.lblnota1.Name = "lblnota1";
            this.lblnota1.Size = new System.Drawing.Size(49, 16);
            this.lblnota1.TabIndex = 3;
            this.lblnota1.Text = "Nota: ";
            // 
            // lblnota2
            // 
            this.lblnota2.AutoSize = true;
            this.lblnota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota2.Location = new System.Drawing.Point(25, 133);
            this.lblnota2.Name = "lblnota2";
            this.lblnota2.Size = new System.Drawing.Size(49, 16);
            this.lblnota2.TabIndex = 4;
            this.lblnota2.Text = "Nota: ";
            // 
            // lblnota3
            // 
            this.lblnota3.AutoSize = true;
            this.lblnota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota3.Location = new System.Drawing.Point(25, 173);
            this.lblnota3.Name = "lblnota3";
            this.lblnota3.Size = new System.Drawing.Size(45, 16);
            this.lblnota3.TabIndex = 5;
            this.lblnota3.Text = "Nota:";
            // 
            // lblnota4
            // 
            this.lblnota4.AutoSize = true;
            this.lblnota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota4.Location = new System.Drawing.Point(25, 205);
            this.lblnota4.Name = "lblnota4";
            this.lblnota4.Size = new System.Drawing.Size(45, 16);
            this.lblnota4.TabIndex = 6;
            this.lblnota4.Text = "Nota:";
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(92, 172);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(100, 20);
            this.txtnota3.TabIndex = 7;
            this.txtnota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota3_KeyPress);
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(92, 132);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(100, 20);
            this.txtnota2.TabIndex = 8;
            this.txtnota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota2_KeyPress);
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(92, 205);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(100, 20);
            this.txtnota4.TabIndex = 9;
            this.txtnota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnota4_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(226, 325);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.Location = new System.Drawing.Point(25, 254);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(79, 16);
            this.lblpromedio.TabIndex = 11;
            this.lblpromedio.Text = "Promedio:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(50, 295);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(60, 16);
            this.lblmensaje.TabIndex = 12;
            this.lblmensaje.Text = "Mensaje";
            this.lblmensaje.Visible = false;
            // 
            // lblnotafinal
            // 
            this.lblnotafinal.AutoSize = true;
            this.lblnotafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotafinal.Location = new System.Drawing.Point(122, 254);
            this.lblnotafinal.Name = "lblnotafinal";
            this.lblnotafinal.Size = new System.Drawing.Size(64, 16);
            this.lblnotafinal.TabIndex = 13;
            this.lblnotafinal.Text = "Nota final";
            this.lblnotafinal.Visible = false;
            // 
            // Ejercicio3_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 360);
            this.Controls.Add(this.lblnotafinal);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblpromedio);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.lblnota4);
            this.Controls.Add(this.lblnota3);
            this.Controls.Add(this.lblnota2);
            this.Controls.Add(this.lblnota1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio3_Notas";
            this.Text = "Ejercicio3_Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnota1;
        private System.Windows.Forms.Label lblnota2;
        private System.Windows.Forms.Label lblnota3;
        private System.Windows.Forms.Label lblnota4;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblnotafinal;
    }
}