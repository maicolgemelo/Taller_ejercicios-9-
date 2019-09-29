namespace taller1_Ejercicios_9_
{
    partial class Ejercicio2_llamadas
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
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtminutos = new System.Windows.Forms.TextBox();
            this.cmblugar = new System.Windows.Forms.ComboBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblminutos = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lbldescuento = new System.Windows.Forms.Label();
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltarifa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(78, 18);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(92, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "LLamadas";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(23, 101);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(55, 16);
            this.lblLugar.TabIndex = 1;
            this.lblLugar.Text = "Lugar :";
            // 
            // txtminutos
            // 
            this.txtminutos.Location = new System.Drawing.Point(84, 153);
            this.txtminutos.Name = "txtminutos";
            this.txtminutos.Size = new System.Drawing.Size(121, 20);
            this.txtminutos.TabIndex = 3;
            this.txtminutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtminutos_KeyPress);
            // 
            // cmblugar
            // 
            this.cmblugar.FormattingEnabled = true;
            this.cmblugar.Location = new System.Drawing.Point(84, 101);
            this.cmblugar.Name = "cmblugar";
            this.cmblugar.Size = new System.Drawing.Size(121, 21);
            this.cmblugar.TabIndex = 4;
            this.cmblugar.SelectedIndexChanged += new System.EventHandler(this.Cmblugar_SelectedIndexChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(218, 122);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(95, 31);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblminutos
            // 
            this.lblminutos.AutoSize = true;
            this.lblminutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminutos.Location = new System.Drawing.Point(9, 153);
            this.lblminutos.Name = "lblminutos";
            this.lblminutos.Size = new System.Drawing.Size(69, 16);
            this.lblminutos.TabIndex = 6;
            this.lblminutos.Text = "Minutos :";
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(242, 299);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lbldescuento
            // 
            this.lbldescuento.AutoSize = true;
            this.lbldescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescuento.Location = new System.Drawing.Point(9, 224);
            this.lbldescuento.Name = "lbldescuento";
            this.lbldescuento.Size = new System.Drawing.Size(86, 16);
            this.lbldescuento.TabIndex = 8;
            this.lbldescuento.Text = "Descuento:";
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporcentaje.Location = new System.Drawing.Point(101, 224);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(83, 16);
            this.lblporcentaje.TabIndex = 9;
            this.lblporcentaje.Text = "Porcentaje";
            this.lblporcentaje.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(43, 264);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(52, 16);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "Total :";
            // 
            // lbltarifa
            // 
            this.lbltarifa.AutoSize = true;
            this.lbltarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarifa.Location = new System.Drawing.Point(101, 264);
            this.lbltarifa.Name = "lbltarifa";
            this.lbltarifa.Size = new System.Drawing.Size(49, 16);
            this.lbltarifa.TabIndex = 11;
            this.lbltarifa.Text = "Tarifa";
            this.lbltarifa.Visible = false;
            // 
            // Ejercicio2_llamadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 334);
            this.Controls.Add(this.lbltarifa);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblporcentaje);
            this.Controls.Add(this.lbldescuento);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblminutos);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.cmblugar);
            this.Controls.Add(this.txtminutos);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio2_llamadas";
            this.Text = "Ejercicio2_llamadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtminutos;
        private System.Windows.Forms.ComboBox cmblugar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblminutos;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lbldescuento;
        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltarifa;
    }
}