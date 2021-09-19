using System;

namespace carritoDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se instancia la clase CarritoCompras, se pasa por parámetro a la clase Menu y se llama al menuPrincipal.
            CarritoCompras miCarrito = new CarritoCompras();
            Menu miMenu = new Menu(miCarrito);
            miMenu.menuPrincipal();
        }
    }
}
