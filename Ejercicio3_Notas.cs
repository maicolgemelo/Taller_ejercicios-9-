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
    public partial class Ejercicio3_Notas : Form
    {

        Promedio promedio = new Promedio();
        public Ejercicio3_Notas()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            promedio.setNota1(double.Parse(txtnota1.Text));
            promedio.setNota2(double.Parse(txtnota2.Text));
            promedio.setNota3(double.Parse(txtnota3.Text));
            promedio.setNota4(double.Parse(txtnota4.Text));

            if(promedio.promedionotas() <= 2.99 ){

                lblnotafinal.Text = promedio.promedionotas().ToString();
                lblnotafinal.Visible = true;
                lblmensaje.Text = "Deficiente";
                lblmensaje.Visible = true;

            }else if (promedio.promedionotas() <= 3.99) {
               
                
                    lblnotafinal.Text = promedio.promedionotas().ToString();
                    lblnotafinal.Visible = true;
                    lblmensaje.Text = "Bien";
                    lblmensaje.Visible = true;

            }else if (promedio.promedionotas() <= 5) {

                lblnotafinal.Text = promedio.promedionotas().ToString();
                lblnotafinal.Visible = true;
                lblmensaje.Text = "Excelente";
                lblmensaje.Visible = true;


            }
             
        }

        private void Txtnota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloDecimal(e);
        }

        private void Txtnota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloDecimal(e);
        }

        private void Txtnota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloDecimal(e);
        }

        private void Txtnota4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloDecimal(e);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }   
}
