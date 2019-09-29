using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
   public class IndiceMasaCorporal{

        private double estatura;
        private double peso;

        public void setEstatura(double valor){

            this.estatura = valor;
        }

        public double getEstatura(){

            return this.estatura;
        }

        public void setPeso(double valor){

            this.peso = valor;
        }

        public double getPeso(){

            return this.peso;
        }

        public double IMC( ) {

            return ((this.getPeso() / (this.getEstatura() * this.getEstatura())) * 10000);
        }
   }
}
