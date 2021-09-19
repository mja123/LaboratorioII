using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace carritoDeCompras
{
    class CarritoCompras
    {
        // Se instancia un atributo de tipo Stack.
        private Stack camisas = new Stack();

        public void agregarCamisa()
        {
            // Se agraga una camisa.
            camisas.Push(1);
            Console.WriteLine("Camisa agregada!");
        }
        public void eliminarCamisa()
        {
            // Se corrobora la existencia de camisa y se elimina la última en ingresar (si es que hay).
            if (cantidadCamisas() == 0)
                Console.WriteLine("No hay camisas en el carrito.");
            else
            {
                camisas.Pop();
                Console.WriteLine("Camisa eliminada!");
            }
                
        }
        public int cantidadCamisas()
        {
            // Devuelve la cantidad de elementos en el Stack.
            return camisas.Count; 
        }
        public int precioSinDescuento()
        {
            // Se calcula el precio sin descuento.
            return cantidadCamisas() * 1000;
        }
        public int descuento()
        {
            // Se calcula el descuento según la cantidad de camisas en el carrito.
            int cantidadDescuento = 0;

            if (cantidadCamisas() >= 3)
                if (cantidadCamisas() <= 5)
                    cantidadDescuento = 10;
                else
                    cantidadDescuento = 20;

            return cantidadDescuento;
        }
        public int precioAbonar()
        {
            // Se calcula el total a abonar contemplando el descuento (si es que hay) correspondiente.
            int total = precioSinDescuento();

            if (descuento() > 0)
            {
                float descuentoAplicado;
                descuentoAplicado = (total * ((float)descuento() / 100));
                total -= (int)descuentoAplicado;
            }
            return total;
        }
    }
}
