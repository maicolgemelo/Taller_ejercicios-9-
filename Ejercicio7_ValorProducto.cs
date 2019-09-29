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
    public partial class Ejercicio7_ValorProducto : Form
    {

        DescuentoProducto descuentoProducto = new DescuentoProducto();
        public Ejercicio7_ValorProducto()
        {
            InitializeComponent();
            lblporcentaje1.Text = "19%";
            lblporcentaje1.Visible = true;
            lblporcentaje2.Text = "20%";
            lblporcentaje2.Visible = true;
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            descuentoProducto.setProducto(int.Parse(txtvalor.Text));

            lbltotalproducto.Text = descuentoProducto.totalproducto().ToString();
            lbltotalproducto.Visible = true;

            lblresultado1.Text = descuentoProducto.iva().ToString();
            lblresultado1.Visible = true;
            lblresultado2.Text = descuentoProducto.descuento().ToString();
            lblresultado2.Visible = true;
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
