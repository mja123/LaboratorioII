using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioVolador
{
    class Superman : SuperHeroe, Volador
    {
        public void volar()
        {
            Console.WriteLine("Estoy volando como un campeón...");
        }
    }
}
