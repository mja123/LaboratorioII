using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Revolver : Arma
    {
        public Revolver()
        {
            Nombre = "Revolver";
        }

        public override string disparar()
        {
            return "Púm...";
        }
    }
}
