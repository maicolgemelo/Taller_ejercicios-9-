using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller1_Ejercicios_9_
{
    public class Edad
    {
        private int año;
        int edad = DateTime.Today.Year;

        public void setAño(int valor){

            this.año = valor;
        }

        public int getAño(){

            return this.año;
        }

        public  int edadpersona()
        {
            return (edad - this.getAño());
        } 
    }
}
