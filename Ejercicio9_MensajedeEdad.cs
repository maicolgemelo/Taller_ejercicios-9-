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
    public partial class Ejercicio9_MensajedeEdad : Form
    {

        MostrarEdad mostrarEdad = new MostrarEdad();
        public Ejercicio9_MensajedeEdad()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            mostrarEdad.setEdad(int.Parse(txtedad.Text));

            if (mostrarEdad.muestralaEdad() <= 10) {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Niño ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }else if (mostrarEdad.muestralaEdad() <= 14) {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = "Pre_Adolescente";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }else if (mostrarEdad.muestralaEdad() <= 18) {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Adolescente ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }else if (mostrarEdad.muestralaEdad() <= 25) {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Joven ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }else if (mostrarEdad.muestralaEdad() <= 65) {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Adulto ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();

            }else if (mostrarEdad.muestralaEdad() > 65) {

                lbledad.Text = mostrarEdad.muestralaEdad().ToString();
                lbledad.Visible = true;
                lblmensaje.Text = " Anciano ";
                lblmensaje.Visible = true;
                txtedad.Text = "";
                txtedad.Focus();
            }
        }

        private void Txtedad_KeyPress(object sender, KeyPressEventArgs e)
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
