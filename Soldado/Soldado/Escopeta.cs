using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Escopeta : Arma
    {
        public Escopeta()
        {
            Nombre = "Escopeta";
        }

        public override string disparar()
        {
            return "¡Pááá!...";
        }
    }
}
