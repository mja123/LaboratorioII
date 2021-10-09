using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioVolador
{
    class Pato : Animal, Volador
    {
        public void volar()
        {
            Console.WriteLine("Estoy volando como un pato... ¡Cuak!");
        }
    }
}
