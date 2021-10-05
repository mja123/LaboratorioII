using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    static class Utiles
    {
        static public int validarDatosInt(String input)
        {

            try
            {
                int inputInt;
                inputInt = Convert.ToInt32(input);
                return inputInt;
            } catch (Exception) {

                return -1;
            }
        }
        static public float validarDatosFloat(String input)
        { 

            try
            {
                float inputFloat;
                inputFloat = float.Parse(input);
                
                return inputFloat;
                
            }
            catch (Exception)
            {
                
                return -1;
            }
          
        } 

        static public bool rangoDatoIngresado(int datoInt=0, float datoFloat=0)
        {
            if (datoInt != 0)
            {
                if (datoInt > 0)
                {
                    return true;
                }
                else
                    return false;
            } else
            {
                if (datoFloat > 0)
                {
                    return true;
                }
                else
                    return false;
            }
             
        }
    }
}
