using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioElectrodomesticosWF.Model
{
    class Televisor : Electrodomestico
    {
        private float resolucion;
        private bool sintonizadorTDT;

        public Televisor()
        {
            this.precioBase = 100;
            this.color = "blanco";
            this.consumoEnergetico = "F";
            this.peso = 5;
            this.resolucion = 20f;
            this.sintonizadorTDT = false;
    }
        public Televisor(int precioBase, int peso) : base(precioBase, peso)
        {
            this.color = "blanco";
            this.consumoEnergetico = "F";
            this.resolucion = 20f;
            this.sintonizadorTDT = false;
        }
        public Televisor(int precioBase, string color, String consumoEnergetico, int peso, float resolucion, bool sintonizadorTDT) 
            : base(precioBase, color, consumoEnergetico, peso)
        {
            
            this.resolucion = resolucion;
            this.sintonizadorTDT = sintonizadorTDT;
        }

        public float Resolucion { get => resolucion; set => resolucion = value; }
        public bool SintonizadorTDT { get => sintonizadorTDT; set => sintonizadorTDT = value; }

        public override int precioFinal()
        {           
            return base.precioFinal();
        }


    }
}
