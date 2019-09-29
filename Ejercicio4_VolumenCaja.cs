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
    public partial class Ejercicio4_VolumenCaja : Form
    {

        VolumenCaja volumenCaja = new VolumenCaja();
        public Ejercicio4_VolumenCaja()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            volumenCaja.setLongitud(double.Parse(txtlongitud.Text));
            volumenCaja.setAncho(double.Parse(txtancho.Text));
            volumenCaja.setAltura(double.Parse(txtaltura.Text));

            lblmensaje.Text = volumenCaja.Volumen().ToString();
            lblmensaje.Visible = true;

        }

        private void Txtlongitud_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            Validar.soloDecimal(e);
        }

        private void Txtancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloDecimal(e);
        }

        private void Txtaltura_KeyPress(object sender, KeyPressEventArgs e)
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
