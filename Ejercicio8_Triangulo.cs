using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1_Ejercicios_9_
{
    public partial class Ejercicio8_Triangulo : Form
    {

        ConfirmarRectangulo confirmarRectangulo = new ConfirmarRectangulo();
        public Ejercicio8_Triangulo()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            confirmarRectangulo.setCatetoa(double.Parse(txtcatetoa.Text));
            confirmarRectangulo.setHipotenusa(double.Parse(txthipotenusa.Text));
            confirmarRectangulo.setCatetob(double.Parse(txtcatetob.Text));

            if (confirmarRectangulo.Sumacatetos() == confirmarRectangulo.pruebaHipotenusa()) {

                lblareat.Text = confirmarRectangulo.Areatriangulo().ToString();
                lblareat.Visible = true;
                lblmensaje.Text = "Es un triangulo rectangulo";
                lblmensaje.Visible = true;
            }
            else
            {
                lblareat.Text = "--";
                lblareat.Visible = true;
                lblmensaje.Text = "No es un triangulo rectangulo";
                lblmensaje.Visible = true;
            }

        }

        private void Txthipotenusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Txtcatetoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Txtcatetob_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
