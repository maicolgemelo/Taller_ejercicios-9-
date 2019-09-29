namespace taller1_Ejercicios_9_
{
    partial class Ejercicio8_Triangulo
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
            this.txthipotenusa = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblhipotenusa = new System.Windows.Forms.Label();
            this.lblcatetoa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcatetoa = new System.Windows.Forms.TextBox();
            this.txtcatetob = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lblareat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(52, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(171, 19);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Triangulo Rectangulo";
            // 
            // txthipotenusa
            // 
            this.txthipotenusa.Location = new System.Drawing.Point(100, 64);
            this.txthipotenusa.Name = "txthipotenusa";
            this.txthipotenusa.Size = new System.Drawing.Size(100, 20);
            this.txthipotenusa.TabIndex = 1;
            this.txthipotenusa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txthipotenusa_KeyPress);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(222, 143);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 2;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.Btncalcular_Click);
            // 
            // lblhipotenusa
            // 
            this.lblhipotenusa.AutoSize = true;
            this.lblhipotenusa.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhipotenusa.Location = new System.Drawing.Point(12, 65);
            this.lblhipotenusa.Name = "lblhipotenusa";
            this.lblhipotenusa.Size = new System.Drawing.Size(82, 17);
            this.lblhipotenusa.TabIndex = 3;
            this.lblhipotenusa.Text = "Hipotenusa:";
            // 
            // lblcatetoa
            // 
            this.lblcatetoa.AutoSize = true;
            this.lblcatetoa.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatetoa.Location = new System.Drawing.Point(30, 106);
            this.lblcatetoa.Name = "lblcatetoa";
            this.lblcatetoa.Size = new System.Drawing.Size(64, 17);
            this.lblcatetoa.TabIndex = 4;
            this.lblcatetoa.Text = "Cateto A:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cateto B:";
            // 
            // txtcatetoa
            // 
            this.txtcatetoa.Location = new System.Drawing.Point(100, 105);
            this.txtcatetoa.Name = "txtcatetoa";
            this.txtcatetoa.Size = new System.Drawing.Size(100, 20);
            this.txtcatetoa.TabIndex = 6;
            this.txtcatetoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcatetoa_KeyPress);
            // 
            // txtcatetob
            // 
            this.txtcatetob.Location = new System.Drawing.Point(100, 142);
            this.txtcatetob.Name = "txtcatetob";
            this.txtcatetob.Size = new System.Drawing.Size(100, 20);
            this.txtcatetob.TabIndex = 7;
            this.txtcatetob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcatetob_KeyPress);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(222, 259);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.Location = new System.Drawing.Point(33, 193);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(45, 19);
            this.lblarea.TabIndex = 9;
            this.lblarea.Text = "Area:";
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(33, 229);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(60, 19);
            this.lblmensaje.TabIndex = 10;
            this.lblmensaje.Text = "Mensaje";
            this.lblmensaje.Visible = false;
            // 
            // lblareat
            // 
            this.lblareat.AutoSize = true;
            this.lblareat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblareat.Location = new System.Drawing.Point(95, 193);
            this.lblareat.Name = "lblareat";
            this.lblareat.Size = new System.Drawing.Size(48, 19);
            this.lblareat.TabIndex = 11;
            this.lblareat.Text = "Area T";
            this.lblareat.Visible = false;
            // 
            // Ejercicio8_Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 294);
            this.Controls.Add(this.lblareat);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtcatetob);
            this.Controls.Add(this.txtcatetoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblcatetoa);
            this.Controls.Add(this.lblhipotenusa);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txthipotenusa);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Ejercicio8_Triangulo";
            this.Text = "Ejercicio8_Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txthipotenusa;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblhipotenusa;
        private System.Windows.Forms.Label lblcatetoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcatetoa;
        private System.Windows.Forms.TextBox txtcatetob;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblareat;
    }
}