using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Soldado
    {
        private Arma arma;
         
        public void recogerArma(Arma arma)
        {
            this.arma = arma;

            if (arma.Nombre == "Pistola")
                Console.WriteLine("{1} recogida.", arma.Nombre);
            else
                Console.WriteLine("{0} recogido.", arma.Nombre);
        }

        public void dejarArma()
        {

            if (this.arma != null)
            {              
                Console.WriteLine("El soldado ha dejado su {0}.", this.arma.Nombre);
                this.arma = null;
            }
                
            else
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos…");
        }

        public void dispararArma()
        {
            if (this.arma != null)
                Console.WriteLine(this.arma.disparar());
            else
                Console.WriteLine("Para poder disparar necesita tener un arma.");
                
        }
        public void verArma()
        {
            if (this.arma != null)
                 Console.WriteLine(arma.Nombre);
            else
                Console.WriteLine("Parece que el soldado no tiene ningún arma en sus manos…");
        }
    }
}
