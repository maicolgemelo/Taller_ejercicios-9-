namespace taller1_Ejercicios_9_
{
    partial class Ejercicio5_RaizCuadrada
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblraiz = new System.Windows.Forms.Label();
            this.lblraizcuadrada = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(57, 18);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(117, 19);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Raiz Cuadrada";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(42, 81);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 1;
            this.txtnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumero_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(162, 78);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(28, 62);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(132, 15);
            this.lblnumero.TabIndex = 3;
            this.lblnumero.Text = "Ingrese un numero:";
            // 
            // lblraiz
            // 
            this.lblraiz.AutoSize = true;
            this.lblraiz.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraiz.Location = new System.Drawing.Point(28, 123);
            this.lblraiz.Name = "lblraiz";
            this.lblraiz.Size = new System.Drawing.Size(98, 17);
            this.lblraiz.TabIndex = 4;
            this.lblraiz.Text = "Raiz Cuadrada:";
            // 
            // lblraizcuadrada
            // 
            this.lblraizcuadrada.AutoSize = true;
            this.lblraizcuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraizcuadrada.Location = new System.Drawing.Point(139, 125);
            this.lblraizcuadrada.Name = "lblraizcuadrada";
            this.lblraizcuadrada.Size = new System.Drawing.Size(96, 16);
            this.lblraizcuadrada.TabIndex = 5;
            this.lblraizcuadrada.Text = "Raiz cuadrada";
            this.lblraizcuadrada.Visible = false;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(39, 160);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(59, 19);
            this.lblmensaje.TabIndex = 6;
            this.lblmensaje.Text = "mensaje";
            this.lblmensaje.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(200, 204);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio5_RaizCuadrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 239);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblraizcuadrada);
            this.Controls.Add(this.lblraiz);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio5_RaizCuadrada";
            this.Text = "9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblraiz;
        private System.Windows.Forms.Label lblraizcuadrada;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnsalir;
    }
}