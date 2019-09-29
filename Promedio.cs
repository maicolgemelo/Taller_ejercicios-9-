using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
   public class Promedio
    {


        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;

        public void setNota1(double valor){

            this.nota1 = valor;
        }

        public double getNota1()
        {
            return this.nota1;
        }

        //VALIDACIO NOTA 2
        public void setNota2(double valor)
        {

            this.nota2 = valor;
        }

        public double getNota2()
        {
            return this.nota2;
        }

        //VALIDACION NOTA 3
        public void setNota3(double valor)
        {

            this.nota3 = valor;
        }

        public double getNota3()
        {
            return this.nota3;
        }

        //VALIDACION NOTA 4
        public void setNota4(double valor)
        {

            this.nota4 = valor;
        }

        public double getNota4()
        {
            return this.nota4;
        }


        public double promedionotas()
        {
            return ((this.getNota1() + this.getNota2() + this.getNota3() + this.getNota4())/ 4);
        }
    }
}
