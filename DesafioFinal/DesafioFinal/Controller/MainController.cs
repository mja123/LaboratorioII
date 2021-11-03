using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioFinal.Controller
{
    class MainController
    {

        private static Model.Pants myPants;
        private static Model.Shirt myShirt;
        public static void chosenClothing(String clothe, int count, int price, bool typeOf, bool standard)
        {

            if (clothe.Equals("pants"))
            {
                myPants = new Model.Pants(price, count, standard, typeOf);
            }
            else
            {
                myShirt = new Model.Shirt(price, count, standard, typeOf);
            }
        }
        public static double showFinalPrice(string clothe)
        {
            if (clothe.Equals("pants"))
            {
                return myPants.finalPrice();
            } else
            {
                return myShirt.finalPrice();
            }
        }
    }
}
