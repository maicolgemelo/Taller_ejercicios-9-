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
    public partial class Ejercicio2_llamadas : Form
    {

        Tarifas tarifas = new Tarifas();
        public Ejercicio2_llamadas()
        {
            InitializeComponent();

            const string texto = "Seleccione..";
            cmblugar.Text = texto;
            cmblugar.Items.Add("Seleccione..");
            cmblugar.Items.Add("Estados Unidos");
            cmblugar.Items.Add("Canada");
            cmblugar.Items.Add("Europa");
            cmblugar.Items.Add("Resto del Mundo");
          

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            

            tarifas.setTotalMinutos(double.Parse(txtminutos.Text));
            
            

            switch (cmblugar.SelectedIndex.ToString()){

                //VALIDACION DE ESTADOS UNIDOS
                case "1":

                    if (tarifas.getTotalMinutos() < 15) {

                        lbltarifa.Text = "$" + tarifas.EstadosUnidos().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    } else {

                        lbltarifa.Text = "$" + tarifas.desc_estadosunidos().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;
                        
                    }

                break;


                //VALIDACION DE CANADA
                case "2":

                    if (tarifas.getTotalMinutos() < 15)
                    {

                        lbltarifa.Text = "$" + tarifas.Canada().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {

                        lbltarifa.Text = "$" + tarifas.desc_canada().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }


                    break;

                    //VALIDACION DE EUROPA
                    case "3":

                    if (tarifas.getTotalMinutos() < 15)
                    {

                        lbltarifa.Text = "$" + tarifas.Europa().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {

                        lbltarifa.Text = "$" + tarifas.desc_europa().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }
                    break;

                     //VALIDACION DEL RESTO DEL MUNDO
                     case "4":

                    if (tarifas.getTotalMinutos() < 15)
                    {

                        lbltarifa.Text = "$" + tarifas.RestodelMundo().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "0%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Red;

                    }
                    else
                    {

                        lbltarifa.Text = "$" + tarifas.desc_restodelmundo().ToString();
                        lbltarifa.Visible = true;
                        lblporcentaje.Text = "20%";
                        lblporcentaje.Visible = true;
                        lblporcentaje.ForeColor = Color.Green;

                    }
                    break;

                    default:

                    MessageBox.Show("escoga un de las Opciones"
                        ,"Aviso"
                        ,MessageBoxButtons.OK
                        ,MessageBoxIcon.Warning);


                    break;

            }


        }

        private void Txtminutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Cmblugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmblugar.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
