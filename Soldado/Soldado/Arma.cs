using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{

    abstract class Arma
    {
        protected String nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        abstract public string disparar();
    }
}
