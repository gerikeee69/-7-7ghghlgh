using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorTDD
{
    public class KorClass

    {

        //osztalyvaltozok
        private double sugar = 0.0, kerulet=0.0, terulet=0.0;
        
        //konstruktor
        public KorClass(double r) 
        {
            this.sugar = r;
        }

        //kerulet szamitas
        //terulet szamitas
        public double setKerulet(double r) { //return this.kerulet = 2 * r * Math.PI;
                                             return 0.0;}
        public double setTerulet(double r) { //return this.terulet = r * r * Math.PI;
                                             return 0.0;}
        public double getSugar() {  return sugar; }

    }
}
