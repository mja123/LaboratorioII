using System;
using System.Collections.Generic;
using System.Text;

namespace carritoDeCompras
{
     class Menu
     {
        // Se asocia la clase Menu con CarritoCompras (menú conoce a carrito, pero no al revez).
        private CarritoCompras miCarrito;
        public Menu(CarritoCompras miCarrito)
        {
            // Se inicializa el objeto de tipo CarritoCompras recibido por argumento.
            this.miCarrito = miCarrito;
        }
         public void menuPrincipal()
         {
            String opcionUsuario = "";
            do
            {
                // Se muestra el menú con las respectivas llamadas a las funciones para actualizar los datos.
                Console.WriteLine("SHOPPING ONLINE DE CAMISAS – Ventas minoristas y mayoristas");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPA:");
                Console.WriteLine("1-   Añadir camisa al carro de compras");
                Console.WriteLine("2-   Eliminar camisa del carro de compras");
                Console.WriteLine("3-   Salir");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("         -    Cantidad de camisas en el carro de compras: {0}", miCarrito.cantidadCamisas());
                Console.WriteLine("         -    Precio unitario: $1000");
                Console.WriteLine("         -    Precio total sin descuento: ${0}", miCarrito.precioSinDescuento());
                Console.WriteLine("         -    Tipo de descuento aplicado: %{0}", miCarrito.descuento());
                Console.WriteLine("         -    Precio final con descuento: ${0} ", miCarrito.precioAbonar());
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú:");

                opcionUsuario = Console.ReadLine();
                // Validación de ingreso, se restringe la lectura.
                if (opcionUsuario == "1" || opcionUsuario == "2" || opcionUsuario == "3")
                    break;

                Console.WriteLine("La opción ingresada se encuentra fuera de rango, intente nuevamente.");
                Console.ReadKey();
                Console.Clear();

            } while (opcionUsuario != "1" && opcionUsuario != "2" && opcionUsuario != "3");

            ejecutarOpcionUsuario(opcionUsuario);
        }
        public void ejecutarOpcionUsuario(String opcionUsuario)
        {
            // Se llama a los subprogramas respectivos a la opción elegida.
            switch (opcionUsuario)
            {
                case "1":
                    miCarrito.agregarCamisa();
                    Console.ReadKey();
                    Console.Clear();
                    menuPrincipal();
                    break;
                case "2":
                    miCarrito.eliminarCamisa();
                    Console.ReadKey();
                    Console.Clear();
                    menuPrincipal();
                    break;
                default:
                    String salir, salirMinusculas = "";

                    Console.Clear();
                    do
                    {
                        // Se valida que el usuario desee salir.
                        Console.WriteLine("¿Está seguro que desea salir? S/N.");
                        salir = Console.ReadLine();
                        salirMinusculas = salir.ToLower();

                        if (salirMinusculas == "n" || salirMinusculas == "s")
                            break;

                        Console.WriteLine("Opción ingreada no válida, intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();

                    } while (salirMinusculas != "n" && salirMinusculas != "s");

                    if (salirMinusculas == "n")
                    {
                        Console.Clear();
                        menuPrincipal();
                    }                  
                    else
                        Console.Clear();
                        Console.WriteLine("Muchas gracias por su tiempo, hasta luego.");
                    break;
            }
        }
    }
}



