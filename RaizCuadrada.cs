using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
   public class RaizCuadrada
   {
        private double numero;

        public void setNumero(double valor){

            this.numero = valor;
        }

        public double getNumero()
        {
            return this.numero;
        }

        public double Raiz()
        {
            return (Math.Sqrt(this.getNumero()));
        }
    }
}
