using System;
using System.Collections.Generic;
using System.Text;

namespace ImprimibleDesafio
{   class Impresora
    {
        private List <Imprimible> colaDeImpresion;

        public Impresora()
        {
            colaDeImpresion = new List<Imprimible>(); 
        }

        public void imprimirTodo()
        {
            foreach(Imprimible archivo in colaDeImpresion)
            {
                archivo.imprimir();
            }
        }

        public void agregarImprimible(Imprimible unImprimible)
        {
            colaDeImpresion.Add(unImprimible);
        }

    }
}
