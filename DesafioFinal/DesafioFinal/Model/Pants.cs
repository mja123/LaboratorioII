using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal.Model
{
    class Pants : Clothe
    {
        private bool shortPants; 
        public Pants(int price, int count, bool standard, bool shortPants)
        {
            this.price = price;
            this.count = count;
            this.standard = standard;
            this.shortPants = shortPants;
        }

        public override double finalPrice()
        {
            double total = base.finalPrice();

            if (shortPants)
            
                total *= 0.8;
            

            return total;
        }
    }
}
