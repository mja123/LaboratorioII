using System;

namespace DesafioVolador
{
    class Program
    {
        static void Main(string[] args)
        {
            Boing747 miBoing = new Boing747();
            Pato miPato = new Pato();
            Superman miSuperman = new Superman();
            TorreDeControl miTorre = new TorreDeControl();

            miTorre.agregarVolador(miBoing);
            miTorre.agregarVolador(miSuperman);
            miTorre.agregarVolador(miPato);

            miTorre.vuelenTodos();
        }
    }
}
