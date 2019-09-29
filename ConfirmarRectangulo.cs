using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
    public class ConfirmarRectangulo
    {
        private double hipotenusa;
        private double catetoa;
        private double catetob;

        public void setHipotenusa(double valor)
        {
            this.hipotenusa = valor;
        }

        public double getHipotenusa()
        {
            return this.hipotenusa;
        }

        public void setCatetoa(double valor)
        {
            this.catetoa = valor;
        }

        public double getCatetoa()
        {
            return this.catetoa;
        }


        public void setCatetob(double valor)
        {
            this.catetob = valor;
        }

        public double getCatetob()
        {
            return this.catetob;
        }

        public double Sumacatetos()
        {
            return ((this.getCatetoa()* this.getCatetoa()) +( this.getCatetob() * this.getCatetob()));

        }

        public double pruebaHipotenusa()
        {
            return (this.getHipotenusa() * this.getHipotenusa());
        }

        public double Areatriangulo()
        {
            return ((this.getCatetoa() * this.getCatetob()) / 2);
        }
    }
}
