using System;

namespace ElSoldado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-== Bienvenido al campo de entrenamiento, Soldado ==-");

            Soldado soldado = new Soldado();
            Revolver revolver = new Revolver();
            Rifle rifle = new Rifle();
            Escopeta escopeta = new Escopeta();

            Menu miMenu = new Menu(ref soldado, ref rifle, ref revolver, ref escopeta);
        }
    }
}





