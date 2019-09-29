using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1_Ejercicios_9_
{
    public class Validar
    {

        public static void soloLetras(KeyPressEventArgs a){

            if (char.IsLetter(a.KeyChar)){

                a.Handled = false;

            }else if (char.IsControl(a.KeyChar)){

                a.Handled = false;

            }else if (char.IsSeparator(a.KeyChar)){

                a.Handled = false;

            }else{

                MessageBox.Show("Solo se permite letras"
                    ,"Aviso"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Warning);
                a.Handled = true;
                return;
            }
        }

        public static void soloNumeros(KeyPressEventArgs a){

            if (char.IsNumber(a.KeyChar))
            {

                a.Handled = false;

            }
            else if (char.IsControl(a.KeyChar))
            {

                a.Handled = false;

            }
            else if (char.IsSeparator(a.KeyChar))
            {

                a.Handled = false;

            }
            else
            {

                MessageBox.Show("Solo se permite numeros"
                    , "Aviso"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                a.Handled = true;
                return;
            }
        }

        public static void soloDecimal(KeyPressEventArgs a){

            if (char.IsDigit(a.KeyChar))
            {

                a.Handled = false;

            }
            else if (char.IsControl(a.KeyChar))
            {

                a.Handled = false;

            }
            else if (char.IsPunctuation(a.KeyChar))
            {

                a.Handled = false;

            }else if (a.KeyChar.ToString().Equals(",").Equals(".")){

                a.Handled = false;

            }else{

                MessageBox.Show("Solo se permite letras"
                    , "Aviso"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                a.Handled = true;
                return;
            }
        }

    }
}
