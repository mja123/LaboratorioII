using System;
using System.Collections.Generic;
using System.Text;

namespace ImprimibleDesafio
{
    class Documento : Imprimible
    {
        public void imprimir()
        {
            Console.WriteLine("Soy un documento de Word");
        }
    }
}
