using System;
using System.Collections.Generic;
using System.Text;

namespace ElSoldado
{
    class Menu
    {

        private Rifle miRifle;
        private Escopeta miEscopeta;
        private Revolver miRevolver;
        private Soldado miSoldado;

        public Menu(ref Soldado soldado, ref Rifle rifle, ref Revolver revolver, ref Escopeta escopeta)
        {
            this.miSoldado = soldado;
            this.miRifle = rifle;
            this.miEscopeta = escopeta;
            this.miRevolver = revolver;

            mostrarMenuPrincipal();
        }

        public void mostrarMenuPrincipal()
        {
            String opcionUsuario;
            int opcionUsuarioInt = 0;

            do
            {

                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1- Recoger arma.");
                Console.WriteLine("2- Dejar arma.");
                Console.WriteLine("3- Disparar.");
                Console.WriteLine("4- Ver arma en uso.");
                Console.WriteLine("5- Salir.");
                opcionUsuario = Console.ReadLine();
                try
                {
                    opcionUsuarioInt = Convert.ToInt32(opcionUsuario);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Debe ingresar un entero ", e);
                }


                if (opcionUsuarioInt > 0 && opcionUsuarioInt < 6)
                    break;
                if (opcionUsuarioInt < 1 || opcionUsuarioInt > 5)
                    Console.WriteLine("Opción ingresada fuera de rango, por favor intente nuevamente");
                Console.Clear();
            } while (opcionUsuarioInt < 1 || opcionUsuarioInt > 5);

            ejecutarAccionElegida(opcionUsuarioInt);
        }

        public void ejecutarAccionElegida(int opcionUsuarioInt)
        {

            switch (opcionUsuarioInt)
            {
                case 1:
                    menuArmas();                  
                    break;

                case 2:
                    miSoldado.dejarArma();
                    Console.ReadKey();
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;

                case 3:
                    miSoldado.dispararArma();
                    Console.ReadKey();
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;
                case 4:
                    miSoldado.verArma();
                    Console.ReadKey();
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Muchas gracias por su tiempo, hasta la próxima.");
                    break;
            }
        }
        
        public void menuArmas()
        {
            String opcionArma;
            int opcionArmaInt = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Por favor, escoja el arma que desea utilizar:");
                Console.WriteLine("1 - Revolver");
                Console.WriteLine("2 - Rifle");
                Console.WriteLine("3 - Escopeta");
                Console.WriteLine("4 - Volver atrás");
                opcionArma = Console.ReadLine();

                try
                {
                    opcionArmaInt = Convert.ToInt32(opcionArma);
                }
                catch (FormatException e)
                {

                    Console.WriteLine("Debe ingresar un entero ", e);
                }

                if (opcionArmaInt > 0 && opcionArmaInt < 5)
                    break;
                if (opcionArmaInt < 1 || opcionArmaInt > 4)
                    Console.WriteLine("Opción ingresada fuera de rango, por favor intente nuevamente");

            } while (opcionArmaInt < 1 || opcionArmaInt > 4);

            ejecutarMenuArmas(opcionArmaInt);
        }

        public void ejecutarMenuArmas(int opcionArmaInt)
        {

            switch (opcionArmaInt)
            {
                case 1:
                    miSoldado.recogerArma(miRevolver);
                    Console.ReadKey();
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;

                case 2:
                    miSoldado.recogerArma(miRifle);
                    Console.ReadKey();
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;

                case 3:
                    miSoldado.recogerArma(miEscopeta);
                    Console.ReadKey();
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;

                default:
                    Console.Clear();
                    mostrarMenuPrincipal();
                    break;
            }
        }
    }
}
