using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioVolador
{
    class Boing747 : Aviones, Volador
    {
        public void volar()
        {
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
