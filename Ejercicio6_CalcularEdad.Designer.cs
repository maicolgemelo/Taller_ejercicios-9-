namespace taller1_Ejercicios_9_
{
    partial class Ejercicio6_CalcularEdad
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
            this.txtyear = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblcalculoedad = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(62, 18);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(100, 19);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Edad Persona";
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(66, 101);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(100, 20);
            this.txtyear.TabIndex = 1;
            this.txtyear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtyear_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(77, 139);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(84, 29);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(25, 79);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(190, 19);
            this.lblyear.TabIndex = 3;
            this.lblyear.Text = "Ingrese año de nacimiento:";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(93, 183);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(46, 19);
            this.lbledad.TabIndex = 4;
            this.lbledad.Text = "Edad:";
            // 
            // lblcalculoedad
            // 
            this.lblcalculoedad.AutoSize = true;
            this.lblcalculoedad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalculoedad.Location = new System.Drawing.Point(93, 215);
            this.lblcalculoedad.Name = "lblcalculoedad";
            this.lblcalculoedad.Size = new System.Drawing.Size(88, 19);
            this.lblcalculoedad.TabIndex = 5;
            this.lblcalculoedad.Text = "Calculo edad";
            this.lblcalculoedad.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(160, 272);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Ejercicio6_CalcularEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 307);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lblcalculoedad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio6_CalcularEdad";
            this.Text = "Ejercicio6_CalcularEdad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblcalculoedad;
        private System.Windows.Forms.Button btnsalir;
    }
}