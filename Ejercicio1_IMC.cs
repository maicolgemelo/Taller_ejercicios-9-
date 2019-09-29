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
    public partial class Ejercicio1_IMC : Form
    {

        IndiceMasaCorporal MasaCorporal = new IndiceMasaCorporal();
        public Ejercicio1_IMC()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            MasaCorporal.setEstatura(double.Parse(txtestatura.Text));
            MasaCorporal.setPeso(double.Parse(txtpeso.Text));

            if (MasaCorporal.IMC() < 18.5)
            {

                lblmensaje1.Text = "IMC:" + MasaCorporal.IMC().ToString();
                lblmensaje1.Visible = true;
                lblmensaje2.Text = "Peso inferior al normal";
                lblmensaje2.Visible = true;

            }
            else if (MasaCorporal.IMC() <= 24.9)
            {

                lblmensaje1.Text = "IMC:" + MasaCorporal.IMC().ToString();
                lblmensaje1.Visible = true;
                lblmensaje2.Text = "Peso inferior al normal";
                lblmensaje2.Visible = true;

            }
            else if (MasaCorporal.IMC() <= 29.9)
            {

                lblmensaje1.Text = "IMC:" + MasaCorporal.IMC().ToString();
                lblmensaje1.Visible = true;
                lblmensaje2.Text = "Peso inferior al normal";
                lblmensaje2.Visible = true;

            }
            else if (MasaCorporal.IMC() > 30.0)
            {

                lblmensaje1.Text = "IMC:" + MasaCorporal.IMC().ToString();
                lblmensaje1.Visible = true;
                lblmensaje2.Text = "Peso inferior al normal";
                lblmensaje2.Visible = true;
            }


        }

        private void Txtestatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloDecimal(e);
        }

        private void Txtpeso_KeyPress(object sender, KeyPressEventArgs e)
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
