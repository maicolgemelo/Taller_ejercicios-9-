using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
   public class MostrarEdad
    {

        private int edad;

        public void setEdad(int valor)
        {
            this.edad = valor;
        }

        public int getEdad()
        {
            return this.edad;
        }


        public int muestralaEdad()
        {
            return (this.getEdad());
        }
    }
}
