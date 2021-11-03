using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal.Model
{
    abstract class Clothe
    {
        protected int price;
        protected int count;
        protected bool standard;

        public virtual double finalPrice()
        {
            double total = price * count;

            if (!standard)
            {
                total *= 1.3;
            }
            return total;
        }
    }
}
