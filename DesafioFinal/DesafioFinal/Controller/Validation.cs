using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal.Controller
{
    class Validation
    {

        public static int intValidation(String value, int min, int max)
        {

            int valueInt;
            try
            {
                valueInt = Convert.ToInt32(value);


            }
            catch (Exception)
            {
                return -1;
            }
            if (valueInt > min && valueInt <= max)
                return valueInt;
            else
                return -1;

        }
    }
}
