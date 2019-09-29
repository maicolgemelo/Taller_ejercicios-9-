namespace taller1_Ejercicios_9_
{
    partial class Ejercicio7_ValorProducto
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.lbliva = new System.Windows.Forms.Label();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblporcentaje1 = new System.Windows.Forms.Label();
            this.lblporcentaje2 = new System.Windows.Forms.Label();
            this.lbltotalproducto = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(56, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(123, 19);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Valor Producto";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(229, 67);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(98, 67);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 2;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.Location = new System.Drawing.Point(37, 66);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(49, 19);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "Valor:";
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(45, 117);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(41, 19);
            this.lbliva.TabIndex = 4;
            this.lbliva.Text = "Iva : ";
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.Location = new System.Drawing.Point(4, 163);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(82, 19);
            this.lbldescuento.TabIndex = 5;
            this.lbldescuento.Text = "Descuento:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(37, 197);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(47, 19);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "Total:";
            // 
            // lblporcentaje1
            // 
            this.lblporcentaje1.AutoSize = true;
            this.lblporcentaje1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje1.Location = new System.Drawing.Point(115, 117);
            this.lblporcentaje1.Name = "lblporcentaje1";
            this.lblporcentaje1.Size = new System.Drawing.Size(93, 19);
            this.lblporcentaje1.TabIndex = 7;
            this.lblporcentaje1.Text = "porcentaje 1";
            this.lblporcentaje1.Visible = false;
            // 
            // lblporcentaje2
            // 
            this.lblporcentaje2.AutoSize = true;
            this.lblporcentaje2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje2.Location = new System.Drawing.Point(115, 163);
            this.lblporcentaje2.Name = "lblporcentaje2";
            this.lblporcentaje2.Size = new System.Drawing.Size(93, 19);
            this.lblporcentaje2.TabIndex = 8;
            this.lblporcentaje2.Text = "porcentaje 2";
            this.lblporcentaje2.Visible = false;
            // 
            // lbltotalproducto
            // 
            this.lbltotalproducto.AutoSize = true;
            this.lbltotalproducto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproducto.Location = new System.Drawing.Point(116, 201);
            this.lbltotalproducto.Name = "lbltotalproducto";
            this.lbltotalproducto.Size = new System.Drawing.Size(102, 19);
            this.lbltotalproducto.TabIndex = 9;
            this.lbltotalproducto.Text = "totalproducto";
            this.lbltotalproducto.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(251, 227);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(79, 26);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado1.Location = new System.Drawing.Point(226, 123);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(78, 19);
            this.lblresultado1.TabIndex = 11;
            this.lblresultado1.Text = "resultado 1";
            this.lblresultado1.Visible = false;
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado2.Location = new System.Drawing.Point(226, 169);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(78, 19);
            this.lblresultado2.TabIndex = 12;
            this.lblresultado2.Text = "resultado 2";
            this.lblresultado2.Visible = false;
            // 
            // Ejercicio7_ValorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 265);
            this.Controls.Add(this.lblresultado2);
            this.Controls.Add(this.lblresultado1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbltotalproducto);
            this.Controls.Add(this.lblporcentaje2);
            this.Controls.Add(this.lblporcentaje1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio7_ValorProducto";
            this.Text = "Ejercicio7_ValorProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblporcentaje1;
        private System.Windows.Forms.Label lblporcentaje2;
        private System.Windows.Forms.Label lbltotalproducto;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.Label lblresultado2;
    }
}