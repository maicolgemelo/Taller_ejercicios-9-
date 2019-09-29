using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller1_Ejercicios_9_
{
   public class Tarifas
    {

        private double descuento;
        private double totalminutos;

        public void setDescuento(double valor )
        {
            this.descuento = valor;

        }

        public double getDescuento(){
            return this.descuento;
        }

        public void setTotalMinutos(double valor){
            this.totalminutos = valor;
        }

        public double getTotalMinutos(){
            return this.totalminutos;
        }


        // ESTADOS UNIDOS
        public double EstadosUnidos()
        {

            return (900 * this.getTotalMinutos());
        }

        //CANADA
        public double Canada()
        {

            return (800 * this.getTotalMinutos());
        }

        //EUROPA
        public double Europa()
        {

            return (950 * this.getTotalMinutos());
        }

        //RESTO DEL MUNDO
        public double RestodelMundo()
        {

            return (1250 * this.getTotalMinutos());
        }

        public double desc_canada()
        {

            return((this.Canada() * 0.2) + this.Canada());
        }

        public double desc_europa()
        {

            return ((this.Europa() * 0.2) + this.Europa());
        }

        public double desc_estadosunidos()
        {

            return ((this.EstadosUnidos() * 0.2) + this.EstadosUnidos());
        }

        public double desc_restodelmundo()
        {

            return ((this.RestodelMundo() * 0.2) + this.RestodelMundo());
        }

    }
}
