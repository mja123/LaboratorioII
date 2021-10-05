using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    /*
    mientras que para los locales importará el número de ventanas que tenga.
    Para los locales, si tienen más de 50 metros cuadrados 
    el precio se incrementa un 1 %, si tienen 1 o ningún ventanal, su precio se reduce un 2 % y 
    si tienen más de 4 ventanales se añade un 2 %.
     */
    class Local : Inmuebles
    {
        int nroVentanas;
        public Local(String direccion, int metrosCuadrados, int antiguedad, float precioBase, int nroVentanas)
        {
            this.direccion = direccion;
            this.metrosCuadrados = metrosCuadrados;
            this.antiguedad = antiguedad;
            this.precioBase = precioBase;
            this.nroVentanas = nroVentanas;
        }


        public override float descuentoTotal()
        {
            float descuentoLocal = descuentoAntiguedad();

            if (nroVentanas <= 1)
            {
                descuentoLocal += precioBase * 0.02f;
            }
            return descuentoLocal;
        }

        public float incrementoLocal()
        {
            float incremento = 0;

            if(metrosCuadrados > 50)
            {
                incremento += precioBase * 0.01f; 
            }
            if (nroVentanas > 4)
            {
                incremento += precioBase * 0.02f;
            }

            return incremento;

        }
        public override float precioFinal()
        {
            float total;

            total = precioBase + incrementoLocal() - descuentoTotal();

            return total;
        }
    }
}
