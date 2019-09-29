using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
   public class VolumenCaja
    {
        private double longitud;
        private double ancho;
        private double altura;

        //Validacion longitud
        public void setLongitud(double valor)
        {
            this.longitud = valor;
        }

        public double getLongitud()
        {
            return this.longitud;
        }

        //Validacion Ancho
        public void setAncho(double valor)
        {
            this.ancho = valor;
        }

        public double getAncho()
        {
            return this.ancho;
        }

        //Validacion Altura

        public void setAltura(double valor)
        {
            this.altura = valor;
        }

        public double getAltura()
        {
            return this.altura;
        }

        //calcular volumen
        public double Volumen()
        {
            return (this.getLongitud() * this.getAncho() * this.getAltura());

        }
    }
}
