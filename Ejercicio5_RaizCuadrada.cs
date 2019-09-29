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
    public partial class Ejercicio5_RaizCuadrada : Form
    {

        RaizCuadrada raizCuadrada = new RaizCuadrada();
        public Ejercicio5_RaizCuadrada()
        {
            InitializeComponent();
            lblraizcuadrada.Text = "";
        }

        private void Btncalcular_Click(object sender, EventArgs e){


            raizCuadrada.setNumero(double.Parse(txtnumero.Text));
             
            if (raizCuadrada.Raiz() > 0){

                lblraizcuadrada.Text = raizCuadrada.Raiz().ToString();
                lblraizcuadrada.Visible = true;

            }else{
                lblraizcuadrada.Text = "";
                lblmensaje.Text = "No se le puede sacar raiz cuadrada";
                lblmensaje.Visible = true;
            }

            
            
        }

        private void Txtnumero_KeyPress(object sender, KeyPressEventArgs e)
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
