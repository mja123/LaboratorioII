using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioElectrodomesticosWF.Model
{
    class Electrodomestico
    {
        protected int precioBase;
        protected String color;
        protected String consumoEnergetico;
        protected int peso;
        public Electrodomestico()
        {
            this.precioBase = 100;
            this.color = "blanco";
            this.consumoEnergetico = "F";
            this.peso = 5;
        }
        public Electrodomestico(int precioBase, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.color = "blanco";
            this.consumoEnergetico = "F";
        }
        public Electrodomestico(int precioBase, string color, String consumoEnergetico, int peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
            this.consumoEnergetico = consumoEnergetico;
            this.color = color;
        }
        protected int PrecioBase { get => precioBase; set => precioBase = value; }
        protected string Color { get => color; set => color = value; }
        protected String ConsumoEnergetico { get => consumoEnergetico; set => consumoEnergetico = value; }
        protected int Peso { get => peso; set => peso = value; }

        //Haciendo los métodos de comprobación privados (como pide la consigna) no podría validar la inicialización de los atributos de las clases hijas
        //con el mismo método (tendría que crear un método igual para cada una de las clases hijas y sería repetir código innecesariamente).
      

        public virtual int precioFinal()
        {
            int precioConsumo;
            int precioPeso;
            int precioFinal = this.precioBase;
            

            if (ConsumoEnergetico == "A")
                precioConsumo = 100;
            else if (ConsumoEnergetico == "B")
                precioConsumo = 80;
            else if (ConsumoEnergetico == "C")
                precioConsumo = 60;
            else if (ConsumoEnergetico == "D")
                precioConsumo = 50;
            else if (ConsumoEnergetico == "E")
                precioConsumo = 30;
            else
                precioConsumo = 10;

            if (Peso >= 0 && Peso <= 19)
                precioPeso = 10;
            else if (Peso >= 20 && Peso <= 49)
                precioPeso = 50;
            else if (Peso >= 50 && Peso <= 79)
                precioPeso = 80;
            else 
                precioPeso = 100;

            precioFinal += precioPeso + precioConsumo;

            return precioFinal;
        }
    }
}
