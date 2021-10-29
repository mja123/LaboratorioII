using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioElectrodomesticosWF.Model
{
    class Lavadora : Electrodomestico
    {
        private int carga;

        public Lavadora()
        {
            this.precioBase = 100;
            this.color = "blanco";
            this.consumoEnergetico = "F";
            this.peso = 5;
            this.carga = 5;
        }
        public Lavadora(int precioBase, int peso) : base(precioBase, peso)
        {
            this.carga = 5;
            this.color = "blanco";
            this.consumoEnergetico = "F";
        }
        public Lavadora(int precioBase, string color, String consumoEnergetico, int peso, int carga) : base(precioBase, color, consumoEnergetico, peso)
        {
            this.carga = carga;
        }

        public int Carga { get => carga; set => carga = value; }

        
        public override int precioFinal()
        {
            int precioFinal = base.precioFinal();
            if (Carga > 30)
                precioFinal += 50; 

            return precioFinal;
        }
    }
}
