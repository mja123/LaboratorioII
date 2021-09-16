using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Rifle : Arma
    {
        public Rifle()
        {
            Nombre = "Rifle";
        }

        public override string disparar()
        {
            return "Púm púm púm!...";
        }
    }
}

