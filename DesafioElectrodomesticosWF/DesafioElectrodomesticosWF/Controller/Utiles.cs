using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioElectrodomesticos
{
    static class Utiles
    {
        static public int validacionInt(string valor)
        {
            try
            {
                if (valor == "")
                    return 0;
                return Convert.ToInt32(valor);
            }
            catch (Exception)
            {
                return -1;
            }
        }
        static public float validacionFloat(string valor)
        {
            try
            {
                if (valor == "")
                    return 0;
                return Convert.ToSingle(valor);
            }
            catch (Exception)
            {
                return -1;

            }
        }
    }
}
