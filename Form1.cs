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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pgbcargaInicial.Value = 0;
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            //this.pgbcargaInicial.Increment(1);
            if (pgbcargaInicial.Value <= 100)
            {

                pgbcargaInicial.Value++;
                lblporcentaje.Text = " Cargando " + pgbcargaInicial.Value.ToString() + " % ";
                lblporcentaje.Visible = true;

            }
            else
            {

                timer1.Stop();
                // MessageBox.Show(" el progressBar ya esta completado");
                Menu menu = new Menu();

                menu.Show();
                this.Hide();
            }
        }

        private void PgbcargaInicial_Click(object sender, EventArgs e)
        {
            //ProgressBar pbar = new ProgressBar();
            //this.timer1.Start();
            //lblporcentaje.Text = "Cargando " + pgbcargaInicial.Value.ToString() + "%";

            //Menu menu = new Menu();
            //menu.Show();
            //this.Hide();


           
        }
    }
}
