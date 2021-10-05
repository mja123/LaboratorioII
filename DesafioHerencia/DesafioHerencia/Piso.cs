using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    //para los pisos, habrá que conocer el piso concreto en el que se encuentra la vivienda,
    //En el caso de los pisos, si es un tercero o más, su precio se incrementa un 3 %.
    class Piso : Inmuebles
    {
        int nroPiso;
        public Piso(String direccion, int metrosCuadrados, int antiguedad, float precioBase, int nroPiso)
        {
            this.direccion = direccion;
            this.metrosCuadrados = metrosCuadrados;
            this.antiguedad = antiguedad;
            this.precioBase = precioBase;
            this.nroPiso = nroPiso;
        }
        public override float descuentoTotal()
        {
             return descuentoAntiguedad();
        }
        public float incrementoNroPiso()
        {
            float incremento = 0;

            if(nroPiso >= 3)
            {
                incremento = precioBase * 0.03f;
            }

            return incremento;
        }

        public override float precioFinal()
        {
            float total;

            total = precioBase - descuentoAntiguedad() + incrementoNroPiso();

            return total;

        }

    }
}
