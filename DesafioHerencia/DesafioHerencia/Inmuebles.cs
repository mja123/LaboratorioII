using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    /*
     Para cualquier tipo de inmueble, se conoce su dirección y el número de metros cuadrados. 
     
    Además, cualquiera de estos inmuebles puede ser nuevo o de segunda mano.
    
    El precio de cada inmueble se calcula a partir de un precio base y una serie de características:
    para cualquier inmueble, si tiene menos de 15 años, su precio se rebaja un 1 %, 
    mientras que si tiene más se reduce un 2 %. 

    Permitir que el usuario ingrese los datos para calcular el valor del inmueble.
     */

    abstract class Inmuebles
    {
        protected String direccion;
        protected int metrosCuadrados;
        protected int antiguedad;
        protected float descuento;
        protected float precioBase;
        public float descuentoAntiguedad()
        {
            if (antiguedad < 15)
            {
                descuento += precioBase * 0.01f;
            } else
            {
                descuento += precioBase * 0.02f;
            }
            return descuento;
        }
        public abstract float descuentoTotal();
        public abstract float precioFinal();
    }
}
