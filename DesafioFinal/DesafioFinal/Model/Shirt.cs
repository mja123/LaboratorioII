using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal.Model
{
    class Shirt : Clothe
    {
        private bool shirtSleeve;
        public Shirt(int price, int count, bool standard, bool shirtSleeve)
        {
            this.price = price;
            this.count = count;
            this.standard = standard;
            this.shirtSleeve = shirtSleeve;
        }

        public override double finalPrice()
        {
            double total = base.finalPrice();

            if (shirtSleeve)

                total *= 0.9;


            return total;
        }
    }
}
